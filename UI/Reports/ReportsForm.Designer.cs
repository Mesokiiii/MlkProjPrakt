namespace Mb.UI.Reports
{
    partial class ReportsForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            lblTitle = new Label();
            pnlSidebar = new Panel();
            lblSidebarCaption = new Label();
            lstReports = new ListBox();
            pnlContent = new Panel();
            dgvReport = new DataGridView();
            pnlFooter = new Panel();
            btnHome = new Button();
            btnExport = new Button();
            btnGenerate = new Button();
            pnlHeader.SuspendLayout();
            pnlSidebar.SuspendLayout();
            pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
            pnlFooter.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(46, 74, 107);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1284, 80);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Light", 20F);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(36, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(108, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Отчёты";
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(237, 241, 246);
            pnlSidebar.Controls.Add(lstReports);
            pnlSidebar.Controls.Add(lblSidebarCaption);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Padding = new Padding(20, 20, 20, 20);
            pnlSidebar.Size = new Size(300, 610);
            pnlSidebar.TabIndex = 1;
            // 
            // lblSidebarCaption
            // 
            lblSidebarCaption.Dock = DockStyle.Top;
            lblSidebarCaption.Font = new Font("Segoe UI Semibold", 11F);
            lblSidebarCaption.ForeColor = Color.FromArgb(74, 85, 104);
            lblSidebarCaption.Location = new Point(20, 20);
            lblSidebarCaption.Name = "lblSidebarCaption";
            lblSidebarCaption.Size = new Size(260, 36);
            lblSidebarCaption.TabIndex = 0;
            lblSidebarCaption.Text = "Доступные отчёты";
            lblSidebarCaption.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lstReports
            // 
            lstReports.BorderStyle = BorderStyle.FixedSingle;
            lstReports.Dock = DockStyle.Fill;
            lstReports.Font = new Font("Segoe UI", 11F);
            lstReports.ForeColor = Color.FromArgb(44, 62, 80);
            lstReports.IntegralHeight = false;
            lstReports.ItemHeight = 30;
            lstReports.Items.AddRange(new object[] { "Врачи по отделениям", "Отделения по больницам", "Свободные места" });
            lstReports.Name = "lstReports";
            lstReports.Size = new Size(260, 534);
            lstReports.TabIndex = 1;
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.FromArgb(244, 246, 250);
            pnlContent.Controls.Add(dgvReport);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Name = "pnlContent";
            pnlContent.Padding = new Padding(28, 24, 28, 24);
            pnlContent.Size = new Size(984, 610);
            pnlContent.TabIndex = 2;
            // 
            // dgvReport
            // 
            dgvReport.AllowUserToAddRows = false;
            dgvReport.AllowUserToDeleteRows = false;
            dgvReport.BackgroundColor = Color.White;
            dgvReport.BorderStyle = BorderStyle.FixedSingle;
            dgvReport.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvReport.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvReport.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(46, 74, 107),
                ForeColor = Color.White,
                Font = new Font("Segoe UI Semibold", 10F),
                Alignment = DataGridViewContentAlignment.MiddleLeft,
                Padding = new Padding(8, 0, 0, 0),
                SelectionBackColor = Color.FromArgb(46, 74, 107),
                SelectionForeColor = Color.White
            };
            dgvReport.ColumnHeadersHeight = 44;
            dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvReport.DefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.White,
                ForeColor = Color.FromArgb(44, 62, 80),
                Font = new Font("Segoe UI", 10F),
                Padding = new Padding(8, 0, 0, 0),
                SelectionBackColor = Color.FromArgb(225, 232, 242),
                SelectionForeColor = Color.FromArgb(44, 62, 80)
            };
            dgvReport.AlternatingRowsDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(248, 250, 252)
            };
            dgvReport.Dock = DockStyle.Fill;
            dgvReport.EnableHeadersVisualStyles = false;
            dgvReport.GridColor = Color.FromArgb(233, 236, 239);
            dgvReport.Name = "dgvReport";
            dgvReport.ReadOnly = true;
            dgvReport.RowHeadersVisible = false;
            dgvReport.RowTemplate.Height = 40;
            dgvReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReport.TabIndex = 0;
            // 
            // pnlFooter
            // 
            pnlFooter.BackColor = Color.White;
            pnlFooter.Controls.Add(btnHome);
            pnlFooter.Controls.Add(btnExport);
            pnlFooter.Controls.Add(btnGenerate);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Padding = new Padding(36, 0, 36, 0);
            pnlFooter.Size = new Size(1284, 80);
            pnlFooter.TabIndex = 3;
            // 
            // btnHome
            // 
            btnHome.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnHome.BackColor = Color.White;
            btnHome.Cursor = Cursors.Hand;
            btnHome.FlatAppearance.BorderColor = Color.FromArgb(206, 212, 218);
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 10.5F);
            btnHome.ForeColor = Color.FromArgb(108, 117, 125);
            btnHome.Location = new Point(1104, 19);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(140, 42);
            btnHome.TabIndex = 2;
            btnHome.Text = "На главную";
            btnHome.UseVisualStyleBackColor = false;
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.White;
            btnExport.Cursor = Cursors.Hand;
            btnExport.FlatAppearance.BorderColor = Color.FromArgb(46, 74, 107);
            btnExport.FlatStyle = FlatStyle.Flat;
            btnExport.Font = new Font("Segoe UI", 10.5F);
            btnExport.ForeColor = Color.FromArgb(46, 74, 107);
            btnExport.Location = new Point(196, 19);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(140, 42);
            btnExport.TabIndex = 1;
            btnExport.Text = "Экспорт";
            btnExport.UseVisualStyleBackColor = false;
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.FromArgb(46, 74, 107);
            btnGenerate.Cursor = Cursors.Hand;
            btnGenerate.FlatAppearance.BorderSize = 0;
            btnGenerate.FlatStyle = FlatStyle.Flat;
            btnGenerate.Font = new Font("Segoe UI", 10.5F);
            btnGenerate.ForeColor = Color.White;
            btnGenerate.Location = new Point(36, 19);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(150, 42);
            btnGenerate.TabIndex = 0;
            btnGenerate.Text = "Сформировать";
            btnGenerate.UseVisualStyleBackColor = false;
            // 
            // ReportsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1284, 770);
            Controls.Add(pnlContent);
            Controls.Add(pnlSidebar);
            Controls.Add(pnlFooter);
            Controls.Add(pnlHeader);
            MinimumSize = new Size(900, 560);
            Name = "ReportsForm";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            Text = "Отчёты";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlSidebar.ResumeLayout(false);
            pnlContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
            pnlFooter.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Panel pnlSidebar;
        private Label lblSidebarCaption;
        private ListBox lstReports;
        private Panel pnlContent;
        private DataGridView dgvReport;
        private Panel pnlFooter;
        private Button btnGenerate;
        private Button btnExport;
        private Button btnHome;
    }
}
