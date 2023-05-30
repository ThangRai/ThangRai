using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quản_lý_bán_hàng
{
    public partial class HoaDonForm : UserControl
    {
        MY_DB mydb = new MY_DB();
        string tenNV;
        THANHTOAN thanhtoan = new THANHTOAN();
        DOANHTHU dt = new DOANHTHU();
        HOADON hoadon = new HOADON();
        public HoaDonForm()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void HoaDonForm_Load(object sender, EventArgs e)
        {
            MUAHANG mh = new MUAHANG();
            SqlCommand command = new SqlCommand("SELECT mahoadon as 'Hóa đơn',mskh as 'Mã khách hàng',magiohang as 'Giỏ hàng',tongtien as 'Tổng tiền',ngaymua as 'Ngày mua' FROM HOADON where trangthai=0");
            dataGridViewHoaDon.DataSource = mh.layHangHoa(command);
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
                tenNV = table.Rows[0]["hoten"].ToString();
            }
        }
        void StyleDatagridview()
        { 
            textBoxMaNV.ReadOnly = true;
            textBoxMaNV.Enabled = false;
            textBoxMaNV.BackColor = Color.FromArgb(82, 122, 122);
            textBoxTenNV.ReadOnly = true;
            textBoxTenNV.Enabled = false;
            textBoxTenNV.BackColor = Color.FromArgb(82, 122, 122);
            dataGridViewHoaDon.ReadOnly = true;
            dataGridViewHoaDon.RowTemplate.Height = 60;
            dataGridViewHoaDon.BorderStyle = BorderStyle.None;
            dataGridViewHoaDon.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewHoaDon.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewHoaDon.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            dataGridViewHoaDon.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewHoaDon.BackgroundColor = Color.FromArgb(148, 184, 184);
            dataGridViewHoaDon.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewHoaDon.EnableHeadersVisualStyles = false;
            dataGridViewHoaDon.AllowUserToAddRows = false;
            dataGridViewHoaDon.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewHoaDon.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 12);

            //dòng tiêu đề của bảng
            dataGridViewHoaDon.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(58, 95, 95);
            dataGridViewHoaDon.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //căn giữa 
           

        }
        void refresh2()
        {
            textBoxMaHD.Text = "";
            textBoxMaKH.Text = "";
            textBoxMaNV.Text = "";
            textBoxTenNV.Text = "";
            textBoxTongTien.Text = "";
        }

        private void dataGridViewHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxMaHD.Text = dataGridViewHoaDon.CurrentRow.Cells[0].Value.ToString();
            textBoxMaKH.Text = dataGridViewHoaDon.CurrentRow.Cells[1].Value.ToString();
            textBoxMaNV.Text = GLOBALS.GlobalUserId.ToString();
            textBoxTenNV.Text = tenNV;
            textBoxTongTien.Text = dataGridViewHoaDon.CurrentRow.Cells[3].Value.ToString();
            double value = Convert.ToDouble(textBoxTongTien.Text);
            textBoxTongTien.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0.00}", value);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonThanhToan_Click(object sender, EventArgs e)
        {
            int mahoadon = Convert.ToInt32(textBoxMaHD.Text);
            int msnv = Convert.ToInt32(textBoxMaNV.Text);
            int mskh = Convert.ToInt32(textBoxMaKH.Text);
            DateTime ngaythanhtoan = dateTimePickerNgayThanhToan.Value;
            double tongtien = Convert.ToDouble(textBoxTongTien.Text);
            int magiohang = Convert.ToInt32(dataGridViewHoaDon.CurrentRow.Cells[2].Value.ToString());
            if (verif() == false)
            {
                MessageBox.Show("Nhập thông tin", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                decimal check;
                if (decimal.TryParse(textBoxMaHD.Text, out check) == false)
                {
                    MessageBox.Show("nhập đúng định dạng mã số nhân viên", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    if (thanhtoan.thanhtoan(mahoadon, msnv, ngaythanhtoan, tongtien))
                    {
                        dt.addDoanhthu(tongtien, ngaythanhtoan);
                        MessageBox.Show("Thanh Toán thành công", "Thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        thanhtoan.updatetrangthai(mahoadon, mskh); //sửa hóa đơn lại thành đã thanh toán 1
                        //cập nhật trạng thái là thanh toán r thì mới được xóa
                        thanhtoan.trangthaithanhtoan(magiohang, mskh);
                        //làm 1 khúc inser vào lịch sử thủ công
                        lichsumuahang(magiohang, mskh);
                        thanhtoan.xoahethangtronggio(magiohang, mskh); //xóa hàng đã thanh toán
                        refresh();
                        refresh2();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi", "Thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }
        void lichsumuahang(int magiohang,int mskh)
        {
            MUAHANG mh = new MUAHANG();

            SqlCommand command = new SqlCommand("SELECT * FROM GIOHANG WHERE mskh=@mskh AND magiohang=@mgh AND thanhtoan=1", mydb.getConnection);
            mydb.openConnection();
            command.Parameters.Add("@mskh", SqlDbType.Int).Value = mskh;
            command.Parameters.Add("@mgh", SqlDbType.Int).Value =magiohang ;
            //adapter.SelectCommand = command;
            int mahang;
            string tenhang;
            int soluong;
            double gia;
            DateTime ngay = DateTime.Now;

            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    mahang =Convert.ToInt32(reader["mahang"].ToString());
                    tenhang = reader["tenhang"].ToString();
                    soluong= Convert.ToInt32(reader["soluong"].ToString());
                    gia = Convert.ToDouble(reader["gia"].ToString());
                    mh.lichsugiohang(magiohang, mahang, tenhang, soluong, gia, mskh, ngay);
                }
            }
            reader.Close();
            //count = (Int32)command.ExecuteScalar();
            mydb.closeConnection();
        }
        bool verif()
        {
            if ((textBoxMaHD.Text.Trim() == "") || (textBoxMaNV.Text.Trim() == "") || (textBoxTenNV.Text.Trim() == "") || (textBoxTongTien.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        void refresh()
        {
            MUAHANG mh = new MUAHANG();
            SqlCommand command = new SqlCommand("SELECT mahoadon as 'Hóa đơn',mskh as 'Mã khách hàng',magiohang as 'Giỏ hàng',tongtien as 'Tổng tiền',ngaymua as 'Ngày mua' FROM HOADON where trangthai=0");
            dataGridViewHoaDon.DataSource = mh.layHangHoa(command);
            getImageAndUsername();
            StyleDatagridview();
        }

        private void buttonHuyDon_Click(object sender, EventArgs e)
        {
            if (textBoxMaHD.Text.Trim() == "" || textBoxMaKH.Text.Trim() == "" || dataGridViewHoaDon.CurrentRow.Cells[2].Value == null)
            {
                MessageBox.Show("Vui lòng nhập thông tin mã hóa đơn và mã số khách hàng", "Hủy hóa đơn", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                decimal check;
                if (decimal.TryParse(textBoxMaHD.Text, out check) == false || decimal.TryParse(textBoxMaHD.Text, out check) == false)
                {
                    MessageBox.Show("Nhập đúng định dạng Mã hóa đơn/MSKH", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    try
                    {
                        int mahoadon = Convert.ToInt32(textBoxMaHD.Text);
                        int mskh = Convert.ToInt32(textBoxMaKH.Text);
                        int magiohang = Convert.ToInt32(dataGridViewHoaDon.CurrentRow.Cells[2].Value.ToString());

                        DialogResult result = MessageBox.Show("Bạn có muốn hủy hóa đơn này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            if (hoadon.HuyHoaDon(mahoadon, mskh)==true)
                            {
                               
                                MessageBox.Show("Hủy hóa đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                //xóa trong don huy
                                refresh();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
            }
        }

        private void buttonKiGui_Click(object sender, EventArgs e)
        {
           
            if (verif() == false)
            {
                MessageBox.Show("Nhập thông tin", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                decimal check;
                if (decimal.TryParse(textBoxMaHD.Text, out check) == false)
                {
                    MessageBox.Show("nhập đúng định dạng mã số nhân viên", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    int mahoadon = Convert.ToInt32(textBoxMaHD.Text);
                    int mskh = Convert.ToInt32(textBoxMaKH.Text);
                    DialogResult result = MessageBox.Show("Bạn có muốn kí gửi hóa đơn này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        if (thanhtoan.kiguihoadon(mahoadon, mskh))
                        {
                            MessageBox.Show("Đã kí gửi hóa đơn", "Thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //sửa hóa đơn lại thành đã thanh toán
                            refresh();
                        }
                        else
                        {
                            MessageBox.Show("Lỗi", "Thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    
                }
            }
        }
    

        private void buttonMokigui_Click(object sender, EventArgs e)
        {
            KiGuiForm kigui = new KiGuiForm();
            kigui.ShowDialog();
            refresh(); 
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void chiTiếtHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            { 
                int mskh = Convert.ToInt32(dataGridViewHoaDon.CurrentRow.Cells[1].Value.ToString());
                int magiohang = Convert.ToInt32(dataGridViewHoaDon.CurrentRow.Cells[2].Value.ToString());
                CTHDForm cthd = new CTHDForm(mskh, magiohang);
                cthd.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
