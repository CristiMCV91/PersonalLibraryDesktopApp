namespace PersonalLibraryApp.Backend
{
    public sealed class Book
    {
        public string Title { get; private set; } = string.Empty;
        public string Author { get; private set; } = string.Empty;
        public string Genre { get; private set; } = string.Empty;
        public int Pages { get; private set; } = 0;
        public string Isbn { get; private set; } = string.Empty;
        public string Status { get; private set; } = string.Empty;
        public int Bookmark { get; private set; } = 0;

        internal Book(string title, string author)
        { 
            Title = title;
            Author = author;
           
        }

        public Book SetTitle(string title)
        {
            Title = title;
            return this;
        }
        public Book SetAuthor(string author)
        {
            Author = author;
            return this;
        }
        public Book SetGenre(string genre)
        {
            Genre = genre;
            return this;
        }
        public Book SetPages(int pages)
        {
            Pages = pages;
            return this;
        }
        public Book SetIsbn(string isbn)
        {
            Isbn = isbn;
            return this;
        }
        public Book SetStatus(string status)
        {
            //if (status.ToLower() == "unread")
            //{
                
            //    this.SetBookmark(0);
            //    Status = status.ToLower();
            //    return this;
            //}
            //else if (status.ToLower() == "read")
            //{
            //    this.SetBookmark(this.Pages);
            //    Status = status.ToLower();
            //    return this;
            //}
            
            Status = status.ToLower();
            return this;
        }
        public Book SetBookmark(int bookmark)
        {
            //if (bookmark == this.Pages)
            //{
            //    this.SetStatus("Read");
            //    Bookmark = bookmark;
            //    return this;
            //} else if (bookmark == 0)
            //{
            //    this.SetStatus("Unread");
            //    Bookmark = bookmark;
            //    return this;
            //}

            Bookmark = bookmark;
            return this;
        }



    }
}
