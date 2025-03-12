using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace PersonalLibraryApp.Backend
{
    public static class Library
    {
        private static List<Book> _booksInternal = [];
        public static List<Book> BooksList => _booksInternal;
        public static List<Book> ReoderBookList;

        public static Book AddNewBook(string title, string author, string genre = "", int pages = 0, string isbn = "", string status = "", int bookmark = 0)
        {
            Book book = CreateBook(title,author)
                .PopulateAdditionalData(genre, pages, isbn, status, bookmark);

            return book;
        }

        public static Book CreateBook(string title, string author)
        {
            if (string.IsNullOrEmpty(title))
            {
                throw new ArgumentNullException(nameof(title));
            }

            if (string.IsNullOrEmpty(author))
            {
                throw new ArgumentNullException(nameof(author));
            }

            Book book = new Book(title, author);
            _booksInternal.Add(book);

            ReoderBookList = _booksInternal;

            return book;
        }

        //public static Book PopulateAdditionalData(this Book book, string genre = "", int pages = 0, string isbn = "", string status = "")
        //{
        //    return book
        //        .SetGenre(genre)
        //        .SetPages(pages)
        //        .SetIsbn(isbn)
        //        .SetStatus(status);
        //}
        public static Book PopulateAdditionalData(this Book book, string genre = "", int pages = 0, string isbn = "", string status = "", int bookmark = 0)
        {
            book
                .SetGenre(genre)
                .SetPages(pages)
                .SetIsbn(isbn)
                .SetStatus(status);
            if (status.ToLower() == "read")
            {
                book.SetBookmark(pages);
            }
            else if (status.ToLower() == "unread")
            {
                book.SetBookmark(0);
            }
            else 
            {
                book.SetBookmark(bookmark);
            }
                
            return book;
        }

        public static void Sort()
        {
            _booksInternal = [.. _booksInternal.OrderBy(x => x.Title)];
        }

        public static void DeleteBook(Book book)
        { 
            _booksInternal.Remove(book);
        }

        public static void SortBy(string criteria)
        {
            ReoderBookList = _booksInternal;
            switch (criteria.ToLower())
            {
                case "title":
                    ReoderBookList = ReoderBookList.OrderBy(item => item.Title).ToList();
                    break;
                case "author":
                    ReoderBookList = ReoderBookList.OrderBy(item => item.Author).ToList();
                    break;
                case "status":
                    ReoderBookList = ReoderBookList.OrderBy(item => item.Status).ToList();
                    break;
            }
        }
        public static void Unsort()
        {
            ReoderBookList = _booksInternal;
        }

    }
}
