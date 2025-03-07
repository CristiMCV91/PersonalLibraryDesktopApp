namespace PersonalLibraryApp
{
    partial class BookRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookRegistration));
            TitleLabel = new Label();
            AuthorLabel = new Label();
            StatusLabel = new Label();
            DetailsButton = new Button();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // TitleLabel
            // 
            TitleLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            TitleLabel.Location = new Point(9, 7);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(328, 15);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "Neuroplasticitatea, Secretul longevitatii creierului";
            // 
            // AuthorLabel
            // 
            AuthorLabel.Location = new Point(9, 32);
            AuthorLabel.Name = "AuthorLabel";
            AuthorLabel.Size = new Size(253, 15);
            AuthorLabel.TabIndex = 1;
            AuthorLabel.Text = "LEON DANAILA";
            // 
            // StatusLabel
            // 
            StatusLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StatusLabel.ForeColor = SystemColors.ControlText;
            StatusLabel.Location = new Point(252, 32);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(56, 15);
            StatusLabel.TabIndex = 2;
            StatusLabel.Text = "Unread";
            StatusLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // DetailsButton
            // 
            DetailsButton.FlatAppearance.BorderSize = 0;
            DetailsButton.FlatStyle = FlatStyle.Flat;
            DetailsButton.Image = (Image)resources.GetObject("DetailsButton.Image");
            DetailsButton.Location = new Point(313, 28);
            DetailsButton.Name = "DetailsButton";
            DetailsButton.Size = new Size(23, 23);
            DetailsButton.TabIndex = 3;
            DetailsButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(209, 208, 212);
            panel1.Location = new Point(0, 59);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(345, 1);
            panel1.TabIndex = 4;
            // 
            // BookRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(DetailsButton);
            Controls.Add(StatusLabel);
            Controls.Add(AuthorLabel);
            Controls.Add(TitleLabel);
            Margin = new Padding(0);
            Name = "BookRegistration";
            Size = new Size(345, 60);
            ResumeLayout(false);
        }

        #endregion

        private Label TitleLabel;
        private Label AuthorLabel;
        private Label StatusLabel;
        private Button DetailsButton;
        private Panel panel1;
    }
}
