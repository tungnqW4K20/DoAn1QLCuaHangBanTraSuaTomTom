namespace WindowsFormsAppDoAa1111
{
    partial class QuanLyNhaCungCap
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
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaNhaCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenNhaCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiaChiNhaCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SDTNhaCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControlQLNhaCC = new DevExpress.XtraGrid.GridControl();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2TextBox6 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnXoaNhaCC = new Guna.UI2.WinForms.Guna2Button();
            this.btnSuaNhaCC = new Guna.UI2.WinForms.Guna2Button();
            this.btnThemNhaCC = new Guna.UI2.WinForms.Guna2Button();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2TextBox4 = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlQLNhaCC)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaNhaCC,
            this.TenNhaCC,
            this.DiaChiNhaCC,
            this.SDTNhaCC});
            this.gridView1.GridControl = this.gridControlQLNhaCC;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            // 
            // MaNhaCC
            // 
            this.MaNhaCC.Caption = "Mã Nhà Cung Cấp";
            this.MaNhaCC.FieldName = "MaNhaCC";
            this.MaNhaCC.MinWidth = 25;
            this.MaNhaCC.Name = "MaNhaCC";
            this.MaNhaCC.Visible = true;
            this.MaNhaCC.VisibleIndex = 0;
            this.MaNhaCC.Width = 94;
            // 
            // TenNhaCC
            // 
            this.TenNhaCC.Caption = "Tên Nhà Cung Cấp";
            this.TenNhaCC.FieldName = "TenNhaCC";
            this.TenNhaCC.MinWidth = 25;
            this.TenNhaCC.Name = "TenNhaCC";
            this.TenNhaCC.Visible = true;
            this.TenNhaCC.VisibleIndex = 1;
            this.TenNhaCC.Width = 94;
            // 
            // DiaChiNhaCC
            // 
            this.DiaChiNhaCC.Caption = "Địa chỉ";
            this.DiaChiNhaCC.FieldName = "DiaChiNhaCC";
            this.DiaChiNhaCC.MinWidth = 25;
            this.DiaChiNhaCC.Name = "DiaChiNhaCC";
            this.DiaChiNhaCC.Visible = true;
            this.DiaChiNhaCC.VisibleIndex = 2;
            this.DiaChiNhaCC.Width = 94;
            // 
            // SDTNhaCC
            // 
            this.SDTNhaCC.Caption = "Số Điện Thoại";
            this.SDTNhaCC.FieldName = "SDTNhaCC";
            this.SDTNhaCC.MinWidth = 25;
            this.SDTNhaCC.Name = "SDTNhaCC";
            this.SDTNhaCC.Visible = true;
            this.SDTNhaCC.VisibleIndex = 3;
            this.SDTNhaCC.Width = 94;
            // 
            // gridControlQLNhaCC
            // 
            this.gridControlQLNhaCC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlQLNhaCC.Location = new System.Drawing.Point(0, 0);
            this.gridControlQLNhaCC.MainView = this.gridView1;
            this.gridControlQLNhaCC.Name = "gridControlQLNhaCC";
            this.gridControlQLNhaCC.Size = new System.Drawing.Size(1332, 337);
            this.gridControlQLNhaCC.TabIndex = 0;
            this.gridControlQLNhaCC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label6.Location = new System.Drawing.Point(158, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 21);
            this.label6.TabIndex = 27;
            this.label6.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label5.Location = new System.Drawing.Point(744, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 21);
            this.label5.TabIndex = 26;
            this.label5.Text = "SĐT";
            // 
            // guna2TextBox6
            // 
            this.guna2TextBox6.BorderRadius = 15;
            this.guna2TextBox6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox6.DefaultText = "";
            this.guna2TextBox6.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox6.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox6.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox6.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox6.Location = new System.Drawing.Point(334, 133);
            this.guna2TextBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox6.Name = "guna2TextBox6";
            this.guna2TextBox6.PasswordChar = '\0';
            this.guna2TextBox6.PlaceholderText = "";
            this.guna2TextBox6.SelectedText = "";
            this.guna2TextBox6.Size = new System.Drawing.Size(229, 48);
            this.guna2TextBox6.TabIndex = 23;
            // 
            // guna2TextBox3
            // 
            this.guna2TextBox3.BorderRadius = 15;
            this.guna2TextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox3.DefaultText = "";
            this.guna2TextBox3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox3.Location = new System.Drawing.Point(910, 133);
            this.guna2TextBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox3.Name = "guna2TextBox3";
            this.guna2TextBox3.PasswordChar = '\0';
            this.guna2TextBox3.PlaceholderText = "";
            this.guna2TextBox3.SelectedText = "";
            this.guna2TextBox3.Size = new System.Drawing.Size(229, 48);
            this.guna2TextBox3.TabIndex = 21;
            // 
            // btnXoaNhaCC
            // 
            this.btnXoaNhaCC.BorderRadius = 15;
            this.btnXoaNhaCC.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaNhaCC.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaNhaCC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoaNhaCC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoaNhaCC.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaNhaCC.ForeColor = System.Drawing.Color.Black;
            this.btnXoaNhaCC.Image = global::WindowsFormsAppDoAa1111.Properties.Resources.recycle_bin;
            this.btnXoaNhaCC.Location = new System.Drawing.Point(861, 276);
            this.btnXoaNhaCC.Name = "btnXoaNhaCC";
            this.btnXoaNhaCC.Size = new System.Drawing.Size(180, 45);
            this.btnXoaNhaCC.TabIndex = 19;
            this.btnXoaNhaCC.Text = "Xóa";
            this.btnXoaNhaCC.Click += new System.EventHandler(this.btnXoaNhaCC_Click);
            // 
            // btnSuaNhaCC
            // 
            this.btnSuaNhaCC.BorderRadius = 15;
            this.btnSuaNhaCC.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaNhaCC.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaNhaCC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSuaNhaCC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSuaNhaCC.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaNhaCC.ForeColor = System.Drawing.Color.Black;
            this.btnSuaNhaCC.Image = global::WindowsFormsAppDoAa1111.Properties.Resources.pen;
            this.btnSuaNhaCC.Location = new System.Drawing.Point(593, 276);
            this.btnSuaNhaCC.Name = "btnSuaNhaCC";
            this.btnSuaNhaCC.Size = new System.Drawing.Size(180, 45);
            this.btnSuaNhaCC.TabIndex = 18;
            this.btnSuaNhaCC.Text = "Sửa";
            this.btnSuaNhaCC.Click += new System.EventHandler(this.btnSuaNhaCC_Click);
            // 
            // btnThemNhaCC
            // 
            this.btnThemNhaCC.BorderRadius = 15;
            this.btnThemNhaCC.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemNhaCC.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemNhaCC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemNhaCC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemNhaCC.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNhaCC.ForeColor = System.Drawing.Color.Black;
            this.btnThemNhaCC.Image = global::WindowsFormsAppDoAa1111.Properties.Resources.add_user1;
            this.btnThemNhaCC.Location = new System.Drawing.Point(284, 276);
            this.btnThemNhaCC.Name = "btnThemNhaCC";
            this.btnThemNhaCC.Size = new System.Drawing.Size(180, 45);
            this.btnThemNhaCC.TabIndex = 17;
            this.btnThemNhaCC.Text = "Thêm";
            this.btnThemNhaCC.Click += new System.EventHandler(this.btnThemNhaCC_Click);
            // 
            // guna2TextBox4
            // 
            this.guna2TextBox4.BorderRadius = 15;
            this.guna2TextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox4.DefaultText = "";
            this.guna2TextBox4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox4.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox4.Location = new System.Drawing.Point(910, 65);
            this.guna2TextBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox4.Name = "guna2TextBox4";
            this.guna2TextBox4.PasswordChar = '\0';
            this.guna2TextBox4.PlaceholderText = "";
            this.guna2TextBox4.SelectedText = "";
            this.guna2TextBox4.Size = new System.Drawing.Size(229, 48);
            this.guna2TextBox4.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControlQLNhaCC);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 363);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1332, 337);
            this.panel2.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label4.Location = new System.Drawing.Point(744, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tên Nhà Cung Cấp";
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BorderRadius = 15;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(334, 65);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(229, 48);
            this.guna2TextBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(164, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Nhà Cung Cấp";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.guna2TextBox6);
            this.panel1.Controls.Add(this.guna2TextBox3);
            this.panel1.Controls.Add(this.btnXoaNhaCC);
            this.panel1.Controls.Add(this.btnSuaNhaCC);
            this.panel1.Controls.Add(this.btnThemNhaCC);
            this.panel1.Controls.Add(this.guna2TextBox4);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.guna2TextBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1332, 363);
            this.panel1.TabIndex = 2;
            // 
            // QuanLyNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 700);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "QuanLyNhaCungCap";
            this.Text = "Quản Lý Nhà Cung Cấp";
            this.Load += new System.EventHandler(this.QuanLyNhaCungCap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlQLNhaCC)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MaNhaCC;
        private DevExpress.XtraGrid.Columns.GridColumn TenNhaCC;
        private DevExpress.XtraGrid.Columns.GridColumn DiaChiNhaCC;
        private DevExpress.XtraGrid.Columns.GridColumn SDTNhaCC;
        private DevExpress.XtraGrid.GridControl gridControlQLNhaCC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox6;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox3;
        private Guna.UI2.WinForms.Guna2Button btnXoaNhaCC;
        private Guna.UI2.WinForms.Guna2Button btnSuaNhaCC;
        private Guna.UI2.WinForms.Guna2Button btnThemNhaCC;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}