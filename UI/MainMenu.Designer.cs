namespace Mb;

partial class MainMenu
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
        lblWelcome = new Label();
        lblSubtitle = new Label();
        pnlDatabase = new Panel();
        lblDatabaseDesc = new Label();
        lblDatabaseTitle = new Label();
        pnlProfile = new Panel();
        lblProfileDesc = new Label();
        lblProfileTitle = new Label();
        pnlReports = new Panel();
        lblReportsDesc = new Label();
        lblReportsTitle = new Label();
        pnlAbout = new Panel();
        lblAboutDesc = new Label();
        lblAboutTitle = new Label();
        btnExit = new Button();
        pnlDatabase.SuspendLayout();
        pnlProfile.SuspendLayout();
        pnlReports.SuspendLayout();
        pnlAbout.SuspendLayout();
        SuspendLayout();
        // 
        // lblWelcome
        // 
        lblWelcome.Anchor = AnchorStyles.None;
        lblWelcome.Font = new Font("Segoe UI Light", 30F);
        lblWelcome.ForeColor = Color.FromArgb(74, 85, 104);
        lblWelcome.Location = new Point(0, 60);
        lblWelcome.Name = "lblWelcome";
        lblWelcome.Size = new Size(824, 55);
        lblWelcome.TabIndex = 0;
        lblWelcome.Text = "Добро пожаловать";
        lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblSubtitle
        // 
        lblSubtitle.Anchor = AnchorStyles.None;
        lblSubtitle.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic);
        lblSubtitle.ForeColor = Color.FromArgb(150, 158, 172);
        lblSubtitle.Location = new Point(0, 120);
        lblSubtitle.Name = "lblSubtitle";
        lblSubtitle.Size = new Size(824, 25);
        lblSubtitle.TabIndex = 1;
        lblSubtitle.Text = "Выберите раздел для работы";
        lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // pnlDatabase
        // 
        pnlDatabase.Anchor = AnchorStyles.None;
        pnlDatabase.BackColor = Color.FromArgb(46, 74, 107);
        pnlDatabase.Controls.Add(lblDatabaseDesc);
        pnlDatabase.Controls.Add(lblDatabaseTitle);
        pnlDatabase.Cursor = Cursors.Hand;
        pnlDatabase.Location = new Point(64, 164);
        pnlDatabase.Name = "pnlDatabase";
        pnlDatabase.Size = new Size(340, 120);
        pnlDatabase.TabIndex = 2;
        pnlDatabase.Click += pnlDatabase_Click;
        // 
        // lblDatabaseDesc
        // 
        lblDatabaseDesc.AutoSize = true;
        lblDatabaseDesc.Cursor = Cursors.Hand;
        lblDatabaseDesc.Font = new Font("Segoe UI", 9.75F);
        lblDatabaseDesc.ForeColor = Color.FromArgb(174, 185, 204);
        lblDatabaseDesc.Location = new Point(18, 46);
        lblDatabaseDesc.MaximumSize = new Size(308, 0);
        lblDatabaseDesc.Name = "lblDatabaseDesc";
        lblDatabaseDesc.Size = new Size(301, 69);
        lblDatabaseDesc.TabIndex = 1;
        lblDatabaseDesc.Text = "Управление справочниками: врачи, больницы и отделения. Поиск и редактирование.";
        lblDatabaseDesc.Click += pnlDatabase_Click;
        // 
        // lblDatabaseTitle
        // 
        lblDatabaseTitle.AutoSize = true;
        lblDatabaseTitle.Cursor = Cursors.Hand;
        lblDatabaseTitle.Font = new Font("Segoe UI", 13.75F, FontStyle.Bold);
        lblDatabaseTitle.ForeColor = Color.White;
        lblDatabaseTitle.Location = new Point(16, 14);
        lblDatabaseTitle.Name = "lblDatabaseTitle";
        lblDatabaseTitle.Size = new Size(156, 31);
        lblDatabaseTitle.TabIndex = 0;
        lblDatabaseTitle.Text = "База данных";
        lblDatabaseTitle.Click += pnlDatabase_Click;
        // 
        // pnlProfile
        // 
        pnlProfile.Anchor = AnchorStyles.None;
        pnlProfile.BackColor = Color.FromArgb(244, 246, 250);
        pnlProfile.Controls.Add(lblProfileDesc);
        pnlProfile.Controls.Add(lblProfileTitle);
        pnlProfile.Location = new Point(420, 164);
        pnlProfile.Name = "pnlProfile";
        pnlProfile.Size = new Size(340, 120);
        pnlProfile.TabIndex = 3;
        pnlProfile.Click += pnlProfile_Click;
        // 
        // lblProfileDesc
        // 
        lblProfileDesc.AutoSize = true;
        lblProfileDesc.Font = new Font("Segoe UI", 9.75F);
        lblProfileDesc.ForeColor = Color.FromArgb(138, 148, 166);
        lblProfileDesc.Location = new Point(18, 46);
        lblProfileDesc.MaximumSize = new Size(308, 0);
        lblProfileDesc.Name = "lblProfileDesc";
        lblProfileDesc.Size = new Size(307, 46);
        lblProfileDesc.TabIndex = 1;
        lblProfileDesc.Click += pnlProfile_Click;
        lblProfileDesc.Text = "Вход в систему, управление учётной записью и персональными данными.";
        // 
        // lblProfileTitle
        // 
        lblProfileTitle.AutoSize = true;
        lblProfileTitle.Font = new Font("Segoe UI", 13.75F, FontStyle.Bold);
        lblProfileTitle.ForeColor = Color.FromArgb(44, 62, 80);
        lblProfileTitle.Location = new Point(16, 14);
        lblProfileTitle.Name = "lblProfileTitle";
        lblProfileTitle.Size = new Size(201, 31);
        lblProfileTitle.TabIndex = 0;
        lblProfileTitle.Click += pnlProfile_Click;
        lblProfileTitle.Text = "Личный кабинет";
        // 
        // pnlReports
        // 
        pnlReports.Anchor = AnchorStyles.None;
        pnlReports.BackColor = Color.FromArgb(244, 246, 250);
        pnlReports.Controls.Add(lblReportsDesc);
        pnlReports.Controls.Add(lblReportsTitle);
        pnlReports.Location = new Point(64, 300);
        pnlReports.Name = "pnlReports";
        pnlReports.Size = new Size(340, 104);
        pnlReports.TabIndex = 4;
        pnlReports.Click += pnlReports_Click;
        // 
        // lblReportsDesc
        // 
        lblReportsDesc.AutoSize = true;
        lblReportsDesc.Font = new Font("Segoe UI", 9.75F);
        lblReportsDesc.ForeColor = Color.FromArgb(138, 148, 166);
        lblReportsDesc.Location = new Point(18, 46);
        lblReportsDesc.MaximumSize = new Size(308, 0);
        lblReportsDesc.Name = "lblReportsDesc";
        lblReportsDesc.Size = new Size(238, 46);
        lblReportsDesc.TabIndex = 1;
        lblReportsDesc.Click += pnlReports_Click;
        lblReportsDesc.Text = "Сводная статистика по всем разделам системы.";
        // 
        // lblReportsTitle
        // 
        lblReportsTitle.AutoSize = true;
        lblReportsTitle.Font = new Font("Segoe UI", 13.75F, FontStyle.Bold);
        lblReportsTitle.ForeColor = Color.FromArgb(44, 62, 80);
        lblReportsTitle.Location = new Point(16, 14);
        lblReportsTitle.Name = "lblReportsTitle";
        lblReportsTitle.Size = new Size(96, 31);
        lblReportsTitle.TabIndex = 0;
        lblReportsTitle.Click += pnlReports_Click;
        lblReportsTitle.Text = "Отчёты";
        // 
        // pnlAbout
        // 
        pnlAbout.Anchor = AnchorStyles.None;
        pnlAbout.BackColor = Color.FromArgb(244, 246, 250);
        pnlAbout.Controls.Add(lblAboutDesc);
        pnlAbout.Controls.Add(lblAboutTitle);
        pnlAbout.Location = new Point(420, 300);
        pnlAbout.Name = "pnlAbout";
        pnlAbout.Size = new Size(340, 104);
        pnlAbout.TabIndex = 5;
        pnlAbout.Click += pnlAbout_Click;
        // 
        // lblAboutDesc
        // 
        lblAboutDesc.AutoSize = true;
        lblAboutDesc.Font = new Font("Segoe UI", 9.75F);
        lblAboutDesc.ForeColor = Color.FromArgb(138, 148, 166);
        lblAboutDesc.Location = new Point(18, 46);
        lblAboutDesc.MaximumSize = new Size(308, 0);
        lblAboutDesc.Name = "lblAboutDesc";
        lblAboutDesc.Size = new Size(302, 46);
        lblAboutDesc.TabIndex = 1;
        lblAboutDesc.Click += pnlAbout_Click;
        lblAboutDesc.Text = "Информация о версии, технологиях и разработчиках.";
        // 
        // lblAboutTitle
        // 
        lblAboutTitle.AutoSize = true;
        lblAboutTitle.Font = new Font("Segoe UI", 13.75F, FontStyle.Bold);
        lblAboutTitle.ForeColor = Color.FromArgb(44, 62, 80);
        lblAboutTitle.Location = new Point(16, 14);
        lblAboutTitle.Name = "lblAboutTitle";
        lblAboutTitle.Size = new Size(162, 31);
        lblAboutTitle.TabIndex = 0;
        lblAboutTitle.Click += pnlAbout_Click;
        lblAboutTitle.Text = "О программе";
        // 
        // btnExit
        // 
        btnExit.Anchor = AnchorStyles.None;
        btnExit.BackColor = Color.White;
        btnExit.FlatAppearance.BorderColor = Color.FromArgb(206, 212, 218);
        btnExit.FlatStyle = FlatStyle.Flat;
        btnExit.Font = new Font("Segoe UI", 9.75F);
        btnExit.ForeColor = Color.FromArgb(108, 117, 125);
        btnExit.Location = new Point(280, 444);
        btnExit.Name = "btnExit";
        btnExit.Size = new Size(253, 38);
        btnExit.TabIndex = 6;
        btnExit.Text = "Выйти из программы";
        btnExit.UseVisualStyleBackColor = false;
        btnExit.Click += btnExit_Click;
        // 
        // MainMenu
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(824, 560);
        Controls.Add(btnExit);
        Controls.Add(pnlAbout);
        Controls.Add(pnlReports);
        Controls.Add(pnlProfile);
        Controls.Add(pnlDatabase);
        Controls.Add(lblSubtitle);
        Controls.Add(lblWelcome);
        MinimumSize = new Size(840, 599);
        Name = "MainMenu";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Главное меню";
        WindowState = FormWindowState.Maximized;
        pnlDatabase.ResumeLayout(false);
        pnlDatabase.PerformLayout();
        pnlProfile.ResumeLayout(false);
        pnlProfile.PerformLayout();
        pnlReports.ResumeLayout(false);
        pnlReports.PerformLayout();
        pnlAbout.ResumeLayout(false);
        pnlAbout.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Label lblWelcome;
    private Label lblSubtitle;
    private Panel pnlDatabase;
    private Label lblDatabaseTitle;
    private Label lblDatabaseDesc;
    private Panel pnlProfile;
    private Label lblProfileTitle;
    private Label lblProfileDesc;
    private Panel pnlReports;
    private Label lblReportsTitle;
    private Label lblReportsDesc;
    private Panel pnlAbout;
    private Label lblAboutTitle;
    private Label lblAboutDesc;
    private Button btnExit;
}
