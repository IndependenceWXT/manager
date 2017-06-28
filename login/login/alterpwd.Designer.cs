namespace login
{
    partial class alterpwd
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
            this.pwd = new System.Windows.Forms.TextBox();
            this.againpwd = new System.Windows.Forms.TextBox();
            this.apwdtext = new System.Windows.Forms.Label();
            this.alterbtn = new System.Windows.Forms.Button();
            this.pwdtext = new System.Windows.Forms.Label();
            this.num = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.close.Location = new System.Drawing.Point(532, -1);
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
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(203, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "修 改 密 码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(116, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "新密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(100, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "确认密码：";
            // 
            // pwd
            // 
            this.pwd.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pwd.Location = new System.Drawing.Point(185, 115);
            this.pwd.Name = "pwd";
            this.pwd.PasswordChar = '*';
            this.pwd.Size = new System.Drawing.Size(160, 26);
            this.pwd.TabIndex = 16;
            // 
            // againpwd
            // 
            this.againpwd.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.againpwd.Location = new System.Drawing.Point(188, 155);
            this.againpwd.Name = "againpwd";
            this.againpwd.PasswordChar = '*';
            this.againpwd.Size = new System.Drawing.Size(157, 26);
            this.againpwd.TabIndex = 17;
            // 
            // apwdtext
            // 
            this.apwdtext.AutoSize = true;
            this.apwdtext.BackColor = System.Drawing.Color.Transparent;
            this.apwdtext.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.apwdtext.Location = new System.Drawing.Point(351, 155);
            this.apwdtext.Name = "apwdtext";
            this.apwdtext.Size = new System.Drawing.Size(17, 20);
            this.apwdtext.TabIndex = 18;
            this.apwdtext.Text = "  ";
            // 
            // alterbtn
            // 
            this.alterbtn.BackColor = System.Drawing.Color.Transparent;
            this.alterbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.alterbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alterbtn.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.alterbtn.ForeColor = System.Drawing.Color.Green;
            this.alterbtn.Location = new System.Drawing.Point(188, 202);
            this.alterbtn.Name = "alterbtn";
            this.alterbtn.Size = new System.Drawing.Size(126, 34);
            this.alterbtn.TabIndex = 28;
            this.alterbtn.Text = "提   交";
            this.alterbtn.UseVisualStyleBackColor = false;
            this.alterbtn.Click += new System.EventHandler(this.alterbtn_Click);
            // 
            // pwdtext
            // 
            this.pwdtext.AutoSize = true;
            this.pwdtext.BackColor = System.Drawing.Color.Transparent;
            this.pwdtext.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pwdtext.Location = new System.Drawing.Point(351, 116);
            this.pwdtext.Name = "pwdtext";
            this.pwdtext.Size = new System.Drawing.Size(17, 20);
            this.pwdtext.TabIndex = 29;
            this.pwdtext.Text = "  ";
            // 
            // num
            // 
            this.num.AutoSize = true;
            this.num.BackColor = System.Drawing.Color.Transparent;
            this.num.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.num.Location = new System.Drawing.Point(220, 265);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(20, 21);
            this.num.TabIndex = 31;
            this.num.Text = "  ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.button1.Location = new System.Drawing.Point(496, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 32;
            this.button1.Text = "×";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.close_Click);
            this.button1.MouseEnter += new System.EventHandler(this.close_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.close_MouseLeave);
            // 
            // alterpwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::login.Properties.Resources.bg4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(527, 264);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.num);
            this.Controls.Add(this.pwdtext);
            this.Controls.Add(this.alterbtn);
            this.Controls.Add(this.apwdtext);
            this.Controls.Add(this.againpwd);
            this.Controls.Add(this.pwd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "alterpwd";
            this.Text = "alterpwd";
            this.Load += new System.EventHandler(this.alterpwd_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.alterpwd_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pwd;
        private System.Windows.Forms.TextBox againpwd;
        private System.Windows.Forms.Label apwdtext;
        private System.Windows.Forms.Button alterbtn;
        private System.Windows.Forms.Label pwdtext;
        private System.Windows.Forms.Label num;
        private System.Windows.Forms.Button button1;
    }
}