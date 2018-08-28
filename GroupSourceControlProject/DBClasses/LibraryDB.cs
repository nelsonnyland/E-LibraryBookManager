using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupSourceControlProject
{
    public static class LibraryDB
    {
        /// <summary>
        /// Adds books to Member's checked-out list.
        /// </summary>
        /// <param name="books"></param>
        public static bool CheckoutBooks(List<Book> books)
        {
            List<Book> memberBooks = 
                MemberDB.GetMemberBooks();

            foreach (Book book in books)
            {
                memberBooks.Add(book);
                book.CheckedOut = true;
            }

            MemberDB.SetMemberBooks(memberBooks);

            return IsChecked(books);
        }

        /// <summary>
        /// Removes books from member's checked-out List.
        /// </summary>
        /// <param name="books"></param>
        public static void CheckInBooks(List<Book> books)
        {
            List<Book> memberBooks =
                MemberDB.GetMemberBooks();

            foreach (Book book in books)
            {
                memberBooks.Remove(book);
                book.CheckedOut = false;
            }

            MemberDB.SetMemberBooks(memberBooks);
        }

        /// <summary>
        /// Gets all books from the Library that are not
        /// checked out.
        /// </summary>
        /// <returns></returns>
        public static List<Book> GetAllUncheckedBooks()
        {            
            LibraryContext context = new LibraryContext();

            List<Book> allBooks =
                (from b in context.Books
                 select b).ToList();

            List<Book> uncheckedBooks = new List<Book>();

            foreach (Book book in allBooks)
            {
                if (book.CheckedOut is false)
                    uncheckedBooks.Add(book);
            }

            return uncheckedBooks;
        }

        /// <summary>
        /// Returns whether or not books are checked-out.
        /// </summary>
        /// <returns>bool</returns>
        public static bool IsChecked(List<Book> books)
        {
            List<Book> memberBooks = MemberDB.GetMemberBooks();

            foreach (Book b in books)
            {
                if (memberBooks.Contains(b))
                    return true;
            }

            return false;
        }
    }
}
