using PersonalLibraryApp.Backend;

namespace PersonalLibraryApp
{
    public partial class MainWindow : Form
    {
        private string _status = string.Empty;
        public MainWindow()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            homeButton_Click(homeButton, e);

            PopulateBooksUI();
        }

        private void PopulateBooksUI()
        {
            homeFlowLayoutPanel.Controls.Clear();
            booksFlowLayoutPanel.Controls.Clear();

            foreach (Book item in Library.BooksList)
            {
                if (item.Status.ToLower() == "reading" || item.Status.ToLower() == "unread")
                {
                    BookCard bookCard = new BookCard(item);

                    homeFlowLayoutPanel.Controls.Add(bookCard);
                }

                BookRegistration bookRegistration = new BookRegistration(item);

                booksFlowLayoutPanel.Controls.Add(bookRegistration);

            }

        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            sectionLabel.Text = "Home";
            homePanel.Visible = true;
            booksPanel.Visible = false;
            searchPanel.Visible = false;
            accountPanel.Visible = false;
            AddNewBookPanel.Visible = false;

        }

        private void bookButton_Click(object sender, EventArgs e)
        {
            sectionLabel.Text = "Books";
            homePanel.Visible = false;
            booksPanel.Visible = true;
            searchPanel.Visible = false;
            accountPanel.Visible = false;
            AddNewBookPanel.Visible = false;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            sectionLabel.Text = "Search";
            homePanel.Visible = false;
            booksPanel.Visible = false;
            searchPanel.Visible = true;
            accountPanel.Visible = false;
            AddNewBookPanel.Visible = false;
        }

        private void userbutton_Click(object sender, EventArgs e)
        {
            sectionLabel.Text = "Account";
            homePanel.Visible = false;
            booksPanel.Visible = false;
            searchPanel.Visible = false;
            accountPanel.Visible = true;
            AddNewBookPanel.Visible = false;
        }

        private void NewBookButton_Click(object sender, EventArgs e)
        {
            sectionLabel.Text = "Add New Book";
            homePanel.Visible = false;
            booksPanel.Visible = false;
            searchPanel.Visible = false;
            accountPanel.Visible = false;
            footerPanel.Visible = false;
            AddNewBookPanel.Visible = true;
            BackPictureButton.Visible = true;
        }


        private void BackPictureButton_Click(object sender, EventArgs e)
        {
            sectionLabel.Text = "Books";
            homePanel.Visible = false;
            booksPanel.Visible = true;
            searchPanel.Visible = false;
            accountPanel.Visible = false;
            footerPanel.Visible = true;
            AddNewBookPanel.Visible = false;
            BackPictureButton.Visible = false;
        }

        private void AddNewBook()
        {
            string? Title = TitleTextBox.Text;
            string? Author = AuthorTextBox.Text;
            string? Genre = GenreTextBox.Text;
            string? Pages = PagesTextBox.Text;
            string? Isbn = IsbnTextBox.Text;
            string? Status = _status;
            string? Bookmark = BookmarkTextBox.Text;

            if (_status == "Reading")
            {
                Library.AddNewBook(Title, Author, Genre, int.Parse(Pages), Isbn, Status);
            }
            else
            {
                Library.AddNewBook(Title, Author, Genre, int.Parse(Pages), Isbn, Status, int.Parse(Bookmark));
            }

        }

        private void ClearBookFields()
        {
            TitleTextBox.Text = string.Empty;
            AuthorTextBox.Text = string.Empty;
            GenreTextBox.Text = string.Empty;
            PagesTextBox.Text = string.Empty;
            IsbnTextBox.Text = string.Empty;
            _status = string.Empty;
            UnreadRadioButton.Checked = false;
            ReadingRadioButton.Checked = false;
            ReadRadioButton.Checked = false;
            BookmarkTextBox.Text = string.Empty;

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
            if (string.IsNullOrEmpty(_status))
            {
                WarningLabel.Text = "Please select book status";
                return;
            }

            if (ReadingRadioButton.Checked && (!int.TryParse(BookmarkTextBox.Text, out int b) || int.Parse(BookmarkTextBox.Text) < 0))
            {
                WarningLabel.Text = "Please insert correct bookmark";
                return;
            }

            if (string.IsNullOrEmpty(BookmarkTextBox.Text))
            {
                BookmarkTextBox.Text = "0";
            }


            AddNewBook();
            ClearBookFields();
            PopulateBooksUI();
            BackPictureButton_Click(BackPictureButton, e);
            bookButton_Click(bookButton, e);
        }

        private void Status_IsChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton == false) return;
            RadioButton rb = (RadioButton)sender;

            if (rb.Checked == true)
            {
                _status = rb.Text;
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
    }
}
