namespace WindowsFormsAppDoAa1111
{
    partial class TimKiemDoUong
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
            this.GiaL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaDanhMuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenDoUong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaDoUong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GiaM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControlDoUong = new DevExpress.XtraGrid.GridControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.btnTimKienNguyenLieu = new Guna.UI2.WinForms.Guna2Button();
            this.txtTenDUTim = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMaDUTim = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.oDataServerModeSource1 = new DevExpress.Data.ODataLinq.ODataServerModeSource();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDoUong)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oDataServerModeSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GiaL
            // 
            this.GiaL.Caption = "Giá size L";
            this.GiaL.FieldName = "GiaL";
            this.GiaL.MinWidth = 25;
            this.GiaL.Name = "GiaL";
            this.GiaL.Visible = true;
            this.GiaL.VisibleIndex = 5;
            this.GiaL.Width = 94;
            // 
            // GiaS
            // 
            this.GiaS.Caption = "Giá size S";
            this.GiaS.FieldName = "GiaS";
            this.GiaS.MinWidth = 25;
            this.GiaS.Name = "GiaS";
            this.GiaS.Visible = true;
            this.GiaS.VisibleIndex = 3;
            this.GiaS.Width = 94;
            // 
            // MaDanhMuc
            // 
            this.MaDanhMuc.Caption = "Mã Danh Mục";
            this.MaDanhMuc.FieldName = "MaDanhMuc";
            this.MaDanhMuc.MinWidth = 25;
            this.MaDanhMuc.Name = "MaDanhMuc";
            this.MaDanhMuc.Visible = true;
            this.MaDanhMuc.VisibleIndex = 2;
            this.MaDanhMuc.Width = 94;
            // 
            // TenDoUong
            // 
            this.TenDoUong.Caption = "Tên Đồ Uống";
            this.TenDoUong.FieldName = "TenDoUong";
            this.TenDoUong.MinWidth = 25;
            this.TenDoUong.Name = "TenDoUong";
            this.TenDoUong.Visible = true;
            this.TenDoUong.VisibleIndex = 1;
            this.TenDoUong.Width = 94;
            // 
            // MaDoUong
            // 
            this.MaDoUong.Caption = "Mã Đồ Uống";
            this.MaDoUong.FieldName = "MaDoUong";
            this.MaDoUong.MinWidth = 25;
            this.MaDoUong.Name = "MaDoUong";
            this.MaDoUong.Visible = true;
            this.MaDoUong.VisibleIndex = 0;
            this.MaDoUong.Width = 94;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaDoUong,
            this.TenDoUong,
            this.MaDanhMuc,
            this.GiaS,
            this.GiaM,
            this.GiaL});
            this.gridView1.GridControl = this.gridControlDoUong;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // GiaM
            // 
            this.GiaM.Caption = "Giá size M";
            this.GiaM.FieldName = "GiaM";
            this.GiaM.MinWidth = 25;
            this.GiaM.Name = "GiaM";
            this.GiaM.Visible = true;
            this.GiaM.VisibleIndex = 4;
            this.GiaM.Width = 94;
            // 
            // gridControlDoUong
            // 
            this.gridControlDoUong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDoUong.Location = new System.Drawing.Point(0, 0);
            this.gridControlDoUong.MainView = this.gridView1;
            this.gridControlDoUong.Name = "gridControlDoUong";
            this.gridControlDoUong.Size = new System.Drawing.Size(1062, 384);
            this.gridControlDoUong.TabIndex = 1;
            this.gridControlDoUong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControlDoUong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 287);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1062, 384);
            this.panel1.TabIndex = 9;
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderRadius = 15;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.Black;
            this.guna2Button2.Image = global::WindowsFormsAppDoAa1111.Properties.Resources.search6;
            this.guna2Button2.Location = new System.Drawing.Point(562, 119);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(180, 45);
            this.guna2Button2.TabIndex = 27;
            this.guna2Button2.Text = "Tìm theo tên";
            // 
            // btnTimKienNguyenLieu
            // 
            this.btnTimKienNguyenLieu.BorderRadius = 15;
            this.btnTimKienNguyenLieu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKienNguyenLieu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKienNguyenLieu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimKienNguyenLieu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimKienNguyenLieu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKienNguyenLieu.ForeColor = System.Drawing.Color.Black;
            this.btnTimKienNguyenLieu.Image = global::WindowsFormsAppDoAa1111.Properties.Resources.search6;
            this.btnTimKienNguyenLieu.Location = new System.Drawing.Point(562, 37);
            this.btnTimKienNguyenLieu.Name = "btnTimKienNguyenLieu";
            this.btnTimKienNguyenLieu.Size = new System.Drawing.Size(180, 45);
            this.btnTimKienNguyenLieu.TabIndex = 25;
            this.btnTimKienNguyenLieu.Text = "Tìm  theo mã";
            this.btnTimKienNguyenLieu.Click += new System.EventHandler(this.btnTimKienNguyenLieu_Click);
            // 
            // txtTenDUTim
            // 
            this.txtTenDUTim.BorderRadius = 15;
            this.txtTenDUTim.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenDUTim.DefaultText = "";
            this.txtTenDUTim.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenDUTim.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenDUTim.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenDUTim.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenDUTim.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenDUTim.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenDUTim.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenDUTim.Location = new System.Drawing.Point(266, 105);
            this.txtTenDUTim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenDUTim.Name = "txtTenDUTim";
            this.txtTenDUTim.PasswordChar = '\0';
            this.txtTenDUTim.PlaceholderText = "";
            this.txtTenDUTim.SelectedText = "";
            this.txtTenDUTim.Size = new System.Drawing.Size(229, 48);
            this.txtTenDUTim.TabIndex = 24;
            this.txtTenDUTim.TextChanged += new System.EventHandler(this.txtTenDMTim_TextChanged);
            // 
            // txtMaDUTim
            // 
            this.txtMaDUTim.BorderRadius = 15;
            this.txtMaDUTim.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaDUTim.DefaultText = "";
            this.txtMaDUTim.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaDUTim.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaDUTim.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaDUTim.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaDUTim.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaDUTim.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaDUTim.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaDUTim.Location = new System.Drawing.Point(266, 34);
            this.txtMaDUTim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaDUTim.Name = "txtMaDUTim";
            this.txtMaDUTim.PasswordChar = '\0';
            this.txtMaDUTim.PlaceholderText = "";
            this.txtMaDUTim.SelectedText = "";
            this.txtMaDUTim.Size = new System.Drawing.Size(229, 48);
            this.txtMaDUTim.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(101, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mã Đồ Uống";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label4.Location = new System.Drawing.Point(101, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tên Đồ Uống";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.guna2Button2);
            this.panelControl1.Controls.Add(this.btnTimKienNguyenLieu);
            this.panelControl1.Controls.Add(this.txtTenDUTim);
            this.panelControl1.Controls.Add(this.txtMaDUTim);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.label4);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1062, 287);
            this.panelControl1.TabIndex = 8;
            // 
            // TimKiemDoUong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 671);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelControl1);
            this.Name = "TimKiemDoUong";
            this.Text = "TimKiemDoUong";
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDoUong)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.oDataServerModeSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn GiaL;
        private DevExpress.XtraGrid.Columns.GridColumn GiaS;
        private DevExpress.XtraGrid.Columns.GridColumn MaDanhMuc;
        private DevExpress.XtraGrid.Columns.GridColumn TenDoUong;
        private DevExpress.XtraGrid.Columns.GridColumn MaDoUong;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn GiaM;
        private DevExpress.XtraGrid.GridControl gridControlDoUong;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button btnTimKienNguyenLieu;
        private Guna.UI2.WinForms.Guna2TextBox txtTenDUTim;
        private Guna.UI2.WinForms.Guna2TextBox txtMaDUTim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private DevExpress.Data.ODataLinq.ODataServerModeSource oDataServerModeSource1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}