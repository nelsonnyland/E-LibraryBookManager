using GroupSourceControlProject.ObjClasses;
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
        /// Returns all the books in the database.
        /// </summary>
        /// <returns>List<Book></returns>
        public static List<Book> GetAllBooks()
        {
            LibraryContext context = new LibraryContext();

            List<Book> allBooks =
                (from b in context.Books
                 select b).ToList();
            
            return allBooks;
        }
        
        /// <summary>
        /// Gets all books from the Library that are not
        /// checked-out.
        /// </summary>
        /// <returns></returns>
        public static List<Book> GetAllUncheckedBooks()
        {            
            List<Book> allBooks = GetAllBooks();

            List<Book> uncheckedBooks = new List<Book>();

            foreach (Book book in allBooks)
            {
                if (book.CheckedOutBy == 0)
                    uncheckedBooks.Add(book);
            }

            return uncheckedBooks;
        }

        /// <summary>
        /// Gets all books checked out by a member.
        /// </summary>
        /// <param name="member">Member</param>
        /// <returns>List<Book></returns>
        public static List<Book> GetMemberBooks()
        {
            Member member = CurrentMember.GetCurrentMember();

            List<Book> allBooks = GetAllBooks();

            List<Book> memberBooks = new List<Book>();

            int memberID = Convert.ToInt32(member.MemberID);

            foreach (Book book in allBooks)
            {
                if (book.CheckedOutBy == memberID) 
                    memberBooks.Add(book);
            }

            return memberBooks;
        }

        /// <summary>
        /// Gets the selected books by isbn from the database.
        /// </summary>
        /// <param name="isbns"></param>
        /// <returns>List<Book></returns>
        public static List<Book> GetSelectedBooks(List<string> isbns)
        {
            LibraryContext context = new LibraryContext();

            List<Book> selectedBooks = new List<Book>();

            foreach (string isbn in isbns)
            {
                Book dbBook = context.Books.Find(isbn);
                selectedBooks.Add(dbBook);
            }

            return selectedBooks;
        }

        /// <summary>
        /// Checks-in the given books by setting the CheckedOutBy
        /// property to 0.
        /// </summary>
        /// <param name="books"></param>
        /// <returns>bool</returns>
        public static bool CheckInBooks(List<Book> books)
        {
            LibraryContext context = new LibraryContext();
            
            Member member = CurrentMember.GetCurrentMember();

            foreach (Book book in books)
            {
                Book dbBook = context.Books.Find(book.ISBN);
                dbBook.CheckedOutBy = 0;
            }

            context.SaveChanges();

            if (IsChecked(books))
                return false;
            else
                return true;
        }
        
        /// <summary>
        /// Checks-out the given books by setting the CheckedOutBy
        /// property to the CurrentMember MemberID.
        /// </summary>
        /// <param name="books">List<Book></param>
        public static bool CheckoutBooks(List<Book> books)
        {
            LibraryContext context = new LibraryContext();
            
            Member member = CurrentMember.GetCurrentMember();

            int memberID = Convert.ToInt32(member.MemberID);

            foreach (Book book in books)
            {
                Book dbBook = context.Books.Find(book.ISBN);
                dbBook.CheckedOutBy = memberID;
            }

            context.SaveChanges();

            if (IsChecked(books))
                return true;
            else
                return false;
        }

        /// <summary>
        /// Queries the database for whether the books
        /// are checked-out or not.
        /// </summary>
        /// <param name="books"></param>
        /// <returns></returns>
        private static bool IsChecked(List<Book> books)
        {
            LibraryContext context = new LibraryContext();

            foreach (Book b in books)
            {
                Book dbBook = context.Books.Find(b.ISBN);

                if (dbBook.CheckedOutBy == 0)
                    return false;
            }

            return true;
        }

        /// <summary>
        /// Checks whether given book is already in
        /// the database.
        /// </summary>
        /// <param name="book"></param>
        /// <returns>bool result</returns>
        public static bool IsBook(Book book)
        {
            List<Book> allBooks = GetAllBooks();

            foreach (Book b in allBooks)
            {
                if (book.Title == b.Title)
                    return true;
            }

            return false;
        }

        /// <summary>
        /// Adds given book to the database.
        /// </summary>
        /// <param name="book"></param>
        public static void AddBook(Book book)
        {
            LibraryContext context = new LibraryContext();

            context.Books.Add(book);

            context.SaveChanges();
        }

        /// <summary>
        /// Removes book from the database.
        /// </summary>
        /// <param name="isbn"></param>
        public static void RemoveBook(string isbn)
        {
            LibraryContext context = new LibraryContext();

            Book book = context.Books.Find(isbn);
            
            context.Books.Remove(book);

            context.SaveChanges();
        }
    }
}
