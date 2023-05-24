using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_evrnt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            string username= txtUserName.Text;
            string pass=txtpassword.Text;
            if(username == "mido" && pass == "midoxmax")
            {
              //  MessageBox.Show("welcome to our system");
              this.Hide();
                dashbord ds= new dashbord();
                ds.Show();
                
            }
            else {
                MessageBox.Show("wronge user name or password");

            }
        }
    }
}
