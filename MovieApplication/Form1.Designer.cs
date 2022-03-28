namespace MovieApplication
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdMovie2 = new System.Windows.Forms.RadioButton();
            this.rdMovie1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdTime4 = new System.Windows.Forms.RadioButton();
            this.rdTime3 = new System.Windows.Forms.RadioButton();
            this.rdTime2 = new System.Windows.Forms.RadioButton();
            this.rdTime1 = new System.Windows.Forms.RadioButton();
            this.cbA1 = new System.Windows.Forms.CheckBox();
            this.cbA2 = new System.Windows.Forms.CheckBox();
            this.cbA4 = new System.Windows.Forms.CheckBox();
            this.cbA3 = new System.Windows.Forms.CheckBox();
            this.cbA6 = new System.Windows.Forms.CheckBox();
            this.cbA5 = new System.Windows.Forms.CheckBox();
            this.cbB6 = new System.Windows.Forms.CheckBox();
            this.cbB5 = new System.Windows.Forms.CheckBox();
            this.cbB4 = new System.Windows.Forms.CheckBox();
            this.cbB3 = new System.Windows.Forms.CheckBox();
            this.cbB2 = new System.Windows.Forms.CheckBox();
            this.cbB1 = new System.Windows.Forms.CheckBox();
            this.cbC6 = new System.Windows.Forms.CheckBox();
            this.cbC5 = new System.Windows.Forms.CheckBox();
            this.cbC4 = new System.Windows.Forms.CheckBox();
            this.cbC3 = new System.Windows.Forms.CheckBox();
            this.cbC2 = new System.Windows.Forms.CheckBox();
            this.cbC1 = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMovie = new System.Windows.Forms.TextBox();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSeat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdMovie2);
            this.groupBox1.Controls.Add(this.rdMovie1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(24, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 248);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ภาพยนต์";
            // 
            // rdMovie2
            // 
            this.rdMovie2.AutoSize = true;
            this.rdMovie2.Location = new System.Drawing.Point(47, 88);
            this.rdMovie2.Name = "rdMovie2";
            this.rdMovie2.Size = new System.Drawing.Size(119, 41);
            this.rdMovie2.TabIndex = 7;
            this.rdMovie2.Text = "พี่นาค 3";
            this.rdMovie2.UseVisualStyleBackColor = true;
            this.rdMovie2.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rdMovie1
            // 
            this.rdMovie1.AutoSize = true;
            this.rdMovie1.Checked = true;
            this.rdMovie1.Location = new System.Drawing.Point(47, 41);
            this.rdMovie1.Name = "rdMovie1";
            this.rdMovie1.Size = new System.Drawing.Size(126, 41);
            this.rdMovie1.TabIndex = 0;
            this.rdMovie1.TabStop = true;
            this.rdMovie1.Text = "เทอมสอง";
            this.rdMovie1.UseVisualStyleBackColor = true;
            this.rdMovie1.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdTime4);
            this.groupBox2.Controls.Add(this.rdTime3);
            this.groupBox2.Controls.Add(this.rdTime2);
            this.groupBox2.Controls.Add(this.rdTime1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(243, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 248);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "รอบ";
            // 
            // rdTime4
            // 
            this.rdTime4.AutoSize = true;
            this.rdTime4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdTime4.Location = new System.Drawing.Point(47, 182);
            this.rdTime4.Name = "rdTime4";
            this.rdTime4.Size = new System.Drawing.Size(101, 41);
            this.rdTime4.TabIndex = 8;
            this.rdTime4.Text = "19:00";
            this.rdTime4.UseVisualStyleBackColor = true;
            this.rdTime4.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rdTime3
            // 
            this.rdTime3.AutoSize = true;
            this.rdTime3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdTime3.Location = new System.Drawing.Point(47, 135);
            this.rdTime3.Name = "rdTime3";
            this.rdTime3.Size = new System.Drawing.Size(101, 41);
            this.rdTime3.TabIndex = 8;
            this.rdTime3.Text = "16:20";
            this.rdTime3.UseVisualStyleBackColor = true;
            this.rdTime3.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rdTime2
            // 
            this.rdTime2.AutoSize = true;
            this.rdTime2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdTime2.Location = new System.Drawing.Point(47, 88);
            this.rdTime2.Name = "rdTime2";
            this.rdTime2.Size = new System.Drawing.Size(101, 41);
            this.rdTime2.TabIndex = 7;
            this.rdTime2.Text = "13:40";
            this.rdTime2.UseVisualStyleBackColor = true;
            this.rdTime2.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rdTime1
            // 
            this.rdTime1.AutoSize = true;
            this.rdTime1.Checked = true;
            this.rdTime1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdTime1.Location = new System.Drawing.Point(47, 41);
            this.rdTime1.Name = "rdTime1";
            this.rdTime1.Size = new System.Drawing.Size(101, 41);
            this.rdTime1.TabIndex = 0;
            this.rdTime1.TabStop = true;
            this.rdTime1.Text = "11:00";
            this.rdTime1.UseVisualStyleBackColor = true;
            this.rdTime1.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // cbA1
            // 
            this.cbA1.AutoSize = true;
            this.cbA1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbA1.Location = new System.Drawing.Point(200, 384);
            this.cbA1.Name = "cbA1";
            this.cbA1.Size = new System.Drawing.Size(68, 41);
            this.cbA1.TabIndex = 8;
            this.cbA1.Text = "A1";
            this.cbA1.UseVisualStyleBackColor = true;
            this.cbA1.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // cbA2
            // 
            this.cbA2.AutoSize = true;
            this.cbA2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbA2.Location = new System.Drawing.Point(274, 384);
            this.cbA2.Name = "cbA2";
            this.cbA2.Size = new System.Drawing.Size(68, 41);
            this.cbA2.TabIndex = 9;
            this.cbA2.Text = "A2";
            this.cbA2.UseVisualStyleBackColor = true;
            this.cbA2.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // cbA4
            // 
            this.cbA4.AutoSize = true;
            this.cbA4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbA4.Location = new System.Drawing.Point(413, 384);
            this.cbA4.Name = "cbA4";
            this.cbA4.Size = new System.Drawing.Size(68, 41);
            this.cbA4.TabIndex = 11;
            this.cbA4.Text = "A4";
            this.cbA4.UseVisualStyleBackColor = true;
            this.cbA4.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // cbA3
            // 
            this.cbA3.AutoSize = true;
            this.cbA3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbA3.Location = new System.Drawing.Point(348, 384);
            this.cbA3.Name = "cbA3";
            this.cbA3.Size = new System.Drawing.Size(68, 41);
            this.cbA3.TabIndex = 10;
            this.cbA3.Text = "A3";
            this.cbA3.UseVisualStyleBackColor = true;
            this.cbA3.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // cbA6
            // 
            this.cbA6.AutoSize = true;
            this.cbA6.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbA6.Location = new System.Drawing.Point(561, 384);
            this.cbA6.Name = "cbA6";
            this.cbA6.Size = new System.Drawing.Size(68, 41);
            this.cbA6.TabIndex = 13;
            this.cbA6.Text = "A6";
            this.cbA6.UseVisualStyleBackColor = true;
            this.cbA6.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // cbA5
            // 
            this.cbA5.AutoSize = true;
            this.cbA5.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbA5.Location = new System.Drawing.Point(487, 384);
            this.cbA5.Name = "cbA5";
            this.cbA5.Size = new System.Drawing.Size(68, 41);
            this.cbA5.TabIndex = 12;
            this.cbA5.Text = "A5";
            this.cbA5.UseVisualStyleBackColor = true;
            this.cbA5.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // cbB6
            // 
            this.cbB6.AutoSize = true;
            this.cbB6.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbB6.Location = new System.Drawing.Point(561, 337);
            this.cbB6.Name = "cbB6";
            this.cbB6.Size = new System.Drawing.Size(66, 41);
            this.cbB6.TabIndex = 19;
            this.cbB6.Text = "B6";
            this.cbB6.UseVisualStyleBackColor = true;
            this.cbB6.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // cbB5
            // 
            this.cbB5.AutoSize = true;
            this.cbB5.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbB5.Location = new System.Drawing.Point(487, 337);
            this.cbB5.Name = "cbB5";
            this.cbB5.Size = new System.Drawing.Size(66, 41);
            this.cbB5.TabIndex = 18;
            this.cbB5.Text = "B5";
            this.cbB5.UseVisualStyleBackColor = true;
            this.cbB5.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // cbB4
            // 
            this.cbB4.AutoSize = true;
            this.cbB4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbB4.Location = new System.Drawing.Point(413, 337);
            this.cbB4.Name = "cbB4";
            this.cbB4.Size = new System.Drawing.Size(66, 41);
            this.cbB4.TabIndex = 17;
            this.cbB4.Text = "B4";
            this.cbB4.UseVisualStyleBackColor = true;
            this.cbB4.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // cbB3
            // 
            this.cbB3.AutoSize = true;
            this.cbB3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbB3.Location = new System.Drawing.Point(348, 337);
            this.cbB3.Name = "cbB3";
            this.cbB3.Size = new System.Drawing.Size(66, 41);
            this.cbB3.TabIndex = 16;
            this.cbB3.Text = "B3";
            this.cbB3.UseVisualStyleBackColor = true;
            this.cbB3.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // cbB2
            // 
            this.cbB2.AutoSize = true;
            this.cbB2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbB2.Location = new System.Drawing.Point(274, 337);
            this.cbB2.Name = "cbB2";
            this.cbB2.Size = new System.Drawing.Size(66, 41);
            this.cbB2.TabIndex = 15;
            this.cbB2.Text = "B2";
            this.cbB2.UseVisualStyleBackColor = true;
            this.cbB2.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // cbB1
            // 
            this.cbB1.AutoSize = true;
            this.cbB1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbB1.Location = new System.Drawing.Point(200, 337);
            this.cbB1.Name = "cbB1";
            this.cbB1.Size = new System.Drawing.Size(66, 41);
            this.cbB1.TabIndex = 14;
            this.cbB1.Text = "B1";
            this.cbB1.UseVisualStyleBackColor = true;
            this.cbB1.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // cbC6
            // 
            this.cbC6.AutoSize = true;
            this.cbC6.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbC6.Location = new System.Drawing.Point(561, 290);
            this.cbC6.Name = "cbC6";
            this.cbC6.Size = new System.Drawing.Size(68, 41);
            this.cbC6.TabIndex = 25;
            this.cbC6.Text = "C6";
            this.cbC6.UseVisualStyleBackColor = true;
            this.cbC6.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // cbC5
            // 
            this.cbC5.AutoSize = true;
            this.cbC5.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbC5.Location = new System.Drawing.Point(487, 290);
            this.cbC5.Name = "cbC5";
            this.cbC5.Size = new System.Drawing.Size(68, 41);
            this.cbC5.TabIndex = 24;
            this.cbC5.Text = "C5";
            this.cbC5.UseVisualStyleBackColor = true;
            this.cbC5.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // cbC4
            // 
            this.cbC4.AutoSize = true;
            this.cbC4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbC4.Location = new System.Drawing.Point(413, 290);
            this.cbC4.Name = "cbC4";
            this.cbC4.Size = new System.Drawing.Size(68, 41);
            this.cbC4.TabIndex = 23;
            this.cbC4.Text = "C4";
            this.cbC4.UseVisualStyleBackColor = true;
            this.cbC4.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // cbC3
            // 
            this.cbC3.AutoSize = true;
            this.cbC3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbC3.Location = new System.Drawing.Point(348, 290);
            this.cbC3.Name = "cbC3";
            this.cbC3.Size = new System.Drawing.Size(68, 41);
            this.cbC3.TabIndex = 22;
            this.cbC3.Text = "C3";
            this.cbC3.UseVisualStyleBackColor = true;
            this.cbC3.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // cbC2
            // 
            this.cbC2.AutoSize = true;
            this.cbC2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbC2.Location = new System.Drawing.Point(274, 290);
            this.cbC2.Name = "cbC2";
            this.cbC2.Size = new System.Drawing.Size(68, 41);
            this.cbC2.TabIndex = 21;
            this.cbC2.Text = "C2";
            this.cbC2.UseVisualStyleBackColor = true;
            this.cbC2.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // cbC1
            // 
            this.cbC1.AutoSize = true;
            this.cbC1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbC1.Location = new System.Drawing.Point(200, 290);
            this.cbC1.Name = "cbC1";
            this.cbC1.Size = new System.Drawing.Size(68, 41);
            this.cbC1.TabIndex = 20;
            this.cbC1.Text = "C1";
            this.cbC1.UseVisualStyleBackColor = true;
            this.cbC1.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.cbC1);
            this.groupBox3.Controls.Add(this.cbC6);
            this.groupBox3.Controls.Add(this.cbA1);
            this.groupBox3.Controls.Add(this.cbC5);
            this.groupBox3.Controls.Add(this.cbA2);
            this.groupBox3.Controls.Add(this.cbC4);
            this.groupBox3.Controls.Add(this.cbA3);
            this.groupBox3.Controls.Add(this.cbC3);
            this.groupBox3.Controls.Add(this.cbA4);
            this.groupBox3.Controls.Add(this.cbC2);
            this.groupBox3.Controls.Add(this.cbA5);
            this.groupBox3.Controls.Add(this.cbA6);
            this.groupBox3.Controls.Add(this.cbB6);
            this.groupBox3.Controls.Add(this.cbB1);
            this.groupBox3.Controls.Add(this.cbB5);
            this.groupBox3.Controls.Add(this.cbB2);
            this.groupBox3.Controls.Add(this.cbB4);
            this.groupBox3.Controls.Add(this.cbB3);
            this.groupBox3.Location = new System.Drawing.Point(26, 298);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(840, 460);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ที่นั่ง";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(346, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 54);
            this.label1.TabIndex = 26;
            this.label1.Text = "จอภาพ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(498, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 37);
            this.label2.TabIndex = 27;
            this.label2.Text = "ภาพยนต์";
            // 
            // tbMovie
            // 
            this.tbMovie.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbMovie.Location = new System.Drawing.Point(613, 73);
            this.tbMovie.Name = "tbMovie";
            this.tbMovie.Size = new System.Drawing.Size(230, 43);
            this.tbMovie.TabIndex = 28;
            // 
            // tbTime
            // 
            this.tbTime.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbTime.Location = new System.Drawing.Point(613, 123);
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(230, 43);
            this.tbTime.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(498, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 37);
            this.label3.TabIndex = 29;
            this.label3.Text = "รอบฉาย";
            // 
            // tbSeat
            // 
            this.tbSeat.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbSeat.Location = new System.Drawing.Point(613, 172);
            this.tbSeat.Name = "tbSeat";
            this.tbSeat.Size = new System.Drawing.Size(230, 43);
            this.tbSeat.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(498, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 37);
            this.label4.TabIndex = 31;
            this.label4.Text = "ที่นั่ง";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(613, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 48);
            this.button1.TabIndex = 33;
            this.button1.Text = "ยืนยัน";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 783);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbSeat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbMovie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GroupBox groupBox1;
        private RadioButton rdMovie2;
        private RadioButton rdMovie1;
        private GroupBox groupBox2;
        private RadioButton rdTime4;
        private RadioButton rdTime3;
        private RadioButton rdTime2;
        private RadioButton rdTime1;
        private CheckBox cbA1;
        private CheckBox cbA2;
        private CheckBox cbA4;
        private CheckBox cbA3;
        private CheckBox cbA6;
        private CheckBox cbA5;
        private CheckBox cbB6;
        private CheckBox cbB5;
        private CheckBox cbB4;
        private CheckBox cbB3;
        private CheckBox cbB2;
        private CheckBox cbB1;
        private CheckBox cbC6;
        private CheckBox cbC5;
        private CheckBox cbC4;
        private CheckBox cbC3;
        private CheckBox cbC2;
        private CheckBox cbC1;
        private GroupBox groupBox3;
        private Label label1;
        private Label label2;
        private TextBox tbMovie;
        private TextBox tbTime;
        private Label label3;
        private TextBox tbSeat;
        private Label label4;
        private Button button1;
    }
}