namespace kursach
{
    partial class EditForm
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
            //this.printOrdersTableAdapter = new kursach.kursachDataSetTableAdapters.PrintOrdersTableAdapter();
            this.servicesTableAdapter = new kursach.kursachDataSetTableAdapters.ServicesTableAdapter();
            this.suppliers_PhotoProductsTableAdapter = new kursach.kursachDataSetTableAdapters.Suppliers_PhotoProductsTableAdapter();
            this.suppliersTableAdapter = new kursach.kursachDataSetTableAdapters.SuppliersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.kursachDataSet)).BeginInit();
            this.SuspendLayout();
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
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(635, 347);
            this.Name = "EditForm";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditForm";
            this.Load += new System.EventHandler(this.EditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kursachDataSet)).EndInit();
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
        //private kursachDataSetTableAdapters.PrintOrdersTableAdapter printOrdersTableAdapter;
        private kursachDataSetTableAdapters.ServicesTableAdapter servicesTableAdapter;
        private kursachDataSetTableAdapters.SuppliersTableAdapter suppliersTableAdapter;
        private kursachDataSetTableAdapters.Suppliers_PhotoProductsTableAdapter suppliers_PhotoProductsTableAdapter;
    }
}