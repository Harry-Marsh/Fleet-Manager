namespace Fleet_Manager
{
    partial class FleetManager
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel5 = new Panel();
            CompSearchBtn = new Button();
            CompClearBtn = new Button();
            CompanySearchLbl = new Label();
            NameLbl = new Label();
            NameTxBx = new TextBox();
            panel4 = new Panel();
            CatagoryLstbx = new ListBox();
            VehicleSearchLbl = new Label();
            CatagoryLbl = new Label();
            VehSearchBtn = new Button();
            FuelTypeLbl = new Label();
            VehClearBtn = new Button();
            FuelTypeTxBx = new TextBox();
            RegistrationTxBx = new TextBox();
            ModelLbl = new Label();
            RegistrationLbl = new Label();
            ModelTxBx = new TextBox();
            MakeTxBx = new TextBox();
            MakeLbl = new Label();
            panel2 = new Panel();
            TitleLbl = new Label();
            panel3 = new Panel();
            gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            CustomerType = new Label();
            TypeTxBx = new TextBox();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(261, 657);
            panel1.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Controls.Add(CustomerType);
            panel5.Controls.Add(TypeTxBx);
            panel5.Controls.Add(CompSearchBtn);
            panel5.Controls.Add(CompClearBtn);
            panel5.Controls.Add(CompanySearchLbl);
            panel5.Controls.Add(NameLbl);
            panel5.Controls.Add(NameTxBx);
            panel5.Location = new Point(18, 362);
            panel5.Name = "panel5";
            panel5.Size = new Size(219, 276);
            panel5.TabIndex = 1;
            // 
            // CompSearchBtn
            // 
            CompSearchBtn.AutoSize = true;
            CompSearchBtn.Location = new Point(29, 130);
            CompSearchBtn.Name = "CompSearchBtn";
            CompSearchBtn.Size = new Size(75, 25);
            CompSearchBtn.TabIndex = 22;
            CompSearchBtn.Text = "Search";
            CompSearchBtn.UseVisualStyleBackColor = true;
            // 
            // CompClearBtn
            // 
            CompClearBtn.AutoSize = true;
            CompClearBtn.Location = new Point(114, 130);
            CompClearBtn.Name = "CompClearBtn";
            CompClearBtn.Size = new Size(75, 25);
            CompClearBtn.TabIndex = 23;
            CompClearBtn.Text = "Clear";
            CompClearBtn.UseVisualStyleBackColor = true;
            // 
            // CompanySearchLbl
            // 
            CompanySearchLbl.AutoSize = true;
            CompanySearchLbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            CompanySearchLbl.ForeColor = SystemColors.ButtonFace;
            CompanySearchLbl.Location = new Point(11, 13);
            CompanySearchLbl.Name = "CompanySearchLbl";
            CompanySearchLbl.Size = new Size(199, 20);
            CompanySearchLbl.TabIndex = 21;
            CompanySearchLbl.Text = "Search By Company Details";
            // 
            // NameLbl
            // 
            NameLbl.AutoSize = true;
            NameLbl.ForeColor = SystemColors.ButtonFace;
            NameLbl.Location = new Point(34, 39);
            NameLbl.Name = "NameLbl";
            NameLbl.Size = new Size(108, 15);
            NameLbl.TabIndex = 20;
            NameLbl.Text = "Insert Client Name:";
            // 
            // NameTxBx
            // 
            NameTxBx.Location = new Point(34, 57);
            NameTxBx.Name = "NameTxBx";
            NameTxBx.Size = new Size(156, 23);
            NameTxBx.TabIndex = 19;
            // 
            // panel4
            // 
            panel4.Controls.Add(CatagoryLstbx);
            panel4.Controls.Add(VehicleSearchLbl);
            panel4.Controls.Add(CatagoryLbl);
            panel4.Controls.Add(VehSearchBtn);
            panel4.Controls.Add(FuelTypeLbl);
            panel4.Controls.Add(VehClearBtn);
            panel4.Controls.Add(FuelTypeTxBx);
            panel4.Controls.Add(RegistrationTxBx);
            panel4.Controls.Add(ModelLbl);
            panel4.Controls.Add(RegistrationLbl);
            panel4.Controls.Add(ModelTxBx);
            panel4.Controls.Add(MakeTxBx);
            panel4.Controls.Add(MakeLbl);
            panel4.Location = new Point(18, 10);
            panel4.Name = "panel4";
            panel4.Size = new Size(219, 329);
            panel4.TabIndex = 0;
            // 
            // CatagoryLstbx
            // 
            CatagoryLstbx.FormattingEnabled = true;
            CatagoryLstbx.ItemHeight = 15;
            CatagoryLstbx.Items.AddRange(new object[] { "Small Car", "Estate Car", "Van" });
            CatagoryLstbx.Location = new Point(33, 232);
            CatagoryLstbx.Name = "CatagoryLstbx";
            CatagoryLstbx.Size = new Size(156, 49);
            CatagoryLstbx.TabIndex = 29;
            // 
            // VehicleSearchLbl
            // 
            VehicleSearchLbl.AutoSize = true;
            VehicleSearchLbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            VehicleSearchLbl.ForeColor = SystemColors.ButtonFace;
            VehicleSearchLbl.Location = new Point(18, 8);
            VehicleSearchLbl.Name = "VehicleSearchLbl";
            VehicleSearchLbl.Size = new Size(182, 20);
            VehicleSearchLbl.TabIndex = 21;
            VehicleSearchLbl.Text = "Search By Vehicle Details";
            // 
            // CatagoryLbl
            // 
            CatagoryLbl.AutoSize = true;
            CatagoryLbl.ForeColor = SystemColors.ButtonFace;
            CatagoryLbl.Location = new Point(33, 214);
            CatagoryLbl.Name = "CatagoryLbl";
            CatagoryLbl.Size = new Size(90, 15);
            CatagoryLbl.TabIndex = 28;
            CatagoryLbl.Text = "Insert Category:";
            // 
            // VehSearchBtn
            // 
            VehSearchBtn.AutoSize = true;
            VehSearchBtn.Location = new Point(29, 287);
            VehSearchBtn.Name = "VehSearchBtn";
            VehSearchBtn.Size = new Size(75, 25);
            VehSearchBtn.TabIndex = 17;
            VehSearchBtn.Text = "Search";
            VehSearchBtn.UseVisualStyleBackColor = true;
            VehSearchBtn.Click += VehSearchBtn_Click;
            // 
            // FuelTypeLbl
            // 
            FuelTypeLbl.AutoSize = true;
            FuelTypeLbl.ForeColor = SystemColors.ButtonFace;
            FuelTypeLbl.Location = new Point(33, 170);
            FuelTypeLbl.Name = "FuelTypeLbl";
            FuelTypeLbl.Size = new Size(91, 15);
            FuelTypeLbl.TabIndex = 27;
            FuelTypeLbl.Text = "Insert Fuel Type:";
            // 
            // VehClearBtn
            // 
            VehClearBtn.AutoSize = true;
            VehClearBtn.Location = new Point(114, 287);
            VehClearBtn.Name = "VehClearBtn";
            VehClearBtn.Size = new Size(75, 25);
            VehClearBtn.TabIndex = 18;
            VehClearBtn.Text = "Clear";
            VehClearBtn.UseVisualStyleBackColor = true;
            VehClearBtn.Click += VehClearBtn_Click;
            // 
            // FuelTypeTxBx
            // 
            FuelTypeTxBx.Location = new Point(33, 188);
            FuelTypeTxBx.Name = "FuelTypeTxBx";
            FuelTypeTxBx.Size = new Size(156, 23);
            FuelTypeTxBx.TabIndex = 26;
            // 
            // RegistrationTxBx
            // 
            RegistrationTxBx.Location = new Point(33, 56);
            RegistrationTxBx.Name = "RegistrationTxBx";
            RegistrationTxBx.Size = new Size(156, 23);
            RegistrationTxBx.TabIndex = 19;
            // 
            // ModelLbl
            // 
            ModelLbl.AutoSize = true;
            ModelLbl.ForeColor = SystemColors.ButtonFace;
            ModelLbl.Location = new Point(33, 126);
            ModelLbl.Name = "ModelLbl";
            ModelLbl.Size = new Size(76, 15);
            ModelLbl.TabIndex = 25;
            ModelLbl.Text = "Insert Model:";
            // 
            // RegistrationLbl
            // 
            RegistrationLbl.AutoSize = true;
            RegistrationLbl.ForeColor = SystemColors.ButtonFace;
            RegistrationLbl.Location = new Point(33, 38);
            RegistrationLbl.Name = "RegistrationLbl";
            RegistrationLbl.Size = new Size(105, 15);
            RegistrationLbl.TabIndex = 20;
            RegistrationLbl.Text = "Insert Registration:";
            // 
            // ModelTxBx
            // 
            ModelTxBx.Location = new Point(33, 144);
            ModelTxBx.Name = "ModelTxBx";
            ModelTxBx.Size = new Size(156, 23);
            ModelTxBx.TabIndex = 24;
            // 
            // MakeTxBx
            // 
            MakeTxBx.Location = new Point(33, 100);
            MakeTxBx.Name = "MakeTxBx";
            MakeTxBx.Size = new Size(156, 23);
            MakeTxBx.TabIndex = 22;
            // 
            // MakeLbl
            // 
            MakeLbl.AutoSize = true;
            MakeLbl.ForeColor = SystemColors.ButtonFace;
            MakeLbl.Location = new Point(33, 82);
            MakeLbl.Name = "MakeLbl";
            MakeLbl.Size = new Size(71, 15);
            MakeLbl.TabIndex = 23;
            MakeLbl.Text = "Insert Make:";
            // 
            // panel2
            // 
            panel2.Controls.Add(TitleLbl);
            panel2.Location = new Point(279, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(973, 67);
            panel2.TabIndex = 1;
            // 
            // TitleLbl
            // 
            TitleLbl.AutoSize = true;
            TitleLbl.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            TitleLbl.ForeColor = SystemColors.ButtonFace;
            TitleLbl.Location = new Point(307, 10);
            TitleLbl.Name = "TitleLbl";
            TitleLbl.Size = new Size(400, 45);
            TitleLbl.TabIndex = 18;
            TitleLbl.Text = "Hire Car Vehicle Manager";
            // 
            // panel3
            // 
            panel3.Controls.Add(gMapControl1);
            panel3.Location = new Point(279, 85);
            panel3.Name = "panel3";
            panel3.Size = new Size(973, 584);
            panel3.TabIndex = 2;
            // 
            // gMapControl1
            // 
            gMapControl1.Bearing = 0F;
            gMapControl1.CanDragMap = true;
            gMapControl1.EmptyTileColor = Color.Navy;
            gMapControl1.GrayScaleMode = false;
            gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            gMapControl1.LevelsKeepInMemory = 5;
            gMapControl1.Location = new Point(3, 3);
            gMapControl1.MarkersEnabled = true;
            gMapControl1.MaxZoom = 20;
            gMapControl1.MinZoom = 2;
            gMapControl1.MouseWheelZoomEnabled = true;
            gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            gMapControl1.Name = "gMapControl1";
            gMapControl1.NegativeMode = false;
            gMapControl1.PolygonsEnabled = true;
            gMapControl1.RetryLoadTile = 0;
            gMapControl1.RoutesEnabled = true;
            gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            gMapControl1.SelectedAreaFillColor = Color.FromArgb(33, 65, 105, 225);
            gMapControl1.ShowTileGridLines = false;
            gMapControl1.Size = new Size(970, 581);
            gMapControl1.TabIndex = 0;
            gMapControl1.Zoom = 0D;
            // 
            // CustomerType
            // 
            CustomerType.AutoSize = true;
            CustomerType.ForeColor = SystemColors.ButtonFace;
            CustomerType.Location = new Point(34, 83);
            CustomerType.Name = "CustomerType";
            CustomerType.Size = new Size(108, 15);
            CustomerType.TabIndex = 25;
            CustomerType.Text = "Insert Client Name:";
            // 
            // TypeTxBx
            // 
            TypeTxBx.Location = new Point(34, 101);
            TypeTxBx.Name = "TypeTxBx";
            TypeTxBx.Size = new Size(156, 23);
            TypeTxBx.TabIndex = 24;
            // 
            // FleetManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(1264, 681);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FleetManager";
            Text = "Fleet Manager";
            Load += FleetManager_Load;
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel4;
        private Panel panel5;
        private Panel panel2;
        private Panel panel3;
        private ListBox CatagoryLstbx;
        private Label VehicleSearchLbl;
        private Label CatagoryLbl;
        private Button VehSearchBtn;
        private Label FuelTypeLbl;
        private Button VehClearBtn;
        private TextBox FuelTypeTxBx;
        private TextBox RegistrationTxBx;
        private Label ModelLbl;
        private Label RegistrationLbl;
        private TextBox ModelTxBx;
        private TextBox MakeTxBx;
        private Label MakeLbl;
        private Label TitleLbl;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private Button CompSearchBtn;
        private Button CompClearBtn;
        private Label CompanySearchLbl;
        private Label NameLbl;
        private TextBox NameTxBx;
        private Label CustomerType;
        private TextBox TypeTxBx;
    }
}