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
    public partial class BookCard : UserControl
    {

        public string TitleText { get => TitleLabel.Text; set => TitleLabel.Text = value; }
        public string AuthorText { get => AuthorLabel.Text; set => AuthorLabel.Text = value.ToUpper(); }
        public string BookmarkPage { get => BookmarkLabel.Text; set => BookmarkLabel.Text = "BOOKMARK: page " + value; }
        
        public string BookmarkPercent { 
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
    }
}
