using Library_IS.Forms;
using Library_IS.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_IS.Lib
{
    public class Factory
    {
        Repository repo = new Repository(new LibraryEntities());

        // :)
        public void CreateUser(User user)
        {
            try
            {
                repo.InsertEntity(user);
                //aaa
            }
            catch { throw; }
        }

        public bool UserNameExists(string userName)
        {
            try
            {
                var user = repo.GetEntityById<User>(userName);
                return user != null;
            }
            catch { throw; }
        }
        //public List<BookView> GetAvailableBooks()
        //{
        //    try
        //    {
        //        return repo.GetEntities<Book>().Select(b => new BookView
        //        {
        //            ID_Book = b.ID_Book,
        //            Book_Name = b.Book_Name,
        //            ISBN = b.ISBN,
        //            Year = b.Year,
        //            Author = b.Author
        //        }).ToList();
        //    }
        //    catch { throw; }
        //}

        public List<BookView> GetAvailableBooks()
        {
            try
            {
                return repo.GetEntitiesByFilter<Book>(b => b.UserBook == null).Select(b => new BookView
                {
                    ID_Book = b.ID_Book,
                    Book_Name = b.Book_Name,
                    ISBN = b.ISBN,
                    Year = b.Year,
                    AuthorFullName = $"{b.Author?.Name} {b.Author?.Surname}"

                }).ToList();
            }
            catch { throw; }

        }

        public List<BookView> GetBooksByUserID(string username)
        {
            try
            {
                return repo.GetEntitiesByFilter<Book>(b => b.UserBook != null && b.UserBook.UserName == username).Select(b => new BookView
                {
                    ID_Book = b.ID_Book,
                    Book_Name = b.Book_Name,
                    ISBN = b.ISBN,
                    Year = b.Year,
                    AuthorFullName = $"{b.Author?.Name} {b.Author?.Surname}"

                }).ToList();
            }
            catch { throw; }

        }

        public bool ReturnBook(long bookId)
        {
            try
            {
                return repo.DeleteEntityById<UserBook>(bookId);
            }
            catch { throw; }
        }

        public bool TakeBook(long bookId, string username)
        {
            try
            {
                UserBook userBook = new UserBook
                {
                    Id_Book = bookId,
                    UserName = username,
                    PickDate = DateTime.Now
                };
                repo.InsertEntity(userBook);
                return true;
            }
            catch { throw; }
        }

        public List<BookView> GetAllBooks()
        {
            try
            {
                return repo.GetEntities<Book>().Select(b => new BookView
                {
                    ID_Book = b.ID_Book,
                    Book_Name = b.Book_Name,
                    ISBN = b.ISBN,
                    Year = b.Year,
                    AuthorFullName = $"{b.Author?.Name} {b.Author?.Surname}"
                }).ToList();
            }
            catch { throw; }
        }

        public bool DeleteBook(long bookId)
        {
            try
            {
                return repo.DeleteEntityById<Book>(bookId);
            }
            catch { throw; }
        }

        public List<AuthorView> GetAllAuthors()
        {
            try
            {
                return repo.GetEntities<Author>().Select(a => new AuthorView
                {
                    ID_Author = a.ID_Author,
                    FullName = $"{a.Name} {a.Surname}"
                }).ToList();
            }
            catch { throw; }
        }

        public bool AddBook(Book book)
        {
            try
            {
                repo.InsertEntity(book);
                return true;
            }
            catch { throw; }
        }
    }
  

}
