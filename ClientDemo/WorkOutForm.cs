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
    public partial class WorkOutForm : Form
    {
        string _host;
        User _user;
        public WorkOutForm(string host, User user)
        {
            _host = host;
            _user = user;

            InitializeComponent();
        }

        private void button_Target_Met_1_Click(object sender, EventArgs e)
        {

        }
    }
}
