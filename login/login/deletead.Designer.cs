namespace login
{
    partial class deletead
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
            this.label2 = new System.Windows.Forms.Label();
            this.count = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.alterbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(706, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "条记录";
            // 
            // count
            // 
            this.count.AutoSize = true;
            this.count.BackColor = System.Drawing.Color.Transparent;
            this.count.Location = new System.Drawing.Point(683, 126);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(17, 12);
            this.count.TabIndex = 8;
            this.count.Text = "  ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(61, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 100;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(686, 169);
            this.dataGridView1.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(328, 89);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(261, 29);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(220, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "选择日期：";
            // 
            // alterbtn
            // 
            this.alterbtn.BackColor = System.Drawing.Color.Transparent;
            this.alterbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.alterbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alterbtn.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.alterbtn.ForeColor = System.Drawing.Color.Green;
            this.alterbtn.Location = new System.Drawing.Point(660, 328);
            this.alterbtn.Name = "alterbtn";
            this.alterbtn.Size = new System.Drawing.Size(87, 34);
            this.alterbtn.TabIndex = 28;
            this.alterbtn.Text = "删除公告";
            this.alterbtn.UseVisualStyleBackColor = false;
            this.alterbtn.Click += new System.EventHandler(this.alterbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(339, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "管理员删除公告";
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.close.Location = new System.Drawing.Point(771, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(30, 30);
            this.close.TabIndex = 30;
            this.close.Text = "×";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            this.close.MouseEnter += new System.EventHandler(this.close_MouseEnter);
            this.close.MouseLeave += new System.EventHandler(this.close_MouseLeave);
            // 
            // deletead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::login.Properties.Resources.bg7;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(802, 374);
            this.Controls.Add(this.close);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.alterbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.count);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "deletead";
            this.Text = "deletead";
            this.Load += new System.EventHandler(this.deletead_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.deletead_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label count;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button alterbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button close;
    }
}