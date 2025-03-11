using PersonalLibraryApp.Backend;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalLibraryApp
{
    public partial class BookDetails : UserControl
    {
        private MainWindow _mainWindow;
        public Book Book;

        public string TitleText { get => TitleLabel.Text; set => TitleLabel.Text = value; }
        public string AuthorText { get => AuthorLabel.Text; set => AuthorLabel.Text = value.ToUpper(); }
        public string GenreText { get => GenreLabel.Text; set => GenreLabel.Text = value; }
        public string PagesText { get => PagesLabel.Text; set => PagesLabel.Text = value; }
        public string IsbnText { get => IsbnLabel.Text; set => IsbnLabel.Text = value; }
        public string StatusText { get => StatusLabel.Text; set => StatusLabel.Text = value; }
        public string BookmarkText { get => BookmarkLabel.Text; set => BookmarkLabel.Text = value; }

        public BookDetails()
        {
            InitializeComponent();
        }

        public BookDetails(MainWindow mainWindow, Book book)
        {
            InitializeComponent();

            _mainWindow = mainWindow;
            Book = book;

            if (Book.Status == "read") MarkAs.Text = "Mark as unread";

            UpdateUI();
        }

        public void UpdateUI()
        {
            if (Book == null)
            {
                throw new ArgumentNullException(nameof(Book));
            }

            TitleText = Book.Title;
            AuthorText += Book.Author.ToUpper();
            GenreText += Book.Genre;
            PagesText += Book.Pages.ToString();
            IsbnText += Book.Isbn;
            StatusText += Book.Status.Substring(0, 1).ToUpper() + Book.Status.Substring(1).ToLower();
            BookmarkText += Book.Bookmark.ToString();

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            _mainWindow.DeleteBook(Book, e);
        }

        private void MarkAsButton_Click(object sender, EventArgs e)
        {
            if (Book.Status == "read") MarkAs.Text = "Mark as unread";


            if (Book.Status == "reading" || Book.Status == "unread")
            {
                _mainWindow.MarkAs(Book, "read", e);
            }
            else if (Book.Status == "read")
            {
                _mainWindow.MarkAs(Book, "unread", e);
            }

        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            _mainWindow.EditBook(Book);
        }
    }
}
