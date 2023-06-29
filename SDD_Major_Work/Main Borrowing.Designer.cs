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
            this.ButtonFinish = new System.Windows.Forms.Button();
            this.ListBoxBooks = new System.Windows.Forms.ListBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.returnBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label7 = new System.Windows.Forms.Label();
            this.ButtonChangeDate = new System.Windows.Forms.Button();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.RadioButton3Days = new System.Windows.Forms.RadioButton();
            this.RadioButton1Week = new System.Windows.Forms.RadioButton();
            this.RadioButton2Weeks = new System.Windows.Forms.RadioButton();
            this.RadioButton4Weeks = new System.Windows.Forms.RadioButton();
            this.ButtonCustomDate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxBorrower
            // 
            this.TextBoxBorrower.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.TextBoxBorrower.Location = new System.Drawing.Point(41, 83);
            this.TextBoxBorrower.Name = "TextBoxBorrower";
            this.TextBoxBorrower.Size = new System.Drawing.Size(180, 26);
            this.TextBoxBorrower.TabIndex = 0;
            this.TextBoxBorrower.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxBorrower_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.label1.Location = new System.Drawing.Point(42, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Borrower code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.label2.Location = new System.Drawing.Point(552, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Borrower name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.label3.Location = new System.Drawing.Point(552, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Borrower code:";
            // 
            // TextBoxBook
            // 
            this.TextBoxBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.TextBoxBook.Location = new System.Drawing.Point(41, 187);
            this.TextBoxBook.Name = "TextBoxBook";
            this.TextBoxBook.Size = new System.Drawing.Size(180, 26);
            this.TextBoxBook.TabIndex = 4;
            this.TextBoxBook.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxBook_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.label4.Location = new System.Drawing.Point(42, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Book ISBN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.label6.Location = new System.Drawing.Point(42, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Books borrowed";
            // 
            // ButtonFinish
            // 
            this.ButtonFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.ButtonFinish.Location = new System.Drawing.Point(587, 517);
            this.ButtonFinish.Name = "ButtonFinish";
            this.ButtonFinish.Size = new System.Drawing.Size(180, 37);
            this.ButtonFinish.TabIndex = 9;
            this.ButtonFinish.Text = "Check out";
            this.ButtonFinish.UseVisualStyleBackColor = true;
            this.ButtonFinish.Click += new System.EventHandler(this.ButtonFinish_Click);
            // 
            // ListBoxBooks
            // 
            this.ListBoxBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.ListBoxBooks.FormattingEnabled = true;
            this.ListBoxBooks.ItemHeight = 20;
            this.ListBoxBooks.Location = new System.Drawing.Point(41, 278);
            this.ListBoxBooks.Name = "ListBoxBooks";
            this.ListBoxBooks.Size = new System.Drawing.Size(726, 224);
            this.ListBoxBooks.TabIndex = 10;
            this.ListBoxBooks.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListBoxBooks_KeyDown);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(16, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.returnBookToolStripMenuItem,
            this.addBookToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1060, 28);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // returnBookToolStripMenuItem
            // 
            this.returnBookToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.returnBookToolStripMenuItem.Name = "returnBookToolStripMenuItem";
            this.returnBookToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.returnBookToolStripMenuItem.Text = "Return book";
            this.returnBookToolStripMenuItem.Click += new System.EventHandler(this.returnBookToolStripMenuItem_Click);
            // 
            // addBookToolStripMenuItem
            // 
            this.addBookToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.addBookToolStripMenuItem.Name = "addBookToolStripMenuItem";
            this.addBookToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.addBookToolStripMenuItem.Text = "Add book";
            this.addBookToolStripMenuItem.Click += new System.EventHandler(this.addBookToolStripMenuItem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.label7.Location = new System.Drawing.Point(560, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Due date";
            // 
            // ButtonChangeDate
            // 
            this.ButtonChangeDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.ButtonChangeDate.Location = new System.Drawing.Point(420, 238);
            this.ButtonChangeDate.Name = "ButtonChangeDate";
            this.ButtonChangeDate.Size = new System.Drawing.Size(131, 35);
            this.ButtonChangeDate.TabIndex = 11;
            this.ButtonChangeDate.Text = "Change date";
            this.ButtonChangeDate.UseVisualStyleBackColor = true;
            this.ButtonChangeDate.Click += new System.EventHandler(this.ButtonChangeDate_Click);
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DateTimePicker.Location = new System.Drawing.Point(149, 42);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(245, 23);
            this.DateTimePicker.TabIndex = 12;
            this.DateTimePicker.Visible = false;
            this.DateTimePicker.ValueChanged += new System.EventHandler(this.DateTimePicker_ValueChanged);
            this.DateTimePicker.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DateTimePicker_KeyPress);
            // 
            // RadioButton3Days
            // 
            this.RadioButton3Days.AutoSize = true;
            this.RadioButton3Days.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.RadioButton3Days.Location = new System.Drawing.Point(11, 15);
            this.RadioButton3Days.Name = "RadioButton3Days";
            this.RadioButton3Days.Size = new System.Drawing.Size(65, 20);
            this.RadioButton3Days.TabIndex = 15;
            this.RadioButton3Days.TabStop = true;
            this.RadioButton3Days.Text = "3 days";
            this.RadioButton3Days.UseVisualStyleBackColor = true;
            this.RadioButton3Days.CheckedChanged += new System.EventHandler(this.RadioButton3Days_CheckedChanged);
            // 
            // RadioButton1Week
            // 
            this.RadioButton1Week.AutoSize = true;
            this.RadioButton1Week.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.RadioButton1Week.Location = new System.Drawing.Point(82, 15);
            this.RadioButton1Week.Name = "RadioButton1Week";
            this.RadioButton1Week.Size = new System.Drawing.Size(67, 20);
            this.RadioButton1Week.TabIndex = 16;
            this.RadioButton1Week.TabStop = true;
            this.RadioButton1Week.Text = "1 week";
            this.RadioButton1Week.UseVisualStyleBackColor = true;
            this.RadioButton1Week.CheckedChanged += new System.EventHandler(this.RadioButton1Week_CheckedChanged);
            // 
            // RadioButton2Weeks
            // 
            this.RadioButton2Weeks.AutoSize = true;
            this.RadioButton2Weeks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.RadioButton2Weeks.Location = new System.Drawing.Point(155, 15);
            this.RadioButton2Weeks.Name = "RadioButton2Weeks";
            this.RadioButton2Weeks.Size = new System.Drawing.Size(74, 20);
            this.RadioButton2Weeks.TabIndex = 17;
            this.RadioButton2Weeks.TabStop = true;
            this.RadioButton2Weeks.Text = "2 weeks";
            this.RadioButton2Weeks.UseVisualStyleBackColor = true;
            this.RadioButton2Weeks.CheckedChanged += new System.EventHandler(this.RadioButton2Weeks_CheckedChanged);
            // 
            // RadioButton4Weeks
            // 
            this.RadioButton4Weeks.AutoSize = true;
            this.RadioButton4Weeks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.RadioButton4Weeks.Location = new System.Drawing.Point(235, 15);
            this.RadioButton4Weeks.Name = "RadioButton4Weeks";
            this.RadioButton4Weeks.Size = new System.Drawing.Size(74, 20);
            this.RadioButton4Weeks.TabIndex = 18;
            this.RadioButton4Weeks.TabStop = true;
            this.RadioButton4Weeks.Text = "4 weeks";
            this.RadioButton4Weeks.UseVisualStyleBackColor = true;
            this.RadioButton4Weeks.CheckedChanged += new System.EventHandler(this.RadioButton4Weeks_CheckedChanged);
            // 
            // ButtonCustomDate
            // 
            this.ButtonCustomDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.ButtonCustomDate.Location = new System.Drawing.Point(315, 10);
            this.ButtonCustomDate.Name = "ButtonCustomDate";
            this.ButtonCustomDate.Size = new System.Drawing.Size(79, 32);
            this.ButtonCustomDate.TabIndex = 19;
            this.ButtonCustomDate.Text = "Custom";
            this.ButtonCustomDate.UseVisualStyleBackColor = true;
            this.ButtonCustomDate.Click += new System.EventHandler(this.ButtonCustomDate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.ButtonCustomDate);
            this.groupBox1.Controls.Add(this.RadioButton4Weeks);
            this.groupBox1.Controls.Add(this.RadioButton2Weeks);
            this.groupBox1.Controls.Add(this.RadioButton1Week);
            this.groupBox1.Controls.Add(this.RadioButton3Days);
            this.groupBox1.Controls.Add(this.DateTimePicker);
            this.groupBox1.Location = new System.Drawing.Point(420, 272);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 72);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // Main_Borrowing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 642);
            this.Controls.Add(this.groupBox1);
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_Borrowing_FormClosing);
            this.Load += new System.EventHandler(this.Main_Borrowing_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Button ButtonFinish;
        private System.Windows.Forms.ListBox ListBoxBooks;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem returnBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBookToolStripMenuItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ButtonChangeDate;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.RadioButton RadioButton3Days;
        private System.Windows.Forms.RadioButton RadioButton1Week;
        private System.Windows.Forms.RadioButton RadioButton2Weeks;
        private System.Windows.Forms.RadioButton RadioButton4Weeks;
        private System.Windows.Forms.Button ButtonCustomDate;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

