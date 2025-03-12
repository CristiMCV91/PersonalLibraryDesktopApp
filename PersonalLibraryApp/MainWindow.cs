using PersonalLibraryApp.Backend;
using static System.Reflection.Metadata.BlobBuilder;

namespace PersonalLibraryApp
{
    public partial class MainWindow : Form
    {
        //private static MainWindow _instance;
        //private static readonly object _lock = new object();

        private string _status = string.Empty;
        private BookDetails _bookDetails = null;
        private BookEditor _bookEditor = null;
        private bool backFromEdit = false;
        private Book Book;
        private List<Book> _bookList = null;


        public MainWindow()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            SortComboBox.SelectedIndex = 0;
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


            }

            foreach (Book item in Library.ReoderBookList)
            {

                BookRegistration bookRegistration = new BookRegistration(this, item);

                booksFlowLayoutPanel.Controls.Add(bookRegistration);

            }

        }

        internal void homeButton_Click(object sender, EventArgs e)
        {
            PopulateBooksUI();
            sectionLabel.Text = "Home";
            homePanel.Visible = true;
            booksPanel.Visible = false;
            searchPanel.Visible = false;
            accountPanel.Visible = false;
            BookEditorFlowLayoutPanel.Visible = false;
            BookDetailsFlowLayoutPanel.Visible = false;
            BackPictureButton.Visible = false;
            CloseBookDetails();

        }

        internal void bookButton_Click(object sender, EventArgs e)
        {
           
            PopulateBooksUI();
            sectionLabel.Text = "Books";
            homePanel.Visible = false;
            booksPanel.Visible = true;
            searchPanel.Visible = false;
            accountPanel.Visible = false;
            BookEditorFlowLayoutPanel.Visible = false;
            BookDetailsFlowLayoutPanel.Visible = false;
            BackPictureButton.Visible = false;
            CloseBookDetails();
        }

        internal void searchButton_Click(object sender, EventArgs e)
        {
            sectionLabel.Text = "Search";
            homePanel.Visible = false;
            booksPanel.Visible = false;
            searchPanel.Visible = true;
            accountPanel.Visible = false;
            BookEditorFlowLayoutPanel.Visible = false;
            BookDetailsFlowLayoutPanel.Visible = false;
            CloseBookDetails();
        }

        internal void userbutton_Click(object sender, EventArgs e)
        {
            sectionLabel.Text = "Account";
            homePanel.Visible = false;
            booksPanel.Visible = false;
            searchPanel.Visible = false;
            accountPanel.Visible = true;
            BookEditorFlowLayoutPanel.Visible = false;
            CloseBookDetails();
        }

        private void NewBookButton_Click(object sender, EventArgs e)
        {
            sectionLabel.Text = "Add New Book";
            homePanel.Visible = false;
            booksPanel.Visible = false;
            searchPanel.Visible = false;
            accountPanel.Visible = false;
            footerPanel.Visible = false;
            BookDetailsFlowLayoutPanel.Visible = false;
            BookEditorFlowLayoutPanel.Visible = true;
            BackPictureButton.Visible = true;
            BookEditorFlowLayoutPanel.Controls.Clear();
            _bookEditor = new BookEditor(this);
            BookEditorFlowLayoutPanel.Controls.Add(_bookEditor);


        }


        internal void BackPictureButton_Click(object sender, EventArgs e)
        {
            PopulateBooksUI();
            sectionLabel.Text = "Books";
            homePanel.Visible = false;
            booksPanel.Visible = true;
            searchPanel.Visible = false;
            accountPanel.Visible = false;
            footerPanel.Visible = true;
            BookDetailsFlowLayoutPanel.Visible = false;
            BookEditorFlowLayoutPanel.Visible = false;
            BackPictureButton.Visible = false;
            CloseBookEditor();
            if (backFromEdit)
            {
                OpenBookDetails(Book);
                backFromEdit = false;
            }
            else
            {
                CloseBookDetails();
            }


        }


        public Book OpenBookDetails(Book book)
        {
            CloseBookEditor();
            sectionLabel.Text = book.Author;
            BookDetailsFlowLayoutPanel.Controls.Clear();
            BookDetailsFlowLayoutPanel.Visible = true;
            homePanel.Visible = false;
            booksPanel.Visible = false;
            searchPanel.Visible = false;
            accountPanel.Visible = false;
            BackPictureButton.Visible = true;
            _bookDetails = new BookDetails(this, book);
            BookDetailsFlowLayoutPanel.Controls.Add(_bookDetails);

            return book;
        }
        public void CloseBookDetails()
        {
            BookDetailsFlowLayoutPanel.Controls.Clear();
            BookDetailsFlowLayoutPanel.Visible = false;
            _bookDetails = null;
            Book = null;

        }

        public void DeleteBook(Book book, EventArgs e)
        {
            CloseBookDetails();
            PopulateBooksUI();
            Library.DeleteBook(book);
            BackPictureButton_Click(BackPictureButton, e);
        }

        public void MarkAs(Book book, string status, EventArgs e)
        {
            book.SetStatus(status);
            CloseBookDetails();
            OpenBookDetails(book);
            PopulateBooksUI();
        }

        public void CloseBookEditor()
        {
            BookEditorFlowLayoutPanel.Controls.Clear();
            BookEditorFlowLayoutPanel.Visible = false;
            _bookEditor = null;

        }

        public void EditBook(Book book)
        {
            CloseBookDetails();
            BookEditorFlowLayoutPanel.Visible = true;
            BookEditorFlowLayoutPanel.Controls.Clear();
            _bookEditor = new BookEditor(this, book);
            BookEditorFlowLayoutPanel.Controls.Add(_bookEditor);
            sectionLabel.Text = "Edit book";
            backFromEdit = true;
            Book = book;
        }



        private void SortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (SortComboBox.SelectedIndex)
            {
                case 0:
                    Library.Unsort();
                    PopulateBooksUI();
                    break;
                case 1:
                    Library.SortBy("title");
                    PopulateBooksUI();
                    break;
                case 2:
                    Library.SortBy("author");
                    PopulateBooksUI();
                    break;
                case 3:
                    Library.SortBy("status");
                    PopulateBooksUI();
                    break;
            }
        }
    }

}
