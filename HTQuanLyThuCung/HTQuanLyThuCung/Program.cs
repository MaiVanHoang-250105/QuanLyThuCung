using HTQuanLyThuCung;
using HTQuanLyThuCung.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTQuanLyThuCung
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Uncomment dòng dưới để mở form tính hash (dùng để tạo script SQL)
            // Application.Run(new frmHashPassword());

            // Form đăng nhập chính
<<<<<<< HEAD
            frmKhachHang loginForm = new frmKhachHang();
=======
            frmDangNhap loginForm = new frmDangNhap();
>>>>>>> 969d3bbb4ca9cab183b71382be0f7108dab407e6
            FontHelper.SetUnicodeFont(loginForm);
            Application.Run(loginForm);
        }
    }
}