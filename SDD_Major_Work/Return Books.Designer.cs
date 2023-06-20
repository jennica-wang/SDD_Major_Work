namespace SDD_Major_Work
{
    partial class Return_Books
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonReturn = new System.Windows.Forms.Button();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.LabelBookName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.textBox1.Location = new System.Drawing.Point(97, 111);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.label1.Location = new System.Drawing.Point(93, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter ISBN";
            // 
            // ButtonReturn
            // 
            this.ButtonReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.ButtonReturn.Location = new System.Drawing.Point(97, 202);
            this.ButtonReturn.Name = "ButtonReturn";
            this.ButtonReturn.Size = new System.Drawing.Size(138, 44);
            this.ButtonReturn.TabIndex = 2;
            this.ButtonReturn.Text = "Return book";
            this.ButtonReturn.UseVisualStyleBackColor = true;
            this.ButtonReturn.Click += new System.EventHandler(this.ButtonReturn_Click);
            // 
            // ButtonClose
            // 
            this.ButtonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.ButtonClose.Location = new System.Drawing.Point(245, 202);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(138, 44);
            this.ButtonClose.TabIndex = 3;
            this.ButtonClose.Text = "Close";
            this.ButtonClose.UseVisualStyleBackColor = true;
            // 
            // LabelBookName
            // 
            this.LabelBookName.AutoSize = true;
            this.LabelBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.LabelBookName.Location = new System.Drawing.Point(93, 152);
            this.LabelBookName.Name = "LabelBookName";
            this.LabelBookName.Size = new System.Drawing.Size(98, 20);
            this.LabelBookName.TabIndex = 4;
            this.LabelBookName.Text = "Book name:";
            // 
            // Return_Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 318);
            this.Controls.Add(this.LabelBookName);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.ButtonReturn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Return_Books";
            this.Text = "Return_Books";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonReturn;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Label LabelBookName;
    }
}