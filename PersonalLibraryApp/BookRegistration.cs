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
        public readonly Book Book;

        public string TitleText { get => TitleLabel.Text; set => TitleLabel.Text = value; }
        public string AuthorText { get => AuthorLabel.Text; set => AuthorLabel.Text = value.ToUpper(); }
        public string StatusText { get => StatusLabel.Text; set => StatusLabel.Text = value; }

        public BookRegistration(Book book)
        {
            InitializeComponent();

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
            StatusText = Book.Status.Substring(0,1).ToUpper() + Book.Status.Substring(1).ToLower();

        }
    }
}
