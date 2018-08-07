using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupSourceControlProject
{
    static class LibraryDB
    {
        public static void AddBook(Book b) //AddBookToDB?
        {
            // Add book to Member list VS Add Book to DB???
            // This currently adds book to DB
            var context = new LibraryContext();

            context.Books.Add(b);

            context.SaveChanges();
        }

        public static void UpdateBook(Book b) //UpdateBookStatus?
        {
            // User functionality VS Admin functionality???
            var context = new LibraryContext();

            Book originalBook = context.Books.Find(b.BookID);

            originalBook.CheckedOut = b.CheckedOut;

            context.SaveChanges();
        }

        public static void DeleteBook(Book b) //DeleteBookFromDB?
        {
            // Currently: Deletes Book from DB
            // Maybe Delete Book from Member's checked out books?
            var context = new LibraryContext();

            context.Books.Add(b);

            context.Entry(b).State = EntityState.Deleted;

            context.SaveChanges();
        }

        public static List<Book> GetAllBooks()
        {
            // Maybe make a separate method for GetAllMembersBooks()
            throw new NotImplementedException();
        }

        public static bool IsChecked(Book book)
        {
            throw new NotImplementedException();
        }

        public static bool CheckOut(Book book)
        {
            throw new NotImplementedException();
        }

        public static bool CheckIn(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
