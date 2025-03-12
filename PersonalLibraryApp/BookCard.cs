using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using PersonalLibraryApp.Backend;

namespace PersonalLibraryApp
{
    public partial class BookCard : UserControl
    {
        private MainWindow _mainWindow;
        public readonly Book Book;

        public string TitleText { get => TitleLabel.Text; set => TitleLabel.Text = value; }
        public string AuthorText { get => AuthorLabel.Text; set => AuthorLabel.Text = value.ToUpper(); }
        public string BookmarkPage { get => BookmarkLabel.Text; set => BookmarkLabel.Text = "BOOKMARK: page " + value; }

        public string BookmarkPercent
        {
            get => ReadingPercentLabel.Text;
            set => ReadingPercentLabel.Text = value + "%";
        }

        public int? ReadingBar { get => ReadingProgressBar.Value; set => ReadingProgressBar.Value = (int)value; }

        public Image? BookCoverImage
        {
            get => BookCoverPictureBox.Image;
            set
            {
                BookCoverPictureBox.Image = value;
                BookCoverPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        public BookCard()
        {
            InitializeComponent();
        }

        public BookCard(MainWindow mainWindow, Book book)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
            Book = book;

            UpdateUI();
        }

        public void UpdateUI()
        {
            if (Book == null)
            {
                throw new ArgumentNullException(nameof(Book));
            }



            TitleText = Book.Title;
            AuthorText = Book.Author;
            BookmarkPage = (Book.Bookmark.ToString() + "/" + Book.Pages.ToString());

            int percent = (int)(((float)Book.Bookmark / Book.Pages) * 100);
            BookmarkPercent = percent.ToString();
            ReadingBar = percent;


        }

        private void BookCoverPictureBox_Click(object sender, EventArgs e)
        {
            if (_mainWindow != null)
            {
                _mainWindow.sectionLabel.Text = Book.Author;
                _mainWindow.OpenBookDetails(Book);
            }
        }
    }
}
