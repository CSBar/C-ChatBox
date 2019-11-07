using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C-ChatBox{
    public partial class SplashScreen : MetroFramework.Forms.MetroForm{
        public SplashScreen(){
            InitializeComponent();           
        }

        private void timer1_Tick(object sender, EventArgs e){
            metroProgressBar1.Increment(1);
            if (metroProgressBar1.Value == 100){
                timer1.Stop();
                this.Hide();
            }
        }
    }
}
