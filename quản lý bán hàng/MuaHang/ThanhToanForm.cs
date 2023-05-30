using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;
using Size = System.Drawing.Size;
using System.IO;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.Globalization;

namespace quản_lý_bán_hàng
{
    public partial class ThanhToanForm : Form
    {
        private int mskh;
        private string tenkh;
        MUAHANG muahang = new MUAHANG();
        bool check = true;

        public ThanhToanForm()
        {
            InitializeComponent();
        }
        public ThanhToanForm(int mskh,string tenkh)
        {
            InitializeComponent();
            this.mskh = mskh;
            this.tenkh = tenkh;
        }

        private void ThanhToanForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT tenhang as'Tên mặt hàng',soluong as 'Số lượng',gia as 'Giá' FROM XUATHOADON WHERE thanhtoan=0 AND mskh =" + mskh);
            dataGridViewTT.DataSource = muahang.layHangHoa(command);
            labelMaKH.Text = "Mã khách hàng: "+mskh;
            labelTenKH.Text = "Khách hàng: "+tenkh;
            double value = Convert.ToDouble(muahang.tongtien(mskh));
            labelTongTien.Text = "Tổng tiền: " + string.Format(new CultureInfo("vi-VN"), "{0:#,##0.00}", value) + " VND";
            dataGridViewTT.ReadOnly = true;
            StyleDatagridview();
            
        }
        void StyleDatagridview()
        {
            dataGridViewTT.ReadOnly = true;
            dataGridViewTT.RowTemplate.Height = 20;
            dataGridViewTT.BorderStyle = BorderStyle.None;
            dataGridViewTT.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewTT.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewTT.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            dataGridViewTT.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewTT.BackgroundColor = Color.FromArgb(148, 184, 184);
            dataGridViewTT.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewTT.EnableHeadersVisualStyles = false;
            dataGridViewTT.AllowUserToAddRows = false;
            dataGridViewTT.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewTT.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 12);

            //dòng tiêu đề của bảng
            dataGridViewTT.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(58, 95, 95);
            dataGridViewTT.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //căn giữa 
            dataGridViewTT.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            

        }
        private void buttonXuatHD_Click(object sender, EventArgs e)
        {
            
        }
        

        private void buttonThanhToan_Click(object sender, EventArgs e)
        {
            if(check==true)
            {
                HOADON hoadon = new HOADON();
                MY_DB mydb = new MY_DB();
                int magiohang = -1;
                SqlCommand command = new SqlCommand("SELECT * FROM GIOHANG WHERE mskh=" + mskh, mydb.getConnection);
                mydb.openConnection();
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    magiohang = Convert.ToInt32(reader["magiohang"]);
                }
                reader.Close();
                mydb.closeConnection();

                DateTime ngaymua = DateTime.Now;
                double tongtien = Convert.ToDouble(muahang.tongtien(mskh));
                if (hoadon.kthoadon(GLOBALS.GlobalUserId)==false)
                {
                    MessageBox.Show("Giỏ hàng đã có hóa đơn vui lòng kiểm tra tại quầy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (hoadon.themvaohoadon(mskh, magiohang, tongtien, ngaymua))
                    {
                        check = false;
                        MessageBox.Show("Kiểm tra tại quầy", "Thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi", "Thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Đã xác nhận vui lòng không xác nhận lại", "Thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
                
        }
    }
}
