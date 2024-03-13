namespace TMDbFormApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">True if managed resources should be disposed; otherwise, false.</param>
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblTitleOriginal = new Label();
            lblAverageScore = new Label();
            lblReleaseDate = new Label();
            txtFilmTitle = new TextBox();
            btnSearch = new Button();
            lblSimilar = new Label();
            listBoxSimilar = new ListBox();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            lblSynopsis = new Label();
            textBoxSynopsis = new TextBox();
            lblPopularity = new Label();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(7, 22);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(32, 15);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Title:";
            // 
            // lblTitleOriginal
            // 
            lblTitleOriginal.AutoSize = true;
            lblTitleOriginal.Location = new Point(7, 45);
            lblTitleOriginal.Margin = new Padding(4, 0, 4, 0);
            lblTitleOriginal.Name = "lblTitleOriginal";
            lblTitleOriginal.Size = new Size(80, 15);
            lblTitleOriginal.TabIndex = 1;
            lblTitleOriginal.Text = "Original Title: ";
            // 
            // lblAverageScore
            // 
            lblAverageScore.AutoSize = true;
            lblAverageScore.Location = new Point(7, 68);
            lblAverageScore.Margin = new Padding(4, 0, 4, 0);
            lblAverageScore.Name = "lblAverageScore";
            lblAverageScore.Size = new Size(88, 15);
            lblAverageScore.TabIndex = 2;
            lblAverageScore.Text = "Average Score: ";
            // 
            // lblReleaseDate
            // 
            lblReleaseDate.AutoSize = true;
            lblReleaseDate.Location = new Point(7, 91);
            lblReleaseDate.Margin = new Padding(4, 0, 4, 0);
            lblReleaseDate.Name = "lblReleaseDate";
            lblReleaseDate.Size = new Size(79, 15);
            lblReleaseDate.TabIndex = 3;
            lblReleaseDate.Text = "Release Date: ";
            // 
            // txtFilmTitle
            // 
            txtFilmTitle.Location = new Point(14, 36);
            txtFilmTitle.Margin = new Padding(4, 3, 4, 3);
            txtFilmTitle.Name = "txtFilmTitle";
            txtFilmTitle.Size = new Size(233, 23);
            txtFilmTitle.TabIndex = 5;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(254, 36);
            btnSearch.Margin = new Padding(4, 3, 4, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(71, 23);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // lblSimilar
            // 
            lblSimilar.AutoSize = true;
            lblSimilar.Location = new Point(2, 68);
            lblSimilar.Name = "lblSimilar";
            lblSimilar.Size = new Size(90, 15);
            lblSimilar.TabIndex = 9;
            lblSimilar.Text = "Similar Movies: ";
            // 
            // listBoxSimilar
            // 
            listBoxSimilar.FormattingEnabled = true;
            listBoxSimilar.ItemHeight = 15;
            listBoxSimilar.Location = new Point(19, 102);
            listBoxSimilar.Margin = new Padding(4, 3, 4, 3);
            listBoxSimilar.Name = "listBoxSimilar";
            listBoxSimilar.Size = new Size(317, 214);
            listBoxSimilar.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(339, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(182, 288);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblSynopsis);
            groupBox1.Controls.Add(textBoxSynopsis);
            groupBox1.Controls.Add(lblPopularity);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(lblTitle);
            groupBox1.Controls.Add(lblTitleOriginal);
            groupBox1.Controls.Add(lblAverageScore);
            groupBox1.Controls.Add(lblReleaseDate);
            groupBox1.Location = new Point(349, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(527, 310);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Movie Info";
            // 
            // lblSynopsis
            // 
            lblSynopsis.AutoSize = true;
            lblSynopsis.Location = new Point(6, 159);
            lblSynopsis.Name = "lblSynopsis";
            lblSynopsis.Size = new Size(53, 15);
            lblSynopsis.TabIndex = 11;
            lblSynopsis.Text = "Synopsis";
            // 
            // textBoxSynopsis
            // 
            textBoxSynopsis.BackColor = SystemColors.Control;
            textBoxSynopsis.Cursor = Cursors.IBeam;
            textBoxSynopsis.Location = new Point(6, 177);
            textBoxSynopsis.Multiline = true;
            textBoxSynopsis.Name = "textBoxSynopsis";
            textBoxSynopsis.Size = new Size(327, 127);
            textBoxSynopsis.TabIndex = 10;
            // 
            // lblPopularity
            // 
            lblPopularity.AutoSize = true;
            lblPopularity.Location = new Point(7, 115);
            lblPopularity.Name = "lblPopularity";
            lblPopularity.Size = new Size(64, 15);
            lblPopularity.TabIndex = 9;
            lblPopularity.Text = "Popularity:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblSimilar);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(331, 310);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Search Movies";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(888, 334);
            Controls.Add(groupBox1);
            Controls.Add(listBoxSimilar);
            Controls.Add(btnSearch);
            Controls.Add(txtFilmTitle);
            Controls.Add(groupBox2);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "TMDb Form API";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTitleOriginal;
        private System.Windows.Forms.Label lblAverageScore;
        private System.Windows.Forms.Label lblReleaseDate;
        private System.Windows.Forms.TextBox txtFilmTitle;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox listBoxSimilar;
        private PictureBox pictureBox1;
        private Label lblSimilar;
        private GroupBox groupBox1;
        private TextBox textBoxSynopsis;
        private Label lblPopularity;
        private Label lblSynopsis;
        private GroupBox groupBox2;
    }
}
