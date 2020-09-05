using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetworkAPI;

namespace ClientDemo
{
    public partial class LogInForm : Form
    {
        private string _defaultHost = @"https://localhost:44340/api";
        public LogInForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox_Host.Text = _defaultHost;
        }

        private void button_LogIn_Click(object sender, EventArgs e)
        {
            string username = textBox_UserName.Text;

            try
            {
                User user = User.LogOn(
                textBox_Host.Text,
                textBox_UserName.Text,
                textBox_Password.Text
                ).Result;

                MessageBox.Show("LogIn succesful");

            }
            catch(Exception error)
            {
                //more info:https://www.dotnetperls.com/messagebox-show
                MessageBox.Show(error.Message);
            }
        }
    }
}
