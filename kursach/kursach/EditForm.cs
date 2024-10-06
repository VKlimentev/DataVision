using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace kursach
{
    public partial class EditForm : Form
    {
        private DataTable _table;
        private bool _isEditing;
        private int _id;

        public EditForm(string tableName, bool isEditing, int id = 0)
        {
            InitializeComponent();
            EditForm_Load(this, EventArgs.Empty);

            _isEditing = isEditing;
            _table = kursachDataSet.Tables[tableName];
            _id = id;

            InitControls();
        }

        private void InitControls()
        {
            int length = 0;

            for (int i = 1; i < _table.Columns.Count; i++)
                CreateLabel(_table.Columns[i], ref length);

            for (int i = 1; i < _table.Columns.Count; i++)
            {
                if (_table.Columns[i].ColumnName.Contains("_Id"))
                    CreateComboBox(_table.Columns[i], length);

                else if (_table.Columns[i].DataType == typeof(DateTime))
                    CreateDateTimePicker(_table.Columns[i], length);

                else if (_table.Columns[i].DataType == typeof(bool))
                    CreateCheckBox(_table.Columns[i], length);

                else if (_table.Columns[i].DataType == typeof(decimal))
                    CreateDecimalNumericUpDown(_table.Columns[i], length);

                else if (_table.Columns[i].DataType == typeof(int))
                    CreateIntNumericUpDown(_table.Columns[i], length);

                else
                    CreateTextBox(_table.Columns[i], length);
            }

            CreateButton();
        }



        private void CreateLabel(DataColumn column, ref int length)
        {
            Label label = new Label();
            label.AutoSize = true;
            label.Font = GetDefaultFont();
            label.Location = new Point(12, 40 * column.Ordinal - 28);
            label.Text = !column.ColumnName.EndsWith("_Id") ? column.ColumnName : column.ColumnName.Remove(column.ColumnName.Length - 3) + "Name";
            Controls.Add(label);
            length = Math.Max(length, label.Width);
        }
        private void CreateComboBox(DataColumn column, int length)
        {
            ComboBox comboBox = new ComboBox();
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.Font = GetDefaultFont();
            comboBox.FormattingEnabled = true;
            comboBox.Location = new Point(25 + length, 40 * column.Ordinal - 28);
            comboBox.Size = new Size(200, 30);

            comboBox.DataSource = kursachDataSet.Tables[column.ColumnName.Remove(column.ColumnName.Length - 3)];
            comboBox.DisplayMember = kursachDataSet.Tables[column.ColumnName.Remove(column.ColumnName.Length - 3)].Columns[1].ColumnName;

            Controls.Add(comboBox);
        }
        private void CreateDateTimePicker(DataColumn column, int length)
        {
            DateTimePicker dateTimePicker = new DateTimePicker();
            dateTimePicker.Font = GetDefaultFont();
            dateTimePicker.Format = DateTimePickerFormat.Short;
            dateTimePicker.Location = new Point(25 + length, 40 * column.Ordinal - 28);
            dateTimePicker.Size = new Size(200, 30);

            if (_isEditing)
            {
                foreach (DataRow row in _table.Rows)
                {
                    if (row.Field<int>(0) == _id)
                    {
                        dateTimePicker.Value = row.Field<DateTime>(column);
                        break;
                    }
                }
            }

            Controls.Add(dateTimePicker);
        }
        private void CreateCheckBox(DataColumn column, int length)
        {
            CheckBox checkBox = new CheckBox();
            checkBox.Font = GetDefaultFont();
            checkBox.Location = new Point(25 + length, 40 * column.Ordinal - 28);
            checkBox.Size = new Size(200, 30);

            if (_isEditing)
            {
                foreach (DataRow row in _table.Rows)
                {
                    if (row.Field<int>(0) == _id)
                    {
                        checkBox.Checked = row.Field<bool>(column);
                        break;
                    }
                }
            }

            checkBox.UseVisualStyleBackColor = true;
            Controls.Add(checkBox);
        }
        private void CreateDecimalNumericUpDown(DataColumn column, int length)
        {
            NumericUpDown numericUpDown = new NumericUpDown();
            numericUpDown.Font = GetDefaultFont();
            numericUpDown.DecimalPlaces = 2;
            numericUpDown.Increment = 0.01M;
            numericUpDown.Maximum = 100000;
            numericUpDown.Location = new Point(25 + length, 40 * column.Ordinal - 28);
            numericUpDown.Size = new Size(200, 30);

            if (_isEditing)
            {
                foreach (DataRow row in _table.Rows)
                {
                    if (row.Field<int>(0) == _id)
                    {
                        numericUpDown.Value = row.Field<decimal>(column);
                        break;
                    }
                }
            }

            Controls.Add(numericUpDown);
        }
        private void CreateIntNumericUpDown(DataColumn column, int length)
        {
            NumericUpDown numericUpDown = new NumericUpDown();
            numericUpDown.Font = GetDefaultFont();
            numericUpDown.DecimalPlaces = 0;
            numericUpDown.Increment = 1;
            numericUpDown.Maximum = 100000;
            numericUpDown.Location = new Point(25 + length, 40 * column.Ordinal - 28);
            numericUpDown.Size = new Size(200, 30);

            if (_isEditing)
            {
                foreach (DataRow row in _table.Rows)
                {
                    if (row.Field<int>(0) == _id)
                    {
                        numericUpDown.Value = row.Field<int>(column);
                        break;
                    }
                }
            }

            Controls.Add(numericUpDown);
        }
        private void CreateTextBox(DataColumn column, int length)
        {
            TextBox textBox = new TextBox();
            textBox.Font = GetDefaultFont();
            textBox.Location = new Point(25 + length, 40 * column.Ordinal - 28);
            textBox.Size = new Size(200, 30);

            if (_isEditing)
            {
                foreach (DataRow row in _table.Rows)
                {
                    if (row.Field<int>(0) == _id)
                    {
                        textBox.Text = row[column].ToString();
                        break;
                    }
                }
            }

            Controls.Add(textBox);
        }
        private void CreateButton()
        {
            Button button = new Button();
            button.AutoSize = true;
            button.Location = new Point((ClientSize.Width - button.Width) / 2, 40 * _table.Columns.Count - 28);
            button.Font = GetDefaultFont();
            button.Text = "OK";
            button.UseVisualStyleBackColor = true;
            button.Click += okButton_Click;
            Controls.Add(button);
        }



        private void okButton_Click(object sender, EventArgs e)
        {
            int i = 1;
            DataRow dataRow = null;

            if (!_isEditing)
            {
                dataRow = _table.NewRow();
                _table.Rows.Add(dataRow);
            }
            else
            {
                foreach (DataRow row in _table.Rows)
                {
                    if (row.Field<int>(0) == _id)
                    {
                        dataRow = row;
                        break;
                    }
                }
            }

            if (dataRow != null)
            {
                foreach (Control control in Controls)
                {
                    if (control is Label)
                        continue;

                    object value = null;

                    if (control is TextBox)
                    {
                        value = ((TextBox)control).Text;
                    }
                    else if (control is ComboBox)
                    {
                        value = ((ComboBox)control).SelectedIndex + 1;
                    }
                    else if (control is NumericUpDown)
                    {
                        if (((NumericUpDown)control).DecimalPlaces == 0)
                            value = (int)((NumericUpDown)control).Value;
                        else
                            value = ((NumericUpDown)control).Value;
                    }
                    else if (control is CheckBox)
                    {
                        value = ((CheckBox)control).Checked;
                    }
                    else if (control is DateTimePicker)
                    {
                        value = ((DateTimePicker)control).Value;
                    }

                    if (value != null)
                    {
                        dataRow[_table.Columns[i].ColumnName] = value;
                        i++;
                    }
                }
            }
            tableAdapterManager.UpdateAll(kursachDataSet);
            this.Close();
        }

        private Font GetDefaultFont()
        {
            return new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
        }

        private void EditForm_Load(object sender, EventArgs e)
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

            if (!_isEditing)
                return;

            foreach (Control control in Controls)
            {
                if (control is ComboBox)
                {
                    for (int i = 1; i < _table.Columns.Count; i++)
                    {
                        if (_table.Columns[i].ColumnName.Contains("_Id"))
                        {
                            foreach (DataTable datatable in kursachDataSet.Tables)
                            {
                                if (datatable.TableName.Contains(_table.Columns[i].ColumnName.Remove(_table.Columns[i].ColumnName.Length - 3)) && !datatable.TableName.Contains("_"))
                                {
                                    for (int j = 0; j < datatable.Rows.Count; j++)
                                    {
                                        if (datatable.Rows[j].Field<Int32>(0) == _id)
                                        {
                                            ((ComboBox)control).SelectedIndex = j;
                                            break;
                                        }
                                    }
                                    break;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
