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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            footerPanel = new Panel();
            homeButton = new Button();
            searchButton = new Button();
            bookButton = new Button();
            userbutton = new Button();
            headerPanel = new Panel();
            pictureBox1 = new PictureBox();
            sectionLabel = new Label();
            homePanel = new Panel();
            homeFlowLayoutPanel = new FlowLayoutPanel();
            booksPanel = new Panel();
            button1 = new Button();
            label1 = new Label();
            comboBox1 = new ComboBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            accountPanel = new Panel();
            label3 = new Label();
            searchPanel = new Panel();
            label4 = new Label();
            notifyIcon1 = new NotifyIcon(components);
            footerPanel.SuspendLayout();
            headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            homePanel.SuspendLayout();
            booksPanel.SuspendLayout();
            accountPanel.SuspendLayout();
            searchPanel.SuspendLayout();
            SuspendLayout();
            // 
            // footerPanel
            // 
            footerPanel.BackColor = Color.FromArgb(221, 219, 255);
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
            headerPanel.BackColor = Color.FromArgb(221, 219, 255);
            headerPanel.Controls.Add(pictureBox1);
            headerPanel.Controls.Add(sectionLabel);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(384, 56);
            headerPanel.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(298, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(74, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // sectionLabel
            // 
            sectionLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            sectionLabel.Font = new Font("Microsoft Sans Serif", 16F);
            sectionLabel.Location = new Point(96, 17);
            sectionLabel.Name = "sectionLabel";
            sectionLabel.Size = new Size(170, 26);
            sectionLabel.TabIndex = 0;
            sectionLabel.Text = "Personal Library";
            sectionLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // homePanel
            // 
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
            homeFlowLayoutPanel.Size = new Size(360, 549);
            homeFlowLayoutPanel.TabIndex = 1;
            homeFlowLayoutPanel.WrapContents = false;
            // 
            // booksPanel
            // 
            booksPanel.Controls.Add(button1);
            booksPanel.Controls.Add(label1);
            booksPanel.Controls.Add(comboBox1);
            booksPanel.Controls.Add(flowLayoutPanel1);
            booksPanel.Dock = DockStyle.Fill;
            booksPanel.Location = new Point(0, 56);
            booksPanel.Name = "booksPanel";
            booksPanel.Size = new Size(384, 549);
            booksPanel.TabIndex = 3;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(221, 219, 255);
            button1.Location = new Point(298, 3);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(74, 61);
            button1.TabIndex = 4;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
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
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(12, 67);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(360, 482);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // accountPanel
            // 
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
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 661);
            Controls.Add(booksPanel);
            Controls.Add(homePanel);
            Controls.Add(accountPanel);
            Controls.Add(searchPanel);
            Controls.Add(headerPanel);
            Controls.Add(footerPanel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "MainWindow";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Personal Library";
            footerPanel.ResumeLayout(false);
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Button homeButton;
        private Button bookButton;
        private Button userbutton;
        private Button searchButton;
        private Panel headerPanel;
        private Label sectionLabel;
        private PictureBox pictureBox1;
        private Panel homePanel;
        private Panel booksPanel;
        private Panel accountPanel;
        private Panel searchPanel;
        private Label label4;
        private Label label3;
        private FlowLayoutPanel homeFlowLayoutPanel;
        private FlowLayoutPanel flowLayoutPanel1;
        private ComboBox comboBox1;
        private Label label1;
        private Button button1;
        private NotifyIcon notifyIcon1;
    }
}
