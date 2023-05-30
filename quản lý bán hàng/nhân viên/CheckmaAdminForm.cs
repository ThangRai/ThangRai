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
    public partial class CheckmaAdminForm : Form
    {
        MY_DB mydb = new MY_DB();
        KHACHHANG kh = new KHACHHANG();
        private int mskh;
        private string tenkh;
        public CheckmaAdminForm()
        {
            InitializeComponent();
        }
        public CheckmaAdminForm(int mskh,string tenkh)
        {
            InitializeComponent();
            this.mskh = mskh;
            this.tenkh = tenkh;
        }
        private void customButton1_Click(object sender, EventArgs e)
        {
            if (textBoxCustom1.Text.Trim() == "")
            {
                MessageBox.Show("Nhập mã xác nhận", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand("SELECT * FROM QUANLY WHERE password = @Pass", mydb.getConnection);
                command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = textBoxCustom1.Text;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                if ((table.Rows.Count > 0))
                {
                    this.Hide();
                    DoiMKForm doimk = new DoiMKForm(mskh,tenkh);
                    doimk.ShowDialog();
                    this.Focus();
                }
                else
                {
                    MessageBox.Show("Invalid Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CheckmaAdminForm_Load(object sender, EventArgs e)
        {

        }
    }
}
