namespace WindowsFormsAppDoAa1111
{
    partial class QuanLyDanhMuc
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
            this.oDataServerModeSource1 = new DevExpress.Data.ODataLinq.ODataServerModeSource();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaDanhMuc = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenDanhMuc = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnTimKienNguyenLieu = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gridControlDMDoUong = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaDanhMuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenDanhMuc = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.oDataServerModeSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDMDoUong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label4.Location = new System.Drawing.Point(101, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tên Danh Mục";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(101, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mã Danh Mục";
            // 
            // txtMaDanhMuc
            // 
            this.txtMaDanhMuc.BorderRadius = 15;
            this.txtMaDanhMuc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaDanhMuc.DefaultText = "";
            this.txtMaDanhMuc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaDanhMuc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaDanhMuc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaDanhMuc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaDanhMuc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaDanhMuc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaDanhMuc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaDanhMuc.Location = new System.Drawing.Point(266, 34);
            this.txtMaDanhMuc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaDanhMuc.Name = "txtMaDanhMuc";
            this.txtMaDanhMuc.PasswordChar = '\0';
            this.txtMaDanhMuc.PlaceholderText = "";
            this.txtMaDanhMuc.SelectedText = "";
            this.txtMaDanhMuc.Size = new System.Drawing.Size(229, 48);
            this.txtMaDanhMuc.TabIndex = 23;
            // 
            // txtTenDanhMuc
            // 
            this.txtTenDanhMuc.BorderRadius = 15;
            this.txtTenDanhMuc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenDanhMuc.DefaultText = "";
            this.txtTenDanhMuc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenDanhMuc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenDanhMuc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenDanhMuc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenDanhMuc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenDanhMuc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenDanhMuc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenDanhMuc.Location = new System.Drawing.Point(266, 105);
            this.txtTenDanhMuc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenDanhMuc.Name = "txtTenDanhMuc";
            this.txtTenDanhMuc.PasswordChar = '\0';
            this.txtTenDanhMuc.PlaceholderText = "";
            this.txtTenDanhMuc.SelectedText = "";
            this.txtTenDanhMuc.Size = new System.Drawing.Size(229, 48);
            this.txtTenDanhMuc.TabIndex = 24;
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
            this.btnTimKienNguyenLieu.Location = new System.Drawing.Point(55, 228);
            this.btnTimKienNguyenLieu.Name = "btnTimKienNguyenLieu";
            this.btnTimKienNguyenLieu.Size = new System.Drawing.Size(180, 45);
            this.btnTimKienNguyenLieu.TabIndex = 25;
            this.btnTimKienNguyenLieu.Text = "Thêm";
            this.btnTimKienNguyenLieu.Click += new System.EventHandler(this.btnTimKienNguyenLieu_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 15;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.Image = global::WindowsFormsAppDoAa1111.Properties.Resources.search6;
            this.guna2Button1.Location = new System.Drawing.Point(451, 228);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 26;
            this.guna2Button1.Text = "Xóa";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.guna2Button1);
            this.panelControl1.Controls.Add(this.btnTimKienNguyenLieu);
            this.panelControl1.Controls.Add(this.txtTenDanhMuc);
            this.panelControl1.Controls.Add(this.txtMaDanhMuc);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.label4);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1148, 387);
            this.panelControl1.TabIndex = 4;
            // 
            // gridControlDMDoUong
            // 
            this.gridControlDMDoUong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDMDoUong.Location = new System.Drawing.Point(0, 387);
            this.gridControlDMDoUong.MainView = this.gridView1;
            this.gridControlDMDoUong.Name = "gridControlDMDoUong";
            this.gridControlDMDoUong.Size = new System.Drawing.Size(1148, 256);
            this.gridControlDMDoUong.TabIndex = 5;
            this.gridControlDMDoUong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaDanhMuc,
            this.TenDanhMuc});
            this.gridView1.GridControl = this.gridControlDMDoUong;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            // 
            // MaDanhMuc
            // 
            this.MaDanhMuc.Caption = "Mã Danh Mục";
            this.MaDanhMuc.FieldName = "MaDanhMuc";
            this.MaDanhMuc.MinWidth = 25;
            this.MaDanhMuc.Name = "MaDanhMuc";
            this.MaDanhMuc.Visible = true;
            this.MaDanhMuc.VisibleIndex = 0;
            this.MaDanhMuc.Width = 94;
            // 
            // TenDanhMuc
            // 
            this.TenDanhMuc.Caption = "Tên Danh Mục";
            this.TenDanhMuc.FieldName = "TenDanhMuc";
            this.TenDanhMuc.MinWidth = 25;
            this.TenDanhMuc.Name = "TenDanhMuc";
            this.TenDanhMuc.Visible = true;
            this.TenDanhMuc.VisibleIndex = 1;
            this.TenDanhMuc.Width = 94;
            // 
            // QuanLyDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 643);
            this.Controls.Add(this.gridControlDMDoUong);
            this.Controls.Add(this.panelControl1);
            this.Name = "QuanLyDanhMuc";
            this.Text = "Quản Lý Danh Mục";
            this.Load += new System.EventHandler(this.QuanLyDanhMuc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.oDataServerModeSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDMDoUong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.Data.ODataLinq.ODataServerModeSource oDataServerModeSource1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtMaDanhMuc;
        private Guna.UI2.WinForms.Guna2TextBox txtTenDanhMuc;
        private Guna.UI2.WinForms.Guna2Button btnTimKienNguyenLieu;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridControlDMDoUong;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MaDanhMuc;
        private DevExpress.XtraGrid.Columns.GridColumn TenDanhMuc;
    }
}