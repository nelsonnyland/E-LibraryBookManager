using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupSourceControlProject
{
    public class Book
    {
        [Key]
        public int BookID { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public int PubDate { get; set; }

        public bool CheckedOut { get; set; }
    }
}
