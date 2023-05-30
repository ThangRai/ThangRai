using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quản_lý_bán_hàng
{
    public partial class KiGuiForm : Form
    {
        public KiGuiForm()
        {
            InitializeComponent();
        }

        private void KiGuiForm_Load(object sender, EventArgs e)
        {
            MUAHANG mh = new MUAHANG();
            SqlCommand command = new SqlCommand("SELECT mahoadon as 'Hóa đơn',mskh as 'Mã khách hàng',magiohang as 'Giỏ hàng',tongtien as 'Tổng tiền',ngaymua as 'Ngày mua' FROM HOADON where trangthai=2");
            dataGridViewKiGui.DataSource = mh.layHangHoa(command);
           
            StyleDatagridview();
        }
        void refresh()
        {
            MUAHANG mh = new MUAHANG();
            SqlCommand command = new SqlCommand("SELECT mahoadon as 'Hóa đơn',mskh as 'Mã khách hàng',magiohang as 'Giỏ hàng',tongtien as 'Tổng tiền',ngaymua as 'Ngày mua' FROM HOADON where trangthai=2");
            dataGridViewKiGui.DataSource = mh.layHangHoa(command);

            StyleDatagridview();
        }
        void StyleDatagridview()
        {
            dataGridViewKiGui.ReadOnly = true;
            dataGridViewKiGui.RowTemplate.Height = 60;
            dataGridViewKiGui.BorderStyle = BorderStyle.None;
            dataGridViewKiGui.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewKiGui.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewKiGui.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            dataGridViewKiGui.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewKiGui.BackgroundColor = Color.FromArgb(148, 184, 184);
            dataGridViewKiGui.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewKiGui.EnableHeadersVisualStyles = false;
            dataGridViewKiGui.AllowUserToAddRows = false;
            dataGridViewKiGui.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewKiGui.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 12);

            //dòng tiêu đề của bảng
            dataGridViewKiGui.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(58, 95, 95);
            dataGridViewKiGui.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //căn giữa 
            

        }

        private void buttonMoKiGui_Click(object sender, EventArgs e)
        {
            THANHTOAN thanhtoan = new THANHTOAN();
            if (dataGridViewKiGui.CurrentRow.Cells[0].Value.ToString() == "" || dataGridViewKiGui.CurrentRow.Cells[1].Value.ToString() == "")
            {
                return;
            }
            else
            {
                int mahoadon = Convert.ToInt32(dataGridViewKiGui.CurrentRow.Cells[0].Value.ToString());
                int mskh = Convert.ToInt32(dataGridViewKiGui.CurrentRow.Cells[1].Value.ToString());
                DialogResult result = MessageBox.Show("Mở kí gửi ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result==DialogResult.Yes)
                {
                    thanhtoan.mokiguihoadon(mahoadon, mskh);
                    MessageBox.Show("Đã mở kí gửi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh();
                }
               
            }
        }
    }
}
