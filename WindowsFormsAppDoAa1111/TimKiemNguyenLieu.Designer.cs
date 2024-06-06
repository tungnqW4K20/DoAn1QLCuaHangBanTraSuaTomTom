namespace WindowsFormsAppDoAa1111
{
    partial class TimKiemNguyenLieu
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnTimKienNguyenLieu = new Guna.UI2.WinForms.Guna2Button();
            this.txtTenNguyenLieuTim = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMaNguyenLieuTim = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControlTKNguyenLieu = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaNguyenLieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenNguyenLieu = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTKNguyenLieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.guna2Button1);
            this.panelControl1.Controls.Add(this.btnTimKienNguyenLieu);
            this.panelControl1.Controls.Add(this.txtTenNguyenLieuTim);
            this.panelControl1.Controls.Add(this.txtMaNguyenLieuTim);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.label4);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1025, 253);
            this.panelControl1.TabIndex = 2;
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
            this.guna2Button1.Location = new System.Drawing.Point(561, 119);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 26;
            this.guna2Button1.Text = "Tìm kiếm";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
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
            this.btnTimKienNguyenLieu.Location = new System.Drawing.Point(561, 28);
            this.btnTimKienNguyenLieu.Name = "btnTimKienNguyenLieu";
            this.btnTimKienNguyenLieu.Size = new System.Drawing.Size(180, 45);
            this.btnTimKienNguyenLieu.TabIndex = 25;
            this.btnTimKienNguyenLieu.Text = "Tìm kiếm";
            this.btnTimKienNguyenLieu.Click += new System.EventHandler(this.btnTimKienNguyenLieu_Click);
            // 
            // txtTenNguyenLieuTim
            // 
            this.txtTenNguyenLieuTim.BorderRadius = 15;
            this.txtTenNguyenLieuTim.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenNguyenLieuTim.DefaultText = "";
            this.txtTenNguyenLieuTim.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenNguyenLieuTim.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenNguyenLieuTim.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNguyenLieuTim.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNguyenLieuTim.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNguyenLieuTim.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenNguyenLieuTim.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNguyenLieuTim.Location = new System.Drawing.Point(266, 105);
            this.txtTenNguyenLieuTim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenNguyenLieuTim.Name = "txtTenNguyenLieuTim";
            this.txtTenNguyenLieuTim.PasswordChar = '\0';
            this.txtTenNguyenLieuTim.PlaceholderText = "";
            this.txtTenNguyenLieuTim.SelectedText = "";
            this.txtTenNguyenLieuTim.Size = new System.Drawing.Size(229, 48);
            this.txtTenNguyenLieuTim.TabIndex = 24;
            // 
            // txtMaNguyenLieuTim
            // 
            this.txtMaNguyenLieuTim.BorderRadius = 15;
            this.txtMaNguyenLieuTim.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaNguyenLieuTim.DefaultText = "";
            this.txtMaNguyenLieuTim.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaNguyenLieuTim.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaNguyenLieuTim.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaNguyenLieuTim.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaNguyenLieuTim.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaNguyenLieuTim.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaNguyenLieuTim.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaNguyenLieuTim.Location = new System.Drawing.Point(266, 34);
            this.txtMaNguyenLieuTim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaNguyenLieuTim.Name = "txtMaNguyenLieuTim";
            this.txtMaNguyenLieuTim.PasswordChar = '\0';
            this.txtMaNguyenLieuTim.PlaceholderText = "";
            this.txtMaNguyenLieuTim.SelectedText = "";
            this.txtMaNguyenLieuTim.Size = new System.Drawing.Size(229, 48);
            this.txtMaNguyenLieuTim.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(101, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mã Nguyên Liệu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label4.Location = new System.Drawing.Point(101, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tên Nguyên Liệu";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControlTKNguyenLieu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 253);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1025, 394);
            this.panel1.TabIndex = 3;
            // 
            // gridControlTKNguyenLieu
            // 
            this.gridControlTKNguyenLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlTKNguyenLieu.Location = new System.Drawing.Point(0, 0);
            this.gridControlTKNguyenLieu.MainView = this.gridView1;
            this.gridControlTKNguyenLieu.Name = "gridControlTKNguyenLieu";
            this.gridControlTKNguyenLieu.Size = new System.Drawing.Size(1025, 394);
            this.gridControlTKNguyenLieu.TabIndex = 2;
            this.gridControlTKNguyenLieu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaNguyenLieu,
            this.TenNguyenLieu});
            this.gridView1.GridControl = this.gridControlTKNguyenLieu;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // MaNguyenLieu
            // 
            this.MaNguyenLieu.Caption = "Mã Nguyên Liệu";
            this.MaNguyenLieu.FieldName = "MaNguyenLieu";
            this.MaNguyenLieu.MinWidth = 25;
            this.MaNguyenLieu.Name = "MaNguyenLieu";
            this.MaNguyenLieu.Visible = true;
            this.MaNguyenLieu.VisibleIndex = 0;
            this.MaNguyenLieu.Width = 94;
            // 
            // TenNguyenLieu
            // 
            this.TenNguyenLieu.Caption = "Tên Nguyên Liệu";
            this.TenNguyenLieu.FieldName = "TenNguyenLieu";
            this.TenNguyenLieu.MinWidth = 25;
            this.TenNguyenLieu.Name = "TenNguyenLieu";
            this.TenNguyenLieu.Visible = true;
            this.TenNguyenLieu.VisibleIndex = 1;
            this.TenNguyenLieu.Width = 94;
            // 
            // TimKiemNguyenLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 647);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelControl1);
            this.Name = "TimKiemNguyenLieu";
            this.Text = "TimKiemNguyenLieu";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTKNguyenLieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private Guna.UI2.WinForms.Guna2Button btnTimKienNguyenLieu;
        private Guna.UI2.WinForms.Guna2TextBox txtTenNguyenLieuTim;
        private Guna.UI2.WinForms.Guna2TextBox txtMaNguyenLieuTim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControlTKNguyenLieu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MaNguyenLieu;
        private DevExpress.XtraGrid.Columns.GridColumn TenNguyenLieu;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}