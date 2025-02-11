namespace PersonalLibraryApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            homeButton = new Button();
            bookButton = new Button();
            searchButton = new Button();
            userbutton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(221, 219, 255);
            panel1.Controls.Add(userbutton);
            panel1.Controls.Add(searchButton);
            panel1.Controls.Add(bookButton);
            panel1.Controls.Add(homeButton);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 603);
            panel1.Name = "panel1";
            panel1.Size = new Size(384, 58);
            panel1.TabIndex = 0;
            // 
            // homeButton
            // 
            homeButton.Dock = DockStyle.Left;
            homeButton.FlatAppearance.BorderSize = 0;
            homeButton.FlatStyle = FlatStyle.Flat;
            homeButton.Image = (Image)resources.GetObject("homeButton.Image");
            homeButton.Location = new Point(0, 0);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(96, 58);
            homeButton.TabIndex = 0;
            homeButton.UseVisualStyleBackColor = true;
            // 
            // bookButton
            // 
            bookButton.Dock = DockStyle.Left;
            bookButton.FlatAppearance.BorderSize = 0;
            bookButton.FlatStyle = FlatStyle.Flat;
            bookButton.Image = (Image)resources.GetObject("bookButton.Image");
            bookButton.Location = new Point(96, 0);
            bookButton.Name = "bookButton";
            bookButton.Size = new Size(96, 58);
            bookButton.TabIndex = 1;
            bookButton.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            searchButton.Dock = DockStyle.Left;
            searchButton.FlatAppearance.BorderSize = 0;
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.Image = (Image)resources.GetObject("searchButton.Image");
            searchButton.Location = new Point(192, 0);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(96, 58);
            searchButton.TabIndex = 2;
            searchButton.UseVisualStyleBackColor = true;
            // 
            // userbutton
            // 
            userbutton.Dock = DockStyle.Left;
            userbutton.FlatAppearance.BorderSize = 0;
            userbutton.FlatStyle = FlatStyle.Flat;
            userbutton.Image = (Image)resources.GetObject("userbutton.Image");
            userbutton.Location = new Point(288, 0);
            userbutton.Name = "userbutton";
            userbutton.Size = new Size(96, 58);
            userbutton.TabIndex = 3;
            userbutton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 661);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Personal Library";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button homeButton;
        private Button bookButton;
        private Button userbutton;
        private Button searchButton;
    }
}
