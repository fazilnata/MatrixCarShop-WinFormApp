namespace NataCarShop.Forms
{
    partial class AdminPage1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPage1));
            this.allAdsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carShopDataSet1 = new NataCarShop.CarShopDataSet1();
            this.deletebtn = new DevExpress.XtraEditors.SimpleButton();
            this.btnBack = new DevExpress.XtraEditors.SimpleButton();
            this.all_AdsTableAdapter = new NataCarShop.CarShopDataSet1TableAdapters.All_AdsTableAdapter();
            this.idDatatxt = new System.Windows.Forms.TextBox();
            this.idlbl = new DevExpress.XtraEditors.LabelControl();
            this.searchbtn = new DevExpress.XtraEditors.SimpleButton();
            this.carsdatagridview = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bodyTypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.walkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currencyIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.barterDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fuelTypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transmissionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gearboxIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.founderYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.engineVolumeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alloyWheelsDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.centralClosureDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.leatherSalonDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.seatVentilationDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.uSADataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.parkingRadarDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.xenonDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lukeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.conditionerDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.rearCameraDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.rainSensorDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.seatHeatingDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.sideCurtainsDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.allAdsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carShopDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsdatagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // allAdsBindingSource
            // 
            this.allAdsBindingSource.DataMember = "All_Ads";
            this.allAdsBindingSource.DataSource = this.carShopDataSet1;
            // 
            // carShopDataSet1
            // 
            this.carShopDataSet1.DataSetName = "CarShopDataSet1";
            this.carShopDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // deletebtn
            // 
            this.deletebtn.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deletebtn.Appearance.Options.UseFont = true;
            this.deletebtn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("deletebtn.ImageOptions.SvgImage")));
            this.deletebtn.ImageOptions.SvgImageSize = new System.Drawing.Size(12, 12);
            this.deletebtn.Location = new System.Drawing.Point(501, 12);
            this.deletebtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(166, 36);
            this.deletebtn.TabIndex = 27;
            this.deletebtn.Text = "Sil\r\n";
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // btnBack
            // 
            this.btnBack.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.Appearance.Options.UseFont = true;
            this.btnBack.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBack.ImageOptions.SvgImage")));
            this.btnBack.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.btnBack.Location = new System.Drawing.Point(1381, 15);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(166, 36);
            this.btnBack.TabIndex = 26;
            this.btnBack.Text = "Əsas Menyu";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // all_AdsTableAdapter
            // 
            this.all_AdsTableAdapter.ClearBeforeFill = true;
            // 
            // idDatatxt
            // 
            this.idDatatxt.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idDatatxt.Location = new System.Drawing.Point(42, 18);
            this.idDatatxt.Name = "idDatatxt";
            this.idDatatxt.Size = new System.Drawing.Size(166, 30);
            this.idDatatxt.TabIndex = 30;
            // 
            // idlbl
            // 
            this.idlbl.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idlbl.Appearance.Options.UseFont = true;
            this.idlbl.Location = new System.Drawing.Point(5, 17);
            this.idlbl.Name = "idlbl";
            this.idlbl.Size = new System.Drawing.Size(21, 23);
            this.idlbl.TabIndex = 31;
            this.idlbl.Text = "ID";
            // 
            // searchbtn
            // 
            this.searchbtn.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchbtn.Appearance.Options.UseFont = true;
            this.searchbtn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("searchbtn.ImageOptions.SvgImage")));
            this.searchbtn.ImageOptions.SvgImageSize = new System.Drawing.Size(14, 14);
            this.searchbtn.Location = new System.Drawing.Point(286, 12);
            this.searchbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(166, 36);
            this.searchbtn.TabIndex = 32;
            this.searchbtn.Text = "Axtar";
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // carsdatagridview
            // 
            this.carsdatagridview.AutoGenerateColumns = false;
            this.carsdatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carsdatagridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.modelIDDataGridViewTextBoxColumn,
            this.bodyTypeIDDataGridViewTextBoxColumn,
            this.walkDataGridViewTextBoxColumn,
            this.colorIDDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.currencyIDDataGridViewTextBoxColumn,
            this.creditDataGridViewCheckBoxColumn,
            this.barterDataGridViewCheckBoxColumn,
            this.fuelTypeIDDataGridViewTextBoxColumn,
            this.transmissionIDDataGridViewTextBoxColumn,
            this.gearboxIDDataGridViewTextBoxColumn,
            this.founderYearDataGridViewTextBoxColumn,
            this.engineVolumeIDDataGridViewTextBoxColumn,
            this.hPDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn,
            this.alloyWheelsDataGridViewCheckBoxColumn,
            this.centralClosureDataGridViewCheckBoxColumn,
            this.leatherSalonDataGridViewCheckBoxColumn,
            this.seatVentilationDataGridViewCheckBoxColumn,
            this.uSADataGridViewCheckBoxColumn,
            this.parkingRadarDataGridViewCheckBoxColumn,
            this.xenonDataGridViewCheckBoxColumn,
            this.lukeDataGridViewCheckBoxColumn,
            this.conditionerDataGridViewCheckBoxColumn,
            this.rearCameraDataGridViewCheckBoxColumn,
            this.rainSensorDataGridViewCheckBoxColumn,
            this.seatHeatingDataGridViewCheckBoxColumn,
            this.sideCurtainsDataGridViewCheckBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.cityIDDataGridViewTextBoxColumn,
            this.contactDataGridViewTextBoxColumn});
            this.carsdatagridview.DataSource = this.allAdsBindingSource;
            this.carsdatagridview.Location = new System.Drawing.Point(5, 81);
            this.carsdatagridview.Name = "carsdatagridview";
            this.carsdatagridview.RowHeadersWidth = 62;
            this.carsdatagridview.RowTemplate.Height = 28;
            this.carsdatagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.carsdatagridview.Size = new System.Drawing.Size(1565, 796);
            this.carsdatagridview.TabIndex = 33;
            this.carsdatagridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.carsdatagridview_CellClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 150;
            // 
            // modelIDDataGridViewTextBoxColumn
            // 
            this.modelIDDataGridViewTextBoxColumn.DataPropertyName = "Model_ID";
            this.modelIDDataGridViewTextBoxColumn.HeaderText = "Model_ID";
            this.modelIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.modelIDDataGridViewTextBoxColumn.Name = "modelIDDataGridViewTextBoxColumn";
            this.modelIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // bodyTypeIDDataGridViewTextBoxColumn
            // 
            this.bodyTypeIDDataGridViewTextBoxColumn.DataPropertyName = "Body_Type_ID";
            this.bodyTypeIDDataGridViewTextBoxColumn.HeaderText = "Body_Type_ID";
            this.bodyTypeIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.bodyTypeIDDataGridViewTextBoxColumn.Name = "bodyTypeIDDataGridViewTextBoxColumn";
            this.bodyTypeIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // walkDataGridViewTextBoxColumn
            // 
            this.walkDataGridViewTextBoxColumn.DataPropertyName = "Walk";
            this.walkDataGridViewTextBoxColumn.HeaderText = "Walk";
            this.walkDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.walkDataGridViewTextBoxColumn.Name = "walkDataGridViewTextBoxColumn";
            this.walkDataGridViewTextBoxColumn.Width = 150;
            // 
            // colorIDDataGridViewTextBoxColumn
            // 
            this.colorIDDataGridViewTextBoxColumn.DataPropertyName = "Color_ID";
            this.colorIDDataGridViewTextBoxColumn.HeaderText = "Color_ID";
            this.colorIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.colorIDDataGridViewTextBoxColumn.Name = "colorIDDataGridViewTextBoxColumn";
            this.colorIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 150;
            // 
            // currencyIDDataGridViewTextBoxColumn
            // 
            this.currencyIDDataGridViewTextBoxColumn.DataPropertyName = "Currency_ID";
            this.currencyIDDataGridViewTextBoxColumn.HeaderText = "Currency_ID";
            this.currencyIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.currencyIDDataGridViewTextBoxColumn.Name = "currencyIDDataGridViewTextBoxColumn";
            this.currencyIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // creditDataGridViewCheckBoxColumn
            // 
            this.creditDataGridViewCheckBoxColumn.DataPropertyName = "Credit";
            this.creditDataGridViewCheckBoxColumn.HeaderText = "Credit";
            this.creditDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.creditDataGridViewCheckBoxColumn.Name = "creditDataGridViewCheckBoxColumn";
            this.creditDataGridViewCheckBoxColumn.Width = 150;
            // 
            // barterDataGridViewCheckBoxColumn
            // 
            this.barterDataGridViewCheckBoxColumn.DataPropertyName = "Barter";
            this.barterDataGridViewCheckBoxColumn.HeaderText = "Barter";
            this.barterDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.barterDataGridViewCheckBoxColumn.Name = "barterDataGridViewCheckBoxColumn";
            this.barterDataGridViewCheckBoxColumn.Width = 150;
            // 
            // fuelTypeIDDataGridViewTextBoxColumn
            // 
            this.fuelTypeIDDataGridViewTextBoxColumn.DataPropertyName = "Fuel_Type_ID";
            this.fuelTypeIDDataGridViewTextBoxColumn.HeaderText = "Fuel_Type_ID";
            this.fuelTypeIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fuelTypeIDDataGridViewTextBoxColumn.Name = "fuelTypeIDDataGridViewTextBoxColumn";
            this.fuelTypeIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // transmissionIDDataGridViewTextBoxColumn
            // 
            this.transmissionIDDataGridViewTextBoxColumn.DataPropertyName = "Transmission_ID";
            this.transmissionIDDataGridViewTextBoxColumn.HeaderText = "Transmission_ID";
            this.transmissionIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.transmissionIDDataGridViewTextBoxColumn.Name = "transmissionIDDataGridViewTextBoxColumn";
            this.transmissionIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // gearboxIDDataGridViewTextBoxColumn
            // 
            this.gearboxIDDataGridViewTextBoxColumn.DataPropertyName = "Gearbox_ID";
            this.gearboxIDDataGridViewTextBoxColumn.HeaderText = "Gearbox_ID";
            this.gearboxIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.gearboxIDDataGridViewTextBoxColumn.Name = "gearboxIDDataGridViewTextBoxColumn";
            this.gearboxIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // founderYearDataGridViewTextBoxColumn
            // 
            this.founderYearDataGridViewTextBoxColumn.DataPropertyName = "FounderYear";
            this.founderYearDataGridViewTextBoxColumn.HeaderText = "FounderYear";
            this.founderYearDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.founderYearDataGridViewTextBoxColumn.Name = "founderYearDataGridViewTextBoxColumn";
            this.founderYearDataGridViewTextBoxColumn.Width = 150;
            // 
            // engineVolumeIDDataGridViewTextBoxColumn
            // 
            this.engineVolumeIDDataGridViewTextBoxColumn.DataPropertyName = "Engine_Volume_ID";
            this.engineVolumeIDDataGridViewTextBoxColumn.HeaderText = "Engine_Volume_ID";
            this.engineVolumeIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.engineVolumeIDDataGridViewTextBoxColumn.Name = "engineVolumeIDDataGridViewTextBoxColumn";
            this.engineVolumeIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // hPDataGridViewTextBoxColumn
            // 
            this.hPDataGridViewTextBoxColumn.DataPropertyName = "HP";
            this.hPDataGridViewTextBoxColumn.HeaderText = "HP";
            this.hPDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.hPDataGridViewTextBoxColumn.Name = "hPDataGridViewTextBoxColumn";
            this.hPDataGridViewTextBoxColumn.Width = 150;
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "Note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "Note";
            this.noteDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            this.noteDataGridViewTextBoxColumn.Width = 150;
            // 
            // alloyWheelsDataGridViewCheckBoxColumn
            // 
            this.alloyWheelsDataGridViewCheckBoxColumn.DataPropertyName = "Alloy_Wheels";
            this.alloyWheelsDataGridViewCheckBoxColumn.HeaderText = "Alloy_Wheels";
            this.alloyWheelsDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.alloyWheelsDataGridViewCheckBoxColumn.Name = "alloyWheelsDataGridViewCheckBoxColumn";
            this.alloyWheelsDataGridViewCheckBoxColumn.Width = 150;
            // 
            // centralClosureDataGridViewCheckBoxColumn
            // 
            this.centralClosureDataGridViewCheckBoxColumn.DataPropertyName = "Central_Closure";
            this.centralClosureDataGridViewCheckBoxColumn.HeaderText = "Central_Closure";
            this.centralClosureDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.centralClosureDataGridViewCheckBoxColumn.Name = "centralClosureDataGridViewCheckBoxColumn";
            this.centralClosureDataGridViewCheckBoxColumn.Width = 150;
            // 
            // leatherSalonDataGridViewCheckBoxColumn
            // 
            this.leatherSalonDataGridViewCheckBoxColumn.DataPropertyName = "Leather_Salon";
            this.leatherSalonDataGridViewCheckBoxColumn.HeaderText = "Leather_Salon";
            this.leatherSalonDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.leatherSalonDataGridViewCheckBoxColumn.Name = "leatherSalonDataGridViewCheckBoxColumn";
            this.leatherSalonDataGridViewCheckBoxColumn.Width = 150;
            // 
            // seatVentilationDataGridViewCheckBoxColumn
            // 
            this.seatVentilationDataGridViewCheckBoxColumn.DataPropertyName = "Seat_Ventilation";
            this.seatVentilationDataGridViewCheckBoxColumn.HeaderText = "Seat_Ventilation";
            this.seatVentilationDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.seatVentilationDataGridViewCheckBoxColumn.Name = "seatVentilationDataGridViewCheckBoxColumn";
            this.seatVentilationDataGridViewCheckBoxColumn.Width = 150;
            // 
            // uSADataGridViewCheckBoxColumn
            // 
            this.uSADataGridViewCheckBoxColumn.DataPropertyName = "USA";
            this.uSADataGridViewCheckBoxColumn.HeaderText = "USA";
            this.uSADataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.uSADataGridViewCheckBoxColumn.Name = "uSADataGridViewCheckBoxColumn";
            this.uSADataGridViewCheckBoxColumn.Width = 150;
            // 
            // parkingRadarDataGridViewCheckBoxColumn
            // 
            this.parkingRadarDataGridViewCheckBoxColumn.DataPropertyName = "Parking_Radar";
            this.parkingRadarDataGridViewCheckBoxColumn.HeaderText = "Parking_Radar";
            this.parkingRadarDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.parkingRadarDataGridViewCheckBoxColumn.Name = "parkingRadarDataGridViewCheckBoxColumn";
            this.parkingRadarDataGridViewCheckBoxColumn.Width = 150;
            // 
            // xenonDataGridViewCheckBoxColumn
            // 
            this.xenonDataGridViewCheckBoxColumn.DataPropertyName = "Xenon";
            this.xenonDataGridViewCheckBoxColumn.HeaderText = "Xenon";
            this.xenonDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.xenonDataGridViewCheckBoxColumn.Name = "xenonDataGridViewCheckBoxColumn";
            this.xenonDataGridViewCheckBoxColumn.Width = 150;
            // 
            // lukeDataGridViewCheckBoxColumn
            // 
            this.lukeDataGridViewCheckBoxColumn.DataPropertyName = "Luke";
            this.lukeDataGridViewCheckBoxColumn.HeaderText = "Luke";
            this.lukeDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.lukeDataGridViewCheckBoxColumn.Name = "lukeDataGridViewCheckBoxColumn";
            this.lukeDataGridViewCheckBoxColumn.Width = 150;
            // 
            // conditionerDataGridViewCheckBoxColumn
            // 
            this.conditionerDataGridViewCheckBoxColumn.DataPropertyName = "Conditioner";
            this.conditionerDataGridViewCheckBoxColumn.HeaderText = "Conditioner";
            this.conditionerDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.conditionerDataGridViewCheckBoxColumn.Name = "conditionerDataGridViewCheckBoxColumn";
            this.conditionerDataGridViewCheckBoxColumn.Width = 150;
            // 
            // rearCameraDataGridViewCheckBoxColumn
            // 
            this.rearCameraDataGridViewCheckBoxColumn.DataPropertyName = "Rear_Camera";
            this.rearCameraDataGridViewCheckBoxColumn.HeaderText = "Rear_Camera";
            this.rearCameraDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.rearCameraDataGridViewCheckBoxColumn.Name = "rearCameraDataGridViewCheckBoxColumn";
            this.rearCameraDataGridViewCheckBoxColumn.Width = 150;
            // 
            // rainSensorDataGridViewCheckBoxColumn
            // 
            this.rainSensorDataGridViewCheckBoxColumn.DataPropertyName = "Rain_Sensor";
            this.rainSensorDataGridViewCheckBoxColumn.HeaderText = "Rain_Sensor";
            this.rainSensorDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.rainSensorDataGridViewCheckBoxColumn.Name = "rainSensorDataGridViewCheckBoxColumn";
            this.rainSensorDataGridViewCheckBoxColumn.Width = 150;
            // 
            // seatHeatingDataGridViewCheckBoxColumn
            // 
            this.seatHeatingDataGridViewCheckBoxColumn.DataPropertyName = "Seat_Heating";
            this.seatHeatingDataGridViewCheckBoxColumn.HeaderText = "Seat_Heating";
            this.seatHeatingDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.seatHeatingDataGridViewCheckBoxColumn.Name = "seatHeatingDataGridViewCheckBoxColumn";
            this.seatHeatingDataGridViewCheckBoxColumn.Width = 150;
            // 
            // sideCurtainsDataGridViewCheckBoxColumn
            // 
            this.sideCurtainsDataGridViewCheckBoxColumn.DataPropertyName = "Side_Curtains";
            this.sideCurtainsDataGridViewCheckBoxColumn.HeaderText = "Side_Curtains";
            this.sideCurtainsDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.sideCurtainsDataGridViewCheckBoxColumn.Name = "sideCurtainsDataGridViewCheckBoxColumn";
            this.sideCurtainsDataGridViewCheckBoxColumn.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // cityIDDataGridViewTextBoxColumn
            // 
            this.cityIDDataGridViewTextBoxColumn.DataPropertyName = "City_ID";
            this.cityIDDataGridViewTextBoxColumn.HeaderText = "City_ID";
            this.cityIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cityIDDataGridViewTextBoxColumn.Name = "cityIDDataGridViewTextBoxColumn";
            this.cityIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // contactDataGridViewTextBoxColumn
            // 
            this.contactDataGridViewTextBoxColumn.DataPropertyName = "Contact";
            this.contactDataGridViewTextBoxColumn.HeaderText = "Contact";
            this.contactDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.contactDataGridViewTextBoxColumn.Name = "contactDataGridViewTextBoxColumn";
            this.contactDataGridViewTextBoxColumn.Width = 150;
            // 
            // AdminPage1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1570, 878);
            this.Controls.Add(this.carsdatagridview);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.idlbl);
            this.Controls.Add(this.idDatatxt);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AdminPage1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPage1";
            this.Load += new System.EventHandler(this.AdminPage1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.allAdsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carShopDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsdatagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton deletebtn;
        private DevExpress.XtraEditors.SimpleButton btnBack;
        private CarShopDataSet1 carShopDataSet1;
        private System.Windows.Forms.BindingSource allAdsBindingSource;
        private CarShopDataSet1TableAdapters.All_AdsTableAdapter all_AdsTableAdapter;
        private System.Windows.Forms.TextBox idDatatxt;
        private DevExpress.XtraEditors.LabelControl idlbl;
        private DevExpress.XtraEditors.SimpleButton searchbtn;
        private System.Windows.Forms.DataGridView carsdatagridview;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bodyTypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn walkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencyIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn creditDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn barterDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fuelTypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transmissionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gearboxIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn founderYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn engineVolumeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn alloyWheelsDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn centralClosureDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn leatherSalonDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn seatVentilationDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn uSADataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn parkingRadarDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn xenonDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn lukeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn conditionerDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn rearCameraDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn rainSensorDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn seatHeatingDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sideCurtainsDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
    }
}