using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using C-ChatDatabase.Framework;
using C-ChatDatabase.DataAccess;

namespace C-ChatBox{
    public partial class Profile : MetroFramework.Forms.MetroForm{
        C-ChatData da = new C-ChatData();

        public string title, email;
        public static string myIP, friendIP;
        public static int myPort, friendPort;
        public Profile(){
            InitializeComponent();            
        }

        private void Profile_Load(object sender, EventArgs e){            
            title = da.getUserTitle(LogForm.thisUser);
            titleLabel.Text = title;

            email = da.getUserMail(LogForm.thisUser);
            mailLabel.Text = email;

            nameLabel.Text = title;
            NetInfo netdat = new NetInfo();

            netdat.netData(LogForm.thisUser);
            myIP = netdat.getLocalIP();
            ipLabel.Text = myIP;

            myPort = da.getPort(LogForm.thisUser);
            portLabel.Text = myPort.ToString();

            List<proNetInfo> gridList = da.gridView();
            var bs = new BindingSource();
            var list = new List<proNetInfo>(gridList);
            bs.DataSource = list;            
            dataGridView1.DataSource = bs;
        }        

        private void metroLabel1_Click(object sender, EventArgs e){

        }

        private void Profile_FormClosed(object sender, FormClosedEventArgs e){
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e){
            if(e.RowIndex >=0){
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                friendName.Text = row.Cells["UName"].Value.ToString();
                friendIPadd.Text = row.Cells["IPAddress"].Value.ToString();
                friendPortadd.Text = e.RowIndex.ToString();
            }
        }

        private void metroButton2_Click(object sender, EventArgs e){
            List<proNetInfo> gridList = da.gridView();
            var bs = new BindingSource();
            var list = new List<proNetInfo>(gridList);
            bs.DataSource = list;
            dataGridView1.DataSource = bs;
        }

        private void Profile_FormClosing(object sender, FormClosingEventArgs e){

        }

        private void metroTile1_Click(object sender, EventArgs e){
            try{
                friendIP = friendIPadd.Text;
                friendPort = Convert.ToInt32(friendPortadd.Text);

                Form1 vid = new Form1();
                vid.Show();
            }
            catch(Exception exp){
                errorVdoLabel.Visible = true;
            }
        }       
        
    }
}
