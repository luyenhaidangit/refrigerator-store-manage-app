using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cao_Van_Dan
{
    public partial class GUI_Load : Form
    {
        public GUI_Load()
        {
            InitializeComponent();
        }
        private void GUI_TrangChu_Load(object sender, EventArgs e)
        {

        }

        private void GUI_Load_KeyPress(object sender, KeyPressEventArgs e)
        {
            GUI_DangNhap frmDangNhap = new GUI_DangNhap();
            this.Hide();
            frmDangNhap.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // Kiểm tra xem người dùng có nhấn nút X không
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Gọi hàm Exit để đóng ứng dụng
                System.Windows.Forms.Application.Exit();
            }

            base.OnFormClosing(e);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
