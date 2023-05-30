using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quản_lý_bán_hàng
{
    public partial class QuanLyKHForm : UserControl
    {
        KHACHHANG kh = new KHACHHANG();
        MY_DB mydb = new MY_DB();
        public QuanLyKHForm()
        {
            InitializeComponent();
        }

        private void QuanLyKHForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT mskh as 'Mã số KH',hoten as 'Họ và tên',gioitinh as 'Giới tính',namsinh as 'Năm sinh',diachi as 'Địa chỉ',sdt as 'Số điện thoại' FROM KHACHHANG");
            dataGridViewKH.DataSource = kh.layKH(command);
            getImageAndUsername();
            StyleDatagridview();
        }
        public void getImageAndUsername()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM NHANVIEN WHERE msnv=@id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = GLOBALS.GlobalUserId;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                byte[] pic = (byte[])table.Rows[0]["hinh"];
                MemoryStream picture = new MemoryStream(pic);
                pictureBoxNhanVien.Image = Image.FromStream(picture);
                labelNhanVien.Text = "Nhân viên: " + table.Rows[0]["hoten"].ToString();

            }
        }
        void StyleDatagridview()
        {
            dataGridViewKH.ReadOnly = true;
            dataGridViewKH.RowTemplate.Height = 60;
            dataGridViewKH.BorderStyle = BorderStyle.None;
            dataGridViewKH.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewKH.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewKH.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            dataGridViewKH.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewKH.BackgroundColor = Color.FromArgb(148, 184, 184);
            dataGridViewKH.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewKH.EnableHeadersVisualStyles = false;
            dataGridViewKH.AllowUserToAddRows = false;
            dataGridViewKH.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewKH.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 12);

            //dòng tiêu đề của bảng
            dataGridViewKH.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(58, 95, 95);
            dataGridViewKH.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            

        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            if (radioButtonMaKH.Checked)
            {
                if ((textBoxTimKiem.Text.Trim() == ""))
                {
                    SqlCommand command = new SqlCommand("SELECT mskh as 'Mã số KH',hoten as 'Họ và tên',gioitinh as 'Giới tính',namsinh as 'Năm sinh',diachi as 'Địa chỉ',sdt as 'Số điện thoại' FROM KHACHHANG");
                    dataGridViewKH.DataSource = kh.layKH(command);
                }
                else
                {

                    try
                    {
                        int id = int.Parse(textBoxTimKiem.Text);
                        SqlCommand command = new SqlCommand("SELECT mskh as 'Mã số KH',hoten as 'Họ và tên',gioitinh as 'Giới tính',namsinh as 'Năm sinh',diachi as 'Địa chỉ',sdt as 'Số điện thoại' FROM KHACHHANG WHERE mskh = " + id);
                        dataGridViewKH.DataSource = kh.layKH(command);
                    }
                    catch
                    {
                        MessageBox.Show("Vui lòng nhập đúng định dạng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else
            {
                if ((textBoxTimKiem.Text.Trim() == ""))
                {
                    SqlCommand command = new SqlCommand("SELECT mskh as 'Mã số KH',hoten as 'Họ và tên',gioitinh as 'Giới tính',namsinh as 'Năm sinh',diachi as 'Địa chỉ',sdt as 'Số điện thoại' FROM KHACHHANG");
                    dataGridViewKH.DataSource = kh.layKH(command);
                }
                else
                {
                    string ten = textBoxTimKiem.Text;
                    SqlCommand command = new SqlCommand("SELECT mskh as 'Mã số KH',hoten as 'Họ và tên',gioitinh as 'Giới tính',namsinh as 'Năm sinh',diachi as 'Địa chỉ',sdt as 'Số điện thoại' FROM KHACHHANG WHERE hoten LIKE '%" + ten + "%'");
                    dataGridViewKH.DataSource = kh.layKH(command);
                }

            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (textBoxMSKH.Text.Trim() == "")
            {
                MessageBox.Show("Nhập thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return false;

            }
            else
            {
                decimal check;
                if (decimal.TryParse(textBoxMSKH.Text, out check) == false)
                {
                    MessageBox.Show("nhập đúng định dạng Mã sách", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    try
                    {
                        int mskh = int.Parse(textBoxMSKH.Text);
                        DialogResult result;
                        result = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Hệ Thống", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (result == DialogResult.Yes)
                        {
                            kh.XoaKH(mskh);
                            MessageBox.Show("Xóa thành công", "Khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            refresh();
                        }
                    }
                    catch
                    {
                        MessageBox.Show(this, "Không xóa được vì đang tồn tại dữ liệu trong bảng khác", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void refresh()
        {
            textBoxMSKH.Text = "";
            textBoxHoTen.Text = "";
            radioButtonNam.Checked = false;
            radioButtonNu.Checked = false;
            dateTimePickerNamSinh.Value = DateTime.Now;
            textBoxDiaChi.Text = "";
            textBoxSDT.Text = "";
            SqlCommand command = new SqlCommand("SELECT mskh as 'Mã số KH',hoten as 'Họ và tên',gioitinh as 'Giới tính',namsinh as 'Năm sinh',diachi as 'Địa chỉ',sdt as 'Số điện thoại' FROM KHACHHANG");
            dataGridViewKH.DataSource = kh.layKH(command);
            StyleDatagridview();
        }
        private void buttonChinhSua_Click(object sender, EventArgs e)
        {
            if (verif() == false)
            {
                MessageBox.Show("Nhập thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return false;

            }
            else
            {
                decimal check;
                if (decimal.TryParse(textBoxMSKH.Text, out check) == false)
                {
                    MessageBox.Show("nhập đúng định dạng Mã sinh viên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {


                    string hoten = textBoxHoTen.Text;
                    string diachi = textBoxDiaChi.Text;
                    string gioitinh = "Nam";

                    if (radioButtonNu.Checked)
                    {
                        gioitinh = "Nu";
                    }
                    int mskh = Convert.ToInt32(textBoxMSKH.Text);
                    string sdt = textBoxSDT.Text;

                    DateTime namsinh = dateTimePickerNamSinh.Value;
                    int born_year = dateTimePickerNamSinh.Value.Year;
                    int this_year = DateTime.Now.Year;


                    //ràng buộc dữ liệu về năm xuất bản(ko cho người dùng nhập sai)
                    //năm xuất bản < năm hiện tại
                    if (((this_year - born_year) < 18) || ((this_year - born_year) > 100))
                    {
                        MessageBox.Show("Độ tuổi phải trong khoảng 18-100", "Khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    //ràng buộc dữ liệu về năm xuất bản(ko cho người dùng nhập sai)
                    //năm xuất bản < năm hiện tại

                    else if (verif() == true)
                    {

                        if (kh.capnhatKH_chua_user_pass(mskh,hoten,gioitinh,namsinh,diachi,sdt))
                        {
                            MessageBox.Show("Sửa thành công", "Khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            refresh();
                        }
                        else
                        {
                            MessageBox.Show("Lỗi", "Khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Empty Fields", "Khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }
        bool verif()
        {
            if ((textBoxMSKH.Text.Trim() == "") || (textBoxHoTen.Text.Trim() == "") || (textBoxDiaChi.Text.Trim() == "")||(textBoxSDT.Text.Trim()==""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void dataGridViewKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxMSKH.Text = dataGridViewKH.CurrentRow.Cells[0].Value.ToString();
            textBoxHoTen.Text = dataGridViewKH.CurrentRow.Cells[1].Value.ToString();
            if ((dataGridViewKH.CurrentRow.Cells[2].Value.ToString() == "Nu"))
            {
                radioButtonNu.Checked = true;
            }
            else
            {
                radioButtonNam.Checked = true;
            }

            dateTimePickerNamSinh.Text = dataGridViewKH.CurrentRow.Cells[3].Value.ToString();
            textBoxDiaChi.Text = dataGridViewKH.CurrentRow.Cells[4].Value.ToString();
            textBoxSDT.Text = dataGridViewKH.CurrentRow.Cells[5].Value.ToString();
        }

        private void buttonSuaThongTin_Click(object sender, EventArgs e)
        {
            if(textBoxMSKH.Text.Trim()==""|| textBoxHoTen.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mã khách hàng/tên khách hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int mskh = Convert.ToInt32(textBoxMSKH.Text);
                string tenkh = textBoxHoTen.Text;
                CheckmaAdminForm checkma = new CheckmaAdminForm(mskh, tenkh);
                checkma.ShowDialog();
            }   
            
        }

        private void lịchSửMuaHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int mskh = Convert.ToInt32(dataGridViewKH.CurrentRow.Cells[0].Value.ToString());
                LichSuMuaHangForm lichsu = new LichSuMuaHangForm(mskh);
                lichsu.ShowDialog();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
