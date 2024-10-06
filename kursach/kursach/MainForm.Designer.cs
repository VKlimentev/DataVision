namespace kursach
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new System.Data.DataSet();
            this.kursachDataSet = new kursach.kursachDataSet();
            this.branchesTableAdapter = new kursach.kursachDataSetTableAdapters.BranchesTableAdapter();
            this.tableAdapterManager = new kursach.kursachDataSetTableAdapters.TableAdapterManager();
            this.branches_EquipmentsTableAdapter = new kursach.kursachDataSetTableAdapters.Branches_EquipmentsTableAdapter();
            this.branches_MaterialsTableAdapter = new kursach.kursachDataSetTableAdapters.Branches_MaterialsTableAdapter();
            this.branches_ServicesTableAdapter = new kursach.kursachDataSetTableAdapters.Branches_ServicesTableAdapter();
            this.brandsTableAdapter = new kursach.kursachDataSetTableAdapters.BrandsTableAdapter();
            this.clientsTableAdapter = new kursach.kursachDataSetTableAdapters.ClientsTableAdapter();
            this.discountCardsTableAdapter = new kursach.kursachDataSetTableAdapters.DiscountCardsTableAdapter();
            this.discountsTableAdapter = new kursach.kursachDataSetTableAdapters.DiscountsTableAdapter();
            this.equipmentsTableAdapter = new kursach.kursachDataSetTableAdapters.EquipmentsTableAdapter();
            this.equipmentTypesTableAdapter = new kursach.kursachDataSetTableAdapters.EquipmentTypesTableAdapter();
            this.filmTypesTableAdapter = new kursach.kursachDataSetTableAdapters.FilmTypesTableAdapter();
            this.kiosks_PhotoProductsTableAdapter = new kursach.kursachDataSetTableAdapters.Kiosks_PhotoProductsTableAdapter();
            this.kiosksTableAdapter = new kursach.kursachDataSetTableAdapters.KiosksTableAdapter();
            this.materialsTableAdapter = new kursach.kursachDataSetTableAdapters.MaterialsTableAdapter();
            this.officeTableAdapter = new kursach.kursachDataSetTableAdapters.OfficeTableAdapter();
            this.ordersTableAdapter = new kursach.kursachDataSetTableAdapters.OrdersTableAdapter();
            this.paperFormatsTableAdapter = new kursach.kursachDataSetTableAdapters.PaperFormatsTableAdapter();
            this.paperTypesTableAdapter = new kursach.kursachDataSetTableAdapters.PaperTypesTableAdapter();
            this.photoProductsTableAdapter = new kursach.kursachDataSetTableAdapters.PhotoProductsTableAdapter();
            this.servicesTableAdapter = new kursach.kursachDataSetTableAdapters.ServicesTableAdapter();
            this.suppliers_PhotoProductsTableAdapter = new kursach.kursachDataSetTableAdapters.Suppliers_PhotoProductsTableAdapter();
            this.suppliersTableAdapter = new kursach.kursachDataSetTableAdapters.SuppliersTableAdapter();
            this.ordersViewTableAdapter = new kursach.kursachDataSetTableAdapters.OrdersViewTableAdapter();
            this.deliveriesTableAdapter = new kursach.kursachDataSetTableAdapters.DeliveriesTableAdapter();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorEditItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.search = new System.Windows.Forms.ToolStripLabel();
            this.searchField = new System.Windows.Forms.ToolStripTextBox();
            this.clearSearchField = new System.Windows.Forms.ToolStripButton();
            this.TablesChooser = new System.Windows.Forms.ToolStripDropDownButton();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Pager = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursachDataSet)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).BeginInit();
            this.bindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.Pager.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "NewDataSet";
            // 
            // kursachDataSet
            // 
            this.kursachDataSet.DataSetName = "kursachDataSet";
            this.kursachDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // branchesTableAdapter
            // 
            this.branchesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Branches_EquipmentsTableAdapter = this.branches_EquipmentsTableAdapter;
            this.tableAdapterManager.Branches_MaterialsTableAdapter = this.branches_MaterialsTableAdapter;
            this.tableAdapterManager.Branches_ServicesTableAdapter = this.branches_ServicesTableAdapter;
            this.tableAdapterManager.BranchesTableAdapter = this.branchesTableAdapter;
            this.tableAdapterManager.BrandsTableAdapter = this.brandsTableAdapter;
            this.tableAdapterManager.ClientsTableAdapter = this.clientsTableAdapter;
            this.tableAdapterManager.DiscountCardsTableAdapter = this.discountCardsTableAdapter;
            this.tableAdapterManager.DiscountsTableAdapter = this.discountsTableAdapter;
            this.tableAdapterManager.EquipmentsTableAdapter = this.equipmentsTableAdapter;
            this.tableAdapterManager.EquipmentTypesTableAdapter = this.equipmentTypesTableAdapter;
            this.tableAdapterManager.FilmTypesTableAdapter = this.filmTypesTableAdapter;
            this.tableAdapterManager.Kiosks_PhotoProductsTableAdapter = this.kiosks_PhotoProductsTableAdapter;
            this.tableAdapterManager.KiosksTableAdapter = this.kiosksTableAdapter;
            this.tableAdapterManager.MaterialsTableAdapter = this.materialsTableAdapter;
            this.tableAdapterManager.OfficeTableAdapter = this.officeTableAdapter;
            this.tableAdapterManager.OrdersTableAdapter = this.ordersTableAdapter;
            this.tableAdapterManager.PaperFormatsTableAdapter = this.paperFormatsTableAdapter;
            this.tableAdapterManager.PaperTypesTableAdapter = this.paperTypesTableAdapter;
            this.tableAdapterManager.PhotoProductsTableAdapter = this.photoProductsTableAdapter;
            this.tableAdapterManager.ServicesTableAdapter = this.servicesTableAdapter;
            this.tableAdapterManager.Suppliers_PhotoProductsTableAdapter = this.suppliers_PhotoProductsTableAdapter;
            this.tableAdapterManager.SuppliersTableAdapter = this.suppliersTableAdapter;
            this.tableAdapterManager.UpdateOrder = kursach.kursachDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // branches_EquipmentsTableAdapter
            // 
            this.branches_EquipmentsTableAdapter.ClearBeforeFill = true;
            // 
            // branches_MaterialsTableAdapter
            // 
            this.branches_MaterialsTableAdapter.ClearBeforeFill = true;
            // 
            // branches_ServicesTableAdapter
            // 
            this.branches_ServicesTableAdapter.ClearBeforeFill = true;
            // 
            // brandsTableAdapter
            // 
            this.brandsTableAdapter.ClearBeforeFill = true;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // discountCardsTableAdapter
            // 
            this.discountCardsTableAdapter.ClearBeforeFill = true;
            // 
            // discountsTableAdapter
            // 
            this.discountsTableAdapter.ClearBeforeFill = true;
            // 
            // equipmentsTableAdapter
            // 
            this.equipmentsTableAdapter.ClearBeforeFill = true;
            // 
            // equipmentTypesTableAdapter
            // 
            this.equipmentTypesTableAdapter.ClearBeforeFill = true;
            // 
            // filmTypesTableAdapter
            // 
            this.filmTypesTableAdapter.ClearBeforeFill = true;
            // 
            // kiosks_PhotoProductsTableAdapter
            // 
            this.kiosks_PhotoProductsTableAdapter.ClearBeforeFill = true;
            // 
            // kiosksTableAdapter
            // 
            this.kiosksTableAdapter.ClearBeforeFill = true;
            // 
            // materialsTableAdapter
            // 
            this.materialsTableAdapter.ClearBeforeFill = true;
            // 
            // officeTableAdapter
            // 
            this.officeTableAdapter.ClearBeforeFill = true;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // paperFormatsTableAdapter
            // 
            this.paperFormatsTableAdapter.ClearBeforeFill = true;
            // 
            // paperTypesTableAdapter
            // 
            this.paperTypesTableAdapter.ClearBeforeFill = true;
            // 
            // photoProductsTableAdapter
            // 
            this.photoProductsTableAdapter.ClearBeforeFill = true;
            // 
            // servicesTableAdapter
            // 
            this.servicesTableAdapter.ClearBeforeFill = true;
            // 
            // suppliers_PhotoProductsTableAdapter
            // 
            this.suppliers_PhotoProductsTableAdapter.ClearBeforeFill = true;
            // 
            // suppliersTableAdapter
            // 
            this.suppliersTableAdapter.ClearBeforeFill = true;
            // 
            // ordersViewTableAdapter
            // 
            this.ordersViewTableAdapter.ClearBeforeFill = true;
            // 
            // deliveriesTableAdapter
            // 
            this.deliveriesTableAdapter.ClearBeforeFill = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView);
            this.tabPage1.Controls.Add(this.bindingNavigator);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 413);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tables";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // bindingNavigator
            // 
            this.bindingNavigator.AddNewItem = null;
            this.bindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator.CountItemFormat = "of {0}";
            this.bindingNavigator.DeleteItem = null;
            this.bindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddItem,
            this.bindingNavigatorEditItem,
            this.bindingNavigatorDeleteItem,
            this.toolStripSeparator1,
            this.search,
            this.searchField,
            this.clearSearchField,
            this.TablesChooser});
            this.bindingNavigator.Location = new System.Drawing.Point(3, 3);
            this.bindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator.Name = "bindingNavigator";
            this.bindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator.Size = new System.Drawing.Size(786, 25);
            this.bindingNavigator.TabIndex = 3;
            this.bindingNavigator.Text = "bindingNavigator";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 22);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(38, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddItem
            // 
            this.bindingNavigatorAddItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddItem.Enabled = false;
            this.bindingNavigatorAddItem.Image = global::kursach.Properties.Resources.plus;
            this.bindingNavigatorAddItem.Name = "bindingNavigatorAddItem";
            this.bindingNavigatorAddItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddItem.Text = "Добавить";
            this.bindingNavigatorAddItem.Click += new System.EventHandler(this.bindingNavigatorAddItem_Click);
            // 
            // bindingNavigatorEditItem
            // 
            this.bindingNavigatorEditItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorEditItem.Enabled = false;
            this.bindingNavigatorEditItem.Image = global::kursach.Properties.Resources.enableEdit;
            this.bindingNavigatorEditItem.Name = "bindingNavigatorEditItem";
            this.bindingNavigatorEditItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorEditItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorEditItem.Text = "Редактировать";
            this.bindingNavigatorEditItem.Click += new System.EventHandler(this.bindingNavigatorEditItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Enabled = false;
            this.bindingNavigatorDeleteItem.Image = global::kursach.Properties.Resources.cross;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // search
            // 
            this.search.Enabled = false;
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.search.Image = ((System.Drawing.Image)(resources.GetObject("search.Image")));
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(66, 22);
            this.search.Text = "Search";
            // 
            // searchField
            // 
            this.searchField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchField.Enabled = false;
            this.searchField.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchField.Name = "searchField";
            this.searchField.Size = new System.Drawing.Size(100, 25);
            this.searchField.TextChanged += new System.EventHandler(this.searchField_TextChanged);
            // 
            // clearSearchField
            // 
            this.clearSearchField.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clearSearchField.Enabled = false;
            this.clearSearchField.Image = global::kursach.Properties.Resources.eraser;
            this.clearSearchField.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.clearSearchField.Name = "clearSearchField";
            this.clearSearchField.Size = new System.Drawing.Size(23, 22);
            this.clearSearchField.Text = "Очистить";
            this.clearSearchField.Click += new System.EventHandler(this.clearSearchField_Click);
            // 
            // TablesChooser
            // 
            this.TablesChooser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TablesChooser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TablesChooser.Image = ((System.Drawing.Image)(resources.GetObject("TablesChooser.Image")));
            this.TablesChooser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TablesChooser.Name = "TablesChooser";
            this.TablesChooser.Size = new System.Drawing.Size(63, 22);
            this.TablesChooser.Text = "Tables";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(3, 28);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(786, 382);
            this.dataGridView.TabIndex = 3;
            this.dataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView_CellFormatting);
            this.dataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView_DataError);
            // 
            // Pager
            // 
            this.Pager.Controls.Add(this.tabPage1);
            this.Pager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pager.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pager.Location = new System.Drawing.Point(0, 0);
            this.Pager.Name = "Pager";
            this.Pager.SelectedIndex = 0;
            this.Pager.Size = new System.Drawing.Size(800, 450);
            this.Pager.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Pager);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhotoCenter";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursachDataSet)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).EndInit();
            this.bindingNavigator.ResumeLayout(false);
            this.bindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.Pager.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private kursachDataSet kursachDataSet;
        private kursachDataSetTableAdapters.BranchesTableAdapter branchesTableAdapter;
        private kursachDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private kursachDataSetTableAdapters.Branches_EquipmentsTableAdapter branches_EquipmentsTableAdapter;
        private kursachDataSetTableAdapters.Branches_MaterialsTableAdapter branches_MaterialsTableAdapter;
        private kursachDataSetTableAdapters.Branches_ServicesTableAdapter branches_ServicesTableAdapter;
        private kursachDataSetTableAdapters.BrandsTableAdapter brandsTableAdapter;
        private kursachDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private kursachDataSetTableAdapters.DiscountCardsTableAdapter discountCardsTableAdapter;
        private kursachDataSetTableAdapters.DiscountsTableAdapter discountsTableAdapter;
        private kursachDataSetTableAdapters.EquipmentsTableAdapter equipmentsTableAdapter;
        private kursachDataSetTableAdapters.EquipmentTypesTableAdapter equipmentTypesTableAdapter;
        private kursachDataSetTableAdapters.FilmTypesTableAdapter filmTypesTableAdapter;
        private kursachDataSetTableAdapters.KiosksTableAdapter kiosksTableAdapter;
        private kursachDataSetTableAdapters.Kiosks_PhotoProductsTableAdapter kiosks_PhotoProductsTableAdapter;
        private kursachDataSetTableAdapters.MaterialsTableAdapter materialsTableAdapter;
        private kursachDataSetTableAdapters.OfficeTableAdapter officeTableAdapter;
        private kursachDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private kursachDataSetTableAdapters.PaperFormatsTableAdapter paperFormatsTableAdapter;
        private kursachDataSetTableAdapters.PaperTypesTableAdapter paperTypesTableAdapter;
        private kursachDataSetTableAdapters.PhotoProductsTableAdapter photoProductsTableAdapter;
        private kursachDataSetTableAdapters.ServicesTableAdapter servicesTableAdapter;
        private kursachDataSetTableAdapters.SuppliersTableAdapter suppliersTableAdapter;
        private kursachDataSetTableAdapters.Suppliers_PhotoProductsTableAdapter suppliers_PhotoProductsTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource;
        private System.Data.DataSet dataSet;
        private kursachDataSetTableAdapters.OrdersViewTableAdapter ordersViewTableAdapter;
        private kursachDataSetTableAdapters.DeliveriesTableAdapter deliveriesTableAdapter;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingNavigator bindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorEditItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel search;
        private System.Windows.Forms.ToolStripTextBox searchField;
        private System.Windows.Forms.ToolStripButton clearSearchField;
        private System.Windows.Forms.ToolStripDropDownButton TablesChooser;
        private System.Windows.Forms.TabControl Pager;
    }
}

