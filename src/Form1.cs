using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
// for Webcam
using AForge.Video;
using AForge.Video.DirectShow;
// for Netzwerk
using System.IO;
using System.Net.Sockets;
using System.Net;

using System.Threading;

namespace C-ChatBox{
    public partial class Form1 : MetroFramework.Forms.MetroForm{
        string localIP = Profile.myIP;
        string remoteIP = Profile.friendIP;
        int localPort = Profile.myPort;
        int remotePort = Profile.friendPort;

        public Form1(){
            InitializeComponent();
            textBox1.Text = remoteIP;
            textBox2.Text = remotePort.ToString();
            textBox4.Text = localPort.ToString();
        }

        VideoCaptureDevice videoSource;

        void InitWebCam(int nr){
        
            // enumeration of all webcams / video devices
            FilterInfoCollection videosources = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            // check if at least one webcam was found
            if (videosources != null){
            
                // bind the webcam "nr" to out project
                videoSource = new VideoCaptureDevice(videosources[nr].MonikerString);

                //try{
                //    // check if webcam has technical abilites
                //    if (videoSource.VideoCapabilities.Length > 0){
                //        string lowestSolution = "10000;0";
                //        // look for the profile with the lowest resolution
                //        for (int i = 0; i < videoSource.VideoCapabilities.Length; i++){
                //        
                //            if (videoSource.VideoCapabilities[i].FrameSize.Width < Convert.ToInt32(lowestSolution.Split(';')[0]))
                //                lowestSolution = videoSource.VideoCapabilities[i].FrameSize.Width.ToString() + ";" + i.ToString();
                //        }
                //        // pass the webcam object the lowest resolution
                //        //videoSource.DesiredFrameSize = videoSource.VideoCapabilities[Convert.ToInt32(lowestSolution.Split(';')[1])].FrameSize;
                //    }
                //}
                //catch (Exception e){
                //    MessageBox.Show(e.ToString());
                //}

                // Assign the webcam object the event hanlder NewFrame
                // this event is triggered for every new image
                videoSource.NewFrame += new AForge.Video.NewFrameEventHandler(videoSource_NewFrame);

                // activate the webcam
                videoSource.Start();
            }
        }

        void videoSource_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs){
        
            // assign every incoming image to the picture box
            //System.Threading.Thread.Sleep(100);
            pictureBoxVideoSelf.BackgroundImage = (Image)eventArgs.Frame.Clone();
        }

        Image LastImageSent = null; // last correctly send image
        Image LastImageReceived = null; // last correctly received image

        Thread Sender; // thread for sending images
        Thread Receiver; // thread for receiving images

        bool Closing = false; // true if form is to be quit
        String ClosingString = "FORM#CLOSING"; // message, which is sent when closing
        byte[] ClosingBytes; // byte coding of this message
        ASCIIEncoding ByteConverter = new ASCIIEncoding(); // object to convert strings to byte arrays and other way

        private void button1_Click(object sender, EventArgs e){
        
            // start thread for sending the own image
            Sender = new Thread(new ParameterizedThreadStart(this.Send));
            Sender.Start(int.Parse(textBox4.Text));

            // start thread for receiving the partner image
            Receiver = new Thread(new ParameterizedThreadStart(Receive));
            Receiver.Start(textBox2.Text + "-" + textBox1.Text);

            ClosingBytes = ByteConverter.GetBytes(ClosingString);
        }

        private void Send(object port){
        
            Thread.Sleep(1000);
            InitWebCam(int.Parse(textBox3.Text)); // start webcam

            TcpListener Server = new TcpListener(int.Parse(port.ToString()));
            Server.Start();

            TcpClient Client = Server.AcceptTcpClient();

            NetworkStream ClientStream = Client.GetStream();

            while (true){
            
                if (Closing)
                    break;
                try{
                
                    WriteImage((Image)pictureBoxVideoSelf.BackgroundImage.Clone(), ClientStream);
                    //currentFrame = grabber.QueryFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                    LastImageSent = (Image)pictureBoxVideoSelf.BackgroundImage.Clone();
                    Thread.Sleep(100);
                }
                catch{
                   // if the current image could not be send, take the backup
                    WriteImage(LastImageSent, ClientStream);
                }
            }
            try{
                ClientStream.Write(ClosingBytes, 0, ClosingBytes.Length);
            }
            catch { };
        }

        //void videoSource_NewFrame(object sender, NewFrameEventArgs eventArgs){
        //    Bitmap image = (Bitmap)eventArgs.Frame.Clone();
        //    System.Threading.Thread.Sleep(100);
        //    pictureBox1.Image = image;
        //}

        private void Receive(object portip){
            // portip has the form "port-ip"
            string[] Parameter = portip.ToString().Split('-');
            System.Net.IPAddress IP = System.Net.IPAddress.Parse(Parameter[1]);

            TcpClient Exchange = new TcpClient();
            NetworkStream ExchangeStream = null;

            Image TempImage;

            // try to setup a connection every 3 seconds
            while (true){
                try{
                    Exchange.Connect(IP, int.Parse(Parameter[0]));
                    ExchangeStream = Exchange.GetStream();
                    break;
                }
                catch{
                    Thread.Sleep(3000);
                }
            }

            while (true){
                if (Closing)
                    break; // quit

                try{
                    // try to display the received image
                    // in case of success
                    TempImage = ReadImage(ExchangeStream);
                    if (TempImage == null)
                        throw new Exception();

                    pictureBoxVideoPartner.BackgroundImage = TempImage;
                    LastImageReceived = (Image)pictureBoxVideoPartner.BackgroundImage.Clone();
                    Thread.Sleep(100);
                }
                catch{
                    try{
                       // in case of error use backup image
                        pictureBoxVideoPartner.BackgroundImage = LastImageReceived;
                    }
                    catch { }
                }
            }
        }

        private void WriteImage(Image image, NetworkStream stream){
            ASCIIEncoding Encoder = new ASCIIEncoding();
            MemoryStream TempStream = new MemoryStream();
            byte[] Buffer;

            try{
                // write the handed over image to the stream
                image.Save(TempStream, System.Drawing.Imaging.ImageFormat.Gif);
            }
            catch
            {
            }

            Buffer = TempStream.ToArray();

            // encode the size of the image as a 20 character string, fill up with x
            string ImageSize = Buffer.Length.ToString();
            while (ImageSize.Length < 20)
                ImageSize += "x";

            // write its size plus content to an array
            byte[] FittedImageSize = Encoder.GetBytes(ImageSize);
            byte[] ImagePlusSize = new byte[FittedImageSize.Length + Buffer.Length];
            Array.Copy(FittedImageSize, ImagePlusSize, FittedImageSize.Length);
            Array.Copy(Buffer, 0, ImagePlusSize, FittedImageSize.Length, Buffer.Length);

            try{
                // write the array
                stream.Write(ImagePlusSize, 0, ImagePlusSize.Length);
                stream.Flush();
            }
            catch{
                // if the stream cannot be written anymore, the partner has quit
                Closing = true;
            }
        }

        private Image ReadImage(NetworkStream stream){
            Image Result;
            int BytesRead;

            // read the first 20 bytes of the stream, since they encode the size of the image
            byte[] ImageSize = new byte[20];
            BytesRead = stream.Read(ImageSize, 0, 20);

            /* if only 12 bytes can be read and they contain the closing string, a termination is requested */
            if (BytesRead == 12){
                if (ByteConverter.GetString(ImageSize, 0, 12) == "FORM#CLOSING"){
                    Closing = true;
                    return null;
                }
            }

            byte[] ErrorBuffer = new byte[100000000];

            ASCIIEncoding Decoder = new ASCIIEncoding();
            string ImageSizeString = Decoder.GetString(ImageSize).Replace("x", "");

            int TestSize;

            if (!int.TryParse(ImageSizeString, out TestSize)){
                stream.Read(ErrorBuffer, 0, ErrorBuffer.Length);
                return null;
            }

            byte[] ImageFile = new byte[int.Parse(ImageSizeString)];

            stream.Read(ImageFile, 0, ImageFile.Length);

            MemoryStream temps = new MemoryStream();

            try{
                temps.Write(ImageFile, 0, ImageFile.Length);
                Result = Image.FromStream(temps);
                return Result;
            }
            catch{
                return null;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e){
            // dispose webcam at closing
            if (videoSource != null && videoSource.IsRunning){
                videoSource.SignalToStop();
                videoSource = null;
            }

            Closing = true;

            Thread.Sleep(3000);

            if (Sender != null && Sender.IsAlive)
                Sender.Abort();

            if (Receiver != null && Receiver.IsAlive)
                Receiver.Abort();
            //Server.Stop();
        }
    }
}
