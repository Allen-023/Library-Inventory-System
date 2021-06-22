using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    // Propertys for a student
    public class PersonModel
    {
        public string StudentId { get; set; }

        public string StudentBorrower { get; set; }

        public string DateLent { get; set; }

        public string DateReturned { get; set; }

        public string BookTitle { get; set; }

        public string BookAuthor { get; set; }

        public string BookEdition { get; set; }

        public string BookPublisher { get; set; }
    }
}
