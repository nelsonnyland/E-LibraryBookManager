using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupSourceControlProject
{
    [Table("Members")]
    public class Member
    {
        [Key]
        [MinLength(9)]
        [MaxLength(9)]
        public string MemberID { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public int PIN { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string FirstName { get; set; }

        // false = not admin
        // true = is admin
        public bool IsAdmin { get; set; }
    }
}
