namespace login
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.员工管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看员工信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.更改员工信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.签到管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.我要签到ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.我的考勤记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询考勤记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.部门管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.部门信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询部门ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改部门信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.个人信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.我的信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.datetime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dtime = new System.Windows.Forms.Label();
            this.yonghu = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.员工管理ToolStripMenuItem,
            this.签到管理ToolStripMenuItem,
            this.部门管理ToolStripMenuItem,
            this.个人信息ToolStripMenuItem,
            this.修改密码ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(723, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 员工管理ToolStripMenuItem
            // 
            this.员工管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看员工信息ToolStripMenuItem,
            this.更改员工信息ToolStripMenuItem});
            this.员工管理ToolStripMenuItem.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.员工管理ToolStripMenuItem.Name = "员工管理ToolStripMenuItem";
            this.员工管理ToolStripMenuItem.Size = new System.Drawing.Size(86, 25);
            this.员工管理ToolStripMenuItem.Text = "员工管理";
            // 
            // 查看员工信息ToolStripMenuItem
            // 
            this.查看员工信息ToolStripMenuItem.Name = "查看员工信息ToolStripMenuItem";
            this.查看员工信息ToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.查看员工信息ToolStripMenuItem.Text = "添删员工信息";
            this.查看员工信息ToolStripMenuItem.Click += new System.EventHandler(this.查看员工信息ToolStripMenuItem_Click);
            // 
            // 更改员工信息ToolStripMenuItem
            // 
            this.更改员工信息ToolStripMenuItem.Name = "更改员工信息ToolStripMenuItem";
            this.更改员工信息ToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.更改员工信息ToolStripMenuItem.Text = "编辑员工信息";
            this.更改员工信息ToolStripMenuItem.Click += new System.EventHandler(this.更改员工信息ToolStripMenuItem_Click);
            // 
            // 签到管理ToolStripMenuItem
            // 
            this.签到管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.我要签到ToolStripMenuItem,
            this.我的考勤记录ToolStripMenuItem,
            this.查询考勤记录ToolStripMenuItem});
            this.签到管理ToolStripMenuItem.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.签到管理ToolStripMenuItem.Name = "签到管理ToolStripMenuItem";
            this.签到管理ToolStripMenuItem.Size = new System.Drawing.Size(86, 25);
            this.签到管理ToolStripMenuItem.Text = "考勤管理";
            // 
            // 我要签到ToolStripMenuItem
            // 
            this.我要签到ToolStripMenuItem.Name = "我要签到ToolStripMenuItem";
            this.我要签到ToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.我要签到ToolStripMenuItem.Text = "我要签到";
            this.我要签到ToolStripMenuItem.Click += new System.EventHandler(this.我要签到ToolStripMenuItem_Click);
            // 
            // 我的考勤记录ToolStripMenuItem
            // 
            this.我的考勤记录ToolStripMenuItem.Name = "我的考勤记录ToolStripMenuItem";
            this.我的考勤记录ToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.我的考勤记录ToolStripMenuItem.Text = "我的考勤记录";
            this.我的考勤记录ToolStripMenuItem.Click += new System.EventHandler(this.我的考勤记录ToolStripMenuItem_Click);
            // 
            // 查询考勤记录ToolStripMenuItem
            // 
            this.查询考勤记录ToolStripMenuItem.Name = "查询考勤记录ToolStripMenuItem";
            this.查询考勤记录ToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.查询考勤记录ToolStripMenuItem.Text = "查询考勤记录";
            this.查询考勤记录ToolStripMenuItem.Click += new System.EventHandler(this.查询考勤记录ToolStripMenuItem_Click);
            // 
            // 部门管理ToolStripMenuItem
            // 
            this.部门管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.部门信息ToolStripMenuItem,
            this.查询部门ToolStripMenuItem,
            this.修改部门信息ToolStripMenuItem});
            this.部门管理ToolStripMenuItem.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.部门管理ToolStripMenuItem.Name = "部门管理ToolStripMenuItem";
            this.部门管理ToolStripMenuItem.Size = new System.Drawing.Size(86, 25);
            this.部门管理ToolStripMenuItem.Text = "部门管理";
            // 
            // 部门信息ToolStripMenuItem
            // 
            this.部门信息ToolStripMenuItem.Name = "部门信息ToolStripMenuItem";
            this.部门信息ToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.部门信息ToolStripMenuItem.Text = "部门信息";
            this.部门信息ToolStripMenuItem.Click += new System.EventHandler(this.部门信息ToolStripMenuItem_Click);
            // 
            // 查询部门ToolStripMenuItem
            // 
            this.查询部门ToolStripMenuItem.Name = "查询部门ToolStripMenuItem";
            this.查询部门ToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.查询部门ToolStripMenuItem.Text = "查询部门";
            this.查询部门ToolStripMenuItem.Click += new System.EventHandler(this.查询部门ToolStripMenuItem_Click);
            // 
            // 修改部门信息ToolStripMenuItem
            // 
            this.修改部门信息ToolStripMenuItem.Name = "修改部门信息ToolStripMenuItem";
            this.修改部门信息ToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.修改部门信息ToolStripMenuItem.Text = "修改部门信息";
            this.修改部门信息ToolStripMenuItem.Click += new System.EventHandler(this.修改部门信息ToolStripMenuItem_Click);
            // 
            // 个人信息ToolStripMenuItem
            // 
            this.个人信息ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.我的信息ToolStripMenuItem});
            this.个人信息ToolStripMenuItem.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.个人信息ToolStripMenuItem.Name = "个人信息ToolStripMenuItem";
            this.个人信息ToolStripMenuItem.Size = new System.Drawing.Size(86, 25);
            this.个人信息ToolStripMenuItem.Text = "个人信息";
            // 
            // 我的信息ToolStripMenuItem
            // 
            this.我的信息ToolStripMenuItem.Name = "我的信息ToolStripMenuItem";
            this.我的信息ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.我的信息ToolStripMenuItem.Text = "我的信息";
            this.我的信息ToolStripMenuItem.Click += new System.EventHandler(this.我的信息ToolStripMenuItem_Click);
            // 
            // 修改密码ToolStripMenuItem
            // 
            this.修改密码ToolStripMenuItem.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.修改密码ToolStripMenuItem.Name = "修改密码ToolStripMenuItem";
            this.修改密码ToolStripMenuItem.Size = new System.Drawing.Size(86, 25);
            this.修改密码ToolStripMenuItem.Text = "修改密码";
            this.修改密码ToolStripMenuItem.Click += new System.EventHandler(this.修改密码ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(220, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "欢迎使用公司人事管理系统";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(220, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "个人信息未补全，请补全个人信息";
            // 
            // datetime
            // 
            this.datetime.AutoSize = true;
            this.datetime.BackColor = System.Drawing.Color.Transparent;
            this.datetime.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.datetime.Location = new System.Drawing.Point(531, 42);
            this.datetime.Name = "datetime";
            this.datetime.Size = new System.Drawing.Size(20, 21);
            this.datetime.TabIndex = 3;
            this.datetime.Text = "  ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dtime
            // 
            this.dtime.AutoSize = true;
            this.dtime.BackColor = System.Drawing.Color.Transparent;
            this.dtime.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtime.Location = new System.Drawing.Point(518, 43);
            this.dtime.Name = "dtime";
            this.dtime.Size = new System.Drawing.Size(21, 20);
            this.dtime.TabIndex = 4;
            this.dtime.Text = "   ";
            // 
            // yonghu
            // 
            this.yonghu.AutoSize = true;
            this.yonghu.BackColor = System.Drawing.Color.Transparent;
            this.yonghu.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.yonghu.ForeColor = System.Drawing.Color.Green;
            this.yonghu.Location = new System.Drawing.Point(599, 4);
            this.yonghu.Name = "yonghu";
            this.yonghu.Size = new System.Drawing.Size(20, 21);
            this.yonghu.TabIndex = 5;
            this.yonghu.Text = "  ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(535, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "用户：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(681, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "退出";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(723, 404);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.yonghu);
            this.Controls.Add(this.dtime);
            this.Controls.Add(this.datetime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "公司人事管理系统";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 签到管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 部门管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 个人信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改密码ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem 我的信息ToolStripMenuItem;
        private System.Windows.Forms.Label datetime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label dtime;
        private System.Windows.Forms.Label yonghu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem 部门信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询部门ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改部门信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 我要签到ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 我的考勤记录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询考勤记录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 员工管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看员工信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 更改员工信息ToolStripMenuItem;
    }
}