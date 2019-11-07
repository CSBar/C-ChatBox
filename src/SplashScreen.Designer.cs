namespace C-ChatBox{
    partial class SplashScreen{
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing){
            if (disposing && (components != null)){
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent(){
        
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            
            // 
            // pictureBox1
            // 
           
           
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(610, 339);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            
            
            // 
            // metroProgressBar1
            // 
            
            
            this.metroProgressBar1.FontSize = MetroFramework.MetroProgressBarSize.Medium;
            this.metroProgressBar1.FontWeight = MetroFramework.MetroProgressBarWeight.Light;
            this.metroProgressBar1.HideProgressText = true;
            this.metroProgressBar1.Location = new System.Drawing.Point(116, 287);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.metroProgressBar1.Size = new System.Drawing.Size(346, 10);
            this.metroProgressBar1.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroProgressBar1.StyleManager = null;
            this.metroProgressBar1.TabIndex = 1;
            this.metroProgressBar1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroProgressBar1.Theme = MetroFramework.MetroThemeStyle.Light;
            
            
            // 
            // timer1
            // 
            
            
            this.timer1.Enabled = true;
            this.timer1.Interval = 12;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            
            
            // 
            // SplashScreen
            // 
            
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 320);
            this.ControlBox = false;
            this.Controls.Add(this.metroProgressBar1);
            this.Controls.Add(this.pictureBox1);
            this.DisplayHeader = false;
            this.Location = new System.Drawing.Point(0, 0);
            this.Movable = false;
            this.Name = "SplashScreen";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.ShadowType.None;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Form1";
            this.TextAlign = MetroFramework.Forms.TextAlign.Center;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
        private System.Windows.Forms.Timer timer1;
    }
}
