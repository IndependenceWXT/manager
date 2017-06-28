namespace login
{
    partial class signRecord
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.wqd = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cd = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.zcqd = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.daycount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(213, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "我的签到记录表（该月所有记录）";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.Location = new System.Drawing.Point(53, 67);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(399, 485);
            this.listView1.TabIndex = 18;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "签到日期";
            this.columnHeader1.Width = 115;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "签到时间";
            this.columnHeader2.Width = 140;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "签到状态";
            this.columnHeader3.Width = 108;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.wqd);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cd);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.zcqd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.daycount);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(477, 354);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 198);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "合计";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(136, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "次";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(136, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "次";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "次";
            // 
            // wqd
            // 
            this.wqd.AutoSize = true;
            this.wqd.Location = new System.Drawing.Point(99, 157);
            this.wqd.Name = "wqd";
            this.wqd.Size = new System.Drawing.Size(17, 20);
            this.wqd.TabIndex = 8;
            this.wqd.Text = "  ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "未签到：";
            // 
            // cd
            // 
            this.cd.AutoSize = true;
            this.cd.Location = new System.Drawing.Point(107, 121);
            this.cd.Name = "cd";
            this.cd.Size = new System.Drawing.Size(17, 20);
            this.cd.TabIndex = 6;
            this.cd.Text = "  ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "迟到：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "正常签到：";
            // 
            // zcqd
            // 
            this.zcqd.AutoSize = true;
            this.zcqd.ForeColor = System.Drawing.Color.Green;
            this.zcqd.Location = new System.Drawing.Point(107, 87);
            this.zcqd.Name = "zcqd";
            this.zcqd.Size = new System.Drawing.Size(17, 20);
            this.zcqd.TabIndex = 3;
            this.zcqd.Text = "  ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "天";
            // 
            // daycount
            // 
            this.daycount.AutoSize = true;
            this.daycount.ForeColor = System.Drawing.Color.Green;
            this.daycount.Location = new System.Drawing.Point(107, 40);
            this.daycount.Name = "daycount";
            this.daycount.Size = new System.Drawing.Size(17, 20);
            this.daycount.TabIndex = 1;
            this.daycount.Text = "  ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "该月共：";
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.close.Location = new System.Drawing.Point(751, -2);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(30, 30);
            this.close.TabIndex = 20;
            this.close.Text = "×";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            this.close.MouseEnter += new System.EventHandler(this.close_MouseEnter);
            this.close.MouseLeave += new System.EventHandler(this.close_MouseLeave);
            // 
            // signRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::login.Properties.Resources.bg7;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(779, 566);
            this.Controls.Add(this.close);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "signRecord";
            this.Text = "signRecord";
            this.Load += new System.EventHandler(this.signRecord_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.signRecord_MouseDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label wqd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label cd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label zcqd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label daycount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
    }
}