using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupSourceControlProject
{
    /// <summary>
    /// The MemberDB class communicates with the database and
    /// handles current logged-in member as well as registration
    /// log-in and some Member class methods.
    /// </summary>
    public static class MemberDB
    {
        /// <summary>
        /// Adds a member to the database.
        /// </summary>
        /// <param name="member"></param>
        public static bool Register(Member member)
        {
            LibraryContext context = new LibraryContext();

            context.Members.Add(member);

            context.SaveChanges();

            return IsMember(member);
        }

        private static void LogIn(Member member)
        {
            CurrentMember.SetCurrentMember(member);
        }

        /// <summary>
        /// Logs user in if verification passes and sets current
        /// member to user.
        /// </summary>
        /// <param name="member"></param>
        public static bool Validate(Member member)
        {
            LibraryContext context = new LibraryContext();

            List<Member> allMembers =
                (from m in context.Members
                 select m).ToList();

            foreach (Member item in allMembers)
            {
                if ((item.Username == member.Username) 
                    && (item.PIN == member.PIN))
                {
                    LogIn(member);
                    return true;
                }
            }

            return false;
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
                if (item.Username == member.Username)
                    return true;
            }

            return false;
        }

        /// <summary>
        /// Gets all books checked out by member.
        /// </summary>
        /// <param name="member">Member</param>
        /// <returns>List<Book></returns>
        public static List<Book> GetMemberBooks()
        {
            Member member = CurrentMember.GetCurrentMember();

            return member.BooksChecked;
        }

        /// <summary>
        /// Sets all books checked out by member.
        /// </summary>
        /// <param name="books">List<Book></param>
        public static void SetMemberBooks(List<Book> books)
        {
            Member member = CurrentMember.GetCurrentMember();

            member.BooksChecked = books;
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
