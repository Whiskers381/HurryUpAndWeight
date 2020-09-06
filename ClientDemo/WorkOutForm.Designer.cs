namespace ClientDemo
{
    partial class WorkOutForm
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
            this.groupBox_Target_1 = new System.Windows.Forms.GroupBox();
            this.label_Target_Reps = new System.Windows.Forms.Label();
            this.textBox_Target_Reps = new System.Windows.Forms.TextBox();
            this.textBox_Target_Sets = new System.Windows.Forms.TextBox();
            this.label_Target_Sets = new System.Windows.Forms.Label();
            this.groupBox_Exercise_1 = new System.Windows.Forms.GroupBox();
            this.groupBox_Set_1 = new System.Windows.Forms.GroupBox();
            this.button_Target_Met = new System.Windows.Forms.Button();
            this.numericUpDown_Reps_1 = new System.Windows.Forms.NumericUpDown();
            this.button_Alt_Target_Met_1 = new System.Windows.Forms.Button();
            this.button_Finish_1 = new System.Windows.Forms.Button();
            this.groupBox_Target_1.SuspendLayout();
            this.groupBox_Exercise_1.SuspendLayout();
            this.groupBox_Set_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Reps_1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_Target_1
            // 
            this.groupBox_Target_1.Controls.Add(this.label_Target_Reps);
            this.groupBox_Target_1.Controls.Add(this.textBox_Target_Reps);
            this.groupBox_Target_1.Controls.Add(this.textBox_Target_Sets);
            this.groupBox_Target_1.Controls.Add(this.label_Target_Sets);
            this.groupBox_Target_1.Location = new System.Drawing.Point(6, 22);
            this.groupBox_Target_1.Name = "groupBox_Target_1";
            this.groupBox_Target_1.Size = new System.Drawing.Size(216, 72);
            this.groupBox_Target_1.TabIndex = 1;
            this.groupBox_Target_1.TabStop = false;
            this.groupBox_Target_1.Text = "Target";
            // 
            // label_Target_Reps
            // 
            this.label_Target_Reps.AutoSize = true;
            this.label_Target_Reps.Location = new System.Drawing.Point(98, 28);
            this.label_Target_Reps.Name = "label_Target_Reps";
            this.label_Target_Reps.Size = new System.Drawing.Size(35, 15);
            this.label_Target_Reps.TabIndex = 2;
            this.label_Target_Reps.Text = "Reps:";
            // 
            // textBox_Target_Reps
            // 
            this.textBox_Target_Reps.Location = new System.Drawing.Point(135, 25);
            this.textBox_Target_Reps.Name = "textBox_Target_Reps";
            this.textBox_Target_Reps.Size = new System.Drawing.Size(35, 23);
            this.textBox_Target_Reps.TabIndex = 3;
            // 
            // textBox_Target_Sets
            // 
            this.textBox_Target_Sets.Location = new System.Drawing.Point(43, 25);
            this.textBox_Target_Sets.Name = "textBox_Target_Sets";
            this.textBox_Target_Sets.Size = new System.Drawing.Size(35, 23);
            this.textBox_Target_Sets.TabIndex = 3;
            // 
            // label_Target_Sets
            // 
            this.label_Target_Sets.AutoSize = true;
            this.label_Target_Sets.Location = new System.Drawing.Point(6, 28);
            this.label_Target_Sets.Name = "label_Target_Sets";
            this.label_Target_Sets.Size = new System.Drawing.Size(31, 15);
            this.label_Target_Sets.TabIndex = 2;
            this.label_Target_Sets.Text = "Sets:";
            // 
            // groupBox_Exercise_1
            // 
            this.groupBox_Exercise_1.Controls.Add(this.button_Finish_1);
            this.groupBox_Exercise_1.Controls.Add(this.groupBox_Set_1);
            this.groupBox_Exercise_1.Controls.Add(this.groupBox_Target_1);
            this.groupBox_Exercise_1.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Exercise_1.Name = "groupBox_Exercise_1";
            this.groupBox_Exercise_1.Size = new System.Drawing.Size(584, 100);
            this.groupBox_Exercise_1.TabIndex = 2;
            this.groupBox_Exercise_1.TabStop = false;
            this.groupBox_Exercise_1.Text = "Exercise_1";
            // 
            // groupBox_Set_1
            // 
            this.groupBox_Set_1.Controls.Add(this.button_Alt_Target_Met_1);
            this.groupBox_Set_1.Controls.Add(this.numericUpDown_Reps_1);
            this.groupBox_Set_1.Controls.Add(this.button_Target_Met);
            this.groupBox_Set_1.Location = new System.Drawing.Point(228, 22);
            this.groupBox_Set_1.Name = "groupBox_Set_1";
            this.groupBox_Set_1.Size = new System.Drawing.Size(247, 72);
            this.groupBox_Set_1.TabIndex = 1;
            this.groupBox_Set_1.TabStop = false;
            this.groupBox_Set_1.Text = "First Set";
            // 
            // button_Target_Met
            // 
            this.button_Target_Met.Location = new System.Drawing.Point(6, 22);
            this.button_Target_Met.Name = "button_Target_Met";
            this.button_Target_Met.Size = new System.Drawing.Size(75, 44);
            this.button_Target_Met.TabIndex = 4;
            this.button_Target_Met.Text = "Target Met";
            this.button_Target_Met.UseVisualStyleBackColor = true;
            this.button_Target_Met.Click += new System.EventHandler(this.button_Target_Met_Click);
            // 
            // numericUpDown_Reps_1
            // 
            this.numericUpDown_Reps_1.Location = new System.Drawing.Point(97, 35);
            this.numericUpDown_Reps_1.Name = "numericUpDown_Reps_1";
            this.numericUpDown_Reps_1.Size = new System.Drawing.Size(60, 23);
            this.numericUpDown_Reps_1.TabIndex = 5;
            // 
            // button_Alt_Target_Met_1
            // 
            this.button_Alt_Target_Met_1.Location = new System.Drawing.Point(163, 22);
            this.button_Alt_Target_Met_1.Name = "button_Alt_Target_Met_1";
            this.button_Alt_Target_Met_1.Size = new System.Drawing.Size(75, 44);
            this.button_Alt_Target_Met_1.TabIndex = 6;
            this.button_Alt_Target_Met_1.Text = "Alternative Target Met";
            this.button_Alt_Target_Met_1.UseVisualStyleBackColor = true;
            // 
            // button_Finish_1
            // 
            this.button_Finish_1.Location = new System.Drawing.Point(481, 22);
            this.button_Finish_1.Name = "button_Finish_1";
            this.button_Finish_1.Size = new System.Drawing.Size(97, 72);
            this.button_Finish_1.TabIndex = 2;
            this.button_Finish_1.Text = "Finish";
            this.button_Finish_1.UseVisualStyleBackColor = true;
            // 
            // WorkOutForm
            // 
            this.ClientSize = new System.Drawing.Size(606, 367);
            this.Controls.Add(this.groupBox_Exercise_1);
            this.Name = "WorkOutForm";
            this.Text = "WorkOut";
            this.groupBox_Target_1.ResumeLayout(false);
            this.groupBox_Target_1.PerformLayout();
            this.groupBox_Exercise_1.ResumeLayout(false);
            this.groupBox_Set_1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Reps_1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Target_1;
        private System.Windows.Forms.Label label_Target_Reps;
        private System.Windows.Forms.TextBox textBox_Target_Reps;
        private System.Windows.Forms.TextBox textBox_Target_Sets;
        private System.Windows.Forms.Label label_Target_Sets;
        private System.Windows.Forms.GroupBox groupBox_Exercise_1;
        private System.Windows.Forms.GroupBox groupBox_Set_1;
        private System.Windows.Forms.Button button_Target_Met;
        private System.Windows.Forms.Button button_Finish_1;
        private System.Windows.Forms.Button button_Alt_Target_Met_1;
        private System.Windows.Forms.NumericUpDown numericUpDown_Reps_1;
    }
}

