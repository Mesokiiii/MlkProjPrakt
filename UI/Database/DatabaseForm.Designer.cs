namespace Mb.UI.Database
{
    partial class DatabaseForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            cmbTables = new ComboBox();
            txtSearch = new TextBox();
            lblTitle = new Label();
            pnlContent = new Panel();
            dgvData = new DataGridView();
            pnlFooter = new Panel();
            btnHome = new Button();
            btnRefresh = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            pnlHeader.SuspendLayout();
            pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            pnlFooter.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(46, 74, 107);
            pnlHeader.Controls.Add(cmbTables);
            pnlHeader.Controls.Add(txtSearch);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1284, 80);
            pnlHeader.TabIndex = 0;
            // 
            // cmbTables
            // 
            cmbTables.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbTables.BackColor = Color.White;
            cmbTables.Cursor = Cursors.Hand;
            cmbTables.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTables.FlatStyle = FlatStyle.Flat;
            cmbTables.Font = new Font("Segoe UI", 11F);
            cmbTables.ForeColor = Color.FromArgb(44, 62, 80);
            cmbTables.Items.AddRange(new object[] { "Врачи", "Больницы", "Отделения" });
            cmbTables.Location = new Point(704, 25);
            cmbTables.Name = "cmbTables";
            cmbTables.Size = new Size(220, 33);
            cmbTables.TabIndex = 2;
            cmbTables.SelectedIndexChanged += cmbTables_SelectedIndexChanged;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 11F);
            txtSearch.Location = new Point(944, 24);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Поиск...";
            txtSearch.Size = new Size(300, 32);
            txtSearch.TabIndex = 3;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Light", 20F);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(36, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(206, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "База данных";
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.FromArgb(244, 246, 250);
            pnlContent.Controls.Add(dgvData);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(0, 80);
            pnlContent.Name = "pnlContent";
            pnlContent.Padding = new Padding(36, 24, 36, 24);
            pnlContent.Size = new Size(1284, 610);
            pnlContent.TabIndex = 1;
            // 
            // dgvData
            // 
            dgvData.AllowUserToAddRows = false;
            dgvData.AllowUserToDeleteRows = false;
            dgvData.BackgroundColor = Color.White;
            dgvData.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvData.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvData.ColumnHeadersHeight = 44;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvData.Dock = DockStyle.Fill;
            dgvData.EnableHeadersVisualStyles = false;
            dgvData.GridColor = Color.FromArgb(233, 236, 239);
            dgvData.Location = new Point(36, 24);
            dgvData.Name = "dgvData";
            dgvData.RowHeadersVisible = false;
            dgvData.RowHeadersWidth = 51;
            dgvData.RowTemplate.Height = 40;
            dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvData.Size = new Size(1212, 562);
            dgvData.TabIndex = 0;
            dgvData.CellContentClick += dgvData_CellContentClick;
            // 
            // pnlFooter
            // 
            pnlFooter.BackColor = Color.White;
            pnlFooter.Controls.Add(btnHome);
            pnlFooter.Controls.Add(btnRefresh);
            pnlFooter.Controls.Add(btnDelete);
            pnlFooter.Controls.Add(btnEdit);
            pnlFooter.Controls.Add(btnAdd);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Location = new Point(0, 690);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Padding = new Padding(36, 0, 36, 0);
            pnlFooter.Size = new Size(1284, 80);
            pnlFooter.TabIndex = 2;
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
            btnHome.TabIndex = 4;
            btnHome.Text = "На главную";
            btnHome.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.White;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderColor = Color.FromArgb(206, 212, 218);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 10.5F);
            btnRefresh.ForeColor = Color.FromArgb(108, 117, 125);
            btnRefresh.Location = new Point(471, 19);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(140, 42);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Обновить";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.White;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderColor = Color.FromArgb(220, 53, 69);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 10.5F);
            btnDelete.ForeColor = Color.FromArgb(220, 53, 69);
            btnDelete.Location = new Point(321, 19);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(140, 42);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.White;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.FlatAppearance.BorderColor = Color.FromArgb(46, 74, 107);
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 10.5F);
            btnEdit.ForeColor = Color.FromArgb(46, 74, 107);
            btnEdit.Location = new Point(171, 19);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(140, 42);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Редактировать";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(46, 74, 107);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 10.5F);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(36, 19);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(125, 42);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // DatabaseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1284, 770);
            Controls.Add(pnlContent);
            Controls.Add(pnlFooter);
            Controls.Add(pnlHeader);
            MinimumSize = new Size(900, 560);
            Name = "DatabaseForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "База данных";
            WindowState = FormWindowState.Maximized;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            pnlFooter.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private TextBox txtSearch;
        private ComboBox cmbTables;
        private Panel pnlContent;
        private DataGridView dgvData;
        private Panel pnlFooter;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnRefresh;
        private Button btnHome;
    }
}
