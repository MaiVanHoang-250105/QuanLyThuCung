using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTQuanLyThuCung
{
    public partial class frmDanhGia : Form
    {
        public frmDanhGia()
        {
            InitializeComponent();
        }

        private void frmDanhGia_Load(object sender, EventArgs e)
        {
            flpDanhGia.Controls.Add(
            TaoDanhGia(5, "Dịch vụ rất tốt", DateTime.Now, "")
            );

            flpDanhGia.Controls.Add(
                TaoDanhGia(4, "Ổn áp", DateTime.Now, "")
            );

            flpDanhGia.Controls.Add(
                TaoDanhGia(5, "Cực kỳ hài lòng", DateTime.Now, "")
            );
        }

        Random rd = new Random();

        string TaoTenNgauNhien()
        {
            string[] tenMau = { "Nguyễn Thị Hai", "Lê Tuấn Anh", "Võ Thị Như Quỳnh", "Tuấn Anh", "Bảo Anh" };
            return tenMau[rd.Next(tenMau.Length)];
        }

        Panel TaoDanhGia(int sao, string comment, DateTime ngay, string imagePath)
        {
            Panel p = new Panel();
            p.Width = 520;
            p.Height = 130;
            p.BorderStyle = BorderStyle.FixedSingle;
            p.BackColor = Color.White;
            p.Margin = new Padding(10);

            // 👤 tên random
            Label lblTen = new Label();
            lblTen.Text = "👤 " + TaoTenNgauNhien();
            lblTen.Font = new Font("Arial", 10, FontStyle.Bold);
            lblTen.Top = 10;
            lblTen.Left = 10;
            lblTen.AutoSize = true;

            // ⭐ sao
            Label lblSao = new Label();
            lblSao.Text = "⭐ " + new string('★', sao);
            lblSao.Top = 30;
            lblSao.Left = 10;
            lblSao.AutoSize = true;

            // 💬 comment
            Label lblCmt = new Label();
            lblCmt.Text = "💬 " + comment;
            lblCmt.Top = 50;
            lblCmt.Left = 10;
            lblCmt.AutoSize = true;

            // 🕒 ngày
            Label lblNgay = new Label();
            lblNgay.Text = "🕒 " + ngay.ToString("dd/MM/yyyy");
            lblNgay.Top = 75;
            lblNgay.Left = 10;
            lblNgay.AutoSize = true;

            // 🖼 ảnh
            if (!string.IsNullOrEmpty(imagePath))
            {
                PictureBox pic = new PictureBox();
                pic.Width = 80;
                pic.Height = 80;
                pic.Left = 400;
                pic.Top = 20;
                pic.SizeMode = PictureBoxSizeMode.StretchImage;

                try
                {
                    pic.Image = Image.FromFile(Application.StartupPath + "\\" + imagePath);
                }
                catch { }

                p.Controls.Add(pic);
            }

            p.Controls.Add(lblTen);
            p.Controls.Add(lblSao);
            p.Controls.Add(lblCmt);
            p.Controls.Add(lblNgay);

            return p;
        }
    }
}
