using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Version_1
{
    public partial class frmChinh : Form
    {
        public frmChinh()
        {
            InitializeComponent();
        }

        string chuoiketnoi = @"Data Source=TUF-DASH-F15;Initial Catalog=CONGTY;Integrated Security=True;";
        string sql;
        SqlConnection ketnoi;
        SqlCommand thuchien;
        SqlDataReader docdulieu;
        int i = 0;
		int dem = 1;


		// Khai báo các biến toàn cục
		public static CongTy congty = new CongTy();
        NhanVien nv;

        public static string static_MaSo, static_HoTen, static_DiaChi, static_ThongTinRieng;
        public static double static_HeSoLuong, static_LuongCanBan;
        public static int static_ChucVu; // 1: Programmer, 2: Designer, 3: Tester, 4: Manager
        public static DateTime static_NgaySinh;

        private void rdbProgrammer_Click(object sender, EventArgs e)
        {
            groupThongTinRieng.Visible = true; // hiện ra.
            lblThongTinRieng.Text = "Tiền Overtime: ";
        }

        private void rdbTester_Click(object sender, EventArgs e)
        {
            groupThongTinRieng.Visible = true; // hiện ra.
            lblThongTinRieng.Text = "Số lỗi: ";
        }

        private void rdbDesigner_Click(object sender, EventArgs e)
        {
            groupThongTinRieng.Visible = true; // hiện ra.
            lblThongTinRieng.Text = "Bonus: ";
        }

        private void rdbManager_Click(object sender, EventArgs e)
        {
            groupThongTinRieng.Visible = false;
        }

        private void frmChinh_Load(object sender, EventArgs e)
        {

            ketnoi = new SqlConnection(chuoiketnoi);


            // ListView sẽ có 10 cột
            lstView.Columns.Add("STT", 70);
            lstView.Columns.Add("Mã Số", 70);
            lstView.Columns.Add("Họ Tên", 140);
            lstView.Columns.Add("Địa Chỉ", 140);
            lstView.Columns.Add("Ngày Sinh", 70);
            lstView.Columns.Add("Hệ Số Lương", 70);
            lstView.Columns.Add("Lương Căn Bản", 90);
            lstView.Columns.Add("Chức Vụ", 140);
            lstView.Columns.Add("Thông Tin Riêng", 140);
            lstView.Columns.Add("Tiền Lương Được Nhận", 90);

            hienthi();
        }
        
        public void hienthi()
        {
            lstView.Items.Clear(); // Xóa hết các dòng đang có
            ketnoi.Open();
            sql = @"SELECT MaSo, HoTen, DiaChi, NgaySinh, HeSoLuong, LuongCanBan,ChucVu,ThongTinThem FROM NhanVien";
            thuchien = new SqlCommand(sql,ketnoi);
            docdulieu = thuchien.ExecuteReader();

            ListViewItem listItem = new ListViewItem();
            i = 0; 
            while(docdulieu.Read())
            {
				    
				listItem.SubItems.Add(docdulieu[0].ToString());
				listItem.SubItems.Add(docdulieu[1].ToString());
				listItem.SubItems.Add(docdulieu[2].ToString());
				listItem.SubItems.Add(docdulieu[3].ToString());
				listItem.SubItems.Add(docdulieu[4].ToString());
				listItem.SubItems.Add(docdulieu[5].ToString());
                

                i++;


            }
			lstView.Items.Add(listItem);


			//if (docdulieu.HasRows)
			//{
			//	while (docdulieu.Read())
			//	{
			//		NhanVien employee = new NhanVien
			//		{
			//			_MASO = docdulieu.GetInt32(0).ToString(),
			//			_HOTEN = docdulieu.GetString(1),
			//			_DIACHI = docdulieu.GetInt32(2).ToString(),
			//			_NGAYSINH = docdulieu.GetDateTime(3),
			//			_HESOLUONG = docdulieu.GetFloat(4),
			//			_LUONGCANBAN = docdulieu.GetFloat(5),
			//		};
			//		congty._DANHSACH.Add(employee);
			//	}
			//}

			//docdulieu.Close();
			//string[] arr = new string[10]; // tạo ra 10 phần tử tượng trưng cho 10 cột


			//// Đổ dữ liệu nhân viên sang ListView

			//arr[0] = (dem++).ToString();
			//arr[1] = nv._MASO;
			//arr[2] = nv._HOTEN;
			//arr[3] = nv._DIACHI;
			//arr[4] = nv._NGAYSINH.ToString("dd/MM/yyyy");
			//arr[5] = nv._HESOLUONG.ToString("0.00");
			//arr[6] = nv._LUONGCANBAN.ToString();
			//if (nv is Designer)
			//{
			//	arr[7] = "Designer";
			//	arr[8] = ((Designer)nv)._TIENTHUONG.ToString();
			//}
			//else if (nv is Programmer)
			//{
			//	arr[7] = "Programmer";
			//	arr[8] = ((Programmer)nv)._TIENNGOAIGIO.ToString();
			//}
			//else if (nv is Tester)
			//{
			//	arr[7] = "Tester";
			//	arr[8] = ((Tester)nv)._SOLOI.ToString();
			//}
			//else if (nv is Manager)
			//{
			//	arr[7] = "Manager";
			//	arr[8] = "NULL";
			//}
			//arr[9] = nv.TinhLuong().ToString();

			//ListViewItem dong = new ListViewItem(arr);
			//lstView.Items.Add(dong);


		}

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (congty.KiemTraMaBiTrung(txtMaSo.Text) == false)
            {
                    MessageBox.Show("Mã số bị trùng");
            }
            else
            {
                // kiểm tra xem thuộc nhân viên loại gì
                if (rdbDesigner.Checked == true)
                {
                        nv = new Designer(txtMaSo.Text, txtHoTen.Text, txtDiaChi.Text,
                        dtpNgaySinh.Value, double.Parse(txtHeSoLuong.Text),
                        double.Parse(txtLuongCanBan.Text),
                        double.Parse(txtThongTinRieng.Text));           
                }
                else if (rdbManager.Checked == true)
                {
                   
                        nv = new Manager(txtMaSo.Text, txtHoTen.Text, txtDiaChi.Text,
                        dtpNgaySinh.Value, double.Parse(txtHeSoLuong.Text),
                        double.Parse(txtLuongCanBan.Text));
                    
                }
                else if (rdbProgrammer.Checked == true)
                {
                    nv = new Programmer(txtMaSo.Text, txtHoTen.Text, txtDiaChi.Text,
                        dtpNgaySinh.Value, double.Parse(txtHeSoLuong.Text),
                        double.Parse(txtLuongCanBan.Text),
                        double.Parse(txtThongTinRieng.Text));           
                }
                else if (rdbTester.Checked == true)
                {
                    nv = new Tester(txtMaSo.Text, txtHoTen.Text, txtDiaChi.Text,
                        dtpNgaySinh.Value, double.Parse(txtHeSoLuong.Text),
                        double.Parse(txtLuongCanBan.Text),
                        int.Parse(txtThongTinRieng.Text));           
                }

                congty._DANHSACH.Add(nv); // Thêm nhân viên vào công ty

                // Đổ dữ liệu từ công ty vào ListView
                string[] arr = new string[10]; // tạo ra 10 phần tử tượng trưng cho 10 cột
                
                
                // Đổ dữ liệu nhân viên sang ListView

                arr[0] = (dem++).ToString();
                arr[1] = nv._MASO;
                arr[2] = nv._HOTEN;
                arr[3] = nv._DIACHI;
                arr[4] = nv._NGAYSINH.ToString("dd/MM/yyyy");
                arr[5] = nv._HESOLUONG.ToString("0.00");
                arr[6] = nv._LUONGCANBAN.ToString();

                if (nv is Designer)
                {
                    arr[7] = "Designer";
                    arr[8] = ((Designer)nv)._TIENTHUONG.ToString();
                }
                else if (nv is Programmer)
                {
                    arr[7] = "Programmer";
                    arr[8] = ((Programmer)nv)._TIENNGOAIGIO.ToString();
                }
                else if (nv is Tester)
                {
                    arr[7] = "Tester";
                    arr[8] = ((Tester)nv)._SOLOI.ToString();
                }
                else if (nv is Manager)
                {
                    arr[7] = "Manager";
                    arr[8] = "NULL";
                }
                arr[9] = nv.TinhLuong().ToString();

                ListViewItem dong = new ListViewItem(arr);
                lstView.Items.Add(dong);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int idx = -1;

            // xác định dòng đang chọn
            for (int i = 0; i < lstView.Items.Count; i++)
            {
                if (lstView.Items[i].Selected == true)
                {
                    //MessageBox.Show("Đang chọn dòng " + i);
                    idx = i;
                    break;
                }
            }

            if (idx != -1)
            {
                lstView.Items.RemoveAt(idx);
                dem--; // rất quan cmn trọng, => cập nhật lại chỉ số thứ tự trong listview cũng chỉnh là trong công ty

                // Xóa nhân viên có vị trí tương ứng trong công ty
                congty._DANHSACH.RemoveAt(idx);


                // Cập nhật lại STT bằng cách chạy lại vào ListView rồi thay lại dữ liệu cho cột đầu tiên (chỉ số 0)
                for (int i = idx; i < lstView.Items.Count; i++)
                {
                    lstView.Items[i].SubItems[0].Text = (i + 1).ToString();
                }
            }
            else
            {
                MessageBox.Show("Còn dòng nào nữa đâu mà xóa");
            }
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Đang sửa dòng nào
            int idx = -1;
            
            // xác định đang chọn dòng nào, lưu ý là có thể chọn nhiều dòng 1 lúc
           /* for (int i = 0; i < lstView.Items.Count; i++)
            {
                if (lstView.Items[i].Selected == true)
                {
                    //MessageBox.Show("Đang chọn dòng " + i);
                    idx = i;
                    //break;
                }
            } */

            // xác định đang chọn dòng nào. Lưu ý: Chỉ chọn 1 dòng.
            idx =  lstView.Items.IndexOf(lstView.SelectedItems[0]);

            //MessageBox.Show("Đang chọn dòng: " + idx);

            if (idx != -1)
            {
                frmCapNhat frm = new frmCapNhat();
                frm.MaSo = lstView.Items[idx].SubItems[1].Text; // truyền ô mã số
                frm.HoTen = lstView.Items[idx].SubItems[2].Text;
                frm.DiaChi = lstView.Items[idx].SubItems[3].Text;
                frm.NgaySinh = DateTime.ParseExact(lstView.Items[idx].SubItems[4].Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                frm.HeSoLuong = double.Parse(lstView.Items[idx].SubItems[5].Text);
                frm.LuongCanBan = double.Parse(lstView.Items[idx].SubItems[6].Text);


                if (lstView.Items[idx].SubItems[7].Text == "Designer")
                {
                    static_ChucVu = 2;
                }
                else if (lstView.Items[idx].SubItems[7].Text == "Tester")
                {
                    static_ChucVu = 3;
                }
                else if (lstView.Items[idx].SubItems[7].Text == "Programmer")
                {
                    static_ChucVu = 1;
                }
                else if (lstView.Items[idx].SubItems[7].Text == "Manager")
                {
                    static_ChucVu = 4;
                }
                frm.ChucVu = static_ChucVu;

                frm.ThongTinRieng = lstView.Items[idx].SubItems[8].Text;

                frm.ShowDialog();

                // Chạy tiếp từ đây xuống

                // cập nhật trên listview

                lstView.Items[idx].SubItems[2].Text = static_HoTen;
                lstView.Items[idx].SubItems[3].Text = static_DiaChi;
                lstView.Items[idx].SubItems[4].Text = static_NgaySinh.ToString("dd/MM/yyyy");
                lstView.Items[idx].SubItems[5].Text = static_HeSoLuong.ToString("0.00");
                lstView.Items[idx].SubItems[6].Text = static_LuongCanBan.ToString();
                // 1: Programmer, 2: Designer, 3: Tester, 4: Manager

                double Luong = static_HeSoLuong * static_LuongCanBan;
                MessageBox.Show(static_ChucVu.ToString());
                if (static_ChucVu == 1)
                {
                    lstView.Items[idx].SubItems[7].Text = "Programmer";

                    Luong += double.Parse(static_ThongTinRieng);
                }
                else if (static_ChucVu == 2)
                {
                    lstView.Items[idx].SubItems[7].Text = "Designer";
                    Luong += double.Parse(static_ThongTinRieng);
                }
                else if (static_ChucVu == 3)
                {
                    lstView.Items[idx].SubItems[7].Text = "Tester";
                    Luong += double.Parse(static_ThongTinRieng) * 100000;
                }
                else if (static_ChucVu == 4)
                {
                    lstView.Items[idx].SubItems[7].Text = "Manager";
                }
                lstView.Items[idx].SubItems[8].Text = static_ThongTinRieng;
                lstView.Items[idx].SubItems[9].Text = Luong.ToString();

                // Cập nhật lại trên công ty nữa


                if (static_ChucVu == 1)
                {
                    congty._DANHSACH[idx] = new Programmer(static_MaSo, static_HoTen, static_DiaChi,
                        static_NgaySinh, static_HeSoLuong,
                        static_LuongCanBan, double.Parse(static_ThongTinRieng));
                }
                else if (static_ChucVu == 2)
                {
                    congty._DANHSACH[idx] = new Designer(static_MaSo, static_HoTen, static_DiaChi,
                        static_NgaySinh, static_HeSoLuong,
                        static_LuongCanBan, double.Parse(static_ThongTinRieng));
                }
                else if (static_ChucVu == 3)
                {
                    congty._DANHSACH[idx] = new Tester(static_MaSo, static_HoTen, static_DiaChi,
                        static_NgaySinh, static_HeSoLuong,
                        static_LuongCanBan, int.Parse(static_ThongTinRieng));
                }
                else if (static_ChucVu == 4)
                {
                    congty._DANHSACH[idx] = new Manager(static_MaSo, static_HoTen, static_DiaChi,
                        static_NgaySinh, static_HeSoLuong,
                        static_LuongCanBan);
                }

                for (int i = 0; i < congty._DANHSACH.Count(); i++)
                {
                    MessageBox.Show("\nCap nhat tren cong ty: Ho ten = " + congty._DANHSACH[i]._HOTEN + ", ngày sinh = " + congty._DANHSACH[i]._NGAYSINH);
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn dòng cần sửa");
            }
        }
        public static string MaSoTimkiem;
        int idx = 0;

		private void btnSapXep_Click(object sender, EventArgs e)
		{

		}

		private void lstView_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void btnTimKiem_Click(object sender, EventArgs e)
        {
            

            // Mỗi lần tìm kiếm thì reset lại ListView
            lstView.Items[idx].BackColor = Color.White;

            FormTimKiem frmTimKiem = new FormTimKiem();
            frmTimKiem.ShowDialog();

            bool Check = false;

            //Khi Form tìm kiếm đóng lại thì sẽ chạy tiếp từ chỗ này trở xuống.
            for (int i = 0; i < lstView.Items.Count; i++)
            {
                if (lstView.Items[i].SubItems[1].Text == MaSoTimkiem)
                {
                    Check = true;
                    idx = i;
                    lstView.Items[i].BackColor = Color.Red;
                    break; // thoát ra vì mã số sẽ không trùng.
                }
            }
            if (Check == false)
            {
                MessageBox.Show("Không tìm thấy");
            }
        }


        string strTimKiem;
       

        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            strTimKiem = txtTimKiem.Text;

            if (e.KeyCode == Keys.Back)
            {
                if (strTimKiem.Length != 0)
                {
                    strTimKiem = strTimKiem.Remove(strTimKiem.Length - 1); // xóa ký tự cuối cùng đi
                    //MessageBox.Show(strTimKiem);
                    

                    txtTimKiem.Select(txtTimKiem.Text.Length, 1);
                }
            }
            
            AddListView();
        }

        void AddListView()
        {
            int dem = 1;
            lstView.Items.Clear();

            for (int i = 0; i < congty._DANHSACH.Count(); i++)
            {
                string strTenTrongCongTy = congty._DANHSACH[i]._HOTEN;
                string strTenTimKiem = strTimKiem;

                // Chuẩn hóa cả 2 thành thường
                strTenTimKiem = strTenTimKiem.ToLower();
                strTenTrongCongTy = strTenTrongCongTy.ToLower();

               
                if (strTenTrongCongTy.Contains(strTenTimKiem) == true)
                {
                    // Đổ dữ liệu từ công ty vào ListView
                    string[] arr = new string[10]; // tạo ra 10 phần tử tượng trưng cho 10 cột


                    // Đổ dữ liệu nhân viên sang ListView

                    arr[0] = (dem++).ToString();
                    arr[1] = congty._DANHSACH[i]._MASO;
                    arr[2] = congty._DANHSACH[i]._HOTEN;
                    arr[3] = congty._DANHSACH[i]._DIACHI;
                    arr[4] = congty._DANHSACH[i]._NGAYSINH.ToString("dd/MM/yyyy");
                    arr[5] = congty._DANHSACH[i]._HESOLUONG.ToString("0.00");
                    arr[6] = congty._DANHSACH[i]._LUONGCANBAN.ToString();

                    if (congty._DANHSACH[i] is Designer)
                    {
                        arr[7] = "Designer";
                        arr[8] = ((Designer)congty._DANHSACH[i])._TIENTHUONG.ToString();
                    }
                    else if (congty._DANHSACH[i] is Programmer)
                    {
                        arr[7] = "Programmer";
                        arr[8] = ((Programmer)congty._DANHSACH[i])._TIENNGOAIGIO.ToString();
                    }
                    else if (congty._DANHSACH[i] is Tester)
                    {
                        arr[7] = "Tester";
                        arr[8] = ((Tester)congty._DANHSACH[i])._SOLOI.ToString();
                    }
                    else if (congty._DANHSACH[i] is Manager)
                    {
                        arr[7] = "Manager";
                        arr[8] = "NULL";
                    }
                    arr[9] = congty._DANHSACH[i].TinhLuong().ToString();

                    ListViewItem dong = new ListViewItem(arr);
                    lstView.Items.Add(dong);
                }
            }
        }
    }
}
