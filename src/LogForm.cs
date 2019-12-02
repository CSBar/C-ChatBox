using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;
using C-ChatDatabase.DataAccess;
using C-ChatDatabase.Framework;

namespace C-ChatBox{
    public partial class LogForm : MetroFramework.Forms.MetroForm{
        C-ChatData data = new C-ChatData();
        public static string thisUser;

        public LogForm(){
            Thread splash = new Thread(new ThreadStart(splashStart));
            splash.Start();
            Thread.Sleep(2000);

            InitializeComponent();                        
            splash.Abort();
        }

        public void splashStart(){
            Application.Run(new SplashScreen());
        }

        private void metroLink1_Click(object sender, EventArgs e){
            logTab.SelectTab(regTab);
        }

        private void metroLink2_Click(object sender, EventArgs e){
            this.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e){            
            //SqlCommand cmd = new SqlCommand("select * from Register where UName = '" + userText.Text + "' and PWord = '" + passText.Text + "'");

            bool log = data.loginApproval(userText.Text, passText.Text);
            if(log == true){
                thisUser = userText.Text;
                Profile pro = new Profile();                
                pro.Show();
                this.Hide();
            }
            else{
                loginLevel.Visible = true;
            }
        }

        private void metroButton2_Click(object sender, EventArgs e){
            //C-ChatData reg = new C-ChatData();
            //reg.regInsert(regFullName.Text, regUserName.Text, regEmail.Text, regPass.Text);
            Register reg = new Register();

            reg.FName = regFullName.Text;
            reg.UName = regUserName.Text;
            reg.Email = regEmail.Text;
            reg.PWord = regPass.Text;
            
            bool regComplete = data.regInsert(reg);
            if (regComplete == true){
                logTab.SelectTab(signIn);
                metroLabel8.Visible = true;
            }
            else{
                metroLabel9.Visible = true;
            }
        }
    }
}
