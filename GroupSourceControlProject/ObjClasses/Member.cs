using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupSourceControlProject
{
    public class Member
    {
        [Key]
        public int CardNumber { get; set; }

        public int PIN { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public List<string> Books { get; set; }

        public List<string> GetBooks()
        {
            return Books;
        }
    }
}
