using Final_Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Final_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Load with current database on start of application
            SQLiteConnection myconnection = new SQLiteConnection("Data Source=.\\Database.db;Version=3;");
            myconnection.Open();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = myconnection;
            cmd.CommandText = "Select * from CCIT_Library";
            using (SQLiteDataReader sdr = cmd.ExecuteReader())
            {
                // Create a new DataTable.
                DataTable dt = new DataTable();
                // Load DataReader into the DataTable.
                dt.Load(sdr);
                sdr.Close();
                myconnection.Close();
                grid1.DataSource = dt;
            }
        }

        // Assigns a person from the user's input
        private void enterButton_Click_1(object sender, EventArgs e)
        {
            PersonModel p = new PersonModel();

            p.StudentId = studentIdTextBox.Text;
            p.StudentBorrower = studentBorrowerTextBox.Text;
            p.DateLent = dateLentTextBox.Text;
            p.DateReturned = dateReturnedTextBox.Text;
            p.BookTitle = bookTitleTextBox.Text;
            p.BookAuthor = bookAuthorTextBox.Text;
            p.BookEdition = bookEditionTextBox.Text;
            p.BookPublisher = bookPublisherTextBox.Text;

            // Saves into database
            SqliteDataAccess.SavePerson(p);  

            // Clears textboxes 
            studentIdTextBox.Text = "";
            studentBorrowerTextBox.Text = "";
            dateLentTextBox.Text = "";
            dateReturnedTextBox.Text = "";
            bookTitleTextBox.Text = "";
            bookAuthorTextBox.Text = "";
            bookEditionTextBox.Text = "";
            bookPublisherTextBox.Text = "";

            // Auto refresh database 
            SQLiteConnection myconnection = new SQLiteConnection("Data Source=.\\Database.db;Version=3;");
            myconnection.Open();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = myconnection;
            cmd.CommandText = "Select * from CCIT_Library";
            using (SQLiteDataReader sdr = cmd.ExecuteReader())
            { 
                // Create a new DataTable.
                DataTable dt = new DataTable();
                // Load DataReader into the DataTable.
                dt.Load(sdr);
                sdr.Close();
                myconnection.Close();
                grid1.DataSource = dt;
            }
        }

        // Refresh datagridview
        private void refreshListButton_Click_1(object sender, EventArgs e)
        {
            SQLiteConnection myconnection = new SQLiteConnection("Data Source=.\\Database.db;Version=3;");
            myconnection.Open();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = myconnection;
            cmd.CommandText = "Select * from CCIT_Library";
            using (SQLiteDataReader sdr = cmd.ExecuteReader())
            {
                // Create a new DataTable.
                DataTable dt = new DataTable();
                // Load DataReader into the DataTable.
                dt.Load(sdr);
                sdr.Close();
                myconnection.Close();
                MessageBox.Show("Database has been refreshed.");
                grid1.DataSource = dt;
            }
        }

        // Delete database entry by specified student id
        private void deleteButton_Click(object sender, EventArgs e)
        {
            // Delete database entry by specified student id
            SQLiteConnection myconnection = new SQLiteConnection("Data Source=.\\Database.db;Version=3;");
            myconnection.Open();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = myconnection;
            cmd.CommandText = "Delete from CCIT_Library where Student_id='" + this.studentIdTextBox.Text + "'  ;";
            using (SQLiteDataReader sdr = cmd.ExecuteReader())
            {
                // Create a new DataTable.
                DataTable dt = new DataTable();
                // Load DataReader into the DataTable.
                dt.Load(sdr);
                sdr.Close();
                myconnection.Close();
                MessageBox.Show("Student ID " + "'" + this.studentIdTextBox.Text + "'" + " has been deleted.");
                grid1.DataSource = dt;
            }

            // Auto refresh after deletion
            SQLiteConnection myconnection1 = new SQLiteConnection("Data Source=.\\Database.db;Version=3;");
            myconnection.Open();
            SQLiteCommand cmd1 = new SQLiteCommand();
            cmd.Connection = myconnection;
            cmd.CommandText = "Select * from CCIT_Library";
            using (SQLiteDataReader sdr = cmd.ExecuteReader())
            {
                // Create a new DataTable.
                DataTable dt = new DataTable();
                // Load DataReader into the DataTable.
                dt.Load(sdr);
                sdr.Close();
                myconnection.Close();
                grid1.DataSource = dt;
            }
            // Auto clear textbox after deletion
            studentIdTextBox.Text = "";
        }

        // Filter datagridview to show missing books
        private void filterButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Database has been filtered to show missing books.");
            ((DataTable)grid1.DataSource).DefaultView.RowFilter = "Date_Returned = ' '";
        }

        // Calls print event to print out to conected printer automatically 
        private void printButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Automatically printing current view of database too connected printer.");
            printDocument1.Print();
        }

        // Prints current display of datagridview 
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.grid1.Width, this.grid1.Height);
            grid1.DrawToBitmap(bm, new Rectangle(0, 0, this.grid1.Width, this.grid1.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        // Show help menu to user
        private void helpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. Add student information by filling out the textboxs and clicking 'Enter Data'" + "\n" + "\n" + "2. Delete student information by entering the specific student ID and then click 'Delete Entry By Student ID'" + "\n" + "\n" + "3. Filter the data to show missing books by clicking 'Filter Data To Show Missing Book Returns'" + "\n" + "\n" + "4. Refresh the data table by clicking 'Refresh Database'" + "\n" + "\n" + "5. The 'Print' button will automatically print out the current view of the data to your connected printer");
        }


        // Update database entry by specified student id
        private void updateButton_Click(object sender, EventArgs e)
        {
            SQLiteConnection myconnection = new SQLiteConnection("Data Source=.\\Database.db;Version=3;");
            myconnection.Open();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = myconnection;
            cmd.CommandText = "update CCIT_Library set Student_id='" + this.studentIdTextBox.Text +  "', Student_Borrower='" + this.studentBorrowerTextBox.Text + "',Date_Lent='" + this.dateLentTextBox.Text + "', Date_Returned='" + this.dateReturnedTextBox.Text + "',Book_Title='" + this.bookTitleTextBox.Text + "',Book_Author='" + this.bookAuthorTextBox.Text + "', Book_Edition='" + this.bookEditionTextBox.Text + "',Book_Publisher='" + this.bookPublisherTextBox.Text + "' where Student_id='" + this.studentIdTextBox.Text + "'   ;";
            using (SQLiteDataReader sdr = cmd.ExecuteReader())
            {
                // Create a new DataTable.
                DataTable dt = new DataTable();
                // Load DataReader into the DataTable.
                dt.Load(sdr);
                sdr.Close();
                myconnection.Close();
                MessageBox.Show("Student ID " + "'" + this.studentIdTextBox.Text + "'" + " was updated.");
                grid1.DataSource = dt;           
            }

            // Auto refresh after update
            SQLiteConnection myconnection1 = new SQLiteConnection("Data Source=.\\Database.db;Version=3;");
            myconnection.Open();
            SQLiteCommand cmd1 = new SQLiteCommand();
            cmd.Connection = myconnection;
            cmd.CommandText = "Select * from CCIT_Library";
            using (SQLiteDataReader sdr = cmd.ExecuteReader())
            {
                // Create a new DataTable.
                DataTable dt = new DataTable();
                // Load DataReader into the DataTable.
                dt.Load(sdr);
                sdr.Close();
                myconnection.Close();
                grid1.DataSource = dt;
            }
            
            // Clears textboxes 
            studentIdTextBox.Text = "";
            studentBorrowerTextBox.Text = "";
            dateLentTextBox.Text = "";
            dateReturnedTextBox.Text = "";
            bookTitleTextBox.Text = "";
            bookAuthorTextBox.Text = "";
            bookEditionTextBox.Text = "";
            bookPublisherTextBox.Text = "";
        }
    }
}

