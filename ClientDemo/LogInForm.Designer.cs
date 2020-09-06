namespace ClientDemo
{
    partial class LogInForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_LogIn = new System.Windows.Forms.Button();
            this.label_UserName = new System.Windows.Forms.Label();
            this.textBox_UserName = new System.Windows.Forms.TextBox();
            this.label_Host = new System.Windows.Forms.Label();
            this.textBox_Host = new System.Windows.Forms.TextBox();
            this.label_Password = new System.Windows.Forms.Label();
            this.button_CheckConnection = new System.Windows.Forms.Button();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.button_Create = new System.Windows.Forms.Button();
            this.checkBox_ShowPassword = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button_LogIn
            // 
            this.button_LogIn.Location = new System.Drawing.Point(94, 165);
            this.button_LogIn.Name = "button_LogIn";
            this.button_LogIn.Size = new System.Drawing.Size(159, 34);
            this.button_LogIn.TabIndex = 1;
            this.button_LogIn.Text = "Log In";
            this.button_LogIn.UseVisualStyleBackColor = true;
            this.button_LogIn.Click += new System.EventHandler(this.button_LogIn_Click);
            // 
            // label_UserName
            // 
            this.label_UserName.AutoSize = true;
            this.label_UserName.Location = new System.Drawing.Point(23, 108);
            this.label_UserName.Name = "label_UserName";
            this.label_UserName.Size = new System.Drawing.Size(65, 15);
            this.label_UserName.TabIndex = 3;
            this.label_UserName.Text = "UserName:";
            // 
            // textBox_UserName
            // 
            this.textBox_UserName.Location = new System.Drawing.Point(94, 105);
            this.textBox_UserName.Name = "textBox_UserName";
            this.textBox_UserName.Size = new System.Drawing.Size(323, 23);
            this.textBox_UserName.TabIndex = 0;
            // 
            // label_Host
            // 
            this.label_Host.AutoSize = true;
            this.label_Host.Location = new System.Drawing.Point(50, 26);
            this.label_Host.Name = "label_Host";
            this.label_Host.Size = new System.Drawing.Size(35, 15);
            this.label_Host.TabIndex = 4;
            this.label_Host.Text = "Host:";
            // 
            // textBox_Host
            // 
            this.textBox_Host.Location = new System.Drawing.Point(94, 23);
            this.textBox_Host.Name = "textBox_Host";
            this.textBox_Host.Size = new System.Drawing.Size(323, 23);
            this.textBox_Host.TabIndex = 5;
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Location = new System.Drawing.Point(25, 136);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(60, 15);
            this.label_Password.TabIndex = 6;
            this.label_Password.Text = "Password:";
            // 
            // button_CheckConnection
            // 
            this.button_CheckConnection.Location = new System.Drawing.Point(94, 52);
            this.button_CheckConnection.Name = "button_CheckConnection";
            this.button_CheckConnection.Size = new System.Drawing.Size(323, 23);
            this.button_CheckConnection.TabIndex = 7;
            this.button_CheckConnection.Text = "Check Connection";
            this.button_CheckConnection.UseVisualStyleBackColor = true;
            this.button_CheckConnection.Click += new System.EventHandler(this.button_CheckConnection_Click);
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(94, 136);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '*';
            this.textBox_Password.Size = new System.Drawing.Size(209, 23);
            this.textBox_Password.TabIndex = 8;
            // 
            // button_Create
            // 
            this.button_Create.Location = new System.Drawing.Point(258, 165);
            this.button_Create.Name = "button_Create";
            this.button_Create.Size = new System.Drawing.Size(159, 34);
            this.button_Create.TabIndex = 9;
            this.button_Create.Text = "Create New User";
            this.button_Create.UseVisualStyleBackColor = true;
            this.button_Create.Click += new System.EventHandler(this.button_Create_Click);
            // 
            // checkBox_ShowPassword
            // 
            this.checkBox_ShowPassword.AutoSize = true;
            this.checkBox_ShowPassword.Location = new System.Drawing.Point(309, 140);
            this.checkBox_ShowPassword.Name = "checkBox_ShowPassword";
            this.checkBox_ShowPassword.Size = new System.Drawing.Size(108, 19);
            this.checkBox_ShowPassword.TabIndex = 10;
            this.checkBox_ShowPassword.Text = "Show Password";
            this.checkBox_ShowPassword.UseVisualStyleBackColor = true;
            this.checkBox_ShowPassword.CheckedChanged += new System.EventHandler(this.checkBox_ShowPassword_CheckedChanged);
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 224);
            this.Controls.Add(this.checkBox_ShowPassword);
            this.Controls.Add(this.button_Create);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.button_CheckConnection);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.textBox_Host);
            this.Controls.Add(this.label_Host);
            this.Controls.Add(this.textBox_UserName);
            this.Controls.Add(this.label_UserName);
            this.Controls.Add(this.button_LogIn);
            this.Name = "LogInForm";
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_LogIn;
        private System.Windows.Forms.Label label_UserName;
        private System.Windows.Forms.TextBox textBox_UserName;
        private System.Windows.Forms.Label label_Host;
        private System.Windows.Forms.TextBox textBox_Host;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Button button_CheckConnection;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Button button_Create;
        private System.Windows.Forms.CheckBox checkBox_ShowPassword;
    }
}

