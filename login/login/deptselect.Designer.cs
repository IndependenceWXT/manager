namespace login
{
    partial class deptselect
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lastpage = new System.Windows.Forms.Label();
            this.allpage = new System.Windows.Forms.Label();
            this.nextpage = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.prevpage = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.firstpage = new System.Windows.Forms.Label();
            this.currentpage = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.allcount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(93, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "选择部门查询部门人员：";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(285, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(270, 29);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(47, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 50;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(584, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lastpage);
            this.groupBox1.Controls.Add(this.allpage);
            this.groupBox1.Controls.Add(this.nextpage);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.prevpage);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.firstpage);
            this.groupBox1.Controls.Add(this.currentpage);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(47, 270);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(584, 46);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "共";
            // 
            // lastpage
            // 
            this.lastpage.AutoSize = true;
            this.lastpage.Location = new System.Drawing.Point(510, 19);
            this.lastpage.Name = "lastpage";
            this.lastpage.Size = new System.Drawing.Size(56, 17);
            this.lastpage.TabIndex = 14;
            this.lastpage.Text = "最后一页";
            this.lastpage.Click += new System.EventHandler(this.lastpage_Click);
            // 
            // allpage
            // 
            this.allpage.AutoSize = true;
            this.allpage.ForeColor = System.Drawing.Color.Green;
            this.allpage.Location = new System.Drawing.Point(32, 17);
            this.allpage.Name = "allpage";
            this.allpage.Size = new System.Drawing.Size(32, 17);
            this.allpage.TabIndex = 6;
            this.allpage.Text = "      ";
            // 
            // nextpage
            // 
            this.nextpage.AutoSize = true;
            this.nextpage.Location = new System.Drawing.Point(448, 19);
            this.nextpage.Name = "nextpage";
            this.nextpage.Size = new System.Drawing.Size(44, 17);
            this.nextpage.TabIndex = 13;
            this.nextpage.Text = "下一页";
            this.nextpage.Click += new System.EventHandler(this.nextpage_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "页";
            // 
            // prevpage
            // 
            this.prevpage.AutoSize = true;
            this.prevpage.Location = new System.Drawing.Point(389, 19);
            this.prevpage.Name = "prevpage";
            this.prevpage.Size = new System.Drawing.Size(44, 17);
            this.prevpage.TabIndex = 12;
            this.prevpage.Text = "上一页";
            this.prevpage.Click += new System.EventHandler(this.prevpage_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "当前";
            // 
            // firstpage
            // 
            this.firstpage.AutoSize = true;
            this.firstpage.Location = new System.Drawing.Point(330, 19);
            this.firstpage.Name = "firstpage";
            this.firstpage.Size = new System.Drawing.Size(44, 17);
            this.firstpage.TabIndex = 11;
            this.firstpage.Text = "第一页";
            this.firstpage.Click += new System.EventHandler(this.firstpage_Click);
            // 
            // currentpage
            // 
            this.currentpage.AutoSize = true;
            this.currentpage.ForeColor = System.Drawing.Color.Green;
            this.currentpage.Location = new System.Drawing.Point(120, 17);
            this.currentpage.Name = "currentpage";
            this.currentpage.Size = new System.Drawing.Size(24, 17);
            this.currentpage.TabIndex = 9;
            this.currentpage.Text = "    ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(150, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "页";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(556, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "共";
            // 
            // allcount
            // 
            this.allcount.AutoSize = true;
            this.allcount.BackColor = System.Drawing.Color.Transparent;
            this.allcount.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.allcount.Location = new System.Drawing.Point(585, 91);
            this.allcount.Name = "allcount";
            this.allcount.Size = new System.Drawing.Size(17, 20);
            this.allcount.TabIndex = 18;
            this.allcount.Text = "  ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(608, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "人";
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.close.Location = new System.Drawing.Point(646, 1);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(30, 30);
            this.close.TabIndex = 20;
            this.close.Text = "×";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            this.close.MouseEnter += new System.EventHandler(this.close_MouseEnter);
            this.close.MouseLeave += new System.EventHandler(this.close_MouseLeave);
            // 
            // deptselect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::login.Properties.Resources.bg7;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(677, 339);
            this.Controls.Add(this.close);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.allcount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "deptselect";
            this.Text = "查询部门";
            this.Load += new System.EventHandler(this.deptselect_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.deptselect_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lastpage;
        private System.Windows.Forms.Label allpage;
        private System.Windows.Forms.Label nextpage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label prevpage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label firstpage;
        private System.Windows.Forms.Label currentpage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label allcount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button close;
    }
}