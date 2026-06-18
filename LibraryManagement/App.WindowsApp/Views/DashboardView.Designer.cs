namespace App.WindowsApp.Views
{
    partial class DashboardView
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblWelcome = new Label();
            btnRefresh = new Button();
            flpCards = new FlowLayoutPanel();
            pnlBooks = new Panel();
            lblBooksLabel = new Label();
            lblTotalBooks = new Label();
            pnlMembers = new Panel();
            lblMembersLabel = new Label();
            lblTotalMembers = new Label();
            pnlIssued = new Panel();
            lblIssuedLabel = new Label();
            lblTotalIssued = new Label();
            pnlReturned = new Panel();
            lblReturnedLabel = new Label();
            lblTotalReturned = new Label();
            pnlOverdue = new Panel();
            lblOverdueLabel = new Label();
            lblTotalOverdue = new Label();
            pnlAvailable = new Panel();
            lblAvailableLabel = new Label();
            lblAvailableBooks = new Label();
            pnlAnnouncements = new Panel();
            lblAnnouncementsHeader = new Label();
            lstAnnouncements = new ListBox();
            flpCards.SuspendLayout();
            pnlBooks.SuspendLayout();
            pnlMembers.SuspendLayout();
            pnlIssued.SuspendLayout();
            pnlReturned.SuspendLayout();
            pnlOverdue.SuspendLayout();
            pnlAvailable.SuspendLayout();
            pnlAnnouncements.SuspendLayout();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblWelcome.Location = new Point(18, 11);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(126, 30);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Dashboard";
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Image = Properties.Resources.refresh;
            btnRefresh.Location = new Point(770, 11);
            btnRefresh.Margin = new Padding(3, 2, 3, 2);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(80, 22);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Refresh";
            btnRefresh.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // flpCards
            // 
            flpCards.AutoScroll = true;
            flpCards.Controls.Add(pnlBooks);
            flpCards.Controls.Add(pnlMembers);
            flpCards.Controls.Add(pnlIssued);
            flpCards.Controls.Add(pnlReturned);
            flpCards.Controls.Add(pnlOverdue);
            flpCards.Controls.Add(pnlAvailable);
            flpCards.Location = new Point(18, 45);
            flpCards.Margin = new Padding(3, 2, 3, 2);
            flpCards.Name = "flpCards";
            flpCards.Size = new Size(578, 225);
            flpCards.TabIndex = 2;
            // 
            // pnlBooks
            // 
            pnlBooks.BackColor = Color.FromArgb(52, 152, 219);
            pnlBooks.Controls.Add(lblBooksLabel);
            pnlBooks.Controls.Add(lblTotalBooks);
            pnlBooks.Location = new Point(9, 8);
            pnlBooks.Margin = new Padding(9, 8, 9, 8);
            pnlBooks.Name = "pnlBooks";
            pnlBooks.Padding = new Padding(13, 11, 13, 11);
            pnlBooks.Size = new Size(162, 90);
            pnlBooks.TabIndex = 0;
            // 
            // lblBooksLabel
            // 
            lblBooksLabel.AutoSize = true;
            lblBooksLabel.Font = new Font("Segoe UI", 10F);
            lblBooksLabel.ForeColor = Color.White;
            lblBooksLabel.Location = new Point(26, 22);
            lblBooksLabel.Name = "lblBooksLabel";
            lblBooksLabel.Size = new Size(79, 19);
            lblBooksLabel.TabIndex = 0;
            lblBooksLabel.Text = "Total Books";
            // 
            // lblTotalBooks
            // 
            lblTotalBooks.AutoSize = true;
            lblTotalBooks.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblTotalBooks.ForeColor = Color.White;
            lblTotalBooks.Location = new Point(26, 49);
            lblTotalBooks.Name = "lblTotalBooks";
            lblTotalBooks.Size = new Size(44, 51);
            lblTotalBooks.TabIndex = 1;
            lblTotalBooks.Text = "0";
            // 
            // pnlMembers
            // 
            pnlMembers.BackColor = Color.FromArgb(46, 204, 113);
            pnlMembers.Controls.Add(lblMembersLabel);
            pnlMembers.Controls.Add(lblTotalMembers);
            pnlMembers.Location = new Point(189, 8);
            pnlMembers.Margin = new Padding(9, 8, 9, 8);
            pnlMembers.Name = "pnlMembers";
            pnlMembers.Padding = new Padding(13, 11, 13, 11);
            pnlMembers.Size = new Size(162, 90);
            pnlMembers.TabIndex = 1;
            // 
            // lblMembersLabel
            // 
            lblMembersLabel.AutoSize = true;
            lblMembersLabel.Font = new Font("Segoe UI", 10F);
            lblMembersLabel.ForeColor = Color.White;
            lblMembersLabel.Location = new Point(26, 22);
            lblMembersLabel.Name = "lblMembersLabel";
            lblMembersLabel.Size = new Size(100, 19);
            lblMembersLabel.TabIndex = 0;
            lblMembersLabel.Text = "Total Members";
            // 
            // lblTotalMembers
            // 
            lblTotalMembers.AutoSize = true;
            lblTotalMembers.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblTotalMembers.ForeColor = Color.White;
            lblTotalMembers.Location = new Point(26, 49);
            lblTotalMembers.Name = "lblTotalMembers";
            lblTotalMembers.Size = new Size(44, 51);
            lblTotalMembers.TabIndex = 1;
            lblTotalMembers.Text = "0";
            // 
            // pnlIssued
            // 
            pnlIssued.BackColor = Color.FromArgb(155, 89, 182);
            pnlIssued.Controls.Add(lblIssuedLabel);
            pnlIssued.Controls.Add(lblTotalIssued);
            pnlIssued.Location = new Point(369, 8);
            pnlIssued.Margin = new Padding(9, 8, 9, 8);
            pnlIssued.Name = "pnlIssued";
            pnlIssued.Padding = new Padding(13, 11, 13, 11);
            pnlIssued.Size = new Size(162, 90);
            pnlIssued.TabIndex = 2;
            // 
            // lblIssuedLabel
            // 
            lblIssuedLabel.AutoSize = true;
            lblIssuedLabel.Font = new Font("Segoe UI", 10F);
            lblIssuedLabel.ForeColor = Color.White;
            lblIssuedLabel.Location = new Point(26, 22);
            lblIssuedLabel.Name = "lblIssuedLabel";
            lblIssuedLabel.Size = new Size(89, 19);
            lblIssuedLabel.TabIndex = 0;
            lblIssuedLabel.Text = "Books Issued";
            // 
            // lblTotalIssued
            // 
            lblTotalIssued.AutoSize = true;
            lblTotalIssued.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblTotalIssued.ForeColor = Color.White;
            lblTotalIssued.Location = new Point(26, 49);
            lblTotalIssued.Name = "lblTotalIssued";
            lblTotalIssued.Size = new Size(44, 51);
            lblTotalIssued.TabIndex = 1;
            lblTotalIssued.Text = "0";
            // 
            // pnlReturned
            // 
            pnlReturned.BackColor = Color.FromArgb(52, 73, 94);
            pnlReturned.Controls.Add(lblReturnedLabel);
            pnlReturned.Controls.Add(lblTotalReturned);
            pnlReturned.Location = new Point(9, 114);
            pnlReturned.Margin = new Padding(9, 8, 9, 8);
            pnlReturned.Name = "pnlReturned";
            pnlReturned.Padding = new Padding(13, 11, 13, 11);
            pnlReturned.Size = new Size(162, 90);
            pnlReturned.TabIndex = 3;
            // 
            // lblReturnedLabel
            // 
            lblReturnedLabel.AutoSize = true;
            lblReturnedLabel.Font = new Font("Segoe UI", 10F);
            lblReturnedLabel.ForeColor = Color.White;
            lblReturnedLabel.Location = new Point(26, 22);
            lblReturnedLabel.Name = "lblReturnedLabel";
            lblReturnedLabel.Size = new Size(106, 19);
            lblReturnedLabel.TabIndex = 0;
            lblReturnedLabel.Text = "Books Returned";
            // 
            // lblTotalReturned
            // 
            lblTotalReturned.AutoSize = true;
            lblTotalReturned.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblTotalReturned.ForeColor = Color.White;
            lblTotalReturned.Location = new Point(26, 49);
            lblTotalReturned.Name = "lblTotalReturned";
            lblTotalReturned.Size = new Size(44, 51);
            lblTotalReturned.TabIndex = 1;
            lblTotalReturned.Text = "0";
            // 
            // pnlOverdue
            // 
            pnlOverdue.BackColor = Color.FromArgb(231, 76, 60);
            pnlOverdue.Controls.Add(lblOverdueLabel);
            pnlOverdue.Controls.Add(lblTotalOverdue);
            pnlOverdue.Location = new Point(189, 114);
            pnlOverdue.Margin = new Padding(9, 8, 9, 8);
            pnlOverdue.Name = "pnlOverdue";
            pnlOverdue.Padding = new Padding(13, 11, 13, 11);
            pnlOverdue.Size = new Size(162, 90);
            pnlOverdue.TabIndex = 4;
            // 
            // lblOverdueLabel
            // 
            lblOverdueLabel.AutoSize = true;
            lblOverdueLabel.Font = new Font("Segoe UI", 10F);
            lblOverdueLabel.ForeColor = Color.White;
            lblOverdueLabel.Location = new Point(26, 22);
            lblOverdueLabel.Name = "lblOverdueLabel";
            lblOverdueLabel.Size = new Size(62, 19);
            lblOverdueLabel.TabIndex = 0;
            lblOverdueLabel.Text = "Overdue";
            // 
            // lblTotalOverdue
            // 
            lblTotalOverdue.AutoSize = true;
            lblTotalOverdue.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblTotalOverdue.ForeColor = Color.White;
            lblTotalOverdue.Location = new Point(26, 49);
            lblTotalOverdue.Name = "lblTotalOverdue";
            lblTotalOverdue.Size = new Size(44, 51);
            lblTotalOverdue.TabIndex = 1;
            lblTotalOverdue.Text = "0";
            // 
            // pnlAvailable
            // 
            pnlAvailable.BackColor = Color.FromArgb(241, 196, 15);
            pnlAvailable.Controls.Add(lblAvailableLabel);
            pnlAvailable.Controls.Add(lblAvailableBooks);
            pnlAvailable.Location = new Point(369, 114);
            pnlAvailable.Margin = new Padding(9, 8, 9, 8);
            pnlAvailable.Name = "pnlAvailable";
            pnlAvailable.Padding = new Padding(13, 11, 13, 11);
            pnlAvailable.Size = new Size(162, 90);
            pnlAvailable.TabIndex = 5;
            // 
            // lblAvailableLabel
            // 
            lblAvailableLabel.AutoSize = true;
            lblAvailableLabel.Font = new Font("Segoe UI", 10F);
            lblAvailableLabel.ForeColor = Color.White;
            lblAvailableLabel.Location = new Point(26, 22);
            lblAvailableLabel.Name = "lblAvailableLabel";
            lblAvailableLabel.Size = new Size(104, 19);
            lblAvailableLabel.TabIndex = 0;
            lblAvailableLabel.Text = "Available Books";
            // 
            // lblAvailableBooks
            // 
            lblAvailableBooks.AutoSize = true;
            lblAvailableBooks.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblAvailableBooks.ForeColor = Color.White;
            lblAvailableBooks.Location = new Point(26, 49);
            lblAvailableBooks.Name = "lblAvailableBooks";
            lblAvailableBooks.Size = new Size(44, 51);
            lblAvailableBooks.TabIndex = 1;
            lblAvailableBooks.Text = "0";
            // 
            // pnlAnnouncements
            // 
            pnlAnnouncements.BackColor = Color.White;
            pnlAnnouncements.BorderStyle = BorderStyle.FixedSingle;
            pnlAnnouncements.Controls.Add(lblAnnouncementsHeader);
            pnlAnnouncements.Controls.Add(lstAnnouncements);
            pnlAnnouncements.Location = new Point(18, 281);
            pnlAnnouncements.Margin = new Padding(3, 2, 3, 2);
            pnlAnnouncements.Name = "pnlAnnouncements";
            pnlAnnouncements.Size = new Size(578, 166);
            pnlAnnouncements.TabIndex = 3;
            // 
            // lblAnnouncementsHeader
            // 
            lblAnnouncementsHeader.AutoSize = true;
            lblAnnouncementsHeader.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblAnnouncementsHeader.ForeColor = Color.FromArgb(52, 73, 94);
            lblAnnouncementsHeader.Location = new Point(9, 8);
            lblAnnouncementsHeader.Name = "lblAnnouncementsHeader";
            lblAnnouncementsHeader.Size = new Size(202, 20);
            lblAnnouncementsHeader.TabIndex = 0;
            lblAnnouncementsHeader.Text = "📢  Active Announcements";
            // 
            // lstAnnouncements
            // 
            lstAnnouncements.BorderStyle = BorderStyle.None;
            lstAnnouncements.Font = new Font("Segoe UI", 9.5F);
            lstAnnouncements.Location = new Point(9, 34);
            lstAnnouncements.Margin = new Padding(3, 2, 3, 2);
            lstAnnouncements.Name = "lstAnnouncements";
            lstAnnouncements.Size = new Size(556, 119);
            lstAnnouncements.TabIndex = 0;
            // 
            // DashboardView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(lblWelcome);
            Controls.Add(btnRefresh);
            Controls.Add(flpCards);
            Controls.Add(pnlAnnouncements);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(3, 2, 3, 2);
            Name = "DashboardView";
            Size = new Size(868, 535);
            Load += DashboardView_Load;
            flpCards.ResumeLayout(false);
            pnlBooks.ResumeLayout(false);
            pnlBooks.PerformLayout();
            pnlMembers.ResumeLayout(false);
            pnlMembers.PerformLayout();
            pnlIssued.ResumeLayout(false);
            pnlIssued.PerformLayout();
            pnlReturned.ResumeLayout(false);
            pnlReturned.PerformLayout();
            pnlOverdue.ResumeLayout(false);
            pnlOverdue.PerformLayout();
            pnlAvailable.ResumeLayout(false);
            pnlAvailable.PerformLayout();
            pnlAnnouncements.ResumeLayout(false);
            pnlAnnouncements.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblWelcome;
        private Button btnRefresh;
        private FlowLayoutPanel flpCards;
        private Panel pnlBooks, pnlMembers, pnlIssued, pnlReturned, pnlOverdue, pnlAvailable;
        private Label lblBooksLabel, lblTotalBooks;
        private Label lblMembersLabel, lblTotalMembers;
        private Label lblIssuedLabel, lblTotalIssued;
        private Label lblReturnedLabel, lblTotalReturned;
        private Label lblOverdueLabel, lblTotalOverdue;
        private Label lblAvailableLabel, lblAvailableBooks;
        private Panel pnlAnnouncements;
        private Label lblAnnouncementsHeader;
        private ListBox lstAnnouncements;
    }
}