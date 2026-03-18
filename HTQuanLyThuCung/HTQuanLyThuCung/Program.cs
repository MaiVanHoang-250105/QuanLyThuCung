using HTQuanLyThuCung;
using HTQuanLyThuCung.Helpers;
using QuanLyThuCung;
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
            frmKhachHang loginForm = new frmKhachHang();
            FontHelper.SetUnicodeFont(loginForm);
            Application.Run(loginForm);
        }
    }
}