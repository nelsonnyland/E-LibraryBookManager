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
        private static Member CurrentMember { get; set; }

        public static Member GetCurrentMember()
        {
            return CurrentMember;
        }

        public static void SetCurrentMember(Member member)
        {
            CurrentMember = member;
        }

        public static void AddMember(Member m)
        {
            LibraryContext context = new LibraryContext();

            context.Members.Add(m);

            context.SaveChanges();
        }

        public static void UpdateMember(Member m)
        {
            var context = new LibraryContext();

            // Find Member's info via their cardnumber
            Member originalMember = context.Members.Find(m.CardNumber);

            // Update Member's info
            originalMember.FirstName = m.FirstName;
            originalMember.LastName = m.LastName;
            originalMember.BooksChecked = m.BooksChecked;

            // Save Changes
            context.SaveChanges();
        }

        public static void DeleteMember(Member m)
        {
            var context = new LibraryContext();
            context.Members.Add(m);

            context.Entry(m).State = EntityState.Deleted;

            context.SaveChanges();
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
