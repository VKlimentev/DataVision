using System;
using System.Data;
using System.Windows.Forms;

namespace kursach
{
    public partial class MainForm : Form
    {
        private string _currentTable;
        public MainForm()
        {
            InitializeComponent();
            InitItems();
        }

        private void InitItems()
        {
            foreach (DataTable table in kursachDataSet.Tables)
            {
                ToolStripMenuItem tableMenuItem = new ToolStripMenuItem(table.TableName);

                tableMenuItem.Click += (sender, e) =>
                {
                    TablesChooser.Text = table.TableName;
                    search.Enabled = true;
                    searchField.Enabled = true;
                    clearSearchField.Enabled = true;
                    bindingNavigatorAddItem.Enabled = true;
                    bindingNavigatorEditItem.Enabled = true;
                    bindingNavigatorDeleteItem.Enabled = true;

                    _currentTable = table.TableName;
                    tableAdapterManager.UpdateAll(kursachDataSet);
                    bindingSource = new BindingSource(kursachDataSet, _currentTable);
                    dataGridView.DataSource = bindingSource;
                    bindingNavigator.BindingSource = bindingSource;
                    foreach (DataGridViewColumn column in dataGridView.Columns)
                    {
                        if (column.HeaderText == "Id")
                            column.Visible = false;
                        else if (column.HeaderText.EndsWith("_Id"))
                            column.HeaderText = column.HeaderText.Remove(column.HeaderText.Length - 3);
                    }
                };

                TablesChooser.DropDownItems.Add(tableMenuItem);
            }
        }

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (!dataGridView.Columns[e.ColumnIndex].Name.EndsWith("_Id") || e.Value.ToString() == "")
                return;

            string columnName = dataGridView.Columns[e.ColumnIndex].Name;
            if (e.ColumnIndex == dataGridView.Columns[columnName].Index)
            {
                int Id = (int)e.Value;

                DataRow[] matchingRows = kursachDataSet.Tables[columnName.Remove(columnName.Length - 3)].Select($"Id = {Id}");

                if (matchingRows.Length > 0)
                    e.Value = matchingRows[0][1];
            }
        }

        private void bindingNavigatorAddItem_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm(_currentTable, false);
            editForm.ShowDialog();
            MainForm_Load(null, null);
        }

        private void bindingNavigatorEditItem_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView.Rows[int.Parse(bindingNavigatorPositionItem.Text) - 1].Cells[0].Value;

            EditForm editForm = new EditForm(_currentTable, true, id);
            editForm.ShowDialog();
            MainForm_Load(null, null);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить?",
                                                  "Подтверждение удаления",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;

            int id = (int)dataGridView.Rows[int.Parse(bindingNavigatorPositionItem.Text) - 1].Cells[0].Value;
            foreach (DataRow row in kursachDataSet.Tables[_currentTable].Rows)
            {
                if (row.Field<int>(0) == id)
                {
                    row.Delete();
                    break;
                }
            }
            tableAdapterManager.UpdateAll(kursachDataSet);
            MainForm_Load(null, null);
        }

        private void searchField_TextChanged(object sender, EventArgs e)
        {
            bindingSource.SuspendBinding();
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                row.Visible = true;
            }
            string filterText = searchField.Text.ToLower();

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                bool matchFound = false;

                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.FormattedValue.ToString().ToLower().Contains(filterText))
                    {
                        matchFound = true;
                        break;
                    }
                }

                row.Visible = matchFound;
            }
            bindingSource.ResumeBinding();
        }

        private void clearSearchField_Click(object sender, EventArgs e)
        {
            searchField.Text = "";
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                row.Visible = true;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursachDataSet.Suppliers_PhotoProducts". При необходимости она может быть перемещена или удалена.
            this.suppliers_PhotoProductsTableAdapter.Fill(this.kursachDataSet.Suppliers_PhotoProducts);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursachDataSet.Suppliers". При необходимости она может быть перемещена или удалена.
            this.suppliersTableAdapter.Fill(this.kursachDataSet.Suppliers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursachDataSet.Services". При необходимости она может быть перемещена или удалена.
            this.servicesTableAdapter.Fill(this.kursachDataSet.Services);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursachDataSet.PhotoProducts". При необходимости она может быть перемещена или удалена.
            this.photoProductsTableAdapter.Fill(this.kursachDataSet.PhotoProducts);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursachDataSet.PaperTypes". При необходимости она может быть перемещена или удалена.
            this.paperTypesTableAdapter.Fill(this.kursachDataSet.PaperTypes);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursachDataSet.PaperFormats". При необходимости она может быть перемещена или удалена.
            this.paperFormatsTableAdapter.Fill(this.kursachDataSet.PaperFormats);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursachDataSet.Orders". При необходимости она может быть перемещена или удалена.
            this.ordersTableAdapter.Fill(this.kursachDataSet.Orders);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursachDataSet.Office". При необходимости она может быть перемещена или удалена.
            this.officeTableAdapter.Fill(this.kursachDataSet.Office);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursachDataSet.Materials". При необходимости она может быть перемещена или удалена.
            this.materialsTableAdapter.Fill(this.kursachDataSet.Materials);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursachDataSet.Kiosks_PhotoProducts". При необходимости она может быть перемещена или удалена.
            this.kiosks_PhotoProductsTableAdapter.Fill(this.kursachDataSet.Kiosks_PhotoProducts);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursachDataSet.Kiosks". При необходимости она может быть перемещена или удалена.
            this.kiosksTableAdapter.Fill(this.kursachDataSet.Kiosks);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursachDataSet.FilmTypes". При необходимости она может быть перемещена или удалена.
            this.filmTypesTableAdapter.Fill(this.kursachDataSet.FilmTypes);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursachDataSet.EquipmentTypes". При необходимости она может быть перемещена или удалена.
            this.equipmentTypesTableAdapter.Fill(this.kursachDataSet.EquipmentTypes);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursachDataSet.Equipments". При необходимости она может быть перемещена или удалена.
            this.equipmentsTableAdapter.Fill(this.kursachDataSet.Equipments);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursachDataSet.Discounts". При необходимости она может быть перемещена или удалена.
            this.discountsTableAdapter.Fill(this.kursachDataSet.Discounts);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursachDataSet.DiscountCards". При необходимости она может быть перемещена или удалена.
            this.discountCardsTableAdapter.Fill(this.kursachDataSet.DiscountCards);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursachDataSet.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.kursachDataSet.Clients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursachDataSet.Brands". При необходимости она может быть перемещена или удалена.
            this.brandsTableAdapter.Fill(this.kursachDataSet.Brands);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursachDataSet.Branches_Services". При необходимости она может быть перемещена или удалена.
            this.branches_ServicesTableAdapter.Fill(this.kursachDataSet.Branches_Services);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursachDataSet.Branches_Materials". При необходимости она может быть перемещена или удалена.
            this.branches_MaterialsTableAdapter.Fill(this.kursachDataSet.Branches_Materials);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursachDataSet.Branches_Equipments". При необходимости она может быть перемещена или удалена.
            this.branches_EquipmentsTableAdapter.Fill(this.kursachDataSet.Branches_Equipments);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursachDataSet.Branches". При необходимости она может быть перемещена или удалена.
            this.branchesTableAdapter.Fill(this.kursachDataSet.Branches);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursachDataSet.OrdersView". При необходимости она может быть перемещена или удалена.
            this.ordersViewTableAdapter.Fill(this.kursachDataSet.OrdersView);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursachDataSet.Deliveries". При необходимости она может быть перемещена или удалена.
            this.deliveriesTableAdapter.Fill(this.kursachDataSet.Deliveries);

        }

        private void dataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
