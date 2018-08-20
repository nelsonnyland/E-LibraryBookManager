using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupSourceControlProject
{
    public static class MemberDB
    {
        // allows for current member access
        private static Member CurrentMember { get; set; }

        public static Member GetCurrentMember()
        {
            return CurrentMember;
        }

        // changes current member
        public static void SetCurrentMember(Member member)
        {
            CurrentMember = member;
        }

        public static bool IsMember(Member member)
        {
            throw new NotImplementedException();
        }

        public static bool LogIn(Member member)
        {
            throw new NotImplementedException();
        }

        public static bool HasBooks(Member member)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets all books checked out by user.
        /// </summary>
        /// <param name="member"></param>
        /// <returns>List of books</returns>
        public static List<Book> GetAllMembersBooks(Member member)
        {
            throw new NotImplementedException();
        }
    }
}
