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
        public static void CheckoutBooks(List<Book> books)
        {
            // Add book to Member's Book List
            Member currentMember = CurrentMember.GetCurrentMember();
            currentMember.AddCheckedBooks(books);

            // Change Book checked-out property
            foreach (Book book in books)
            {
                book.CheckedOut = true;
            }
        }

        /// <summary>
        /// Removes books from member's checked-out List.
        /// </summary>
        /// <param name="books"></param>
        public static void CheckInBooks(List<Book> books)
        {
            // Remove Book from Member's Book List
            Member currentMember = CurrentMember.GetCurrentMember();

            List<Book> checkedBooks = 
                currentMember.GetCheckedBooks();

            foreach (Book book in books)
            {
                checkedBooks.Remove(book);
            }

            // Change Book checked-out property
            foreach (Book book in books)
            {
                book.CheckedOut = false;
            }
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
        /// Returns a boolean value that cooresponds to
        /// whether or not the book is checked-out.
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        public static bool IsBookCheckedOut(Book book)
        {
            // return checked/checked-out status of book 
            return book.CheckedOut;
        }
    }
}
