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
        /// Logs user in if verification passes.
        /// </summary>
        /// <param name="member"></param>
        public static void LogIn(Member member)
        {
            CurrentMember.SetCurrentMember(member);
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

    /// <summary>
    /// CurrentMember class keeps track of who the currently
    /// logged-in member is. Accessible through public get
    /// and set methods.
    /// </summary>
    public static class CurrentMember
    {
        private static Member Current { get; set; }

        public static Member GetCurrentMember()
        {
            return Current;
        }

        public static void SetCurrentMember(Member member)
        {
            Current = member;
        }
    }
}
