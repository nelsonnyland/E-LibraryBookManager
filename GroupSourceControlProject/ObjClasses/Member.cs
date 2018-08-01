using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupSourceControlProject
{
    class Member
    {
        public int CardNumber { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public List<string> Books { get; set; }

        public List<string> GetBooks()
        {
            return Books;
        }
    }
}
