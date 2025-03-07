using PersonalLibraryApp.Backend;

namespace PersonalLibraryApp
{
    public partial class MainWindow : Form
    {
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


        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    homeButton_Click(homeButton, e);
        //}

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
    }
}
