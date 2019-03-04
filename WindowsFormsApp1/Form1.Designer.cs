namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TodayYear = new System.Windows.Forms.TextBox();
            this.TodayMonth = new System.Windows.Forms.TextBox();
            this.TodayDay = new System.Windows.Forms.TextBox();
            this.Day = new System.Windows.Forms.TextBox();
            this.CountYear = new System.Windows.Forms.TextBox();
            this.CountMonth = new System.Windows.Forms.TextBox();
            this.CountDay = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "請輸入今天的日期";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "請輸入今天是星期幾";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(342, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "日期計算器";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "請輸入要計算的日期";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "結果";
            // 
            // TodayYear
            // 
            this.TodayYear.Location = new System.Drawing.Point(196, 54);
            this.TodayYear.Name = "TodayYear";
            this.TodayYear.Size = new System.Drawing.Size(100, 22);
            this.TodayYear.TabIndex = 5;
            this.TodayYear.Text = "2019";
            // 
            // TodayMonth
            // 
            this.TodayMonth.Location = new System.Drawing.Point(345, 54);
            this.TodayMonth.Name = "TodayMonth";
            this.TodayMonth.Size = new System.Drawing.Size(100, 22);
            this.TodayMonth.TabIndex = 6;
            this.TodayMonth.Text = "2";
            // 
            // TodayDay
            // 
            this.TodayDay.Location = new System.Drawing.Point(498, 54);
            this.TodayDay.Name = "TodayDay";
            this.TodayDay.Size = new System.Drawing.Size(100, 22);
            this.TodayDay.TabIndex = 7;
            this.TodayDay.Text = "26";
            // 
            // Day
            // 
            this.Day.Location = new System.Drawing.Point(196, 93);
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(100, 22);
            this.Day.TabIndex = 8;
            this.Day.Text = "2";
            // 
            // CountYear
            // 
            this.CountYear.Location = new System.Drawing.Point(196, 140);
            this.CountYear.Name = "CountYear";
            this.CountYear.Size = new System.Drawing.Size(100, 22);
            this.CountYear.TabIndex = 9;
            this.CountYear.Text = "2169";
            // 
            // CountMonth
            // 
            this.CountMonth.Location = new System.Drawing.Point(345, 143);
            this.CountMonth.Name = "CountMonth";
            this.CountMonth.Size = new System.Drawing.Size(100, 22);
            this.CountMonth.TabIndex = 10;
            this.CountMonth.Text = "2";
            // 
            // CountDay
            // 
            this.CountDay.Location = new System.Drawing.Point(498, 143);
            this.CountDay.Name = "CountDay";
            this.CountDay.Size = new System.Drawing.Size(100, 22);
            this.CountDay.TabIndex = 11;
            this.CountDay.Text = "26";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(629, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 107);
            this.button1.TabIndex = 12;
            this.button1.Text = "計算";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(302, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "年";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(302, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "年";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(451, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "月";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(601, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "日";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(302, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 17);
            this.label10.TabIndex = 16;
            this.label10.Text = "年";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(451, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 17);
            this.label11.TabIndex = 17;
            this.label11.Text = "月";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(604, 143);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 17);
            this.label12.TabIndex = 18;
            this.label12.Text = "日";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CountDay);
            this.Controls.Add(this.CountMonth);
            this.Controls.Add(this.CountYear);
            this.Controls.Add(this.Day);
            this.Controls.Add(this.TodayDay);
            this.Controls.Add(this.TodayMonth);
            this.Controls.Add(this.TodayYear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TodayYear;
        private System.Windows.Forms.TextBox TodayMonth;
        private System.Windows.Forms.TextBox TodayDay;
        private System.Windows.Forms.TextBox Day;
        private System.Windows.Forms.TextBox CountYear;
        private System.Windows.Forms.TextBox CountMonth;
        private System.Windows.Forms.TextBox CountDay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

