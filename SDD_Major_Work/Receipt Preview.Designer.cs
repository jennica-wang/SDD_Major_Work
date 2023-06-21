namespace SDD_Major_Work
{
    partial class Receipt_Preview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receipt_Preview));
            this.label1 = new System.Windows.Forms.Label();
            this.LabelBorrowerName = new System.Windows.Forms.Label();
            this.LabelBorrowingDate = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.ButtonReturn = new System.Windows.Forms.Button();
            this.ButtonConfirm = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LabelDueDate = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.label1.Location = new System.Drawing.Point(219, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Receipt Details";
            // 
            // LabelBorrowerName
            // 
            this.LabelBorrowerName.AutoSize = true;
            this.LabelBorrowerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.LabelBorrowerName.Location = new System.Drawing.Point(121, 138);
            this.LabelBorrowerName.Name = "LabelBorrowerName";
            this.LabelBorrowerName.Size = new System.Drawing.Size(124, 20);
            this.LabelBorrowerName.TabIndex = 1;
            this.LabelBorrowerName.Text = "Borrower name";
            // 
            // LabelBorrowingDate
            // 
            this.LabelBorrowingDate.AutoSize = true;
            this.LabelBorrowingDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.LabelBorrowingDate.Location = new System.Drawing.Point(121, 161);
            this.LabelBorrowingDate.Name = "LabelBorrowingDate";
            this.LabelBorrowingDate.Size = new System.Drawing.Size(191, 20);
            this.LabelBorrowingDate.TabIndex = 2;
            this.LabelBorrowingDate.Text = "Borrowing date and time";
            // 
            // ButtonReturn
            // 
            this.ButtonReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.ButtonReturn.Location = new System.Drawing.Point(286, 296);
            this.ButtonReturn.Name = "ButtonReturn";
            this.ButtonReturn.Size = new System.Drawing.Size(145, 38);
            this.ButtonReturn.TabIndex = 9;
            this.ButtonReturn.Text = "Go back";
            this.ButtonReturn.UseVisualStyleBackColor = true;
            this.ButtonReturn.Click += new System.EventHandler(this.ButtonReturn_Click);
            // 
            // ButtonConfirm
            // 
            this.ButtonConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.ButtonConfirm.Location = new System.Drawing.Point(132, 296);
            this.ButtonConfirm.Name = "ButtonConfirm";
            this.ButtonConfirm.Size = new System.Drawing.Size(145, 38);
            this.ButtonConfirm.TabIndex = 7;
            this.ButtonConfirm.Text = "Borrow books";
            this.ButtonConfirm.UseVisualStyleBackColor = true;
            this.ButtonConfirm.Click += new System.EventHandler(this.ButtonConfirm_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.label7.Location = new System.Drawing.Point(128, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 20);
            this.label7.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(84, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(395, 209);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // LabelDueDate
            // 
            this.LabelDueDate.AutoSize = true;
            this.LabelDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.LabelDueDate.Location = new System.Drawing.Point(121, 202);
            this.LabelDueDate.Name = "LabelDueDate";
            this.LabelDueDate.Size = new System.Drawing.Size(77, 20);
            this.LabelDueDate.TabIndex = 3;
            this.LabelDueDate.Text = "Due date";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Receipt_Preview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 450);
            this.Controls.Add(this.ButtonReturn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ButtonConfirm);
            this.Controls.Add(this.LabelDueDate);
            this.Controls.Add(this.LabelBorrowingDate);
            this.Controls.Add(this.LabelBorrowerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Receipt_Preview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receipt Preview";
            this.Load += new System.EventHandler(this.Receipt_Preview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelBorrowerName;
        private System.Windows.Forms.Label LabelBorrowingDate;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button ButtonReturn;
        private System.Windows.Forms.Button ButtonConfirm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LabelDueDate;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}