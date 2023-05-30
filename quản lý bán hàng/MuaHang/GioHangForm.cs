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

namespace quản_lý_bán_hàng
{
    public partial class GioHangForm : Form
    {
        private int mskh;
        private string tenkh;
        private int magiohang;
        MUAHANG muahang = new MUAHANG();
        public GioHangForm()
        {
            InitializeComponent();
        }
        public GioHangForm(int mskh,string tenkh)
        {
            InitializeComponent();
            this.mskh = mskh;
            this.tenkh = tenkh;
        }

        private void GioHangForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT stt,magiohang,mahang,tenhang as 'Tên mặt hàng',soluong as 'Số lượng',gia as'Giá' FROM dbo.GIOHANG WHERE thanhtoan=0 AND mskh ="+mskh);
            dataGridViewGH.DataSource = muahang.layHangHoa(command);
            textBoxMSKH.Text = mskh+"";
            textBoxTenKH.Text = tenkh;
            double value = Convert.ToDouble(muahang.tongtien(mskh));
            labelTongTien.Text = "Tổng tiền: " + string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", value) + " VND";
            StyleDatagridview();
        }
        void refresh()
        {
            
            SqlCommand command = new SqlCommand("SELECT stt,magiohang,mahang,tenhang as 'Tên mặt hàng',soluong as 'Số lượng',gia as'Giá' FROM dbo.GIOHANG WHERE thanhtoan=0 AND mskh =" + mskh);
            dataGridViewGH.DataSource = muahang.layHangHoa(command);
            textBoxMSKH.Text = mskh + "";
            textBoxTenKH.Text = tenkh;
            double value = Convert.ToDouble(muahang.tongtien(mskh));
            labelTongTien.Text = "Tổng tiền: " + string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", value) + " VND";
            StyleDatagridview();
        }
        void StyleDatagridview()
        {
            dataGridViewGH.ReadOnly = true;
            //dataGridViewGH.RowTemplate.Height = 60;
            dataGridViewGH.BorderStyle = BorderStyle.None;
            dataGridViewGH.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewGH.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewGH.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            dataGridViewGH.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewGH.BackgroundColor = Color.FromArgb(148, 184, 184);
            dataGridViewGH.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewGH.EnableHeadersVisualStyles = false;
            dataGridViewGH.AllowUserToAddRows = false;
            dataGridViewGH.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewGH.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 12);

            //dòng tiêu đề của bảng
            dataGridViewGH.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(58, 95, 95);
            dataGridViewGH.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //căn giữa 
            
        }

        private void buttonXoaHang_Click(object sender, EventArgs e)
        {
            int dong = dataGridViewGH.CurrentRow.Index;
            if (dong == -1)
            {
                MessageBox.Show("Chọn dòng cần xóa", "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int mahang = Convert.ToInt32(dataGridViewGH.Rows[dong].Cells[2].Value.ToString());
                int magiohang = Convert.ToInt32(dataGridViewGH.Rows[dong].Cells[1].Value.ToString());
                int stt= Convert.ToInt32(dataGridViewGH.Rows[dong].Cells[0].Value.ToString());
                DialogResult result;
                result = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Hệ Thống", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                try
                {
                    if (result == DialogResult.Yes)
                    {
                        if (muahang.Xoahang(stt,mahang,magiohang))
                        {
                            MessageBox.Show("Xóa thành công", "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            refresh();
                        }
                        else
                        {
                            MessageBox.Show("Xóa không thành công", "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonThanhToan_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThanhToanForm thanhtoan = new ThanhToanForm(mskh, tenkh);
            thanhtoan.ShowDialog();
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
