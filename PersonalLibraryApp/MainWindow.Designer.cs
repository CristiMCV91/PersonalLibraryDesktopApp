namespace PersonalLibraryApp
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Button SaveButton;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            footerPanel = new Panel();
            homeButton = new Button();
            searchButton = new Button();
            bookButton = new Button();
            userbutton = new Button();
            headerPanel = new Panel();
            BackPictureButton = new PictureBox();
            sectionLabel = new Label();
            homePanel = new Panel();
            homeFlowLayoutPanel = new FlowLayoutPanel();
            booksPanel = new Panel();
            NewBookButton = new Button();
            label1 = new Label();
            comboBox1 = new ComboBox();
            booksFlowLayoutPanel = new FlowLayoutPanel();
            AddNewBookPanel = new Panel();
            WarningLabel = new Label();
            TitleLabel = new Label();
            TitleTextBox = new TextBox();
            AuthorLabel = new Label();
            AuthorTextBox = new TextBox();
            GenreLabel = new Label();
            GenreTextBox = new TextBox();
            PagesLabel = new Label();
            PagesTextBox = new TextBox();
            IsbnLabel = new Label();
            IsbnTextBox = new TextBox();
            StatusLabel = new GroupBox();
            UnreadRadioButton = new RadioButton();
            ReadingRadioButton = new RadioButton();
            ReadRadioButton = new RadioButton();
            BookmarkLabel = new Label();
            BookmarkTextBox = new TextBox();
            accountPanel = new Panel();
            label3 = new Label();
            searchPanel = new Panel();
            label4 = new Label();
            SaveButton = new Button();
            footerPanel.SuspendLayout();
            headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BackPictureButton).BeginInit();
            homePanel.SuspendLayout();
            booksPanel.SuspendLayout();
            AddNewBookPanel.SuspendLayout();
            StatusLabel.SuspendLayout();
            accountPanel.SuspendLayout();
            searchPanel.SuspendLayout();
            SuspendLayout();
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.Black;
            SaveButton.FlatAppearance.BorderSize = 0;
            SaveButton.FlatStyle = FlatStyle.Flat;
            SaveButton.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaveButton.ForeColor = Color.White;
            SaveButton.Location = new Point(32, 521);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(320, 52);
            SaveButton.TabIndex = 11;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // footerPanel
            // 
            footerPanel.BackColor = Color.FromArgb(115, 103, 240);
            footerPanel.Controls.Add(homeButton);
            footerPanel.Controls.Add(searchButton);
            footerPanel.Controls.Add(bookButton);
            footerPanel.Controls.Add(userbutton);
            footerPanel.Dock = DockStyle.Bottom;
            footerPanel.Location = new Point(0, 605);
            footerPanel.Name = "footerPanel";
            footerPanel.Size = new Size(384, 56);
            footerPanel.TabIndex = 0;
            // 
            // homeButton
            // 
            homeButton.Dock = DockStyle.Left;
            homeButton.FlatAppearance.BorderSize = 0;
            homeButton.FlatStyle = FlatStyle.Flat;
            homeButton.Image = (Image)resources.GetObject("homeButton.Image");
            homeButton.Location = new Point(0, 0);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(96, 56);
            homeButton.TabIndex = 0;
            homeButton.UseVisualStyleBackColor = true;
            homeButton.Click += homeButton_Click;
            // 
            // searchButton
            // 
            searchButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            searchButton.FlatAppearance.BorderSize = 0;
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.Image = (Image)resources.GetObject("searchButton.Image");
            searchButton.Location = new Point(192, 0);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(96, 56);
            searchButton.TabIndex = 2;
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // bookButton
            // 
            bookButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            bookButton.FlatAppearance.BorderSize = 0;
            bookButton.FlatStyle = FlatStyle.Flat;
            bookButton.Image = (Image)resources.GetObject("bookButton.Image");
            bookButton.Location = new Point(96, 0);
            bookButton.Name = "bookButton";
            bookButton.Size = new Size(96, 56);
            bookButton.TabIndex = 1;
            bookButton.UseVisualStyleBackColor = true;
            bookButton.Click += bookButton_Click;
            // 
            // userbutton
            // 
            userbutton.Dock = DockStyle.Right;
            userbutton.FlatAppearance.BorderSize = 0;
            userbutton.FlatStyle = FlatStyle.Flat;
            userbutton.Image = (Image)resources.GetObject("userbutton.Image");
            userbutton.Location = new Point(288, 0);
            userbutton.Name = "userbutton";
            userbutton.Size = new Size(96, 56);
            userbutton.TabIndex = 3;
            userbutton.UseVisualStyleBackColor = true;
            userbutton.Click += userbutton_Click;
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(115, 103, 240);
            headerPanel.Controls.Add(BackPictureButton);
            headerPanel.Controls.Add(sectionLabel);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(384, 56);
            headerPanel.TabIndex = 1;
            // 
            // BackPictureButton
            // 
            BackPictureButton.Image = (Image)resources.GetObject("BackPictureButton.Image");
            BackPictureButton.Location = new Point(12, 17);
            BackPictureButton.Margin = new Padding(0);
            BackPictureButton.Name = "BackPictureButton";
            BackPictureButton.Size = new Size(30, 30);
            BackPictureButton.SizeMode = PictureBoxSizeMode.StretchImage;
            BackPictureButton.TabIndex = 7;
            BackPictureButton.TabStop = false;
            BackPictureButton.Visible = false;
            BackPictureButton.Click += BackPictureButton_Click;
            // 
            // sectionLabel
            // 
            sectionLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            sectionLabel.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sectionLabel.ForeColor = Color.White;
            sectionLabel.Location = new Point(96, 17);
            sectionLabel.Name = "sectionLabel";
            sectionLabel.Size = new Size(170, 26);
            sectionLabel.TabIndex = 0;
            sectionLabel.Text = "Personal Library";
            sectionLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // homePanel
            // 
            homePanel.BackColor = Color.White;
            homePanel.Controls.Add(homeFlowLayoutPanel);
            homePanel.Dock = DockStyle.Fill;
            homePanel.Location = new Point(0, 56);
            homePanel.Name = "homePanel";
            homePanel.Size = new Size(384, 549);
            homePanel.TabIndex = 2;
            // 
            // homeFlowLayoutPanel
            // 
            homeFlowLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            homeFlowLayoutPanel.AutoScroll = true;
            homeFlowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            homeFlowLayoutPanel.Location = new Point(12, 0);
            homeFlowLayoutPanel.Name = "homeFlowLayoutPanel";
            homeFlowLayoutPanel.Size = new Size(372, 549);
            homeFlowLayoutPanel.TabIndex = 1;
            homeFlowLayoutPanel.WrapContents = false;
            // 
            // booksPanel
            // 
            booksPanel.BackColor = Color.White;
            booksPanel.Controls.Add(NewBookButton);
            booksPanel.Controls.Add(label1);
            booksPanel.Controls.Add(comboBox1);
            booksPanel.Controls.Add(booksFlowLayoutPanel);
            booksPanel.Dock = DockStyle.Fill;
            booksPanel.Location = new Point(0, 56);
            booksPanel.Name = "booksPanel";
            booksPanel.Size = new Size(384, 549);
            booksPanel.TabIndex = 3;
            // 
            // NewBookButton
            // 
            NewBookButton.FlatAppearance.BorderSize = 0;
            NewBookButton.FlatStyle = FlatStyle.Flat;
            NewBookButton.Image = (Image)resources.GetObject("NewBookButton.Image");
            NewBookButton.Location = new Point(342, 15);
            NewBookButton.Margin = new Padding(0);
            NewBookButton.Name = "NewBookButton";
            NewBookButton.Size = new Size(30, 30);
            NewBookButton.TabIndex = 6;
            NewBookButton.UseVisualStyleBackColor = true;
            NewBookButton.Click += NewBookButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 3;
            label1.Text = "Sort by";
            // 
            // comboBox1
            // 
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Author", "Status" });
            comboBox1.Location = new Point(62, 20);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(78, 23);
            comboBox1.TabIndex = 2;
            comboBox1.Text = "Sort by";
            // 
            // booksFlowLayoutPanel
            // 
            booksFlowLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            booksFlowLayoutPanel.AutoScroll = true;
            booksFlowLayoutPanel.Location = new Point(12, 59);
            booksFlowLayoutPanel.Name = "booksFlowLayoutPanel";
            booksFlowLayoutPanel.Size = new Size(372, 549);
            booksFlowLayoutPanel.TabIndex = 1;
            // 
            // AddNewBookPanel
            // 
            AddNewBookPanel.BackColor = Color.White;
            AddNewBookPanel.Controls.Add(WarningLabel);
            AddNewBookPanel.Controls.Add(TitleLabel);
            AddNewBookPanel.Controls.Add(TitleTextBox);
            AddNewBookPanel.Controls.Add(AuthorLabel);
            AddNewBookPanel.Controls.Add(AuthorTextBox);
            AddNewBookPanel.Controls.Add(GenreLabel);
            AddNewBookPanel.Controls.Add(GenreTextBox);
            AddNewBookPanel.Controls.Add(PagesLabel);
            AddNewBookPanel.Controls.Add(PagesTextBox);
            AddNewBookPanel.Controls.Add(IsbnLabel);
            AddNewBookPanel.Controls.Add(IsbnTextBox);
            AddNewBookPanel.Controls.Add(StatusLabel);
            AddNewBookPanel.Controls.Add(BookmarkLabel);
            AddNewBookPanel.Controls.Add(BookmarkTextBox);
            AddNewBookPanel.Controls.Add(SaveButton);
            AddNewBookPanel.ForeColor = Color.FromArgb(68, 64, 80);
            AddNewBookPanel.Location = new Point(0, 56);
            AddNewBookPanel.Margin = new Padding(0);
            AddNewBookPanel.Name = "AddNewBookPanel";
            AddNewBookPanel.Size = new Size(384, 605);
            AddNewBookPanel.TabIndex = 7;
            AddNewBookPanel.Tag = "";
            // 
            // WarningLabel
            // 
            WarningLabel.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            WarningLabel.ForeColor = Color.Red;
            WarningLabel.Location = new Point(32, 20);
            WarningLabel.Name = "WarningLabel";
            WarningLabel.Size = new Size(321, 18);
            WarningLabel.TabIndex = 19;
            WarningLabel.Text = "Warning messages";
            WarningLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitleLabel.Location = new Point(32, 35);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(46, 18);
            TitleLabel.TabIndex = 4;
            TitleLabel.Text = "Title *";
            // 
            // TitleTextBox
            // 
            TitleTextBox.BackColor = Color.FromArgb(241, 241, 242);
            TitleTextBox.BorderStyle = BorderStyle.None;
            TitleTextBox.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitleTextBox.ForeColor = Color.FromArgb(68, 64, 80);
            TitleTextBox.HideSelection = false;
            TitleTextBox.Location = new Point(33, 59);
            TitleTextBox.Margin = new Padding(0);
            TitleTextBox.Name = "TitleTextBox";
            TitleTextBox.Size = new Size(320, 20);
            TitleTextBox.TabIndex = 1;
            // 
            // AuthorLabel
            // 
            AuthorLabel.AutoSize = true;
            AuthorLabel.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AuthorLabel.Location = new Point(32, 93);
            AuthorLabel.Name = "AuthorLabel";
            AuthorLabel.Size = new Size(61, 18);
            AuthorLabel.TabIndex = 2;
            AuthorLabel.Text = "Author *";
            // 
            // AuthorTextBox
            // 
            AuthorTextBox.BackColor = Color.FromArgb(241, 241, 242);
            AuthorTextBox.BorderStyle = BorderStyle.None;
            AuthorTextBox.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AuthorTextBox.ForeColor = Color.FromArgb(68, 64, 80);
            AuthorTextBox.HideSelection = false;
            AuthorTextBox.Location = new Point(33, 117);
            AuthorTextBox.Margin = new Padding(0);
            AuthorTextBox.Name = "AuthorTextBox";
            AuthorTextBox.Size = new Size(320, 20);
            AuthorTextBox.TabIndex = 2;
            // 
            // GenreLabel
            // 
            GenreLabel.AutoSize = true;
            GenreLabel.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GenreLabel.Location = new Point(32, 151);
            GenreLabel.Name = "GenreLabel";
            GenreLabel.Size = new Size(47, 18);
            GenreLabel.TabIndex = 6;
            GenreLabel.Text = "Genre";
            // 
            // GenreTextBox
            // 
            GenreTextBox.BackColor = Color.FromArgb(241, 241, 242);
            GenreTextBox.BorderStyle = BorderStyle.None;
            GenreTextBox.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GenreTextBox.ForeColor = Color.FromArgb(68, 64, 80);
            GenreTextBox.HideSelection = false;
            GenreTextBox.Location = new Point(33, 175);
            GenreTextBox.Margin = new Padding(0);
            GenreTextBox.Name = "GenreTextBox";
            GenreTextBox.Size = new Size(320, 20);
            GenreTextBox.TabIndex = 3;
            // 
            // PagesLabel
            // 
            PagesLabel.AutoSize = true;
            PagesLabel.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PagesLabel.Location = new Point(32, 211);
            PagesLabel.Name = "PagesLabel";
            PagesLabel.Size = new Size(54, 18);
            PagesLabel.TabIndex = 8;
            PagesLabel.Text = "Pages *";
            // 
            // PagesTextBox
            // 
            PagesTextBox.BackColor = Color.FromArgb(241, 241, 242);
            PagesTextBox.BorderStyle = BorderStyle.None;
            PagesTextBox.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PagesTextBox.ForeColor = Color.FromArgb(68, 64, 80);
            PagesTextBox.HideSelection = false;
            PagesTextBox.Location = new Point(33, 233);
            PagesTextBox.Margin = new Padding(0);
            PagesTextBox.Name = "PagesTextBox";
            PagesTextBox.Size = new Size(320, 20);
            PagesTextBox.TabIndex = 4;
            // 
            // IsbnLabel
            // 
            IsbnLabel.AutoSize = true;
            IsbnLabel.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IsbnLabel.Location = new Point(32, 269);
            IsbnLabel.Name = "IsbnLabel";
            IsbnLabel.Size = new Size(37, 18);
            IsbnLabel.TabIndex = 10;
            IsbnLabel.Text = "ISBN";
            // 
            // IsbnTextBox
            // 
            IsbnTextBox.BackColor = Color.FromArgb(241, 241, 242);
            IsbnTextBox.BorderStyle = BorderStyle.None;
            IsbnTextBox.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IsbnTextBox.ForeColor = Color.FromArgb(68, 64, 80);
            IsbnTextBox.HideSelection = false;
            IsbnTextBox.Location = new Point(33, 292);
            IsbnTextBox.Margin = new Padding(0);
            IsbnTextBox.Name = "IsbnTextBox";
            IsbnTextBox.Size = new Size(320, 20);
            IsbnTextBox.TabIndex = 5;
            // 
            // StatusLabel
            // 
            StatusLabel.Controls.Add(UnreadRadioButton);
            StatusLabel.Controls.Add(ReadingRadioButton);
            StatusLabel.Controls.Add(ReadRadioButton);
            StatusLabel.Font = new Font("Calibri", 11.25F, FontStyle.Bold);
            StatusLabel.Location = new Point(32, 327);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(321, 112);
            StatusLabel.TabIndex = 6;
            StatusLabel.TabStop = false;
            StatusLabel.Text = "Status *";
            // 
            // UnreadRadioButton
            // 
            UnreadRadioButton.AutoSize = true;
            UnreadRadioButton.Location = new Point(8, 25);
            UnreadRadioButton.Name = "UnreadRadioButton";
            UnreadRadioButton.Size = new Size(72, 22);
            UnreadRadioButton.TabIndex = 7;
            UnreadRadioButton.TabStop = true;
            UnreadRadioButton.Text = "Unread";
            UnreadRadioButton.UseVisualStyleBackColor = true;
            UnreadRadioButton.CheckedChanged += Status_IsChanged;
            // 
            // ReadingRadioButton
            // 
            ReadingRadioButton.AutoSize = true;
            ReadingRadioButton.Location = new Point(8, 53);
            ReadingRadioButton.Name = "ReadingRadioButton";
            ReadingRadioButton.Size = new Size(76, 22);
            ReadingRadioButton.TabIndex = 8;
            ReadingRadioButton.TabStop = true;
            ReadingRadioButton.Text = "Reading";
            ReadingRadioButton.UseVisualStyleBackColor = true;
            ReadingRadioButton.CheckedChanged += Status_IsChanged;
            // 
            // ReadRadioButton
            // 
            ReadRadioButton.AutoSize = true;
            ReadRadioButton.Location = new Point(8, 81);
            ReadRadioButton.Name = "ReadRadioButton";
            ReadRadioButton.Size = new Size(57, 22);
            ReadRadioButton.TabIndex = 9;
            ReadRadioButton.TabStop = true;
            ReadRadioButton.Text = "Read";
            ReadRadioButton.UseVisualStyleBackColor = true;
            ReadRadioButton.CheckedChanged += Status_IsChanged;
            // 
            // BookmarkLabel
            // 
            BookmarkLabel.AutoSize = true;
            BookmarkLabel.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BookmarkLabel.Location = new Point(32, 454);
            BookmarkLabel.Name = "BookmarkLabel";
            BookmarkLabel.Size = new Size(212, 18);
            BookmarkLabel.TabIndex = 16;
            BookmarkLabel.Text = "Bookmark (if Reading is checked)";
            // 
            // BookmarkTextBox
            // 
            BookmarkTextBox.BackColor = Color.FromArgb(241, 241, 242);
            BookmarkTextBox.BorderStyle = BorderStyle.None;
            BookmarkTextBox.Enabled = false;
            BookmarkTextBox.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BookmarkTextBox.ForeColor = Color.FromArgb(68, 64, 80);
            BookmarkTextBox.HideSelection = false;
            BookmarkTextBox.Location = new Point(33, 477);
            BookmarkTextBox.Margin = new Padding(0);
            BookmarkTextBox.Name = "BookmarkTextBox";
            BookmarkTextBox.Size = new Size(320, 20);
            BookmarkTextBox.TabIndex = 10;
            // 
            // accountPanel
            // 
            accountPanel.BackColor = Color.White;
            accountPanel.Controls.Add(label3);
            accountPanel.Dock = DockStyle.Fill;
            accountPanel.Location = new Point(0, 56);
            accountPanel.Name = "accountPanel";
            accountPanel.Size = new Size(384, 549);
            accountPanel.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(168, 131);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 0;
            label3.Text = "Account";
            // 
            // searchPanel
            // 
            searchPanel.BackColor = Color.White;
            searchPanel.Controls.Add(label4);
            searchPanel.Dock = DockStyle.Fill;
            searchPanel.Location = new Point(0, 56);
            searchPanel.Name = "searchPanel";
            searchPanel.Size = new Size(384, 549);
            searchPanel.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(168, 131);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 0;
            label4.Text = "Search";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 661);
            Controls.Add(AddNewBookPanel);
            Controls.Add(booksPanel);
            Controls.Add(homePanel);
            Controls.Add(searchPanel);
            Controls.Add(accountPanel);
            Controls.Add(headerPanel);
            Controls.Add(footerPanel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "MainWindow";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Personal Library";
            footerPanel.ResumeLayout(false);
            headerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BackPictureButton).EndInit();
            homePanel.ResumeLayout(false);
            booksPanel.ResumeLayout(false);
            booksPanel.PerformLayout();
            AddNewBookPanel.ResumeLayout(false);
            AddNewBookPanel.PerformLayout();
            StatusLabel.ResumeLayout(false);
            StatusLabel.PerformLayout();
            accountPanel.ResumeLayout(false);
            accountPanel.PerformLayout();
            searchPanel.ResumeLayout(false);
            searchPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel footerPanel;
        private Button homeButton;
        private Button bookButton;
        private Button userbutton;
        private Button searchButton;
        private Panel headerPanel;
        private Label sectionLabel;
        private Panel homePanel;
        private Panel booksPanel;
        private Panel accountPanel;
        private Panel searchPanel;
        private Label label4;
        private Label label3;
        private FlowLayoutPanel homeFlowLayoutPanel;
        private FlowLayoutPanel booksFlowLayoutPanel;
        private ComboBox comboBox1;
        private Label label1;
        private Button NewBookButton;
        private Panel AddNewBookPanel;
        private PictureBox BackPictureButton;
        private TextBox AuthorTextBox;
        private Label AuthorLabel;
        private TextBox TitleTextBox;
        private Label TitleLabel;
        private TextBox GenreTextBox;
        private Label GenreLabel;
        private TextBox PagesTextBox;
        private Label PagesLabel;
        private TextBox IsbnTextBox;
        private Label IsbnLabel;
        private GroupBox StatusLabel;
        private RadioButton ReadRadioButton;
        private RadioButton ReadingRadioButton;
        private RadioButton UnreadRadioButton;
        private Button SaveButton;
        private TextBox BookmarkTextBox;
        private Label BookmarkLabel;
        private Label WarningLabel;
    }
}
