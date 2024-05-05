using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Version_1
{
    public partial class frmCapNhat : Form
    {
        public frmCapNhat()
        {
            InitializeComponent();
        }
        public string MaSo, HoTen, DiaChi, ThongTinRieng;
        public double HeSoLuong, LuongCanBan;
        public int ChucVu; // 1: Programmer, 2: Designer, 3: Tester, 4: Manager
        public DateTime NgaySinh;

        private void frmCapNhat_Load(object sender, EventArgs e)
        {
            txtMaSo.Text = MaSo;
            txtHoTen.Text = HoTen;
            txtDiaChi.Text = DiaChi;
            dtpNgaySinh.Value = NgaySinh;
            txtThongTinRieng.Text = ThongTinRieng;
            txtHeSoLuong.Text = HeSoLuong.ToString();
            txtLuongCanBan.Text = LuongCanBan.ToString();

            if (ChucVu == 1)
            {
                rdbProgrammer.Checked = true;
            }
            else if (ChucVu == 2)
            {
                rdbDesigner.Checked = true;
            }
            else if (ChucVu == 3)
            {
                rdbTester.Checked = true;
            }
            else if(ChucVu == 4)
            {
                rdbManager.Checked = true;
            }

            // chưa cập nhật ngày sinh
            

            // ẩn cột mã số không cho sửa
            txtMaSo.Enabled = false;
        }
        

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            frmChinh.static_HoTen = txtHoTen.Text;
            frmChinh.static_DiaChi = txtDiaChi.Text;
            
            // ngày sinh bỏ qua
            frmChinh.static_NgaySinh = dtpNgaySinh.Value;
            frmChinh.static_HeSoLuong = double.Parse(txtHeSoLuong.Text);
            frmChinh.static_LuongCanBan = double.Parse(txtLuongCanBan.Text);

            if (rdbDesigner.Checked == true)
            {
                ChucVu = 2;
            }
            else if (rdbManager.Checked == true)
            {
                ChucVu = 4;
            }
            else if (rdbProgrammer.Checked == true)
            {
                ChucVu = 1;
            }
            else if (rdbTester.Checked == true)
            {
                ChucVu = 3;
            }

            frmChinh.static_ChucVu = ChucVu;
            frmChinh.static_ThongTinRieng = txtThongTinRieng.Text;

            //MessageBox.Show(frmChinh.static_ChucVu.ToString());

            this.Close();  
        }
    }
}
