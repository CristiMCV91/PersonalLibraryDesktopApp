namespace PersonalLibraryApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            homeButton_Click(homeButton, e);
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            sectionLabel.Text = "Home";
            homePanel.Visible = true;
            booksPanel.Visible = false;
            searchPanel.Visible = false;
            accountPanel.Visible = false;

            BookCard Book = new BookCard();
            Book.TitleText = "Neuroplasticitatea, Secretul longevitatii Creierului";
            Book.AuthorText = "Leon Danaila";
            Book.BookmarkPage = "200";
            Book.BookmarkPercent = "50";
            Book.ReadingBar = 50;

            HomeflowLayoutPanel.Controls.Add(Book);

        }

        private void bookButton_Click(object sender, EventArgs e)
        {
            sectionLabel.Text = "Books";
            homePanel.Visible = false;
            booksPanel.Visible = true;
            searchPanel.Visible = false;
            accountPanel.Visible = false;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            sectionLabel.Text = "Search";
            homePanel.Visible = false;
            booksPanel.Visible = false;
            searchPanel.Visible = true;
            accountPanel.Visible = false;
        }

        private void userbutton_Click(object sender, EventArgs e)
        {
            sectionLabel.Text = "Account";
            homePanel.Visible = false;
            booksPanel.Visible = false;
            searchPanel.Visible = false;
            accountPanel.Visible = true;
        }
    }
}
