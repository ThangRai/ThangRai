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
    public partial class MatHangForm : UserControl
    {
        MATHANG mathang = new MATHANG();
        MY_DB mydb = new MY_DB();
     
        public MatHangForm()
        {
            InitializeComponent();
        }
        
        private void MatHangForm_Load(object sender, EventArgs e)
        {
           
            SqlCommand command = new SqlCommand("SELECT mahang as 'Mã mặt hàng',loaihang as 'Loại hàng',tenhang as 'Tên mặt hàng',hinh as 'Hình',gia as 'Giá/sản phẩm',soluong as 'Số lượng' FROM HANGHOA");
            dataGridViewMatHang.DataSource = mathang.layHangHoa(command);
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            picCol = (DataGridViewImageColumn)dataGridViewMatHang.Columns[3];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            getImageAndUsername();
            StyleDatagridview();
            labelThongTinKho.Text = "Tổng mặt hàng trong kho:" +mathang.tongmathang();




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
           
            dataGridViewMatHang.ReadOnly = true;
            dataGridViewMatHang.RowTemplate.Height = 60;
            dataGridViewMatHang.BorderStyle = BorderStyle.None;
            dataGridViewMatHang.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewMatHang.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewMatHang.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            dataGridViewMatHang.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewMatHang.BackgroundColor = Color.FromArgb(148, 184, 184);
            dataGridViewMatHang.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewMatHang.EnableHeadersVisualStyles = false;
            dataGridViewMatHang.AllowUserToAddRows = false;
            dataGridViewMatHang.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewMatHang.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 12);
            
            //dòng tiêu đề của bảng
            dataGridViewMatHang.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(58, 95, 95);
            dataGridViewMatHang.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //căn giữa 
           

        }
        private void customButton1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void textBoxCustom1_Click(object sender, EventArgs e)
        {

        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofp = new OpenFileDialog();
            ofp.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((ofp.ShowDialog() == DialogResult.OK))
            {
                pictureBoxHinh.Image = Image.FromFile(ofp.FileName);
            }
        }

        private void dataGridViewMatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxMaHang.Text = dataGridViewMatHang.CurrentRow.Cells[0].Value.ToString();
            comboBoxLoaiHang.Text = dataGridViewMatHang.CurrentRow.Cells[1].Value.ToString();
            textBoxTenMH.Text = dataGridViewMatHang.CurrentRow.Cells[2].Value.ToString();
            byte[] pic;
            pic = (byte[])dataGridViewMatHang.CurrentRow.Cells[3].Value;
            MemoryStream picture = new MemoryStream(pic);
            pictureBoxHinh.Image = Image.FromStream(picture);

            textBoxGia.Text = dataGridViewMatHang.CurrentRow.Cells[4].Value.ToString();
            textBoxSL.Text = dataGridViewMatHang.CurrentRow.Cells[5].Value.ToString();
            double value = Convert.ToDouble(textBoxGia.Text);
            textBoxGia.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0.00}", value);
        }

        private void buttonNhap_Click(object sender, EventArgs e)
        {
            if(checkrong()==false)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông mặt hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                string loaihang = comboBoxLoaiHang.Text;
                string tenhang = textBoxTenMH.Text;
                int mahang = Convert.ToInt32(textBoxMaHang.Text);
                MemoryStream pic = new MemoryStream();
                pictureBoxHinh.Image.Save(pic, pictureBoxHinh.Image.RawFormat);
                double gia =Convert.ToDouble(textBoxGia.Text);
                int soluong =Convert.ToInt32(textBoxSL.Text);
                if (mathang.checkID(mahang) == false || mathang.checkten(tenhang) == false)
                {
                    MessageBox.Show("Kiểm tra thông tin bị trùng (ID/tên hàng)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (mathang.themhang(mahang,loaihang, tenhang, pic, gia, soluong))
                    {
                        MessageBox.Show("Thêm thành công", "Hàng hóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        refresh();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi", "Hàng hóa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        bool checkrong()
        {
            if (textBoxGia.Text.Trim() == "" || textBoxSL.Text.Trim() == "" || textBoxSL.Text.Trim() == "" || pictureBoxHinh.Image == null)
            {
                return false;
            }
            else
                return true;
        }
        void refresh()
        {
            SqlCommand command = new SqlCommand("SELECT mahang as 'Mã mặt hàng',loaihang as 'Loại hàng',tenhang as 'Tên mặt hàng',hinh as 'Hình',gia as 'Giá/sản phẩm',soluong as 'Số lượng' FROM HANGHOA");
            dataGridViewMatHang.DataSource = mathang.layHangHoa(command);
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            picCol = (DataGridViewImageColumn)dataGridViewMatHang.Columns[3];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            StyleDatagridview();
            //ShowComboboxLoaiHang();
            textBoxMaHang.Text = "";
            textBoxGia.Text = "";
            textBoxSL.Text = "";
            textBoxTenMH.Text = "";
            pictureBoxHinh.Image = null;
        }
        private void buttonSua_Click(object sender, EventArgs e)
        {
            if (checkrong() == false)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông mặt hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int mahang = Convert.ToInt32(textBoxMaHang.Text);
                string loaihang = comboBoxLoaiHang.Text;
                string tenhang = textBoxTenMH.Text;
                MemoryStream pic = new MemoryStream();
                pictureBoxHinh.Image.Save(pic, pictureBoxHinh.Image.RawFormat);
                double gia = Convert.ToDouble(textBoxGia.Text);
                int soluong = Convert.ToInt32(textBoxSL.Text);
                if (mathang.checkten(tenhang) == false)
                {
                    MessageBox.Show("Kiểm tra thông tin bị trùng tên hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (mathang.updateHang(mahang,loaihang, tenhang, pic, gia, soluong))
                {
                    MessageBox.Show("Đã chỉnh sửa", "Hàng hóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh();
                }
                else
                {
                    MessageBox.Show("Lỗi", "Hàng hóa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if(textBoxMaHang.Text.Trim()=="")
            {
                MessageBox.Show("Nhập mã hàng cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int id = int.Parse(textBoxMaHang.Text);
                DialogResult result;
                result = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Hệ Thống", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {

                    
                    if (mathang.Xoahang(id))
                    {

                        MessageBox.Show("Xóa thành công", "Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        refresh();
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công", "Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }    
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            ResetForm reset = new ResetForm();
            reset.ShowDialog();
            this.Focus();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            
            if (radioButtonMaMH.Checked)
            {
                if ((textBoxTimKiem.Text.Trim() == ""))
                {
                    SqlCommand command = new SqlCommand("SELECT mahang as 'Mã mặt hàng',loaihang as 'Loại hàng',tenhang as 'Tên mặt hàng',hinh as 'Hình',gia as'Giá',soluong as 'Số lượng' FROM HANGHOA");
                    dataGridViewMatHang.DataSource = mathang.layHangHoa(command);
                }
                else
                {

                    try
                    {
                        int mamh = int.Parse(textBoxTimKiem.Text);
                        SqlCommand command = new SqlCommand("SELECT mahang as 'Mã mặt hàng',loaihang as 'Loại hàng',tenhang as 'Tên mặt hàng',hinh as 'Hình',gia as'Giá',soluong as 'Số lượng' FROM HANGHOA WHERE mahang=" + mamh);
                        dataGridViewMatHang.DataSource = mathang.layHangHoa(command);
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
                    SqlCommand command = new SqlCommand("SELECT mahang as 'Mã mặt hàng',loaihang as 'Loại hàng',tenhang as 'Tên mặt hàng',hinh as 'Hình',gia as'Giá',soluong as 'Số lượng' FROM HANGHOA");
                    dataGridViewMatHang.DataSource = mathang.layHangHoa(command);
                }
                else
                {
                    try
                    {
                        string mamh = textBoxTimKiem.Text.ToString();
                        SqlCommand command = new SqlCommand("SELECT mahang as 'Mã mặt hàng',loaihang as 'Loại hàng',tenhang as 'Tên mặt hàng',hinh as 'Hình',gia as'Giá',soluong as 'Số lượng' FROM HANGHOA WHERE tenhang LIKE '%" + mamh + "%'");
                        dataGridViewMatHang.DataSource = mathang.layHangHoa(command);
                    }
                    catch
                    {
                        MessageBox.Show("Vui lòng nhập đúng định dạng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
