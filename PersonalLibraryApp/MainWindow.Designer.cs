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
            SortComboBox = new ComboBox();
            booksFlowLayoutPanel = new FlowLayoutPanel();
            accountPanel = new Panel();
            label3 = new Label();
            searchPanel = new Panel();
            label4 = new Label();
            BookDetailsFlowLayoutPanel = new FlowLayoutPanel();
            BookEditorFlowLayoutPanel = new FlowLayoutPanel();
            footerPanel.SuspendLayout();
            headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BackPictureButton).BeginInit();
            homePanel.SuspendLayout();
            booksPanel.SuspendLayout();
            accountPanel.SuspendLayout();
            searchPanel.SuspendLayout();
            SuspendLayout();
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
            headerPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            headerPanel.BackColor = Color.FromArgb(115, 103, 240);
            headerPanel.Controls.Add(BackPictureButton);
            headerPanel.Controls.Add(sectionLabel);
            headerPanel.Location = new Point(0, 0);
            headerPanel.Margin = new Padding(0);
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
            sectionLabel.Location = new Point(107, 17);
            sectionLabel.Name = "sectionLabel";
            sectionLabel.Size = new Size(170, 26);
            sectionLabel.TabIndex = 0;
            sectionLabel.Text = "Personal Library";
            sectionLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // homePanel
            // 
            homePanel.Anchor = AnchorStyles.None;
            homePanel.BackColor = Color.White;
            homePanel.Controls.Add(homeFlowLayoutPanel);
            homePanel.Location = new Point(0, 56);
            homePanel.Margin = new Padding(0);
            homePanel.Name = "homePanel";
            homePanel.Size = new Size(384, 550);
            homePanel.TabIndex = 2;
            // 
            // homeFlowLayoutPanel
            // 
            homeFlowLayoutPanel.AutoScroll = true;
            homeFlowLayoutPanel.BackColor = Color.White;
            homeFlowLayoutPanel.Dock = DockStyle.Bottom;
            homeFlowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            homeFlowLayoutPanel.Location = new Point(0, 0);
            homeFlowLayoutPanel.Margin = new Padding(0);
            homeFlowLayoutPanel.Name = "homeFlowLayoutPanel";
            homeFlowLayoutPanel.Size = new Size(384, 550);
            homeFlowLayoutPanel.TabIndex = 1;
            homeFlowLayoutPanel.WrapContents = false;
            // 
            // booksPanel
            // 
            booksPanel.Anchor = AnchorStyles.None;
            booksPanel.BackColor = Color.White;
            booksPanel.Controls.Add(NewBookButton);
            booksPanel.Controls.Add(label1);
            booksPanel.Controls.Add(SortComboBox);
            booksPanel.Controls.Add(booksFlowLayoutPanel);
            booksPanel.Location = new Point(0, 56);
            booksPanel.Margin = new Padding(0);
            booksPanel.Name = "booksPanel";
            booksPanel.Size = new Size(384, 550);
            booksPanel.TabIndex = 3;
            // 
            // NewBookButton
            // 
            NewBookButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            NewBookButton.FlatAppearance.BorderSize = 0;
            NewBookButton.FlatStyle = FlatStyle.Flat;
            NewBookButton.Image = (Image)resources.GetObject("NewBookButton.Image");
            NewBookButton.Location = new Point(345, 10);
            NewBookButton.Margin = new Padding(0);
            NewBookButton.Name = "NewBookButton";
            NewBookButton.Size = new Size(30, 30);
            NewBookButton.TabIndex = 6;
            NewBookButton.UseVisualStyleBackColor = true;
            NewBookButton.Click += NewBookButton_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 3;
            label1.Text = "Sort by";
            // 
            // SortComboBox
            // 
            SortComboBox.Anchor = AnchorStyles.None;
            SortComboBox.FlatStyle = FlatStyle.Flat;
            SortComboBox.FormattingEnabled = true;
            SortComboBox.Items.AddRange(new object[] { "Default", "Title", "Author", "Status" });
            SortComboBox.Location = new Point(60, 14);
            SortComboBox.Name = "SortComboBox";
            SortComboBox.Size = new Size(104, 23);
            SortComboBox.TabIndex = 2;
            SortComboBox.SelectedIndexChanged += SortComboBox_SelectedIndexChanged;
            // 
            // booksFlowLayoutPanel
            // 
            booksFlowLayoutPanel.AutoScroll = true;
            booksFlowLayoutPanel.BackColor = Color.White;
            booksFlowLayoutPanel.Dock = DockStyle.Bottom;
            booksFlowLayoutPanel.Location = new Point(0, 50);
            booksFlowLayoutPanel.Margin = new Padding(0);
            booksFlowLayoutPanel.Name = "booksFlowLayoutPanel";
            booksFlowLayoutPanel.Size = new Size(384, 500);
            booksFlowLayoutPanel.TabIndex = 1;
            // 
            // accountPanel
            // 
            accountPanel.BackColor = Color.White;
            accountPanel.Controls.Add(label3);
            accountPanel.Dock = DockStyle.Fill;
            accountPanel.Location = new Point(0, 0);
            accountPanel.Name = "accountPanel";
            accountPanel.Size = new Size(384, 661);
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
            searchPanel.Location = new Point(0, 0);
            searchPanel.Name = "searchPanel";
            searchPanel.Size = new Size(384, 661);
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
            // BookDetailsFlowLayoutPanel
            // 
            BookDetailsFlowLayoutPanel.BackColor = Color.White;
            BookDetailsFlowLayoutPanel.Location = new Point(0, 56);
            BookDetailsFlowLayoutPanel.Margin = new Padding(0);
            BookDetailsFlowLayoutPanel.Name = "BookDetailsFlowLayoutPanel";
            BookDetailsFlowLayoutPanel.Size = new Size(384, 549);
            BookDetailsFlowLayoutPanel.TabIndex = 7;
            BookDetailsFlowLayoutPanel.Visible = false;
            // 
            // BookEditorFlowLayoutPanel
            // 
            BookEditorFlowLayoutPanel.BackColor = Color.White;
            BookEditorFlowLayoutPanel.Location = new Point(0, 56);
            BookEditorFlowLayoutPanel.Margin = new Padding(0);
            BookEditorFlowLayoutPanel.Name = "BookEditorFlowLayoutPanel";
            BookEditorFlowLayoutPanel.Size = new Size(384, 605);
            BookEditorFlowLayoutPanel.TabIndex = 0;
            BookEditorFlowLayoutPanel.Visible = false;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 661);
            Controls.Add(booksPanel);
            Controls.Add(BookEditorFlowLayoutPanel);
            Controls.Add(homePanel);
            Controls.Add(headerPanel);
            Controls.Add(footerPanel);
            Controls.Add(accountPanel);
            Controls.Add(searchPanel);
            Controls.Add(BookDetailsFlowLayoutPanel);
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
            accountPanel.ResumeLayout(false);
            accountPanel.PerformLayout();
            searchPanel.ResumeLayout(false);
            searchPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel footerPanel;
        internal Button homeButton;
        internal Button bookButton;
        internal Button userbutton;
        internal Button searchButton;
        private Panel headerPanel;
        internal Label sectionLabel;
        private Panel homePanel;
        private Panel booksPanel;
        private Panel accountPanel;
        private Panel searchPanel;
        private Label label4;
        private Label label3;
        private FlowLayoutPanel homeFlowLayoutPanel;
        private FlowLayoutPanel booksFlowLayoutPanel;
        private ComboBox SortComboBox;
        private Label label1;
        private Button NewBookButton;
        internal PictureBox BackPictureButton;
        private FlowLayoutPanel BookDetailsFlowLayoutPanel;
        private FlowLayoutPanel BookEditorFlowLayoutPanel;
    }
}
