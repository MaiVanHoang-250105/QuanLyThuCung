namespace QuanLyThuCung
{
    partial class frmKhachHang
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelList = new System.Windows.Forms.Panel();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOtherInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colView = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.panelList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.panelList);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1667, 862);
            this.panelMain.TabIndex = 0;
            // 
            // panelList
            // 
            this.panelList.Controls.Add(this.dgvCustomers);
            this.panelList.Controls.Add(this.btnAdd);
            this.panelList.Controls.Add(this.lblTitle);
            this.panelList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelList.Location = new System.Drawing.Point(0, 0);
            this.panelList.Margin = new System.Windows.Forms.Padding(4);
            this.panelList.Name = "panelList";
            this.panelList.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.panelList.Size = new System.Drawing.Size(1667, 862);
            this.panelList.TabIndex = 0;
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.BackgroundColor = System.Drawing.Color.White;
            this.dgvCustomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colName,
            this.colAddress,
            this.colPhone,
            this.colEmail,
            this.colOtherInfo,
            this.colView,
            this.colDelete});
            this.dgvCustomers.EnableHeadersVisualStyles = false;
            this.dgvCustomers.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dgvCustomers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.dgvCustomers.Location = new System.Drawing.Point(27, 86);
            this.dgvCustomers.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.RowHeadersVisible = false;
            this.dgvCustomers.RowHeadersWidth = 50;
            this.dgvCustomers.RowTemplate.Height = 40;
            this.dgvCustomers.RowTemplate.ReadOnly = true;
            this.dgvCustomers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvCustomers.Size = new System.Drawing.Size(1613, 751);
            this.dgvCustomers.TabIndex = 3;
            this.dgvCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomers_CellContentClick);
            this.dgvCustomers.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvCustomers_RowPrePaint);
            // 
            // colId
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.colId.DefaultCellStyle = dataGridViewCellStyle1;
            this.colId.HeaderText = "#";
            this.colId.MinimumWidth = 6;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Width = 50;
            // 
            // colName
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.colName.DefaultCellStyle = dataGridViewCellStyle2;
            this.colName.HeaderText = "Tên khách hàng";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 180;
            // 
            // colAddress
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.colAddress.DefaultCellStyle = dataGridViewCellStyle3;
            this.colAddress.HeaderText = "Địa chỉ";
            this.colAddress.MinimumWidth = 6;
            this.colAddress.Name = "colAddress";
            this.colAddress.ReadOnly = true;
            this.colAddress.Width = 300;
            // 
            // colPhone
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.colPhone.DefaultCellStyle = dataGridViewCellStyle4;
            this.colPhone.HeaderText = "Số điện thoại";
            this.colPhone.MinimumWidth = 6;
            this.colPhone.Name = "colPhone";
            this.colPhone.ReadOnly = true;
            this.colPhone.Width = 130;
            // 
            // colEmail
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.colEmail.DefaultCellStyle = dataGridViewCellStyle5;
            this.colEmail.HeaderText = "Email";
            this.colEmail.MinimumWidth = 6;
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            this.colEmail.Width = 200;
            // 
            // colOtherInfo
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.colOtherInfo.DefaultCellStyle = dataGridViewCellStyle6;
            this.colOtherInfo.HeaderText = "Thông tin khác";
            this.colOtherInfo.MinimumWidth = 6;
            this.colOtherInfo.Name = "colOtherInfo";
            this.colOtherInfo.ReadOnly = true;
            this.colOtherInfo.Width = 180;
            // 
            // colView
            // 
            this.colView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colView.HeaderText = "Thao tác";
            this.colView.MinimumWidth = 6;
            this.colView.Name = "colView";
            this.colView.ReadOnly = true;
            this.colView.Text = "👁";
            this.colView.ToolTipText = "Xem chi tiết";
            this.colView.UseColumnTextForButtonValue = true;
            this.colView.Width = 70;
            // 
            // colDelete
            // 
            this.colDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colDelete.HeaderText = "";
            this.colDelete.MinimumWidth = 6;
            this.colDelete.Name = "colDelete";
            this.colDelete.ReadOnly = true;
            this.colDelete.Text = "🗑";
            this.colDelete.ToolTipText = "Xóa";
            this.colDelete.UseColumnTextForButtonValue = true;
            this.colDelete.Width = 60;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(160)))), ((int)(((byte)(71)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(1440, 25);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(147, 44);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblTitle.Location = new System.Drawing.Point(24, 31);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(367, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "DANH SÁCH KHÁCH HÀNG";
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1667, 862);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý khách hàng - Quản lý thú cưng";
//            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            this.panelMain.ResumeLayout(false);
            this.panelList.ResumeLayout(false);
            this.panelList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelList;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOtherInfo;
        private System.Windows.Forms.DataGridViewButtonColumn colView;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
    }
}