namespace login
{
    partial class alterdept
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deletebtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.label1.Location = new System.Drawing.Point(123, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "管理员对部门信息进行编辑（添加，修改，删除）";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 50;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(538, 173);
            this.dataGridView1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.deletebtn);
            this.groupBox1.Controls.Add(this.updatebtn);
            this.groupBox1.Controls.Add(this.addbtn);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(40, 275);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(541, 117);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "编辑";
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.Color.Transparent;
            this.deletebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletebtn.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.deletebtn.ForeColor = System.Drawing.Color.Green;
            this.deletebtn.Location = new System.Drawing.Point(449, 70);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(72, 34);
            this.deletebtn.TabIndex = 6;
            this.deletebtn.Text = "删除";
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.BackColor = System.Drawing.Color.Transparent;
            this.updatebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatebtn.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.updatebtn.ForeColor = System.Drawing.Color.Green;
            this.updatebtn.Location = new System.Drawing.Point(361, 72);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(67, 31);
            this.updatebtn.TabIndex = 5;
            this.updatebtn.Text = "更新";
            this.updatebtn.UseVisualStyleBackColor = false;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.Color.Transparent;
            this.addbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbtn.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.addbtn.ForeColor = System.Drawing.Color.Green;
            this.addbtn.Location = new System.Drawing.Point(278, 72);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(65, 30);
            this.addbtn.TabIndex = 4;
            this.addbtn.Text = "添加";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(104, 75);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(157, 26);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(157, 26);
            this.textBox1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "部门电话：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "部门名称：";
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.close.Location = new System.Drawing.Point(589, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(30, 30);
            this.close.TabIndex = 13;
            this.close.Text = "×";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            this.close.MouseEnter += new System.EventHandler(this.close_MouseEnter);
            this.close.MouseLeave += new System.EventHandler(this.close_MouseLeave);
            // 
            // alterdept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::login.Properties.Resources.bg7;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(619, 422);
            this.Controls.Add(this.close);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "alterdept";
            this.Text = "alterdept";
            this.Load += new System.EventHandler(this.alterdept_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.alterdept_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button close;
    }
}