using PersonalLibraryApp.Backend;
using System.Windows.Forms;
using static System.Reflection.Metadata.BlobBuilder;

namespace PersonalLibraryApp
{
    public partial class MainWindow : Form
    {
        // These variables track the status and view states
        private string _status = string.Empty;
        private BookDetails _bookDetails = null;
        private BookEditor _bookEditor = null;
        public bool backFromEdit = false;
        private bool backFromSearch = false;
        private bool backFromHome = false;
        private Book Book;
        private List<Book> _bookList = null;
        private bool _oneTime_Notification = true;

        // Constructor to initialize the form components
        public MainWindow()
        {
            InitializeComponent();
        }

        // On form load, set default configurations
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            SortComboBox.SelectedIndex = 0;
            homeButton_Click(homeButton, e);
            PopulateBooksUI();
            notifyIcon1.ContextMenuStrip = contextMenu;
        }

        // Method to populate books in the UI for both home and books panels
        private void PopulateBooksUI()
        {
            homeFlowLayoutPanel.Controls.Clear();
            booksFlowLayoutPanel.Controls.Clear();

            // Add books with specific statuses to the home page
            foreach (Book item in Library.BooksList)
            {
                if (item.Status.ToLower() == "reading" || item.Status.ToLower() == "unread")
                {
                    BookCard bookCard = new BookCard(this, item);
                    homeFlowLayoutPanel.Controls.Add(bookCard);
                }
            }

            // Add books to the "Books" section
            foreach (Book item in Library.ReoderBookList)
            {
                BookRegistration bookRegistration = new BookRegistration(this, item);
                booksFlowLayoutPanel.Controls.Add(bookRegistration);
            }
        }

        // Method to handle clicking the home button
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
            backFromSearch = false;
            backFromHome = true;
            CloseBookDetails();
        }

        // Method to handle clicking the books button
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
            backFromSearch = false;
            backFromHome = false;
            CloseBookDetails();
        }

        // Method to handle clicking the search button
        internal void searchButton_Click(object sender, EventArgs e)
        {
            sectionLabel.Text = "Search";
            homePanel.Visible = false;
            booksPanel.Visible = false;
            searchPanel.Visible = true;
            accountPanel.Visible = false;
            BookEditorFlowLayoutPanel.Visible = false;
            BookDetailsFlowLayoutPanel.Visible = false;
            backFromSearch = true;
            backFromHome = false;
            CloseBookDetails();
        }

        // Method to handle clicking the user account button
        internal void userbutton_Click(object sender, EventArgs e)
        {
            sectionLabel.Text = "Account";
            homePanel.Visible = false;
            booksPanel.Visible = false;
            searchPanel.Visible = false;
            accountPanel.Visible = true;
            BookEditorFlowLayoutPanel.Visible = false;
            backFromSearch = false;
            backFromHome = false;
            CloseBookDetails();
        }

        // Method to handle clicking the new book button
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

        // Method to handle the back button click in various views
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
                if (backFromSearch) searchButton_Click(sender, e);
                if (backFromHome) homeButton_Click(sender, e);
            }

        }

        // Method to open the details of a book
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

        // Method to close the book details view
        public void CloseBookDetails()
        {
            BookDetailsFlowLayoutPanel.Controls.Clear();
            BookDetailsFlowLayoutPanel.Visible = false;
            _bookDetails = null;
            Book = null;
        }

        // Method to delete a book
        public void DeleteBook(Book book, EventArgs e)
        {
            CloseBookDetails();
            PopulateBooksUI();
            Library.DeleteBook(book);
            BackPictureButton_Click(BackPictureButton, e);
        }

        // Method to mark a book with a certain status (e.g., reading, unread)
        public void MarkAs(Book book, string status, EventArgs e)
        {
            book.SetStatus(status);
            CloseBookDetails();
            OpenBookDetails(book);
            PopulateBooksUI();
        }

        // Method to close the book editor view
        public void CloseBookEditor()
        {
            BookEditorFlowLayoutPanel.Controls.Clear();
            BookEditorFlowLayoutPanel.Visible = false;
            _bookEditor = null;
        }

        // Method to edit a book
        public void EditBook(Book book)
        {
            backFromEdit = true;
            CloseBookDetails();
            BookEditorFlowLayoutPanel.Visible = true;
            BookEditorFlowLayoutPanel.Controls.Clear();
            _bookEditor = new BookEditor(this, book);
            BookEditorFlowLayoutPanel.Controls.Add(_bookEditor);
            sectionLabel.Text = "Edit book";
            Book = book;
        }

        // Method to handle sorting books based on various criteria
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

        // Method to handle real-time search updates as text changes
        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            Library.SearchBooks(SearchTextBox.Text);
            searchFlowLayoutPanel.Controls.Clear();
            foreach (Book item in Library.SearchBookList)
            {
                BookRegistration bookRegistration = new BookRegistration(this, item);
                searchFlowLayoutPanel.Controls.Add(bookRegistration);
            }
        }

        // Method to handle form closing, saving settings and minimizing to system tray
        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                var WindowLocation = this.Location;
                Properties.Settings.Default.WindowLocation = WindowLocation;
            }

            Properties.Settings.Default.Save();

            e.Cancel = true;
            this.Hide();
            notifyIcon1.Visible = true;
            if (_oneTime_Notification)
            {
                notifyIcon1.ShowBalloonTip(3000, "Minimized application", "The application runs in the System Tray.", ToolTipIcon.Info);
                _oneTime_Notification = false;
            }
        }

        // Method to handle the loading of saved window location and settings
        private void MainWindow_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.WindowLocation != Point.Empty)
            {
                this.Location = Properties.Settings.Default.WindowLocation;
            }
            notifyIcon1.Visible = true;
        }

        // Method to handle the mouse click event on the system tray icon
        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        // Method to handle maximizing the application from the system tray
        private void maximizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        // Method to handle closing the application from the system tray menu
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Application.ExitThread();
            Environment.Exit(0);
        }

        // Method to clear the search results
        private void SearchClearButton_Click(object sender, EventArgs e)
        {
            Library.SearchBooks("");
            SearchTextBox.Text = "";
            searchFlowLayoutPanel.Controls.Clear();
        }
    }
}
