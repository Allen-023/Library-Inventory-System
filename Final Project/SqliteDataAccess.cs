using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public class SqliteDataAccess
    {
        // Insert data into database and throw exception if student id is not unique 
        public static void SavePerson(PersonModel person)
        {
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    cnn.Execute("insert into CCIT_Library (Student_Id, Student_Borrower, Date_Lent, Date_Returned, Book_Title, Book_Author, Book_Edition, Book_Publisher) values (@StudentId, @StudentBorrower,@DateLent,@DateReturned,@BookTitle, @BookAuthor,@BookEdition, @BookPublisher)", person);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR: Student ID's must be unique");
            }
        }
        // Loads the connection string 
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
