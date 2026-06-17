using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using ClosedXML.Excel;

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

        // Экспорт отчёта в Excel
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
            saveDialog.Filter = "Excel файлы (*.xlsx)|*.xlsx";
            saveDialog.FileName = $"Отчёт_{DateTime.Now:dd-MM-yyyy}.xlsx";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Создаём новую книгу Excel
                    var workbook = new XLWorkbook();
                    var worksheet = workbook.Worksheets.Add("Отчёт");

                    // Записываем заголовки столбцов
                    for (int i = 0; i < dgvReport.Columns.Count; i++)
                    {
                        // Берём название столбца
                        worksheet.Cell(1, i + 1).Value = dgvReport.Columns[i].HeaderText;
                        // Делаем заголовок жирным
                        worksheet.Cell(1, i + 1).Style.Font.Bold = true;
                    }

                    // Записываем данные построчно
                    int excelRow = 2;
                    foreach (DataGridViewRow row in dgvReport.Rows)
                    {
                        if (row.IsNewRow) continue;

                        for (int col = 0; col < dgvReport.Columns.Count; col++)
                        {
                            var value = row.Cells[col].Value;
                            worksheet.Cell(excelRow, col + 1).Value = value?.ToString() ?? "";
                        }
                        excelRow++;
                    }

                    // Сохраняем файл
                    workbook.SaveAs(saveDialog.FileName);

                    MessageBox.Show("Отчёт успешно сохранён!", "Успех",
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
