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
        pnlDatabase = new Panel();
        lblDatabaseTitle = new Label();
        pnlProfile = new Panel();
        pnlAbout = new Panel();
        pnlReports = new Panel();
        pnlDatabase.SuspendLayout();
        SuspendLayout();
        // 
        // pnlDatabase
        // 
        pnlDatabase.BorderStyle = BorderStyle.FixedSingle;
        pnlDatabase.Controls.Add(lblDatabaseTitle);
        pnlDatabase.Location = new Point(159, 88);
        pnlDatabase.Name = "pnlDatabase";
        pnlDatabase.Size = new Size(152, 111);
        pnlDatabase.TabIndex = 0;
        pnlDatabase.Click += pnlDatabase_Click;
    
        // 
        // lblDatabaseTitle
        // 
        lblDatabaseTitle.AutoSize = true;
        lblDatabaseTitle.Location = new Point(23, 42);
        lblDatabaseTitle.Name = "lblDatabaseTitle";
        lblDatabaseTitle.Size = new Size(97, 20);
        lblDatabaseTitle.TabIndex = 0;
        lblDatabaseTitle.Text = "База данных";
        // 
        // pnlProfile
        // 
        pnlProfile.Location = new Point(365, 88);
        pnlProfile.Name = "pnlProfile";
        pnlProfile.Size = new Size(152, 111);
        pnlProfile.TabIndex = 1;
        // 
        // pnlAbout
        // 
        pnlAbout.Location = new Point(365, 228);
        pnlAbout.Name = "pnlAbout";
        pnlAbout.Size = new Size(152, 111);
        pnlAbout.TabIndex = 2;
        // 
        // pnlReports
        // 
        pnlReports.Location = new Point(159, 228);
        pnlReports.Name = "pnlReports";
        pnlReports.Size = new Size(152, 111);
        pnlReports.TabIndex = 3;
        // 
        // MainMenu
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(pnlReports);
        Controls.Add(pnlAbout);
        Controls.Add(pnlProfile);
        Controls.Add(pnlDatabase);
        Name = "MainMenu";
        Text = "Form1";
        pnlDatabase.ResumeLayout(false);
        pnlDatabase.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Panel pnlDatabase;
    private Panel pnlProfile;
    private Panel pnlAbout;
    private Panel pnlReports;
    private Label lblDatabaseTitle;
}
