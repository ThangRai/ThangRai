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
    
    public partial class KHForm : Form
    {
        MUAHANG muahang = new MUAHANG();
        MY_DB mydb = new MY_DB();
        string tenkh;
        private int magh;
        bool check = true;
        double coupon = 1;
        bool check2 = false;
        public KHForm()
        {
            InitializeComponent();
        }
        public KHForm(int magh)
        {
            InitializeComponent();
            this.magh = magh;
        }
        private void buttonThem_Click(object sender, EventArgs e)
        {
            if (magh == 0)
            {
                MessageBox.Show("Vui lòng chọn giỏ hàng để mua sắm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
               
                if (checkrong() == false)
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông mặt hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    try
                    {
                        int mskh = GLOBALS.GlobalUserId;
                        string tenhang = textBoxTenHang.Text;
                        int mahang = Convert.ToInt32(textBoxMaHang.Text);
                        int magiohang = magh;
                        double gia = Convert.ToDouble(textBoxGia.Text);
                        int soluong = Convert.ToInt32(numericSoLuong.Text);
                        double tonggia = gia * soluong;
                        if (check2 == true) //áp dụng mã giảm giá
                        {
                            tonggia = tonggia - tonggia * coupon;
                        }
                        if (muahang.themhangvaogio(magiohang, mahang, tenhang, soluong, tonggia, mskh))
                        {
                            //muahang.lichsugiohang(magiohang, mahang, tenhang, soluong, tonggia, mskh);
                            MessageBox.Show("Thêm thành công", "Hàng hóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            giohang();
                            refresh();
                            refresh2();
                        }
                        else
                        {
                            MessageBox.Show("Lỗi", "Hàng hóa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Vui lòng kiểm tra lại thông tin nhập", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                bool checkrong()
                {
                    if (textBoxGia.Text.Trim() == "" || textBoxMaHang.Text.Trim() == "" || pictureBoxHinh.Image == null)
                    {
                        return false;
                    }
                    else
                        return true;
                }
            }
        }

        private void dataGridViewMatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxMaHang.Text = dataGridViewMatHang.CurrentRow.Cells[0].Value.ToString();
            textBoxTenHang.Text = dataGridViewMatHang.CurrentRow.Cells[2].Value.ToString();
            textBoxGia.Text = dataGridViewMatHang.CurrentRow.Cells[4].Value.ToString();
            byte[] pic;
            pic = (byte[])dataGridViewMatHang.CurrentRow.Cells[3].Value;
            MemoryStream picture = new MemoryStream(pic);
            pictureBoxHinh.Image = Image.FromStream(picture);
            double value = Convert.ToDouble(textBoxGia.Text);
            textBoxGia.Text=string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", value);
        }
        
        void refresh()
        {
            textBoxMaHang.Text = "";
            textBoxTenHang.Text = "";
            textBoxGia.Text = "";
            pictureBoxHinh.Image = null;
            numericSoLuong.Value = 0;
        }
        
        
        public void giohang()
        {
            int count = 0;
            SqlCommand command2 = new SqlCommand("SELECT * FROM dbo.GIOHANG WHERE mskh="+GLOBALS.GlobalUserId+"AND thanhtoan=0", mydb.getConnection);
            mydb.openConnection();
            SqlDataReader reader = command2.ExecuteReader();
            if (reader.HasRows)
            {
                //reader.Read();
                while (reader.Read())
                {
                    magh = Convert.ToInt32(reader["magiohang"].ToString());
                    count++;
                }
                check = false;
            }
            reader.Close();
            //count = (Int32)command.ExecuteScalar();
            mydb.closeConnection();
            if (count >0)
            {
                
                pictureBoxGioHang.Image = Properties.Resources._192538898_870335780587167_3162353575899320839_n;
                pictureBoxGioHang.BackColor = Color.Transparent;
            }    
        }
        void StyleDatagridview()
        {
            textBoxGia.ReadOnly = true;
            textBoxGia.Enabled = false;
            textBoxGia.BackColor = Color.FromArgb(82, 122, 122);
            textBoxMaHang.ReadOnly = true;
            textBoxMaHang.Enabled = false;
            textBoxMaHang.BackColor = Color.FromArgb(82, 122, 122);
            textBoxTenHang.ReadOnly = true;
            textBoxTenHang.Enabled = false;
            textBoxTenHang.BackColor = Color.FromArgb(82, 122, 122);
            dataGridViewMatHang.ReadOnly = true;
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
        public void getImageAndUsername()
        {
            MY_DB mydb = new MY_DB();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM KHACHHANG WHERE mskh=@id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = GLOBALS.GlobalUserId;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                tenkh = table.Rows[0]["hoten"].ToString();
                labelKH.Text = "Khách hàng: " + table.Rows[0]["hoten"].ToString();

            }
        }
        private void KHForm_Load(object sender, EventArgs e)
        {
            textBoxGia.ReadOnly = true;
            textBoxGia.Enabled = false;
            textBoxGia.BackColor = Color.FromArgb(122, 122, 122);
            SqlCommand command = new SqlCommand("SELECT mahang as 'Mã mặt hàng',loaihang as 'Loại hàng',tenhang as 'Tên mặt hàng',hinh as 'Hình',gia as'Giá',soluong as 'Số lượng' FROM HANGHOA");
            dataGridViewMatHang.DataSource = muahang.layHangHoa(command);
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            picCol = (DataGridViewImageColumn)dataGridViewMatHang.Columns[3];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

            getImageAndUsername();
            //check giỏ hàng
            giohang();
            //hien thi gio hang
            labelGioHang.Text = "Giỏ hàng :" + magh;

            StyleDatagridview();
        }
        void refresh2()
        {
            labelGioHang.Text = "Giỏ hàng :" + magh;
            SqlCommand command = new SqlCommand("SELECT mahang as 'Mã mặt hàng',loaihang as 'Loại hàng',tenhang as 'Tên mặt hàng',hinh as 'Hình',gia as'Giá',soluong as 'Số lượng' FROM HANGHOA");
            dataGridViewMatHang.DataSource = muahang.layHangHoa(command);
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            picCol = (DataGridViewImageColumn)dataGridViewMatHang.Columns[3];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            StyleDatagridview();
        }
        private void pictureBoxGioHang_Click(object sender, EventArgs e)
        {

            int mskh = GLOBALS.GlobalUserId;
            GioHangForm giohang = new GioHangForm(mskh,tenkh);
            giohang.ShowDialog();
            refresh2();
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 lo = new Form1();
            lo.ShowDialog();
        }

        private void buttonChonGH_Click(object sender, EventArgs e)
        {
            
           
            if (check == false)
            {
                MessageBox.Show("Khách hàng đang có giỏ hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Hide();
                ChonGioHang chongh = new ChonGioHang();
                chongh.ShowDialog();
                this.Close();
            }
           
        }

        private void labelGioHang_Click(object sender, EventArgs e)
        {

        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            if (textBoxMaGG.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng điền mã giảm giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (textBoxMaGG.Text == "khong")
                {
                    MessageBox.Show("Kiểm tra lại mã giảm giá", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    
                    MY_DB mydb = new MY_DB();
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    DataTable table = new DataTable();
                    SqlCommand command = new SqlCommand("SELECT * FROM HANGHOA WHERE magiamgia = @mgg ", mydb.getConnection);
                    command.Parameters.Add("@mgg", SqlDbType.VarChar).Value = textBoxMaGG.Text;
                    adapter.SelectCommand = command;
                    adapter.Fill(table);
                    if ((table.Rows.Count > 0))
                    {
                        MessageBox.Show("Mã giảm giá hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        coupon = 0.1;
                        check2 = true;
                    }
                    else
                    {
                        MessageBox.Show("Kiểm tra lại mã giảm giá", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        Random random = new Random();
        int x = 158, y = 69, a = 1;

        private void dataGridViewMatHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                x += a;
                labelKhuyenMai.Location = new Point(x, y);
                if (x >= 421)
                {
                    a = -1;
                    labelKhuyenMai.ForeColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
                }
                if (x <= 69)
                {
                    a = 1;
                    labelKhuyenMai.ForeColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
                }

            }
            catch (Exception ex)
            { }
        }
    }
}
