namespace login
{
    partial class myInformation
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numtext = new System.Windows.Forms.Label();
            this.nametext = new System.Windows.Forms.Label();
            this.teltext = new System.Windows.Forms.Label();
            this.lookbtn = new System.Windows.Forms.Button();
            this.img = new System.Windows.Forms.PictureBox();
            this.dept = new System.Windows.Forms.ComboBox();
            this.age = new System.Windows.Forms.NumericUpDown();
            this.tel = new System.Windows.Forms.TextBox();
            this.createdate = new System.Windows.Forms.DateTimePicker();
            this.name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.num = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.alterbtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.close = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.age)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.numtext);
            this.groupBox1.Controls.Add(this.nametext);
            this.groupBox1.Controls.Add(this.teltext);
            this.groupBox1.Controls.Add(this.lookbtn);
            this.groupBox1.Controls.Add(this.img);
            this.groupBox1.Controls.Add(this.dept);
            this.groupBox1.Controls.Add(this.age);
            this.groupBox1.Controls.Add(this.tel);
            this.groupBox1.Controls.Add(this.createdate);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.num);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(56, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(623, 375);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "我的信息";
            // 
            // numtext
            // 
            this.numtext.AutoSize = true;
            this.numtext.Location = new System.Drawing.Point(314, 53);
            this.numtext.Name = "numtext";
            this.numtext.Size = new System.Drawing.Size(17, 20);
            this.numtext.TabIndex = 31;
            this.numtext.Text = "  ";
            // 
            // nametext
            // 
            this.nametext.AutoSize = true;
            this.nametext.Location = new System.Drawing.Point(314, 112);
            this.nametext.Name = "nametext";
            this.nametext.Size = new System.Drawing.Size(17, 20);
            this.nametext.TabIndex = 30;
            this.nametext.Text = "  ";
            // 
            // teltext
            // 
            this.teltext.AutoSize = true;
            this.teltext.Location = new System.Drawing.Point(314, 224);
            this.teltext.Name = "teltext";
            this.teltext.Size = new System.Drawing.Size(17, 20);
            this.teltext.TabIndex = 29;
            this.teltext.Text = "  ";
            // 
            // lookbtn
            // 
            this.lookbtn.BackColor = System.Drawing.Color.Transparent;
            this.lookbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.lookbtn.Enabled = false;
            this.lookbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lookbtn.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lookbtn.ForeColor = System.Drawing.Color.Green;
            this.lookbtn.Location = new System.Drawing.Point(490, 284);
            this.lookbtn.Name = "lookbtn";
            this.lookbtn.Size = new System.Drawing.Size(92, 34);
            this.lookbtn.TabIndex = 28;
            this.lookbtn.Text = "选择图片";
            this.lookbtn.UseVisualStyleBackColor = false;
            this.lookbtn.Click += new System.EventHandler(this.lookbtn_Click);
            // 
            // img
            // 
            this.img.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.img.Location = new System.Drawing.Point(388, 87);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(194, 181);
            this.img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img.TabIndex = 13;
            this.img.TabStop = false;
            // 
            // dept
            // 
            this.dept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dept.Enabled = false;
            this.dept.FormattingEnabled = true;
            this.dept.Location = new System.Drawing.Point(108, 316);
            this.dept.Name = "dept";
            this.dept.Size = new System.Drawing.Size(200, 28);
            this.dept.TabIndex = 12;
            // 
            // age
            // 
            this.age.Enabled = false;
            this.age.Location = new System.Drawing.Point(108, 164);
            this.age.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.age.Name = "age";
            this.age.ReadOnly = true;
            this.age.Size = new System.Drawing.Size(200, 26);
            this.age.TabIndex = 11;
            this.age.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // tel
            // 
            this.tel.Location = new System.Drawing.Point(108, 218);
            this.tel.Name = "tel";
            this.tel.ReadOnly = true;
            this.tel.Size = new System.Drawing.Size(200, 26);
            this.tel.TabIndex = 10;
            // 
            // createdate
            // 
            this.createdate.Enabled = false;
            this.createdate.Location = new System.Drawing.Point(108, 270);
            this.createdate.Name = "createdate";
            this.createdate.Size = new System.Drawing.Size(200, 26);
            this.createdate.TabIndex = 9;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(108, 109);
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Size = new System.Drawing.Size(200, 26);
            this.name.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(369, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "我的头像：";
            // 
            // num
            // 
            this.num.Location = new System.Drawing.Point(108, 53);
            this.num.Name = "num";
            this.num.ReadOnly = true;
            this.num.Size = new System.Drawing.Size(200, 26);
            this.num.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "所属部门：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "入职日期：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "联系方式：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "年龄：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "真实姓名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "员工号：";
            // 
            // alterbtn
            // 
            this.alterbtn.BackColor = System.Drawing.Color.Transparent;
            this.alterbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.alterbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alterbtn.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.alterbtn.ForeColor = System.Drawing.Color.Green;
            this.alterbtn.Location = new System.Drawing.Point(592, 44);
            this.alterbtn.Name = "alterbtn";
            this.alterbtn.Size = new System.Drawing.Size(87, 34);
            this.alterbtn.TabIndex = 27;
            this.alterbtn.Text = "编辑资料";
            this.alterbtn.UseVisualStyleBackColor = false;
            this.alterbtn.Click += new System.EventHandler(this.alterbtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.close.Location = new System.Drawing.Point(694, 1);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(30, 30);
            this.close.TabIndex = 28;
            this.close.Text = "×";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            this.close.MouseEnter += new System.EventHandler(this.close_MouseEnter);
            this.close.MouseLeave += new System.EventHandler(this.close_MouseLeave);
            // 
            // myInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::login.Properties.Resources.bg4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(723, 498);
            this.Controls.Add(this.close);
            this.Controls.Add(this.alterbtn);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "myInformation";
            this.Text = "myInformation";
            this.Load += new System.EventHandler(this.myInformation_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.myinfo_MouseDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.age)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button alterbtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox dept;
        private System.Windows.Forms.NumericUpDown age;
        private System.Windows.Forms.TextBox tel;
        private System.Windows.Forms.DateTimePicker createdate;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox num;
        private System.Windows.Forms.Button lookbtn;
        private System.Windows.Forms.PictureBox img;
        private System.Windows.Forms.Label teltext;
        private System.Windows.Forms.Label nametext;
        private System.Windows.Forms.Label numtext;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button close;
    }
}