using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalLibraryApp.Backend
{
    public static class Library
    {
        private static List<Book> _booksInternal = [];
        public static List<Book> BooksList => _booksInternal;

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

            return book;
        }

        public static Book PopulateAdditionalData(this Book book, string genre = "", int pages = 0, string isbn = "", string status = "", int bookmark = 0 )
        {
            return book
                .SetGenre(genre)
                .SetPages(pages)
                .SetIsbn(isbn)
                .SetStatus(status)
                .SetBookmark(bookmark);
        }

        public static void Sort()
        {
            _booksInternal = [.. _booksInternal.OrderBy(x => x.Title)];
        }

    }
}
