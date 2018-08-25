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
        public int MemberID { get; set; }

        public string Username { get; set; }

        public int PIN { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public bool IsAdmin { get; set; }

        private List<Book> BooksChecked { get; set; }

        public List<Book> GetCheckedBooks()
        {
            return BooksChecked;
        }

        public void AddCheckedBooks(List<Book> books)
        {
            BooksChecked.AddRange(books);            
        }
    }
}
