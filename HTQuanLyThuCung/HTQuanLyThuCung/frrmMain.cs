using System;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace HTQuanLyThuCung
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadDashboard();
        }

        private void LoadDashboard()
        {
            lblTitle.Text = "Trang chủ";

            int pets = 5;
            int customers = 5;
            int services = 4;
            int appointments = 5;

            lblPets.Text = "🐶 Thú cưng\n" + pets;
            lblCustomers.Text = "👤 Khách hàng\n" + customers;
            lblServices.Text = "💅 Dịch vụ\n" + services;
            lblAppointments.Text = "📅 Tổng lịch hẹn\n" + appointments;

            chartStats.Series.Clear();

            Series s = new Series();
            s.ChartType = SeriesChartType.Column;
            s.IsValueShownAsLabel = true;

            s.Points.AddXY("Thú cưng", pets);
            s.Points.AddXY("Khách hàng", customers);
            s.Points.AddXY("Dịch vụ", services);

            chartStats.Series.Add(s);

            DataTable tb = new DataTable();
            tb.Columns.Add("Thú cưng");
            tb.Columns.Add("Dịch vụ");
            tb.Columns.Add("Thời gian");

            tb.Rows.Add("Milu", "Khám sức khỏe", "15/03");

            dgvAppointments.DataSource = tb;
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            panelDashboard.Visible = true;
            LoadDashboard();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Khách hàng";
            panelDashboard.Visible = false;
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Bán hàng";
            panelDashboard.Visible = false;
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Thống kê";
            panelDashboard.Visible = false;
        }

        private void btnHangHoa_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Hàng hóa";
            panelDashboard.Visible = false;
        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Dịch vụ";
            panelDashboard.Visible = false;
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Nhân viên";
            panelDashboard.Visible = false;
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đăng xuất?",
                "Thông báo",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}