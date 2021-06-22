namespace Final_Project
{
    partial class Form1
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
            this.promptLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bookPublisherTextBox = new System.Windows.Forms.TextBox();
            this.bookEditionTextBox = new System.Windows.Forms.TextBox();
            this.bookAuthorTextBox = new System.Windows.Forms.TextBox();
            this.bookTitleTextBox = new System.Windows.Forms.TextBox();
            this.dateReturnedTextBox = new System.Windows.Forms.TextBox();
            this.dateLentTextBox = new System.Windows.Forms.TextBox();
            this.studentBorrowerTextBox = new System.Windows.Forms.TextBox();
            this.studentIdTextBox = new System.Windows.Forms.TextBox();
            this.bookPublisherLabel = new System.Windows.Forms.Label();
            this.bookEditionLabel = new System.Windows.Forms.Label();
            this.bookAuthorLabel = new System.Windows.Forms.Label();
            this.bookTitleLabel = new System.Windows.Forms.Label();
            this.dateReturnedLabel = new System.Windows.Forms.Label();
            this.dateLentLabel = new System.Windows.Forms.Label();
            this.studentBorrowerLabel = new System.Windows.Forms.Label();
            this.studentIdLabel = new System.Windows.Forms.Label();
            this.enterButton = new System.Windows.Forms.Button();
            this.refreshListButton = new System.Windows.Forms.Button();
            this.grid1 = new System.Windows.Forms.DataGridView();
            this.deleteButton = new System.Windows.Forms.Button();
            this.filterButton = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).BeginInit();
            this.SuspendLayout();
            // 
            // promptLabel
            // 
            this.promptLabel.AutoSize = true;
            this.promptLabel.Location = new System.Drawing.Point(222, 9);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(120, 13);
            this.promptLabel.TabIndex = 0;
            this.promptLabel.Text = "Enter information below:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bookPublisherTextBox);
            this.groupBox1.Controls.Add(this.bookEditionTextBox);
            this.groupBox1.Controls.Add(this.bookAuthorTextBox);
            this.groupBox1.Controls.Add(this.bookTitleTextBox);
            this.groupBox1.Controls.Add(this.dateReturnedTextBox);
            this.groupBox1.Controls.Add(this.dateLentTextBox);
            this.groupBox1.Controls.Add(this.studentBorrowerTextBox);
            this.groupBox1.Controls.Add(this.studentIdTextBox);
            this.groupBox1.Controls.Add(this.bookPublisherLabel);
            this.groupBox1.Controls.Add(this.bookEditionLabel);
            this.groupBox1.Controls.Add(this.bookAuthorLabel);
            this.groupBox1.Controls.Add(this.bookTitleLabel);
            this.groupBox1.Controls.Add(this.dateReturnedLabel);
            this.groupBox1.Controls.Add(this.dateLentLabel);
            this.groupBox1.Controls.Add(this.studentBorrowerLabel);
            this.groupBox1.Controls.Add(this.studentIdLabel);
            this.groupBox1.Location = new System.Drawing.Point(38, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 362);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Information:";
            // 
            // bookPublisherTextBox
            // 
            this.bookPublisherTextBox.Location = new System.Drawing.Point(153, 306);
            this.bookPublisherTextBox.Name = "bookPublisherTextBox";
            this.bookPublisherTextBox.Size = new System.Drawing.Size(177, 20);
            this.bookPublisherTextBox.TabIndex = 15;
            // 
            // bookEditionTextBox
            // 
            this.bookEditionTextBox.Location = new System.Drawing.Point(153, 271);
            this.bookEditionTextBox.Name = "bookEditionTextBox";
            this.bookEditionTextBox.Size = new System.Drawing.Size(177, 20);
            this.bookEditionTextBox.TabIndex = 14;
            // 
            // bookAuthorTextBox
            // 
            this.bookAuthorTextBox.Location = new System.Drawing.Point(153, 230);
            this.bookAuthorTextBox.Name = "bookAuthorTextBox";
            this.bookAuthorTextBox.Size = new System.Drawing.Size(177, 20);
            this.bookAuthorTextBox.TabIndex = 13;
            // 
            // bookTitleTextBox
            // 
            this.bookTitleTextBox.Location = new System.Drawing.Point(153, 195);
            this.bookTitleTextBox.Name = "bookTitleTextBox";
            this.bookTitleTextBox.Size = new System.Drawing.Size(177, 20);
            this.bookTitleTextBox.TabIndex = 12;
            // 
            // dateReturnedTextBox
            // 
            this.dateReturnedTextBox.Location = new System.Drawing.Point(153, 159);
            this.dateReturnedTextBox.Name = "dateReturnedTextBox";
            this.dateReturnedTextBox.Size = new System.Drawing.Size(177, 20);
            this.dateReturnedTextBox.TabIndex = 11;
            // 
            // dateLentTextBox
            // 
            this.dateLentTextBox.Location = new System.Drawing.Point(153, 115);
            this.dateLentTextBox.Name = "dateLentTextBox";
            this.dateLentTextBox.Size = new System.Drawing.Size(177, 20);
            this.dateLentTextBox.TabIndex = 10;
            // 
            // studentBorrowerTextBox
            // 
            this.studentBorrowerTextBox.Location = new System.Drawing.Point(153, 74);
            this.studentBorrowerTextBox.Name = "studentBorrowerTextBox";
            this.studentBorrowerTextBox.Size = new System.Drawing.Size(177, 20);
            this.studentBorrowerTextBox.TabIndex = 9;
            // 
            // studentIdTextBox
            // 
            this.studentIdTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.studentIdTextBox.Location = new System.Drawing.Point(153, 33);
            this.studentIdTextBox.Name = "studentIdTextBox";
            this.studentIdTextBox.Size = new System.Drawing.Size(177, 20);
            this.studentIdTextBox.TabIndex = 8;
            // 
            // bookPublisherLabel
            // 
            this.bookPublisherLabel.AutoSize = true;
            this.bookPublisherLabel.Location = new System.Drawing.Point(6, 306);
            this.bookPublisherLabel.Name = "bookPublisherLabel";
            this.bookPublisherLabel.Size = new System.Drawing.Size(81, 13);
            this.bookPublisherLabel.TabIndex = 7;
            this.bookPublisherLabel.Text = "Book Publisher:";
            // 
            // bookEditionLabel
            // 
            this.bookEditionLabel.AutoSize = true;
            this.bookEditionLabel.Location = new System.Drawing.Point(6, 271);
            this.bookEditionLabel.Name = "bookEditionLabel";
            this.bookEditionLabel.Size = new System.Drawing.Size(70, 13);
            this.bookEditionLabel.TabIndex = 6;
            this.bookEditionLabel.Text = "Book Edition:";
            // 
            // bookAuthorLabel
            // 
            this.bookAuthorLabel.AutoSize = true;
            this.bookAuthorLabel.Location = new System.Drawing.Point(6, 230);
            this.bookAuthorLabel.Name = "bookAuthorLabel";
            this.bookAuthorLabel.Size = new System.Drawing.Size(69, 13);
            this.bookAuthorLabel.TabIndex = 5;
            this.bookAuthorLabel.Text = "Book Author:";
            // 
            // bookTitleLabel
            // 
            this.bookTitleLabel.AutoSize = true;
            this.bookTitleLabel.Location = new System.Drawing.Point(6, 195);
            this.bookTitleLabel.Name = "bookTitleLabel";
            this.bookTitleLabel.Size = new System.Drawing.Size(58, 13);
            this.bookTitleLabel.TabIndex = 4;
            this.bookTitleLabel.Text = "Book Title:";
            // 
            // dateReturnedLabel
            // 
            this.dateReturnedLabel.AutoSize = true;
            this.dateReturnedLabel.Location = new System.Drawing.Point(6, 159);
            this.dateReturnedLabel.Name = "dateReturnedLabel";
            this.dateReturnedLabel.Size = new System.Drawing.Size(80, 13);
            this.dateReturnedLabel.TabIndex = 3;
            this.dateReturnedLabel.Text = "Date Returned:";
            // 
            // dateLentLabel
            // 
            this.dateLentLabel.AutoSize = true;
            this.dateLentLabel.Location = new System.Drawing.Point(6, 115);
            this.dateLentLabel.Name = "dateLentLabel";
            this.dateLentLabel.Size = new System.Drawing.Size(57, 13);
            this.dateLentLabel.TabIndex = 2;
            this.dateLentLabel.Text = "Date Lent:";
            // 
            // studentBorrowerLabel
            // 
            this.studentBorrowerLabel.AutoSize = true;
            this.studentBorrowerLabel.Location = new System.Drawing.Point(6, 74);
            this.studentBorrowerLabel.Name = "studentBorrowerLabel";
            this.studentBorrowerLabel.Size = new System.Drawing.Size(92, 13);
            this.studentBorrowerLabel.TabIndex = 1;
            this.studentBorrowerLabel.Text = "Student Borrower:";
            // 
            // studentIdLabel
            // 
            this.studentIdLabel.AutoSize = true;
            this.studentIdLabel.Location = new System.Drawing.Point(6, 33);
            this.studentIdLabel.Name = "studentIdLabel";
            this.studentIdLabel.Size = new System.Drawing.Size(61, 13);
            this.studentIdLabel.TabIndex = 0;
            this.studentIdLabel.Text = "Student ID:";
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(243, 409);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(75, 23);
            this.enterButton.TabIndex = 2;
            this.enterButton.Text = "Enter Data";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click_1);
            // 
            // refreshListButton
            // 
            this.refreshListButton.Location = new System.Drawing.Point(928, 409);
            this.refreshListButton.Name = "refreshListButton";
            this.refreshListButton.Size = new System.Drawing.Size(130, 23);
            this.refreshListButton.TabIndex = 4;
            this.refreshListButton.Text = "Refresh Database";
            this.refreshListButton.UseVisualStyleBackColor = true;
            this.refreshListButton.Click += new System.EventHandler(this.refreshListButton_Click_1);
            // 
            // grid1
            // 
            this.grid1.AllowUserToAddRows = false;
            this.grid1.AllowUserToDeleteRows = false;
            this.grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid1.Location = new System.Drawing.Point(433, 41);
            this.grid1.Name = "grid1";
            this.grid1.ReadOnly = true;
            this.grid1.Size = new System.Drawing.Size(840, 362);
            this.grid1.TabIndex = 5;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(191, 467);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(163, 23);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Delete Entry By Student ID";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(523, 409);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(220, 23);
            this.filterButton.TabIndex = 7;
            this.filterButton.Text = "Filter Data To Show Missing Book Returns";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(799, 409);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(75, 23);
            this.printButton.TabIndex = 8;
            this.printButton.Text = "Print";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(1169, 9);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(75, 23);
            this.helpButton.TabIndex = 9;
            this.helpButton.Text = "Help";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(191, 438);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(163, 23);
            this.updateButton.TabIndex = 10;
            this.updateButton.Text = "Update Entry By Student ID";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1290, 522);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.grid1);
            this.Controls.Add(this.refreshListButton);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.promptLabel);
            this.Name = "Form1";
            this.Text = "CCIT Library";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label promptLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label dateReturnedLabel;
        private System.Windows.Forms.Label dateLentLabel;
        private System.Windows.Forms.Label studentBorrowerLabel;
        private System.Windows.Forms.Label studentIdLabel;
        private System.Windows.Forms.TextBox bookPublisherTextBox;
        private System.Windows.Forms.TextBox bookEditionTextBox;
        private System.Windows.Forms.TextBox bookAuthorTextBox;
        private System.Windows.Forms.TextBox bookTitleTextBox;
        private System.Windows.Forms.TextBox dateReturnedTextBox;
        private System.Windows.Forms.TextBox dateLentTextBox;
        private System.Windows.Forms.TextBox studentBorrowerTextBox;
        private System.Windows.Forms.TextBox studentIdTextBox;
        private System.Windows.Forms.Label bookPublisherLabel;
        private System.Windows.Forms.Label bookEditionLabel;
        private System.Windows.Forms.Label bookAuthorLabel;
        private System.Windows.Forms.Label bookTitleLabel;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Button refreshListButton;
        private System.Windows.Forms.DataGridView grid1;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button filterButton;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Button updateButton;
    }
}

