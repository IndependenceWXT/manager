namespace login
{
    partial class register
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
            this.close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.num = new System.Windows.Forms.TextBox();
            this.pwd = new System.Windows.Forms.TextBox();
            this.againpwd = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.check = new System.Windows.Forms.TextBox();
            this.img = new System.Windows.Forms.PictureBox();
            this.change = new System.Windows.Forms.Label();
            this.loginbtn = new System.Windows.Forms.Button();
            this.registerbtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.numtext = new System.Windows.Forms.Label();
            this.pwdtext = new System.Windows.Forms.Label();
            this.nametext = new System.Windows.Forms.Label();
            this.checktext = new System.Windows.Forms.Label();
            this.apwdtext = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.close.Location = new System.Drawing.Point(531, 2);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(30, 30);
            this.close.TabIndex = 12;
            this.close.Text = "×";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            this.close.MouseEnter += new System.EventHandler(this.close_MouseEnter);
            this.close.MouseLeave += new System.EventHandler(this.close_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(176, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 28);
            this.label1.TabIndex = 13;
            this.label1.Text = "注册信息";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(93, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "用户名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(109, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "密码：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(77, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 21);
            this.label4.TabIndex = 16;
            this.label4.Text = "确认密码：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(77, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 21);
            this.label5.TabIndex = 17;
            this.label5.Text = "真实姓名：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(93, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 21);
            this.label6.TabIndex = 18;
            this.label6.Text = "验证码：";
            // 
            // num
            // 
            this.num.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.num.Location = new System.Drawing.Point(170, 72);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(208, 26);
            this.num.TabIndex = 19;
            // 
            // pwd
            // 
            this.pwd.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pwd.Location = new System.Drawing.Point(170, 106);
            this.pwd.Name = "pwd";
            this.pwd.PasswordChar = '*';
            this.pwd.Size = new System.Drawing.Size(208, 26);
            this.pwd.TabIndex = 20;
            // 
            // againpwd
            // 
            this.againpwd.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.againpwd.Location = new System.Drawing.Point(173, 144);
            this.againpwd.Name = "againpwd";
            this.againpwd.PasswordChar = '*';
            this.againpwd.Size = new System.Drawing.Size(205, 26);
            this.againpwd.TabIndex = 21;
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.name.Location = new System.Drawing.Point(173, 179);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(205, 26);
            this.name.TabIndex = 22;
            // 
            // check
            // 
            this.check.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.check.Location = new System.Drawing.Point(173, 218);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(99, 26);
            this.check.TabIndex = 23;
            // 
            // img
            // 
            this.img.Location = new System.Drawing.Point(278, 218);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(100, 37);
            this.img.TabIndex = 24;
            this.img.TabStop = false;
            // 
            // change
            // 
            this.change.AutoSize = true;
            this.change.BackColor = System.Drawing.Color.Transparent;
            this.change.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.change.Location = new System.Drawing.Point(275, 268);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(92, 17);
            this.change.TabIndex = 25;
            this.change.Text = "看不清，换一张";
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // loginbtn
            // 
            this.loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginbtn.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.loginbtn.ForeColor = System.Drawing.Color.Green;
            this.loginbtn.Location = new System.Drawing.Point(270, 300);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(114, 34);
            this.loginbtn.TabIndex = 27;
            this.loginbtn.Text = "登录";
            this.loginbtn.UseVisualStyleBackColor = true;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // registerbtn
            // 
            this.registerbtn.BackColor = System.Drawing.Color.Transparent;
            this.registerbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.registerbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerbtn.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.registerbtn.ForeColor = System.Drawing.Color.Green;
            this.registerbtn.Location = new System.Drawing.Point(113, 300);
            this.registerbtn.Name = "registerbtn";
            this.registerbtn.Size = new System.Drawing.Size(119, 34);
            this.registerbtn.TabIndex = 26;
            this.registerbtn.Text = "注册";
            this.registerbtn.UseVisualStyleBackColor = false;
            this.registerbtn.Click += new System.EventHandler(this.registerbtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(384, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 20);
            this.label7.TabIndex = 28;
            // 
            // numtext
            // 
            this.numtext.AutoSize = true;
            this.numtext.BackColor = System.Drawing.Color.Transparent;
            this.numtext.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numtext.Location = new System.Drawing.Point(384, 72);
            this.numtext.Name = "numtext";
            this.numtext.Size = new System.Drawing.Size(13, 20);
            this.numtext.TabIndex = 29;
            this.numtext.Text = " ";
            // 
            // pwdtext
            // 
            this.pwdtext.AutoSize = true;
            this.pwdtext.BackColor = System.Drawing.Color.Transparent;
            this.pwdtext.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pwdtext.Location = new System.Drawing.Point(384, 109);
            this.pwdtext.Name = "pwdtext";
            this.pwdtext.Size = new System.Drawing.Size(13, 20);
            this.pwdtext.TabIndex = 30;
            this.pwdtext.Text = " ";
            // 
            // nametext
            // 
            this.nametext.AutoSize = true;
            this.nametext.BackColor = System.Drawing.Color.Transparent;
            this.nametext.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nametext.Location = new System.Drawing.Point(384, 186);
            this.nametext.Name = "nametext";
            this.nametext.Size = new System.Drawing.Size(13, 20);
            this.nametext.TabIndex = 31;
            this.nametext.Text = " ";
            // 
            // checktext
            // 
            this.checktext.AutoSize = true;
            this.checktext.BackColor = System.Drawing.Color.Transparent;
            this.checktext.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checktext.Location = new System.Drawing.Point(384, 224);
            this.checktext.Name = "checktext";
            this.checktext.Size = new System.Drawing.Size(17, 20);
            this.checktext.TabIndex = 32;
            this.checktext.Text = "  ";
            // 
            // apwdtext
            // 
            this.apwdtext.AutoSize = true;
            this.apwdtext.BackColor = System.Drawing.Color.Transparent;
            this.apwdtext.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.apwdtext.Location = new System.Drawing.Point(384, 149);
            this.apwdtext.Name = "apwdtext";
            this.apwdtext.Size = new System.Drawing.Size(13, 20);
            this.apwdtext.TabIndex = 33;
            this.apwdtext.Text = " ";
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::login.Properties.Resources.bg2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(558, 349);
            this.Controls.Add(this.apwdtext);
            this.Controls.Add(this.checktext);
            this.Controls.Add(this.nametext);
            this.Controls.Add(this.pwdtext);
            this.Controls.Add(this.numtext);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.registerbtn);
            this.Controls.Add(this.change);
            this.Controls.Add(this.img);
            this.Controls.Add(this.check);
            this.Controls.Add(this.name);
            this.Controls.Add(this.againpwd);
            this.Controls.Add(this.pwd);
            this.Controls.Add(this.num);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "register";
            this.Text = "register";
            this.Load += new System.EventHandler(this.register_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.register_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox num;
        private System.Windows.Forms.TextBox pwd;
        private System.Windows.Forms.TextBox againpwd;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox check;
        private System.Windows.Forms.PictureBox img;
        private System.Windows.Forms.Label change;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Button registerbtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label numtext;
        private System.Windows.Forms.Label pwdtext;
        private System.Windows.Forms.Label nametext;
        private System.Windows.Forms.Label checktext;
        private System.Windows.Forms.Label apwdtext;
    }
}