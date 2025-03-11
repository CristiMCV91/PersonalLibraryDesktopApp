namespace PersonalLibraryApp
{
    partial class BookDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookDetails));
            TitleLabel = new Label();
            BookCoverPicture = new PictureBox();
            MarkAs = new Button();
            EditButton = new Button();
            DeleteButton = new Button();
            BookmarkLabel = new Label();
            StatusLabel = new Label();
            IsbnLabel = new Label();
            PagesLabel = new Label();
            GenreLabel = new Label();
            AuthorLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)BookCoverPicture).BeginInit();
            SuspendLayout();
            // 
            // TitleLabel
            // 
            TitleLabel.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitleLabel.Location = new Point(56, 203);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(280, 53);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "Title";
            TitleLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // BookCoverPicture
            // 
            BookCoverPicture.Image = (Image)resources.GetObject("BookCoverPicture.Image");
            BookCoverPicture.Location = new Point(110, 25);
            BookCoverPicture.Name = "BookCoverPicture";
            BookCoverPicture.Size = new Size(160, 160);
            BookCoverPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            BookCoverPicture.TabIndex = 1;
            BookCoverPicture.TabStop = false;
            // 
            // MarkAs
            // 
            MarkAs.BackColor = Color.Black;
            MarkAs.FlatStyle = FlatStyle.Flat;
            MarkAs.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MarkAs.ForeColor = Color.White;
            MarkAs.Location = new Point(31, 423);
            MarkAs.Name = "MarkAs";
            MarkAs.Size = new Size(320, 40);
            MarkAs.TabIndex = 3;
            MarkAs.Text = "Mark as read";
            MarkAs.UseVisualStyleBackColor = false;
            MarkAs.Click += MarkAsButton_Click;
            // 
            // EditButton
            // 
            EditButton.BackColor = Color.Gainsboro;
            EditButton.FlatAppearance.BorderColor = Color.Gray;
            EditButton.FlatStyle = FlatStyle.Flat;
            EditButton.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EditButton.ForeColor = Color.Black;
            EditButton.Location = new Point(31, 481);
            EditButton.Margin = new Padding(0);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(130, 35);
            EditButton.TabIndex = 4;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = false;
            EditButton.Click += EditButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = Color.White;
            DeleteButton.FlatAppearance.BorderColor = Color.Red;
            DeleteButton.FlatStyle = FlatStyle.Flat;
            DeleteButton.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DeleteButton.ForeColor = Color.Black;
            DeleteButton.Location = new Point(221, 481);
            DeleteButton.Margin = new Padding(0);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(130, 35);
            DeleteButton.TabIndex = 5;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // BookmarkLabel
            // 
            BookmarkLabel.AutoSize = true;
            BookmarkLabel.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BookmarkLabel.ForeColor = Color.FromArgb(68, 64, 80);
            BookmarkLabel.Location = new Point(31, 377);
            BookmarkLabel.Name = "BookmarkLabel";
            BookmarkLabel.Size = new Size(120, 19);
            BookmarkLabel.TabIndex = 6;
            BookmarkLabel.Text = "Bookmark: pag. ";
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StatusLabel.ForeColor = Color.FromArgb(68, 64, 80);
            StatusLabel.Location = new Point(31, 357);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(60, 19);
            StatusLabel.TabIndex = 7;
            StatusLabel.Text = "Status: ";
            // 
            // IsbnLabel
            // 
            IsbnLabel.AutoSize = true;
            IsbnLabel.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IsbnLabel.ForeColor = Color.FromArgb(68, 64, 80);
            IsbnLabel.Location = new Point(31, 337);
            IsbnLabel.Name = "IsbnLabel";
            IsbnLabel.Size = new Size(49, 19);
            IsbnLabel.TabIndex = 8;
            IsbnLabel.Text = "ISBN: ";
            // 
            // PagesLabel
            // 
            PagesLabel.AutoSize = true;
            PagesLabel.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PagesLabel.ForeColor = Color.FromArgb(68, 64, 80);
            PagesLabel.Location = new Point(31, 317);
            PagesLabel.Name = "PagesLabel";
            PagesLabel.Size = new Size(56, 19);
            PagesLabel.TabIndex = 9;
            PagesLabel.Text = "Pages: ";
            // 
            // GenreLabel
            // 
            GenreLabel.AutoSize = true;
            GenreLabel.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GenreLabel.ForeColor = Color.FromArgb(68, 64, 80);
            GenreLabel.Location = new Point(31, 297);
            GenreLabel.Name = "GenreLabel";
            GenreLabel.Size = new Size(58, 19);
            GenreLabel.TabIndex = 10;
            GenreLabel.Text = "Genre: ";
            // 
            // AuthorLabel
            // 
            AuthorLabel.AutoSize = true;
            AuthorLabel.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AuthorLabel.ForeColor = Color.FromArgb(68, 64, 80);
            AuthorLabel.Location = new Point(31, 277);
            AuthorLabel.Name = "AuthorLabel";
            AuthorLabel.Size = new Size(66, 19);
            AuthorLabel.TabIndex = 11;
            AuthorLabel.Text = "Author: ";
            // 
            // BookDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(BookCoverPicture);
            Controls.Add(TitleLabel);
            Controls.Add(AuthorLabel);
            Controls.Add(GenreLabel);
            Controls.Add(PagesLabel);
            Controls.Add(IsbnLabel);
            Controls.Add(StatusLabel);
            Controls.Add(BookmarkLabel);
            Controls.Add(DeleteButton);
            Controls.Add(EditButton);
            Controls.Add(MarkAs);
            Name = "BookDetails";
            Size = new Size(380, 545);
            ((System.ComponentModel.ISupportInitialize)BookCoverPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TitleLabel;
        private PictureBox BookCoverPicture;
        private Button MarkAs;
        private Button EditButton;
        private Button DeleteButton;
        private Label BookmarkLabel;
        private Label StatusLabel;
        private Label IsbnLabel;
        private Label PagesLabel;
        private Label GenreLabel;
        private Label AuthorLabel;
    }
}
