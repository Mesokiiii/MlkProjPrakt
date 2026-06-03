using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace Mb.UI.Reports
{
    public partial class ReportsForm : Form
    {
        private readonly string connectionString;

        public ReportsForm()
        {
            InitializeComponent();

            // Получаем строку подключения из конфигурации
            connectionString = ConfigurationManager.ConnectionStrings["HospitalDB"].ConnectionString;

            // Привязываем события кнопок
            btnGenerate.Click += btnGenerate_Click;
            btnExport.Click += btnExport_Click;
            btnHome.Click += btnHome_Click;
        }

        // Кнопка "Сформировать" — выполняет выбранный отчёт
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (lstReports.SelectedItem == null)
            {
                MessageBox.Show("Выберите отчёт из списка.", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string reportName = lstReports.SelectedItem.ToString();

            try
            {
                DataTable result = GetReportData(reportName);
                dgvReport.DataSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при формировании отчёта: " + ex.Message,
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Получение данных отчёта по имени
        private DataTable GetReportData(string reportName)
        {
            string query = "";

            switch (reportName)
            {
                case "Врачи по отделениям":
                    query = "SELECT В.ФИО_врача, В.Должность, В.Специальность, О.Название_отделения " +
                            "FROM Врачи AS В INNER JOIN Отделения AS О ON В.Код_отделения = О.Код_отделения " +
                            "ORDER BY О.Название_отделения, В.ФИО_врача";
                    break;

                case "Отделения по больницам":
                    query = "SELECT О.Название_отделения, О.Число_мест, О.Число_свободных_мест, Б.Адрес " +
                            "FROM Отделения AS О INNER JOIN Больницы AS Б ON О.Номер_больницы = Б.Номер_больницы " +
                            "ORDER BY Б.Адрес, О.Название_отделения";
                    break;

                case "Свободные места":
                    query = "SELECT О.Название_отделения, О.Число_свободных_мест, Б.Адрес " +
                            "FROM Отделения AS О INNER JOIN Больницы AS Б ON О.Номер_больницы = Б.Номер_больницы " +
                            "WHERE О.Число_свободных_мест > 0 " +
                            "ORDER BY О.Число_свободных_мест DESC";
                    break;

                default:
                    throw new Exception("Неизвестный отчёт: " + reportName);
            }

            return ExecuteQuery(query);
        }

        // Выполнение SQL-запроса и возврат таблицы
        private DataTable ExecuteQuery(string query)
        {
            DataTable table = new DataTable();

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(command))
                    {
                        adapter.Fill(table);
                    }
                }
            }

            return table;
        }

        // Экспорт данных из DataGridView в CSV-файл
        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dgvReport.DataSource == null || dgvReport.Rows.Count == 0)
            {
                MessageBox.Show("Сначала сформируйте отчёт.", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Диалог сохранения файла
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "CSV файл (*.csv)|*.csv";
            saveDialog.FileName = "Отчёт_" + DateTime.Now.ToString("yyyy-MM-dd");

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StringBuilder sb = new StringBuilder();

                    // Заголовки столбцов
                    for (int i = 0; i < dgvReport.Columns.Count; i++)
                    {
                        sb.Append(dgvReport.Columns[i].HeaderText);
                        if (i < dgvReport.Columns.Count - 1)
                            sb.Append(";");
                    }
                    sb.AppendLine();

                    // Данные строк
                    for (int row = 0; row < dgvReport.Rows.Count; row++)
                    {
                        for (int col = 0; col < dgvReport.Columns.Count; col++)
                        {
                            object value = dgvReport.Rows[row].Cells[col].Value;
                            sb.Append(value != null ? value.ToString() : "");
                            if (col < dgvReport.Columns.Count - 1)
                                sb.Append(";");
                        }
                        sb.AppendLine();
                    }

                    File.WriteAllText(saveDialog.FileName, sb.ToString(), Encoding.UTF8);
                    MessageBox.Show("Отчёт сохранён: " + saveDialog.FileName, "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при сохранении: " + ex.Message,
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Кнопка "На главную"
        private void btnHome_Click(object sender, EventArgs e) => this.Close();
    }
}
