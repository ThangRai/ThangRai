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
    public partial class QuanLyMaGiamGiaForm : Form
    {
        MATHANG mh = new MATHANG();
        public QuanLyMaGiamGiaForm()
        {
            InitializeComponent();
        }

        private void QuanLyMaGiamGiaForm_Load(object sender, EventArgs e)
        {
            StyleDatagridview();
        }
        void StyleDatagridview()
        {
            textBoxMaMH.ReadOnly = true;
            textBoxMaMH.Enabled = false;
            textBoxMaMH.BackColor = Color.FromArgb(82, 122, 122);
            textBoxTenMH.ReadOnly = true;
            textBoxTenMH.Enabled = false;
            textBoxTenMH.BackColor = Color.FromArgb(82, 122, 122);
            SqlCommand command = new SqlCommand("SELECT mahang as 'Mã mặt hàng',tenhang as 'Tên mặt hàng',magiamgia as 'Mã giảm giá' FROM HANGHOA");
            dataGridViewMaGG.DataSource = mh.layHangHoa(command);
            dataGridViewMaGG.ReadOnly = true;
            dataGridViewMaGG.RowTemplate.Height = 60;
            dataGridViewMaGG.BorderStyle = BorderStyle.None;
            dataGridViewMaGG.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewMaGG.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewMaGG.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            dataGridViewMaGG.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewMaGG.BackgroundColor = Color.FromArgb(148, 184, 184);
            dataGridViewMaGG.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewMaGG.EnableHeadersVisualStyles = false;
            dataGridViewMaGG.AllowUserToAddRows = false;
            dataGridViewMaGG.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewMaGG.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 12);

            //dòng tiêu đề của bảng
            dataGridViewMaGG.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(58, 95, 95);
            dataGridViewMaGG.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
           

        }

        private void dataGridViewMaGG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxMaMH.Text = dataGridViewMaGG.CurrentRow.Cells[0].Value.ToString();
            textBoxTenMH.Text = dataGridViewMaGG.CurrentRow.Cells[1].Value.ToString();
            textBoxMaGG.Text= dataGridViewMaGG.CurrentRow.Cells[2].Value.ToString();
        }
        void refresh()
        {
            StyleDatagridview();
            textBoxMaGG.Text = "";
            textBoxMaMH.Text = "";
            textBoxTenMH.Text = "";
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            if(textBoxMaMH.Text.Trim()=="")
            {
                MessageBox.Show("Vui lòng nhập mã mặt hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(textBoxMaGG.Text.Trim()=="")
                {
                    MessageBox.Show("Vui lòng nhập mã giảm giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }   
                else
                {
                    int mamh = Convert.ToInt32(textBoxMaMH.Text);
                    string magg = textBoxMaGG.Text.ToString();
                    if(mh.themmagiamgia(mamh,magg)==true)
                    {
                       
                        refresh();
                        MessageBox.Show("Đã thêm mã giảm giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Chưa thêm mã giảm giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }    
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)  
        {
            if (textBoxMaMH.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mã mặt hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            { 
                int mamh = Convert.ToInt32(textBoxMaMH.Text);
                string magg = "khong";
                mh.themmagiamgia(mamh, magg);
                MessageBox.Show("Đã xóa mã giảm giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refresh();
            }
        }
    }
}
