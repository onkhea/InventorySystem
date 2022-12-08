namespace InventorySystem.GUI.CheckStock
{
    partial class XtraForm1
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding1 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding2 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding3 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding4 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding5 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding6 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding7 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding8 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.inventoryModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ស្តុកជាក់ស្តែង = new DevExpress.XtraPivotGrid.PivotGridField();
            this.បញ្ហាទំនិញ = new DevExpress.XtraPivotGrid.PivotGridField();
            this.ចំនួននៅសល់ = new DevExpress.XtraPivotGrid.PivotGridField();
            this.ទីតាំងឃ្លាំង = new DevExpress.XtraPivotGrid.PivotGridField();
            this.សាខា = new DevExpress.XtraPivotGrid.PivotGridField();
            this.ទំនិញ = new DevExpress.XtraPivotGrid.PivotGridField();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.serviceLocationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pivotGridField1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField2 = new DevExpress.XtraPivotGrid.PivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceLocationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1310, 20);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 619);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1310, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 20);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 599);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1310, 20);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 599);
            // 
            // Root
            // 
            this.Root.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1287, 521);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.pivotGridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1267, 501);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pivotGridControl1.DataSource = this.inventoryModelBindingSource;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.ស្តុកជាក់ស្តែង,
            this.បញ្ហាទំនិញ,
            this.ចំនួននៅសល់,
            this.ទីតាំងឃ្លាំង,
            this.សាខា,
            this.ទំនិញ});
            this.pivotGridControl1.Location = new System.Drawing.Point(12, 12);
            this.pivotGridControl1.MenuManager = this.barManager1;
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized;
            this.pivotGridControl1.Size = new System.Drawing.Size(1263, 497);
            this.pivotGridControl1.TabIndex = 4;
            this.pivotGridControl1.Click += new System.EventHandler(this.pivotGridControl1_Click);
            // 
            // inventoryModelBindingSource
            // 
            this.inventoryModelBindingSource.DataSource = typeof(InventorySystem.GUI.inventory.InventoryModel);
            // 
            // ស្តុកជាក់ស្តែង
            // 
            this.ស្តុកជាក់ស្តែង.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.ស្តុកជាក់ស្តែង.AreaIndex = 0;
            this.ស្តុកជាក់ស្តែង.Caption = "ស្តុកជាក់ស្តែង";
            dataSourceColumnBinding1.ColumnName = "Saller";
            this.ស្តុកជាក់ស្តែង.DataBinding = dataSourceColumnBinding1;
            this.ស្តុកជាក់ស្តែង.Name = "ស្តុកជាក់ស្តែង";
            this.ស្តុកជាក់ស្តែង.Width = 139;
            // 
            // បញ្ហាទំនិញ
            // 
            this.បញ្ហាទំនិញ.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.បញ្ហាទំនិញ.AreaIndex = 1;
            this.បញ្ហាទំនិញ.DataBinding = dataSourceColumnBinding2;
            this.បញ្ហាទំនិញ.Name = "បញ្ហាទំនិញ";
            this.បញ្ហាទំនិញ.Width = 170;
            // 
            // ចំនួននៅសល់
            // 
            this.ចំនួននៅសល់.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.ចំនួននៅសល់.AreaIndex = 2;
            this.ចំនួននៅសល់.Caption = "ចំនួននៅសល់";
            dataSourceColumnBinding3.ColumnName = "Price";
            this.ចំនួននៅសល់.DataBinding = dataSourceColumnBinding3;
            this.ចំនួននៅសល់.Name = "ចំនួននៅសល់";
            this.ចំនួននៅសល់.Width = 110;
            // 
            // ទីតាំងឃ្លាំង
            // 
            this.ទីតាំងឃ្លាំង.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.ទីតាំងឃ្លាំង.AreaIndex = 0;
            this.ទីតាំងឃ្លាំង.Caption = "ទីតាំងឃ្លាំង";
            dataSourceColumnBinding4.ColumnName = "Location";
            this.ទីតាំងឃ្លាំង.DataBinding = dataSourceColumnBinding4;
            this.ទីតាំងឃ្លាំង.Name = "ទីតាំងឃ្លាំង";
            // 
            // សាខា
            // 
            this.សាខា.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.សាខា.AreaIndex = 0;
            this.សាខា.Caption = "សាខា";
            dataSourceColumnBinding5.ColumnName = "Client";
            this.សាខា.DataBinding = dataSourceColumnBinding5;
            this.សាខា.Name = "សាខា";
            this.សាខា.Width = 240;
            // 
            // ទំនិញ
            // 
            this.ទំនិញ.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.ទំនិញ.AreaIndex = 1;
            this.ទំនិញ.Caption = "ទំនិញ";
            dataSourceColumnBinding6.ColumnName = "Price";
            this.ទំនិញ.DataBinding = dataSourceColumnBinding6;
            this.ទំនិញ.Name = "ទំនិញ";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutControl1.Controls.Add(this.pivotGridControl1);
            this.layoutControl1.Location = new System.Drawing.Point(11, 26);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1270, 286, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1287, 521);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // serviceLocationBindingSource
            // 
            this.serviceLocationBindingSource.DataSource = typeof(InventorySystem.ServiceLocation.ServiceLocation);
            // 
            // pivotGridField1
            // 
            this.pivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.pivotGridField1.AreaIndex = 2;
            this.pivotGridField1.Caption = "LoadData";
            dataSourceColumnBinding7.ColumnName = "Price";
            this.pivotGridField1.DataBinding = dataSourceColumnBinding7;
            this.pivotGridField1.Name = "pivotGridField1";
            this.pivotGridField1.Width = 110;
            // 
            // pivotGridField2
            // 
            this.pivotGridField2.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.pivotGridField2.AreaIndex = 2;
            this.pivotGridField2.Caption = "LoadData";
            dataSourceColumnBinding8.ColumnName = "Price";
            this.pivotGridField2.DataBinding = dataSourceColumnBinding8;
            this.pivotGridField2.Name = "pivotGridField2";
            this.pivotGridField2.Width = 110;
            // 
            // XtraForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 639);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "XtraForm1";
            this.Text = "ត្រួតពិនិត្យទំនិញ";
            this.Load += new System.EventHandler(this.XtraForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.serviceLocationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraPivotGrid.PivotGridField ស្តុកជាក់ស្តែង;
        private DevExpress.XtraPivotGrid.PivotGridField បញ្ហាទំនិញ;
        private DevExpress.XtraPivotGrid.PivotGridField ចំនួននៅសល់;
        private DevExpress.XtraPivotGrid.PivotGridField ទីតាំងឃ្លាំង;
        private DevExpress.XtraPivotGrid.PivotGridField សាខា;
        private DevExpress.XtraPivotGrid.PivotGridField ទំនិញ;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource inventoryModelBindingSource;
        private System.Windows.Forms.BindingSource serviceLocationBindingSource;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField1;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField2;
    }
}