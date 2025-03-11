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
    public partial class BookRegistration : UserControl
    {
        private MainWindow _mainWindow;
        public readonly Book Book;

        public string TitleText { get => TitleLabel.Text; set => TitleLabel.Text = value; }
        public string AuthorText { get => AuthorLabel.Text; set => AuthorLabel.Text = value.ToUpper(); }
        public string StatusText { get => StatusLabel.Text; set => StatusLabel.Text = value; }

        public BookRegistration()
        {
            InitializeComponent();
        }

        public BookRegistration(MainWindow mainWindow, Book book)
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
            AuthorText = Book.Author.ToUpper();
            StatusText = Book.Status.Substring(0, 1).ToUpper() + Book.Status.Substring(1).ToLower();

        }

        private void DetailsButton_Click(object sender, EventArgs e)
        {
            if (_mainWindow != null)
            {
                _mainWindow.sectionLabel.Text = Book.Author;
                _mainWindow.OpenBookDetails(Book);
            }
        }
    }
}
