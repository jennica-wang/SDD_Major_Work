namespace SDD_Major_Work
{
    partial class Add_Book
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
            this.TextBoxISBN = new System.Windows.Forms.TextBox();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxGenre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxAuthor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.LabelRecentAdd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.label1.Location = new System.Drawing.Point(47, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ISBN";
            // 
            // TextBoxISBN
            // 
            this.TextBoxISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.TextBoxISBN.Location = new System.Drawing.Point(51, 63);
            this.TextBoxISBN.Name = "TextBoxISBN";
            this.TextBoxISBN.Size = new System.Drawing.Size(220, 26);
            this.TextBoxISBN.TabIndex = 5;
            this.TextBoxISBN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxISBN_KeyPress);
            // 
            // TextBoxName
            // 
            this.TextBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.TextBoxName.Location = new System.Drawing.Point(51, 141);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(220, 26);
            this.TextBoxName.TabIndex = 7;
            this.TextBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxName_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.label2.Location = new System.Drawing.Point(47, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Book name";
            // 
            // TextBoxGenre
            // 
            this.TextBoxGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.TextBoxGenre.Location = new System.Drawing.Point(331, 141);
            this.TextBoxGenre.Name = "TextBoxGenre";
            this.TextBoxGenre.Size = new System.Drawing.Size(220, 26);
            this.TextBoxGenre.TabIndex = 11;
            this.TextBoxGenre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxGenre_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.label3.Location = new System.Drawing.Point(327, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Author";
            // 
            // TextBoxAuthor
            // 
            this.TextBoxAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.TextBoxAuthor.Location = new System.Drawing.Point(331, 63);
            this.TextBoxAuthor.Name = "TextBoxAuthor";
            this.TextBoxAuthor.Size = new System.Drawing.Size(220, 26);
            this.TextBoxAuthor.TabIndex = 9;
            this.TextBoxAuthor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxAuthor_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.label4.Location = new System.Drawing.Point(327, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Genre";
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.ButtonAdd.Location = new System.Drawing.Point(51, 202);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(105, 43);
            this.ButtonAdd.TabIndex = 17;
            this.ButtonAdd.Text = "Add book";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonClose
            // 
            this.ButtonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.ButtonClose.Location = new System.Drawing.Point(163, 202);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(108, 43);
            this.ButtonClose.TabIndex = 18;
            this.ButtonClose.Text = "Close";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // LabelRecentAdd
            // 
            this.LabelRecentAdd.AutoSize = true;
            this.LabelRecentAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.LabelRecentAdd.Location = new System.Drawing.Point(47, 275);
            this.LabelRecentAdd.Name = "LabelRecentAdd";
            this.LabelRecentAdd.Size = new System.Drawing.Size(129, 20);
            this.LabelRecentAdd.TabIndex = 19;
            this.LabelRecentAdd.Text = "Recently added:";
            this.LabelRecentAdd.Visible = false;
            // 
            // Add_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 415);
            this.Controls.Add(this.LabelRecentAdd);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.TextBoxGenre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBoxAuthor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBoxISBN);
            this.Controls.Add(this.label1);
            this.Name = "Add_Book";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Book";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Add_Book_FormClosing);
            this.Load += new System.EventHandler(this.Add_Book_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxISBN;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxGenre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxAuthor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Label LabelRecentAdd;
    }
}