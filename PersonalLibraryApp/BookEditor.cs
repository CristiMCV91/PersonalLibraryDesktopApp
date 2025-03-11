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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PersonalLibraryApp
{
    public partial class BookEditor : UserControl
    {
        private MainWindow _mainWindow;
        public Book Book;
        private bool _newBook;

        public string Title { get => TitleTextBox.Text; set => TitleTextBox.Text = value; }
        public string Author { get => AuthorTextBox.Text; set => AuthorTextBox.Text = value.ToUpper(); }
        public string Genre { get => GenreTextBox.Text; set => GenreTextBox.Text = value; }
        public string Pages { get => PagesTextBox.Text; set => PagesTextBox.Text = value; }
        public string Isbn { get => IsbnTextBox.Text; set => IsbnTextBox.Text = value; }
        public string Status { get; set; }
        public string Bookmark { get => BookmarkTextBox.Text; set => BookmarkTextBox.Text = value; }

        public BookEditor()
        {            
            InitializeComponent();
            ClearNewBookFields();
        }
        public BookEditor(MainWindow mainWindow)
        {
            _newBook = true;
            _mainWindow = mainWindow; 
            InitializeComponent();
            ClearNewBookFields();
        }
        public BookEditor(MainWindow mainWindow, Book book)
        {

            _newBook = false;
            _mainWindow = mainWindow;
            Book = book;
            InitializeComponent();
            ClearNewBookFields();
            PopulateField();


        }

        private void AddNewBook()
        {
            Title = TitleTextBox.Text;
            Author = AuthorTextBox.Text;
            Genre = GenreTextBox.Text;
            Pages = PagesTextBox.Text;
            Isbn = IsbnTextBox.Text;
            Bookmark = BookmarkTextBox.Text;

            if (Status == "Reading")
            {
                Library.AddNewBook(Title, Author, Genre, int.Parse(Pages), Isbn, Status, int.Parse(Bookmark));
                
            }
            else
            {
                Library.AddNewBook(Title, Author, Genre, int.Parse(Pages), Isbn, Status);
            }

        }
        private void ModifyBook()
        {
            Title = TitleTextBox.Text;
            Author = AuthorTextBox.Text;
            Genre = GenreTextBox.Text;
            Pages = PagesTextBox.Text;
            Isbn = IsbnTextBox.Text;
            Bookmark = BookmarkTextBox.Text;

            if (Status == "Reading")
            {
                Book
                    .SetTitle(Title)
                    .SetAuthor(Author)
                    .SetGenre(Genre)
                    .SetPages(int.Parse(Pages))
                    .SetIsbn(Isbn)
                    .SetStatus(Status)
                    .SetBookmark(int.Parse(Bookmark));

            }
            else
            {
                Book
                    .SetTitle(Title)
                    .SetAuthor(Author)
                    .SetGenre(Genre)
                    .SetPages(int.Parse(Pages))
                    .SetIsbn(Isbn)
                    .SetStatus(Status);
                    
            }


        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            WarningLabel.Text = string.Empty;
            if (string.IsNullOrEmpty(TitleTextBox.Text))
            {
                WarningLabel.Text = "Title can't be empty";
                return;
            }
            if (string.IsNullOrEmpty(AuthorTextBox.Text))
            {
                WarningLabel.Text = "Author can't be empty";
                return;
            }
            if (string.IsNullOrEmpty(GenreTextBox.Text))
            {
                GenreTextBox.Text = "";
            }
            if (string.IsNullOrEmpty(PagesTextBox.Text))
            {
                WarningLabel.Text = "Pages can't be empty";
                return;
            }
            if (!int.TryParse(PagesTextBox.Text, out int a) || int.Parse(PagesTextBox.Text) < 1)
            {
                WarningLabel.Text = "Please insert correct pages";
                return;
            }
            if (string.IsNullOrEmpty(IsbnTextBox.Text))
            {
                IsbnTextBox.Text = "";
            }
            if (string.IsNullOrEmpty(Status))
            {
                WarningLabel.Text = "Please select book status";
                return;
            }

            if (ReadingRadioButton.Checked && (!int.TryParse(BookmarkTextBox.Text, out int b) || int.Parse(BookmarkTextBox.Text) < 0) || int.Parse(BookmarkTextBox.Text) > int.Parse(PagesTextBox.Text))
            {
                WarningLabel.Text = "Please insert correct bookmark";
                return;
            }

            if (string.IsNullOrEmpty(BookmarkTextBox.Text))
            {
                BookmarkTextBox.Text = "0";
            }

            if (_newBook)
            {
                AddNewBook();
                _mainWindow.BackPictureButton_Click(_mainWindow.BackPictureButton, e);
            }
            else 
            {
                ModifyBook();
                _mainWindow.OpenBookDetails(Book);
            }
            
            ClearNewBookFields();
        }

        private void Status_IsChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton == false) return;
            RadioButton rb = (RadioButton)sender;

            if (rb.Checked == true)
            {
                Status = rb.Text;
            }
            if (rb.Text == "Reading")
            {
                BookmarkTextBox.Enabled = true;
            }
            else
            {
                BookmarkTextBox.Enabled = false;
            }
        }

        private void ClearNewBookFields()
        {
            WarningLabel.Text = String.Empty;
            TitleTextBox.Text = string.Empty;
            AuthorTextBox.Text = string.Empty;
            GenreTextBox.Text = string.Empty;
            PagesTextBox.Text = string.Empty;
            IsbnTextBox.Text = string.Empty;
            Status = string.Empty;
            UnreadRadioButton.Checked = false;
            ReadingRadioButton.Checked = false;
            ReadRadioButton.Checked = false;
            BookmarkTextBox.Text = string.Empty;

        }

        private void PopulateField()
        {
            if (!_newBook)
            {
                TitleTextBox.Text = Book.Title;
                AuthorTextBox.Text = Book.Author;
                GenreTextBox.Text = Book.Genre;
                PagesTextBox.Text = Book.Pages.ToString();
                IsbnTextBox.Text = Book.Isbn;
                Status = Book.Status;
                switch (Status)
                {
                    case "unread":
                        UnreadRadioButton.Checked = true;
                        BookmarkTextBox.Text = string.Empty;
                        break;
                    case "reading":
                        ReadingRadioButton.Checked = true;
                        BookmarkTextBox.Text = Book.Bookmark.ToString();
                        break;
                    case "read":
                        ReadRadioButton.Checked = true;
                        BookmarkTextBox.Text = string.Empty;
                        break;
                    default:
                        UnreadRadioButton.Checked = false;
                        ReadingRadioButton.Checked = false;
                        ReadingRadioButton.Checked = false;

                        break;
                }
            }


        }

    }
}
