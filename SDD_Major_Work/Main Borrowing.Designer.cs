namespace SDD_Major_Work
{
    partial class Main_Borrowing
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
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TextBoxBorrower = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxBook = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ButtonFinish = new System.Windows.Forms.Button();
            this.ListBoxBooks = new System.Windows.Forms.ListBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.ButtonChangeDate = new System.Windows.Forms.Button();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ButtonDeserialise = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.returnBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deserialiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxBorrower
            // 
            this.TextBoxBorrower.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.TextBoxBorrower.Location = new System.Drawing.Point(39, 59);
            this.TextBoxBorrower.Name = "TextBoxBorrower";
            this.TextBoxBorrower.Size = new System.Drawing.Size(180, 26);
            this.TextBoxBorrower.TabIndex = 0;
            this.TextBoxBorrower.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxBorrower_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.label1.Location = new System.Drawing.Point(40, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter borrower code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.label2.Location = new System.Drawing.Point(550, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Borrower name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.label3.Location = new System.Drawing.Point(550, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Borrower code:";
            // 
            // TextBoxBook
            // 
            this.TextBoxBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.TextBoxBook.Location = new System.Drawing.Point(39, 162);
            this.TextBoxBook.Name = "TextBoxBook";
            this.TextBoxBook.Size = new System.Drawing.Size(180, 26);
            this.TextBoxBook.TabIndex = 4;
            this.TextBoxBook.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxBook_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.label4.Location = new System.Drawing.Point(40, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Enter ISBN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.label6.Location = new System.Drawing.Point(40, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Books borrowed";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.label7.Location = new System.Drawing.Point(552, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Due date";
            // 
            // ButtonFinish
            // 
            this.ButtonFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.ButtonFinish.Location = new System.Drawing.Point(768, 571);
            this.ButtonFinish.Name = "ButtonFinish";
            this.ButtonFinish.Size = new System.Drawing.Size(243, 37);
            this.ButtonFinish.TabIndex = 9;
            this.ButtonFinish.Text = "Finalise borrowing ->";
            this.ButtonFinish.UseVisualStyleBackColor = true;
            this.ButtonFinish.Click += new System.EventHandler(this.ButtonFinish_Click);
            // 
            // ListBoxBooks
            // 
            this.ListBoxBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.ListBoxBooks.FormattingEnabled = true;
            this.ListBoxBooks.ItemHeight = 20;
            this.ListBoxBooks.Location = new System.Drawing.Point(39, 260);
            this.ListBoxBooks.Name = "ListBoxBooks";
            this.ListBoxBooks.Size = new System.Drawing.Size(678, 224);
            this.ListBoxBooks.TabIndex = 10;
            this.ListBoxBooks.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListBoxBooks_KeyDown);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // ButtonChangeDate
            // 
            this.ButtonChangeDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.ButtonChangeDate.Location = new System.Drawing.Point(459, 219);
            this.ButtonChangeDate.Name = "ButtonChangeDate";
            this.ButtonChangeDate.Size = new System.Drawing.Size(84, 31);
            this.ButtonChangeDate.TabIndex = 11;
            this.ButtonChangeDate.Text = "Change";
            this.ButtonChangeDate.UseVisualStyleBackColor = true;
            this.ButtonChangeDate.Click += new System.EventHandler(this.ButtonChangeDate_Click);
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Location = new System.Drawing.Point(460, 252);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(220, 20);
            this.DateTimePicker.TabIndex = 12;
            this.DateTimePicker.Visible = false;
            this.DateTimePicker.ValueChanged += new System.EventHandler(this.DateTimePicker_ValueChanged);
            this.DateTimePicker.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DateTimePicker_KeyPress);
            // 
            // ButtonDeserialise
            // 
            this.ButtonDeserialise.Location = new System.Drawing.Point(260, 33);
            this.ButtonDeserialise.Name = "ButtonDeserialise";
            this.ButtonDeserialise.Size = new System.Drawing.Size(94, 38);
            this.ButtonDeserialise.TabIndex = 13;
            this.ButtonDeserialise.Text = "deserialise";
            this.ButtonDeserialise.UseVisualStyleBackColor = true;
            this.ButtonDeserialise.Click += new System.EventHandler(this.ButtonDeserialise_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.returnBookToolStripMenuItem,
            this.deserialiseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1060, 26);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // returnBookToolStripMenuItem
            // 
            this.returnBookToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.returnBookToolStripMenuItem.Name = "returnBookToolStripMenuItem";
            this.returnBookToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.returnBookToolStripMenuItem.Text = "Return book";
            this.returnBookToolStripMenuItem.Click += new System.EventHandler(this.returnBookToolStripMenuItem_Click);
            // 
            // deserialiseToolStripMenuItem
            // 
            this.deserialiseToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.deserialiseToolStripMenuItem.Name = "deserialiseToolStripMenuItem";
            this.deserialiseToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.deserialiseToolStripMenuItem.Text = "Deserialise";
            this.deserialiseToolStripMenuItem.Click += new System.EventHandler(this.deserialiseToolStripMenuItem_Click);
            // 
            // Main_Borrowing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 642);
            this.Controls.Add(this.ButtonDeserialise);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.ButtonChangeDate);
            this.Controls.Add(this.ListBoxBooks);
            this.Controls.Add(this.ButtonFinish);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextBoxBook);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxBorrower);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main_Borrowing";
            this.Text = "Main Borrowing";
            this.Load += new System.EventHandler(this.Main_Borrowing_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxBorrower;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxBook;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ButtonFinish;
        private System.Windows.Forms.ListBox ListBoxBooks;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button ButtonChangeDate;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.Button ButtonDeserialise;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem returnBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deserialiseToolStripMenuItem;
    }
}

