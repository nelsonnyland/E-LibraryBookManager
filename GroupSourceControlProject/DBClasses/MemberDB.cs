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

        /// <summary>
        /// Verifies if a library member, if so
        /// returns true.
        /// </summary>
        /// <param name="member"></param>
        /// <returns>bool verification result</returns>
        public static bool IsMember(Member member)
        {
            LibraryContext context = new LibraryContext();

            List<Member> allMembers =
                (from m in context.Members
                 select m).ToList();

            foreach (Member item in allMembers)
            {
                if ((item.CardNumber == member.CardNumber) &&
                    (item.PIN == member.PIN))
                    return true;
            }

            return false;
        }

        /// <summary>
        /// Logs user in if passes verification.
        /// </summary>
        /// <param name="member"></param>
        public static void LogIn(Member member)
        {
            SetCurrentMember(member);
        }

        /// <summary>
        /// Checks if Member has books checked out.
        /// </summary>
        /// <param name="member"></param>
        /// <returns>bool answer if has books</returns>
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
            return member.GetCheckedBooks();
        }
    }
}
