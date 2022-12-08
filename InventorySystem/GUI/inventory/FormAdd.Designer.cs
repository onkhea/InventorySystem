namespace InventorySystem.GUI.inventory
{
    partial class FormAdd
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
            this.BtAdd = new DevExpress.XtraEditors.SimpleButton();
            this.txtPrice = new DevExpress.XtraEditors.TextEdit();
            this.txtClient = new DevExpress.XtraEditors.TextEdit();
            this.txtLocation = new DevExpress.XtraEditors.TextEdit();
            this.txtDelivery = new DevExpress.XtraEditors.TextEdit();
            this.txtSell = new DevExpress.XtraEditors.TextEdit();
            this.txtStartDate = new DevExpress.XtraEditors.DateEdit();
            this.TxtEnddate = new DevExpress.XtraEditors.DateEdit();
            this.BtClear = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClient.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDelivery.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSell.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEnddate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEnddate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // BtAdd
            // 
            this.BtAdd.Appearance.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.BtAdd.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtAdd.Appearance.Options.UseBackColor = true;
            this.BtAdd.Appearance.Options.UseFont = true;
            this.BtAdd.Appearance.Options.UseForeColor = true;
            this.BtAdd.Location = new System.Drawing.Point(219, 340);
            this.BtAdd.Name = "BtAdd";
            this.BtAdd.Size = new System.Drawing.Size(75, 26);
            this.BtAdd.TabIndex = 10;
            this.BtAdd.Text = "បញ្ចូល";
            this.BtAdd.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.EditValue = "0";
            this.txtPrice.Location = new System.Drawing.Point(219, 201);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.txtPrice.Properties.Appearance.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.txtPrice.Properties.Appearance.Options.UseBackColor = true;
            this.txtPrice.Properties.Appearance.Options.UseFont = true;
            this.txtPrice.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtPrice.Properties.MaskSettings.Set("mask", "c");
            this.txtPrice.Properties.UseMaskAsDisplayFormat = true;
            this.txtPrice.Size = new System.Drawing.Size(198, 30);
            this.txtPrice.TabIndex = 4;
            // 
            // txtClient
            // 
            this.txtClient.Location = new System.Drawing.Point(219, 153);
            this.txtClient.Name = "txtClient";
            this.txtClient.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.txtClient.Properties.Appearance.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.txtClient.Properties.Appearance.Options.UseBackColor = true;
            this.txtClient.Properties.Appearance.Options.UseFont = true;
            this.txtClient.Size = new System.Drawing.Size(198, 30);
            this.txtClient.TabIndex = 3;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(219, 104);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.txtLocation.Properties.Appearance.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.txtLocation.Properties.Appearance.Options.UseBackColor = true;
            this.txtLocation.Properties.Appearance.Options.UseFont = true;
            this.txtLocation.Size = new System.Drawing.Size(198, 30);
            this.txtLocation.TabIndex = 2;
            // 
            // txtDelivery
            // 
            this.txtDelivery.Location = new System.Drawing.Point(219, 58);
            this.txtDelivery.Name = "txtDelivery";
            this.txtDelivery.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.txtDelivery.Properties.Appearance.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.txtDelivery.Properties.Appearance.Options.UseBackColor = true;
            this.txtDelivery.Properties.Appearance.Options.UseFont = true;
            this.txtDelivery.Size = new System.Drawing.Size(198, 30);
            this.txtDelivery.TabIndex = 1;
            // 
            // txtSell
            // 
            this.txtSell.Location = new System.Drawing.Point(219, 12);
            this.txtSell.Name = "txtSell";
            this.txtSell.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.txtSell.Properties.Appearance.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.txtSell.Properties.Appearance.Options.UseBackColor = true;
            this.txtSell.Properties.Appearance.Options.UseFont = true;
            this.txtSell.Size = new System.Drawing.Size(198, 30);
            this.txtSell.TabIndex = 0;
            // 
            // txtStartDate
            // 
            this.txtStartDate.EditValue = null;
            this.txtStartDate.Location = new System.Drawing.Point(219, 245);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.txtStartDate.Properties.Appearance.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.txtStartDate.Properties.Appearance.Options.UseBackColor = true;
            this.txtStartDate.Properties.Appearance.Options.UseFont = true;
            this.txtStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtStartDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtStartDate.Properties.MaskSettings.Set("mask", "d");
            this.txtStartDate.Size = new System.Drawing.Size(198, 30);
            this.txtStartDate.TabIndex = 11;
            // 
            // TxtEnddate
            // 
            this.TxtEnddate.EditValue = null;
            this.TxtEnddate.Location = new System.Drawing.Point(219, 291);
            this.TxtEnddate.Name = "TxtEnddate";
            this.TxtEnddate.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.TxtEnddate.Properties.Appearance.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.TxtEnddate.Properties.Appearance.Options.UseBackColor = true;
            this.TxtEnddate.Properties.Appearance.Options.UseFont = true;
            this.TxtEnddate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TxtEnddate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TxtEnddate.Properties.MaskSettings.Set("mask", "d");
            this.TxtEnddate.Size = new System.Drawing.Size(198, 30);
            this.TxtEnddate.TabIndex = 12;
            // 
            // BtClear
            // 
            this.BtClear.Appearance.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtClear.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.BtClear.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtClear.Appearance.Options.UseBackColor = true;
            this.BtClear.Appearance.Options.UseFont = true;
            this.BtClear.Appearance.Options.UseForeColor = true;
            this.BtClear.Location = new System.Drawing.Point(342, 340);
            this.BtClear.Name = "BtClear";
            this.BtClear.Size = new System.Drawing.Size(75, 26);
            this.BtClear.TabIndex = 15;
            this.BtClear.Text = "សំអាត";
            this.BtClear.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(102, 209);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(64, 19);
            this.labelControl5.TabIndex = 20;
            this.labelControl5.Text = "តម្លៃទំនិញ";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(102, 156);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(89, 19);
            this.labelControl4.TabIndex = 19;
            this.labelControl4.Text = "ឈ្មោះអ្នកទទួល";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(104, 112);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(38, 19);
            this.labelControl3.TabIndex = 18;
            this.labelControl3.Text = "ទីតាង";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(102, 71);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(82, 19);
            this.labelControl2.TabIndex = 17;
            this.labelControl2.Text = "អ្នកដីកទំនិញ";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(102, 20);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(67, 19);
            this.labelControl1.TabIndex = 16;
            this.labelControl1.Text = "ឈ្មោះទំនិញ";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(104, 253);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(57, 19);
            this.labelControl6.TabIndex = 21;
            this.labelControl6.Text = "ថ្ងៃនាំចូល";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(102, 299);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(62, 19);
            this.labelControl7.TabIndex = 22;
            this.labelControl7.Text = "ថ្ងៃនាំចេញ";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.Location = new System.Drawing.Point(465, 340);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 26);
            this.simpleButton1.TabIndex = 23;
            this.simpleButton1.Text = "បោះបង់";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click_1);
            // 
            // FormAdd
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 392);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.BtClear);
            this.Controls.Add(this.TxtEnddate);
            this.Controls.Add(this.txtStartDate);
            this.Controls.Add(this.BtAdd);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtClient);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.txtDelivery);
            this.Controls.Add(this.txtSell);
            this.IconOptions.Image = global::InventorySystem.Properties.Resources.gold_golden_k_alphabet_letter_logo_icon_with_floral_design_for_business_and_company_vector__1_;
            this.Name = "FormAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAdd";
            this.Load += new System.EventHandler(this.FormAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClient.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDelivery.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSell.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEnddate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEnddate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtSell;
        private DevExpress.XtraEditors.TextEdit txtDelivery;
        private DevExpress.XtraEditors.TextEdit txtLocation;
        private DevExpress.XtraEditors.TextEdit txtClient;
        private DevExpress.XtraEditors.TextEdit txtPrice;
        private DevExpress.XtraEditors.SimpleButton BtAdd;
        private DevExpress.XtraEditors.DateEdit txtStartDate;
        private DevExpress.XtraEditors.DateEdit TxtEnddate;
        private DevExpress.XtraEditors.SimpleButton BtClear;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}