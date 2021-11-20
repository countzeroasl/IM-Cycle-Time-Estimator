namespace IM_Cycle_Time_Estimator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
			this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
			this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
			this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
			this.maskedTextBox5 = new System.Windows.Forms.MaskedTextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "",
            "ABS",
            "PA",
            "PBT",
            "PC",
            "PC/ABS",
            "PE",
            "PEEK",
            "PEI",
            "PET",
            "PMMA",
            "POM",
            "PP",
            "PPS",
            "PS",
            "PVC"});
			this.comboBox1.Location = new System.Drawing.Point(15, 117);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(190, 21);
			this.comboBox1.TabIndex = 0;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			this.comboBox1.TextUpdate += new System.EventHandler(this.comboBox1_TextUpdate);
			this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
			this.comboBox1.Leave += new System.EventHandler(this.comboBox1_Leave);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(86, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(289, 62);
			this.label1.TabIndex = 1;
			this.label1.Text = "Injection Molding Cycle Time Estimator";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 94);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Material";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(204, 94);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(171, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Maximum Wall Thickness (in)";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(265, 120);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(110, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "Injection Temp (F)";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(287, 146);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(88, 13);
			this.label5.TabIndex = 5;
			this.label5.Text = "Mold Temp (F)";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(268, 172);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(107, 13);
			this.label6.TabIndex = 6;
			this.label6.Text = "Ejection Temp (F)";
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Checked = true;
			this.radioButton1.Location = new System.Drawing.Point(48, 174);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(96, 17);
			this.radioButton1.TabIndex = 1;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Centerline Cool";
			this.radioButton1.UseVisualStyleBackColor = true;
			this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new System.Drawing.Point(48, 199);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(89, 17);
			this.radioButton2.TabIndex = 2;
			this.radioButton2.Text = "Average Cool";
			this.radioButton2.UseVisualStyleBackColor = true;
			this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Enabled = false;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(255, 257);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(120, 13);
			this.label7.TabIndex = 14;
			this.label7.Text = "Total Cycle Time (s)";
			this.label7.Visible = false;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(30, 155);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(135, 16);
			this.label8.TabIndex = 15;
			this.label8.Text = "Estimation Method";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(309, 200);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(91, 42);
			this.button1.TabIndex = 8;
			this.button1.Text = "Calculate";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(15, 225);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(158, 17);
			this.checkBox1.TabIndex = 3;
			this.checkBox1.Text = "Mold has Unscrewing Cores";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// maskedTextBox1
			// 
			this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.maskedTextBox1.Location = new System.Drawing.Point(381, 91);
			this.maskedTextBox1.Mask = "9.000";
			this.maskedTextBox1.Name = "maskedTextBox1";
			this.maskedTextBox1.Size = new System.Drawing.Size(54, 21);
			this.maskedTextBox1.TabIndex = 4;
			this.maskedTextBox1.Tag = "";
			this.maskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.maskedTextBox1.TextChanged += new System.EventHandler(this.maskedTextBox1_TextChanged);
			this.maskedTextBox1.Enter += new System.EventHandler(this.maskedTextBox1_Enter);
			// 
			// maskedTextBox2
			// 
			this.maskedTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.maskedTextBox2.Location = new System.Drawing.Point(381, 117);
			this.maskedTextBox2.Name = "maskedTextBox2";
			this.maskedTextBox2.Size = new System.Drawing.Size(54, 21);
			this.maskedTextBox2.TabIndex = 5;
			this.maskedTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.maskedTextBox2.TextChanged += new System.EventHandler(this.maskedTextBox2_TextChanged);
			this.maskedTextBox2.Enter += new System.EventHandler(this.maskedTextBox2_Enter);
			// 
			// maskedTextBox3
			// 
			this.maskedTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.maskedTextBox3.Location = new System.Drawing.Point(381, 143);
			this.maskedTextBox3.Name = "maskedTextBox3";
			this.maskedTextBox3.Size = new System.Drawing.Size(54, 21);
			this.maskedTextBox3.TabIndex = 6;
			this.maskedTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.maskedTextBox3.TextChanged += new System.EventHandler(this.maskedTextBox3_TextChanged);
			this.maskedTextBox3.Enter += new System.EventHandler(this.maskedTextBox3_Enter);
			// 
			// maskedTextBox4
			// 
			this.maskedTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.maskedTextBox4.Location = new System.Drawing.Point(381, 169);
			this.maskedTextBox4.Name = "maskedTextBox4";
			this.maskedTextBox4.Size = new System.Drawing.Size(54, 21);
			this.maskedTextBox4.TabIndex = 7;
			this.maskedTextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.maskedTextBox4.TextChanged += new System.EventHandler(this.maskedTextBox4_TextChanged);
			this.maskedTextBox4.Enter += new System.EventHandler(this.maskedTextBox4_Enter);
			// 
			// maskedTextBox5
			// 
			this.maskedTextBox5.Enabled = false;
			this.maskedTextBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.maskedTextBox5.Location = new System.Drawing.Point(381, 254);
			this.maskedTextBox5.Name = "maskedTextBox5";
			this.maskedTextBox5.ReadOnly = true;
			this.maskedTextBox5.Size = new System.Drawing.Size(63, 21);
			this.maskedTextBox5.TabIndex = 25;
			this.maskedTextBox5.TabStop = false;
			this.maskedTextBox5.Visible = false;
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(12, 257);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(52, 23);
			this.button2.TabIndex = 26;
			this.button2.Text = "About";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(456, 292);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.maskedTextBox5);
			this.Controls.Add(this.maskedTextBox4);
			this.Controls.Add(this.maskedTextBox3);
			this.Controls.Add(this.maskedTextBox2);
			this.Controls.Add(this.maskedTextBox1);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.radioButton2);
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "Injection Molding Cycle Time Estimator";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
		private System.Windows.Forms.MaskedTextBox maskedTextBox5;
		private System.Windows.Forms.Button button2;
    }
}

