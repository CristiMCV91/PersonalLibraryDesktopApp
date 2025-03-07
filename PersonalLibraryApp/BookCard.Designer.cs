namespace PersonalLibraryApp
{
    partial class BookCard
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookCard));
            BookCoverPictureBox = new PictureBox();
            TitleLabel = new Label();
            ReadingPercentLabel = new Label();
            AuthorLabel = new Label();
            ReadingProgressBar = new ProgressBar();
            BookmarkLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)BookCoverPictureBox).BeginInit();
            SuspendLayout();
            // 
            // BookCoverPictureBox
            // 
            BookCoverPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            BookCoverPictureBox.Image = (Image)resources.GetObject("BookCoverPictureBox.Image");
            BookCoverPictureBox.Location = new Point(233, 12);
            BookCoverPictureBox.Margin = new Padding(0);
            BookCoverPictureBox.Name = "BookCoverPictureBox";
            BookCoverPictureBox.Size = new Size(73, 103);
            BookCoverPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            BookCoverPictureBox.TabIndex = 0;
            BookCoverPictureBox.TabStop = false;
            // 
            // TitleLabel
            // 
            TitleLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            TitleLabel.Location = new Point(19, 11);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(200, 37);
            TitleLabel.TabIndex = 1;
            TitleLabel.Text = "Book Title";
            // 
            // ReadingPercentLabel
            // 
            ReadingPercentLabel.AutoSize = true;
            ReadingPercentLabel.Location = new Point(19, 93);
            ReadingPercentLabel.Name = "ReadingPercentLabel";
            ReadingPercentLabel.Size = new Size(29, 15);
            ReadingPercentLabel.TabIndex = 2;
            ReadingPercentLabel.Text = "50%";
            // 
            // AuthorLabel
            // 
            AuthorLabel.Location = new Point(19, 48);
            AuthorLabel.Name = "AuthorLabel";
            AuthorLabel.Size = new Size(200, 30);
            AuthorLabel.TabIndex = 3;
            AuthorLabel.Text = "BOOK AUTHOR";
            // 
            // ReadingProgressBar
            // 
            ReadingProgressBar.ForeColor = Color.DodgerBlue;
            ReadingProgressBar.Location = new Point(19, 111);
            ReadingProgressBar.Name = "ReadingProgressBar";
            ReadingProgressBar.Size = new Size(200, 4);
            ReadingProgressBar.TabIndex = 4;
            ReadingProgressBar.Value = 50;
            // 
            // BookmarkLabel
            // 
            BookmarkLabel.Location = new Point(19, 78);
            BookmarkLabel.Name = "BookmarkLabel";
            BookmarkLabel.Size = new Size(200, 15);
            BookmarkLabel.TabIndex = 5;
            BookmarkLabel.Text = "BOOKMARK: page 80";
            // 
            // BookCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(BookmarkLabel);
            Controls.Add(ReadingProgressBar);
            Controls.Add(AuthorLabel);
            Controls.Add(ReadingPercentLabel);
            Controls.Add(TitleLabel);
            Controls.Add(BookCoverPictureBox);
            Margin = new Padding(5, 10, 5, 10);
            Name = "BookCard";
            Size = new Size(320, 132);
            ((System.ComponentModel.ISupportInitialize)BookCoverPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox BookCoverPictureBox;
        private Label TitleLabel;
        private Label ReadingPercentLabel;
        private Label AuthorLabel;
        private ProgressBar ReadingProgressBar;
        private Label BookmarkLabel;
    }
}
