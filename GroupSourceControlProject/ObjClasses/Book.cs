using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupSourceControlProject
{
    [Table("Books")]
    public class Book
    {
        [Key]
        [Required]
        [StringLength(10)]
        public string ISBN { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        public int PubDate { get; set; }

        [Required]
        public string Category { get; set; }

        // 0 = not checked-out
        // [MemberID] = member checked-out by
        public int CheckedOutBy { get; set; }
    }
}
