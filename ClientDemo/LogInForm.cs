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
        private string _defaultHost = @"https://localhost:44340";
        public LogInForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox_Host.Text = _defaultHost;
            textBox_Password.PasswordChar = '*';
        }

        private async void button_LogIn_Click(object sender, EventArgs e)
        {
            try
            {
                User user = await User.LogIn(
                textBox_Host.Text,
                textBox_UserName.Text,
                textBox_Password.Text
                );

                this.Hide();
                WorkOutForm workOutForm = new WorkOutForm(textBox_Host.Text, user);
                workOutForm.ShowDialog();
            }
            catch(Exception error)
            {
                //more info:https://www.dotnetperls.com/messagebox-show
                MessageBox.Show(error.Message);
            }
        }

        private async void button_Create_Click(object sender, EventArgs e)
        {
            try
            {
                User user = await User.Create(
                textBox_Host.Text,
                textBox_UserName.Text,
                textBox_Password.Text
                );

                this.Hide();
                WorkOutForm workOutForm = new WorkOutForm(textBox_Host.Text, user);
                workOutForm.ShowDialog();

                MessageBox.Show("User creation succesful");

            }
            catch (Exception error)
            {
                //more info:https://www.dotnetperls.com/messagebox-show
                MessageBox.Show(error.Message);
            }
        }

        private async void button_CheckConnection_Click(object sender, EventArgs e)
        {
            if(await User.CheckConnection(textBox_Host.Text))
            {
                MessageBox.Show("Connection is fine");
            }
            else
            {
                MessageBox.Show("Failed to connect");
            }
        }

        private void checkBox_ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_ShowPassword.Checked)
            {
                textBox_Password.PasswordChar = '\u0000';
            }
            else
            {
                textBox_Password.PasswordChar = '*';
            }
        }
    }
}
