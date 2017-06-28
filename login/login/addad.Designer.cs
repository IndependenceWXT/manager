namespace login
{
    partial class addad
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.addbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(66, 92);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(422, 138);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.Color.Transparent;
            this.addbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbtn.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.addbtn.ForeColor = System.Drawing.Color.Green;
            this.addbtn.Location = new System.Drawing.Point(351, 249);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(137, 29);
            this.addbtn.TabIndex = 13;
            this.addbtn.Text = "添加";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(219, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 27);
            this.label1.TabIndex = 14;
            this.label1.Text = "发 布 公 告";
            // 
            // addad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::login.Properties.Resources.bg7;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(547, 309);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "addad";
            this.Text = "添加公告";
            this.Load += new System.EventHandler(this.addad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Label label1;
    }
}