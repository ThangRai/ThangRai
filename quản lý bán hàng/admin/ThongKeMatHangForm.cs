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
    public partial class ThongKeMatHangForm : Form
    {
        MATHANG mh = new MATHANG();
        public ThongKeMatHangForm()
        {
            InitializeComponent();
        }

        private void ThongKeMatHangForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT A.tenhang AS 'Tên mặt hàng',COUNT(B.soluong) AS 'Số lượng' FROM dbo.HANGHOA A,dbo.LICHSU_GIOHANG B WHERE A.mahang=B.mahang GROUP BY A.tenhang");
            dataGridViewAVG.ReadOnly = true;
            dataGridViewAVG.RowTemplate.Height = 80;
            dataGridViewAVG.DataSource = mh.layHangHoa(command);
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

                    chart1.Series["Số lượng"].Points.AddXY(ten_tam, giatri);
                    chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
                }
            }
        }
    }
}
