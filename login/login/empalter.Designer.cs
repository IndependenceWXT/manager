namespace login
{
    partial class empalter
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.updatebtn = new System.Windows.Forms.Button();
            this.dept = new System.Windows.Forms.ComboBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.tel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.NumericUpDown();
            this.name = new System.Windows.Forms.TextBox();
            this.num = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.age)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(250, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名：";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(314, 72);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(248, 29);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.updatebtn);
            this.groupBox1.Controls.Add(this.dept);
            this.groupBox1.Controls.Add(this.date);
            this.groupBox1.Controls.Add(this.tel);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.age);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.num);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(60, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(695, 264);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "编辑信息";
            // 
            // updatebtn
            // 
            this.updatebtn.BackColor = System.Drawing.Color.Transparent;
            this.updatebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatebtn.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.updatebtn.ForeColor = System.Drawing.Color.Green;
            this.updatebtn.Location = new System.Drawing.Point(275, 213);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(137, 29);
            this.updatebtn.TabIndex = 12;
            this.updatebtn.Text = "更新";
            this.updatebtn.UseVisualStyleBackColor = false;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // dept
            // 
            this.dept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dept.FormattingEnabled = true;
            this.dept.Location = new System.Drawing.Point(440, 101);
            this.dept.Name = "dept";
            this.dept.Size = new System.Drawing.Size(200, 28);
            this.dept.TabIndex = 11;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(440, 37);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(200, 26);
            this.date.TabIndex = 10;
            // 
            // tel
            // 
            this.tel.Location = new System.Drawing.Point(440, 166);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(200, 26);
            this.tel.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(355, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "所属部门：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(355, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "入职日期：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(355, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "联系方式：";
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(126, 163);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(200, 26);
            this.age.TabIndex = 5;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(126, 101);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(200, 26);
            this.name.TabIndex = 4;
            // 
            // num
            // 
            this.num.Location = new System.Drawing.Point(126, 39);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(200, 26);
            this.num.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "员工年龄：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "员工姓名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "员工工号：";
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.close.Location = new System.Drawing.Point(775, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(30, 30);
            this.close.TabIndex = 13;
            this.close.Text = "×";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            this.close.MouseEnter += new System.EventHandler(this.close_MouseEnter);
            this.close.MouseLeave += new System.EventHandler(this.close_MouseLeave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(346, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "修改员工信息";
            // 
            // empalter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::login.Properties.Resources.bg7;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(804, 412);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.close);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "empalter";
            this.Text = "empalter";
            this.Load += new System.EventHandler(this.empalter_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.empalter_MouseDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.age)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox num;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown age;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.ComboBox dept;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.TextBox tel;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label label8;
    }
}