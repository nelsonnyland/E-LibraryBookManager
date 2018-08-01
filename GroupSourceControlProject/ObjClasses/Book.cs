using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupSourceControlProject
{
    class Book
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public int PubDate { get; set; }

        public bool CheckedOut { get; set; }
    }
}
