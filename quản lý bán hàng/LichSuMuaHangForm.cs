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
    public partial class LichSuMuaHangForm : Form
    {
        MUAHANG muahang = new MUAHANG();
        private int mskh;
        string tenkh = "";
        public LichSuMuaHangForm()
        {
            InitializeComponent();
        }
        public LichSuMuaHangForm(int mskh)
        {
            InitializeComponent();
            this.mskh = mskh;
        }
        string layten()
        {
            MY_DB mydb = new MY_DB();
            SqlCommand command2 = new SqlCommand("SELECT * FROM dbo.KHACHHANG WHERE mskh=" + mskh, mydb.getConnection);
            mydb.openConnection();
            SqlDataReader reader = command2.ExecuteReader();
            reader.Read();
            tenkh = reader["hoten"].ToString();
            reader.Close();
            //count = (Int32)command.ExecuteScalar();
            mydb.closeConnection();
            return tenkh;

        }
        private void LichSuMuaHangForm_Load(object sender, EventArgs e)
        {
            tenkh = layten();
            SqlCommand command = new SqlCommand("SELECT tenhang as'Tên mặt hàng',soluong as 'Số lượng',gia as 'Giá' FROM LICHSU_GIOHANG WHERE mskh =" + mskh);
            dataGridViewTT.DataSource = muahang.layHangHoa(command);
            labelMaKH.Text = "Mã khách hàng: " + mskh;
            labelTenKH.Text = "Khách hàng: " + tenkh;
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
            
        }
    }
}
