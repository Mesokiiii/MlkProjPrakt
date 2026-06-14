using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Mb.UI.Database
{
    // Форма для работы с таблицами БД (просмотр, CRUD, поиск)
    public partial class DatabaseForm : Form
    {
        private readonly DataService dataService;

        public DatabaseForm(DataService dataService)
        {
            InitializeComponent();

            // Показываем кнопки редактирования только для ролей с правами
            this.Load += (s, e) => {
                string role = UserSession.CurrentRole;
                bool canEdit = (role == Roles.Admin || role == Roles.HeadDoctor);
                bool canDelete = (role == Roles.Admin);
                btnAdd.Visible = canEdit;
                btnEdit.Visible = canEdit;
                btnDelete.Visible = canDelete;
            };

            this.dataService = dataService;
            cmbTables.SelectedIndex = 0;
        }

        // Загрузка данных выбранной таблицы в DataGridView
        private void LoadData()
        {
            if (cmbTables.SelectedItem == null) return;
            string tableName = cmbTables.SelectedItem.ToString();

            try
            {
                DataTable table = dataService.GetTable(tableName);
                dgvData.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки: " + ex.Message);
            }
        }

        // Удаление выбранной записи с подтверждением
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvData.CurrentRow == null)
            {
                MessageBox.Show("Выберите запись для удаления.");
                return;
            }

            try
            {
                int id = Convert.ToInt32(dgvData.CurrentRow.Cells[0].Value);
                string tableName = cmbTables.SelectedItem.ToString();

                var result = MessageBox.Show(
                    $"Удалить запись с ID {id} из таблицы {tableName}?",
                    "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    bool isDeleted = dataService.DataRecord(tableName, id);
                    if (isDeleted)
                    {
                        MessageBox.Show("Запись удалена!");
                        LoadData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Добавление новой записи через форму редактирования
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string tableName = cmbTables.SelectedItem.ToString();

            var fields = dgvData.Columns.Cast<DataGridViewColumn>()
                .ToDictionary(c => c.Name, c => (string?)null);

            var editForm = new EditRecordForm($"Добавление в {tableName}", fields);

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    dataService.SaveRecord(tableName, editForm.Values);
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // Редактирование выбранной записи
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvData.CurrentRow == null) return;

            string tableName = cmbTables.SelectedItem.ToString();
            int id = Convert.ToInt32(dgvData.CurrentRow.Cells[0].Value);

            var fields = dgvData.Columns.Cast<DataGridViewColumn>()
                .ToDictionary(c => c.Name, c => dgvData.CurrentRow.Cells[c.Index].Value?.ToString());

            var editForm = new EditRecordForm($"Редактирование {tableName}", fields);

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    dataService.SaveRecord(tableName, editForm.Values, id);
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // Поиск по второму столбцу таблицы (фильтрация на месте)
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (dgvData.DataSource is DataTable dt)
            {
                string filterColumn = dt.Columns[1].ColumnName;
                // Экранируем одинарную кавычку, чтобы пользователь не сломал фильтр (защита от инъекции)
                string safeText = txtSearch.Text.Replace("'", "''");
                dt.DefaultView.RowFilter = $"[{filterColumn}] LIKE '%{safeText}%'";
            }
        }

        private void cmbTables_SelectedIndexChanged(object sender, EventArgs e) => LoadData();
        private void btnRefresh_Click(object sender, EventArgs e) => LoadData();
        private void btnHome_Click(object sender, EventArgs e) => this.Close();
        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e) { }


    }
}
