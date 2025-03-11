namespace PersonalLibraryApp
{
    partial class BookEditor
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
            Button SaveButton;
            WarningLabel = new Label();
            label2 = new Label();
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
            SaveButton = new Button();
            StatusLabel.SuspendLayout();
            SuspendLayout();
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.Black;
            SaveButton.FlatAppearance.BorderSize = 0;
            SaveButton.FlatStyle = FlatStyle.Flat;
            SaveButton.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaveButton.ForeColor = Color.White;
            SaveButton.Location = new Point(32, 515);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(320, 52);
            SaveButton.TabIndex = 51;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // WarningLabel
            // 
            WarningLabel.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            WarningLabel.ForeColor = Color.Red;
            WarningLabel.Location = new Point(32, 14);
            WarningLabel.Name = "WarningLabel";
            WarningLabel.Size = new Size(321, 18);
            WarningLabel.TabIndex = 53;
            WarningLabel.Text = "Warning message";
            WarningLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(32, 29);
            label2.Name = "label2";
            label2.Size = new Size(46, 18);
            label2.TabIndex = 43;
            label2.Text = "Title *";
            // 
            // TitleTextBox
            // 
            TitleTextBox.BackColor = Color.FromArgb(241, 241, 242);
            TitleTextBox.BorderStyle = BorderStyle.None;
            TitleTextBox.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitleTextBox.ForeColor = Color.FromArgb(68, 64, 80);
            TitleTextBox.HideSelection = false;
            TitleTextBox.Location = new Point(33, 53);
            TitleTextBox.Margin = new Padding(0);
            TitleTextBox.Name = "TitleTextBox";
            TitleTextBox.Size = new Size(320, 20);
            TitleTextBox.TabIndex = 39;
            // 
            // AuthorLabel
            // 
            AuthorLabel.AutoSize = true;
            AuthorLabel.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AuthorLabel.Location = new Point(32, 87);
            AuthorLabel.Name = "AuthorLabel";
            AuthorLabel.Size = new Size(61, 18);
            AuthorLabel.TabIndex = 40;
            AuthorLabel.Text = "Author *";
            // 
            // AuthorTextBox
            // 
            AuthorTextBox.BackColor = Color.FromArgb(241, 241, 242);
            AuthorTextBox.BorderStyle = BorderStyle.None;
            AuthorTextBox.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AuthorTextBox.ForeColor = Color.FromArgb(68, 64, 80);
            AuthorTextBox.HideSelection = false;
            AuthorTextBox.Location = new Point(33, 111);
            AuthorTextBox.Margin = new Padding(0);
            AuthorTextBox.Name = "AuthorTextBox";
            AuthorTextBox.Size = new Size(320, 20);
            AuthorTextBox.TabIndex = 41;
            // 
            // GenreLabel
            // 
            GenreLabel.AutoSize = true;
            GenreLabel.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GenreLabel.Location = new Point(32, 145);
            GenreLabel.Name = "GenreLabel";
            GenreLabel.Size = new Size(47, 18);
            GenreLabel.TabIndex = 46;
            GenreLabel.Text = "Genre";
            // 
            // GenreTextBox
            // 
            GenreTextBox.BackColor = Color.FromArgb(241, 241, 242);
            GenreTextBox.BorderStyle = BorderStyle.None;
            GenreTextBox.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GenreTextBox.ForeColor = Color.FromArgb(68, 64, 80);
            GenreTextBox.HideSelection = false;
            GenreTextBox.Location = new Point(33, 169);
            GenreTextBox.Margin = new Padding(0);
            GenreTextBox.Name = "GenreTextBox";
            GenreTextBox.Size = new Size(320, 20);
            GenreTextBox.TabIndex = 42;
            // 
            // PagesLabel
            // 
            PagesLabel.AutoSize = true;
            PagesLabel.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PagesLabel.Location = new Point(32, 205);
            PagesLabel.Name = "PagesLabel";
            PagesLabel.Size = new Size(54, 18);
            PagesLabel.TabIndex = 48;
            PagesLabel.Text = "Pages *";
            // 
            // PagesTextBox
            // 
            PagesTextBox.BackColor = Color.FromArgb(241, 241, 242);
            PagesTextBox.BorderStyle = BorderStyle.None;
            PagesTextBox.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PagesTextBox.ForeColor = Color.FromArgb(68, 64, 80);
            PagesTextBox.HideSelection = false;
            PagesTextBox.Location = new Point(33, 227);
            PagesTextBox.Margin = new Padding(0);
            PagesTextBox.Name = "PagesTextBox";
            PagesTextBox.Size = new Size(320, 20);
            PagesTextBox.TabIndex = 44;
            // 
            // IsbnLabel
            // 
            IsbnLabel.AutoSize = true;
            IsbnLabel.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IsbnLabel.Location = new Point(32, 263);
            IsbnLabel.Name = "IsbnLabel";
            IsbnLabel.Size = new Size(37, 18);
            IsbnLabel.TabIndex = 49;
            IsbnLabel.Text = "ISBN";
            // 
            // IsbnTextBox
            // 
            IsbnTextBox.BackColor = Color.FromArgb(241, 241, 242);
            IsbnTextBox.BorderStyle = BorderStyle.None;
            IsbnTextBox.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IsbnTextBox.ForeColor = Color.FromArgb(68, 64, 80);
            IsbnTextBox.HideSelection = false;
            IsbnTextBox.Location = new Point(33, 286);
            IsbnTextBox.Margin = new Padding(0);
            IsbnTextBox.Name = "IsbnTextBox";
            IsbnTextBox.Size = new Size(320, 20);
            IsbnTextBox.TabIndex = 45;
            // 
            // StatusLabel
            // 
            StatusLabel.Controls.Add(UnreadRadioButton);
            StatusLabel.Controls.Add(ReadingRadioButton);
            StatusLabel.Controls.Add(ReadRadioButton);
            StatusLabel.Font = new Font("Calibri", 11.25F, FontStyle.Bold);
            StatusLabel.Location = new Point(32, 321);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(321, 112);
            StatusLabel.TabIndex = 47;
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
            BookmarkLabel.Location = new Point(32, 448);
            BookmarkLabel.Name = "BookmarkLabel";
            BookmarkLabel.Size = new Size(212, 18);
            BookmarkLabel.TabIndex = 52;
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
            BookmarkTextBox.Location = new Point(33, 471);
            BookmarkTextBox.Margin = new Padding(0);
            BookmarkTextBox.Name = "BookmarkTextBox";
            BookmarkTextBox.Size = new Size(320, 20);
            BookmarkTextBox.TabIndex = 50;
            // 
            // BookEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(WarningLabel);
            Controls.Add(label2);
            Controls.Add(TitleTextBox);
            Controls.Add(AuthorLabel);
            Controls.Add(AuthorTextBox);
            Controls.Add(GenreLabel);
            Controls.Add(GenreTextBox);
            Controls.Add(PagesLabel);
            Controls.Add(PagesTextBox);
            Controls.Add(IsbnLabel);
            Controls.Add(IsbnTextBox);
            Controls.Add(StatusLabel);
            Controls.Add(BookmarkLabel);
            Controls.Add(BookmarkTextBox);
            Controls.Add(SaveButton);
            Margin = new Padding(0);
            Name = "BookEditor";
            Size = new Size(384, 605);
            StatusLabel.ResumeLayout(false);
            StatusLabel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label WarningLabel;
        private Label label2;
        private TextBox TitleTextBox;
        private Label AuthorLabel;
        private TextBox AuthorTextBox;
        private Label GenreLabel;
        private TextBox GenreTextBox;
        private Label PagesLabel;
        private TextBox PagesTextBox;
        private Label IsbnLabel;
        private TextBox IsbnTextBox;
        private GroupBox StatusLabel;
        private RadioButton UnreadRadioButton;
        private RadioButton ReadingRadioButton;
        private RadioButton ReadRadioButton;
        private Label BookmarkLabel;
        private TextBox BookmarkTextBox;
    }
}
