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
    public partial class ThongKeDoanhThuForm : Form
    {
        DOANHTHU dt = new DOANHTHU();
        public ThongKeDoanhThuForm()
        {
            InitializeComponent();
        }

        private void ThongKeDoanhThuForm_Load(object sender, EventArgs e)
        {
            StyleDatagridview();


            SqlCommand command = new SqlCommand("SELECT MONTH(ngay) AS 'Tháng',SUM(tien) AS 'Doanh Thu' FROM dbo.DOANHTHU GROUP BY MONTH(ngay)");
            dataGridViewAVG.ReadOnly = true;
            dataGridViewAVG.RowTemplate.Height = 80;
            dataGridViewAVG.DataSource = dt.layDoanhThu(command);
            dataGridViewAVG.AllowUserToAddRows = false;


            //
            //chartAVG.Series["ChartAVG"].Points.AddXY("thang 2", 1500);
            //chartAVG.Series["ChartAVG"].Points.AddXY("thang 3", 1400);
            //chartAVG.Series["ChartAVG"].Points.AddXY("thang 4", 1200);
            int RowCount = dataGridViewAVG.Rows.Count; //hang`
            int ColumnCount = dataGridViewAVG.Columns.Count; //cot
            int r;
            string ten_tam;
            int giatri;
            for (r = 0; r < RowCount; r++) //chay hang`
            {
                ten_tam = dataGridViewAVG.Rows[r].Cells[0].Value.ToString();
                for (int c = 1; c < ColumnCount; c++)
                {
                    giatri = Convert.ToInt32(dataGridViewAVG.Rows[r].Cells[c].Value);
                    
                    chart1.Series["VNĐ"].Points.AddXY("Tháng "+ten_tam, giatri);
                    chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
                }
            }
        }
        void StyleDatagridview()
        {
            DateTime ngay = DateTime.Now;
            SqlCommand command = new SqlCommand("SELECT * FROM DOANHTHU");
            command.Parameters.Add("@ngay", SqlDbType.DateTime).Value = ngay;
            dataGridViewDoanhThu.DataSource = dt.layDoanhThu(command);
            dataGridViewDoanhThu.ReadOnly = true;
            dataGridViewDoanhThu.RowTemplate.Height = 60;
            dataGridViewDoanhThu.BorderStyle = BorderStyle.None;
            dataGridViewDoanhThu.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewDoanhThu.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewDoanhThu.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            dataGridViewDoanhThu.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewDoanhThu.BackgroundColor = Color.FromArgb(148, 184, 184);
            dataGridViewDoanhThu.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewDoanhThu.EnableHeadersVisualStyles = false;
            dataGridViewDoanhThu.AllowUserToAddRows = false;
            dataGridViewDoanhThu.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewDoanhThu.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 12);

            //dòng tiêu đề của bảng
            dataGridViewDoanhThu.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(58, 95, 95);
            dataGridViewDoanhThu.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //căn giữa 
            dataGridViewDoanhThu.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            

        }
        private void chartAVG_Click(object sender, EventArgs e)
        {

        }

        private void buttonThongKe_Click(object sender, EventArgs e)
        {
            string ngay = dateTimePicker1.Value.ToString();
            SqlCommand command = new SqlCommand("SELECT * FROM DOANHTHU WHERE ngay=@ngay");
            command.Parameters.Add("@ngay", SqlDbType.VarChar).Value = ngay;
            dataGridViewDoanhThu.DataSource = dt.layDoanhThu(command);
        }
    }
}
