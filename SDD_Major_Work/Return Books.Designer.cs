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
            this.TextBoxISBN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonReturn = new System.Windows.Forms.Button();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.LabelBookName = new System.Windows.Forms.Label();
            this.LabelRecentReturn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextBoxISBN
            // 
            this.TextBoxISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.TextBoxISBN.Location = new System.Drawing.Point(46, 80);
            this.TextBoxISBN.Name = "TextBoxISBN";
            this.TextBoxISBN.Size = new System.Drawing.Size(138, 26);
            this.TextBoxISBN.TabIndex = 0;
            this.TextBoxISBN.TextChanged += new System.EventHandler(this.TextBoxISBN_TextChanged);
            this.TextBoxISBN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxISBN_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.label1.Location = new System.Drawing.Point(42, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Book ISBN";
            // 
            // ButtonReturn
            // 
            this.ButtonReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.ButtonReturn.Location = new System.Drawing.Point(46, 171);
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
            this.ButtonClose.Location = new System.Drawing.Point(194, 171);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(138, 44);
            this.ButtonClose.TabIndex = 3;
            this.ButtonClose.Text = "Close";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // LabelBookName
            // 
            this.LabelBookName.AutoSize = true;
            this.LabelBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.LabelBookName.Location = new System.Drawing.Point(42, 121);
            this.LabelBookName.Name = "LabelBookName";
            this.LabelBookName.Size = new System.Drawing.Size(98, 20);
            this.LabelBookName.TabIndex = 4;
            this.LabelBookName.Text = "Book name:";
            // 
            // LabelRecentReturn
            // 
            this.LabelRecentReturn.AutoSize = true;
            this.LabelRecentReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.LabelRecentReturn.Location = new System.Drawing.Point(43, 252);
            this.LabelRecentReturn.Name = "LabelRecentReturn";
            this.LabelRecentReturn.Size = new System.Drawing.Size(146, 20);
            this.LabelRecentReturn.TabIndex = 5;
            this.LabelRecentReturn.Text = "Recently returned:";
            this.LabelRecentReturn.Visible = false;
            // 
            // Return_Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 355);
            this.Controls.Add(this.LabelRecentReturn);
            this.Controls.Add(this.LabelBookName);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.ButtonReturn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxISBN);
            this.Name = "Return_Books";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Return_Books";
            this.Load += new System.EventHandler(this.Return_Books_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxISBN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonReturn;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Label LabelBookName;
        private System.Windows.Forms.Label LabelRecentReturn;
    }
}