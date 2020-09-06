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

        private async void WorkOutForm_Load(object sender, EventArgs e)
        {
            await _user.NextWorkOut(_host);

            this.Text = _user._name +"-"+ _user._currentWorkOutGoal.WorkOutName;

            groupBox_Exercise_1.Text = _user._currentWorkOutGoal.Exercise_1.Name;
            groupBox_Exercise_2.Text = _user._currentWorkOutGoal.Exercise_2.Name;
            groupBox_Exercise_3.Text = _user._currentWorkOutGoal.Exercise_3.Name;

            textBox_Target_Sets_1.Text = _user._currentWorkOutGoal.Exercise_1.Sets.ToString();
            textBox_Target_Sets_2.Text = _user._currentWorkOutGoal.Exercise_2.Sets.ToString();
            textBox_Target_Sets_3.Text = _user._currentWorkOutGoal.Exercise_3.Sets.ToString();

            textBox_Target_Reps_1.Text = _user._currentWorkOutGoal.Exercise_1.Reps.ToString();
            textBox_Target_Reps_2.Text = _user._currentWorkOutGoal.Exercise_2.Reps.ToString();
            textBox_Target_Reps_3.Text = _user._currentWorkOutGoal.Exercise_3.Reps.ToString();

            numericUpDown_Reps_1.Value = _user._currentWorkOutGoal.Exercise_1.Reps;
            numericUpDown_Reps_2.Value = _user._currentWorkOutGoal.Exercise_2.Reps;
            numericUpDown_Reps_3.Value = _user._currentWorkOutGoal.Exercise_3.Reps;
            //todo display loading window
            //groupBox_Exercise_1.Text = 
            //this.Text = 
        }
    }
}
