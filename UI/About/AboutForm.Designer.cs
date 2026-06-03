namespace Mb.UI.About
{
    partial class AboutForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlCard = new Panel();
            lblTitle = new Label();
            lblAuthor = new Label();
            lblDescription = new Label();
            btnHome = new Button();
            pnlCard.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCard
            // 
            pnlCard.Anchor = AnchorStyles.None;
            pnlCard.BackColor = Color.White;
            pnlCard.BorderStyle = BorderStyle.FixedSingle;
            pnlCard.Controls.Add(lblTitle);
            pnlCard.Controls.Add(lblAuthor);
            pnlCard.Controls.Add(lblDescription);
            pnlCard.Controls.Add(btnHome);
            pnlCard.Location = new Point(40, 30);
            pnlCard.Name = "pnlCard";
            pnlCard.Size = new Size(400, 340);
            pnlCard.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI Light", 20F);
            lblTitle.ForeColor = Color.FromArgb(46, 74, 107);
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(360, 42);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "О программе";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAuthor
            // 
            lblAuthor.Font = new Font("Segoe UI Semibold", 10.5F);
            lblAuthor.ForeColor = Color.FromArgb(44, 62, 80);
            lblAuthor.Location = new Point(20, 80);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(360, 50);
            lblAuthor.TabIndex = 1;
            lblAuthor.Text = "Студент 1 курса\r\nГруппа: Б.ПИН.ИИ\r\nГруздев Андрей";
            lblAuthor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDescription
            // 
            lblDescription.Font = new Font("Segoe UI", 9.75F);
            lblDescription.ForeColor = Color.FromArgb(108, 117, 125);
            lblDescription.Location = new Point(20, 150);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(360, 120);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "Информационная система управления данными больничной сети. " +
                "Приложение позволяет просматривать, добавлять, редактировать и удалять " +
                "записи о больницах, отделениях и врачах. Реализовано разграничение прав " +
                "доступа, формирование отчётов и экспорт данных.";
            lblDescription.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.White;
            btnHome.Cursor = Cursors.Hand;
            btnHome.FlatAppearance.BorderColor = Color.FromArgb(206, 212, 218);
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 9.75F);
            btnHome.ForeColor = Color.FromArgb(108, 117, 125);
            btnHome.Location = new Point(125, 285);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(150, 36);
            btnHome.TabIndex = 3;
            btnHome.Text = "← На главную";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += (s, e) => this.Close();
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 250);
            ClientSize = new Size(480, 400);
            Controls.Add(pnlCard);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AboutForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            pnlCard.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCard;
        private Label lblTitle;
        private Label lblAuthor;
        private Label lblDescription;
        private Button btnHome;
    }
}
