namespace Mb.UI.Database
{
    partial class EditRecordForm
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
            flpFields = new FlowLayoutPanel();
            pnlFooter = new Panel();
            btnSave = new Button();
            btnCancel = new Button();
            pnlHeader.SuspendLayout();
            pnlFooter.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(46, 74, 107);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(426, 70);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Light", 18F);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(28, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(232, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Редактирование";
            // 
            // flpFields
            // 
            flpFields.AutoScroll = true;
            flpFields.BackColor = Color.White;
            flpFields.Dock = DockStyle.Fill;
            flpFields.FlowDirection = FlowDirection.TopDown;
            flpFields.Location = new Point(0, 70);
            flpFields.Name = "flpFields";
            flpFields.Padding = new Padding(32, 16, 32, 16);
            flpFields.Size = new Size(426, 495);
            flpFields.TabIndex = 1;
            flpFields.WrapContents = false;
            // 
            // pnlFooter
            // 
            pnlFooter.BackColor = Color.FromArgb(244, 246, 250);
            pnlFooter.Controls.Add(btnSave);
            pnlFooter.Controls.Add(btnCancel);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Location = new Point(0, 565);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(426, 80);
            pnlFooter.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSave.BackColor = Color.FromArgb(46, 74, 107);
            btnSave.Cursor = Cursors.Hand;
            btnSave.DialogResult = DialogResult.OK;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 10.5F);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(270, 20);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(124, 42);
            btnSave.TabIndex = 0;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.BackColor = Color.White;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(206, 212, 218);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10.5F);
            btnCancel.ForeColor = Color.FromArgb(108, 117, 125);
            btnCancel.Location = new Point(142, 20);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 42);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // EditRecordForm
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            CancelButton = btnCancel;
            ClientSize = new Size(426, 645);
            Controls.Add(flpFields);
            Controls.Add(pnlFooter);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditRecordForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Редактирование записи";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlFooter.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private FlowLayoutPanel flpFields;
        private Panel pnlFooter;
        private Button btnSave;
        private Button btnCancel;
    }
}
