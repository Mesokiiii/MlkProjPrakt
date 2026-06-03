namespace Mb.UI.Database
{
    public partial class EditRecordForm : Form
    {
        private readonly Dictionary<string, TextBox> inputs = new();

        /// <summary>Edited field values, available after the dialog returns OK.</summary>
        public Dictionary<string, string> Values =>
            inputs.ToDictionary(p => p.Key, p => p.Value.Text.Trim());

        public EditRecordForm(string title, IDictionary<string, string?> fields)
        {
            InitializeComponent();
            lblTitle.Text = title;
            BuildFields(fields);
        }

        private void BuildFields(IDictionary<string, string?> fields)
        {
            flpFields.SuspendLayout();
            foreach (var (name, value) in fields)
            {
                var label = new Label
                {
                    Text = name,
                    AutoSize = false,
                    Size = new Size(360, 22),
                    Margin = new Padding(0, 8, 0, 2),
                    Font = new Font("Segoe UI", 9.75F),
                    ForeColor = Color.FromArgb(108, 117, 125)
                };
                var box = new TextBox
                {
                    Text = value ?? string.Empty,
                    Size = new Size(360, 30),
                    Margin = new Padding(0, 0, 0, 6),
                    BorderStyle = BorderStyle.FixedSingle,
                    Font = new Font("Segoe UI", 11F)
                };
                inputs[name] = box;
                flpFields.Controls.Add(label);
                flpFields.Controls.Add(box);
            }
            flpFields.ResumeLayout();
        }
    }
}
