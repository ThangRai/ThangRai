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
    public partial class DoiMKForm : Form
    {
        private int mskh;
        private string tenkh;
        public DoiMKForm()
        {
            InitializeComponent();
        }
        public DoiMKForm(int mskh,string tenkh)
        {
            InitializeComponent();
            this.mskh = mskh;
            this.tenkh = tenkh;
        }
        private void buttonXacNhan_Click(object sender, EventArgs e)
        {
            KHACHHANG kh = new KHACHHANG();
            string username = textBoxUser.Text;
            string password = textBoxPass.Text;
            string repassword = textBoxRePass.Text;
            if (verif() == true)
            {

                if (kh.update_user_pass(mskh,username,repassword))
                {
                    MessageBox.Show("Đã cập nhật", "Khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lỗi", "Khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error", "Khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        bool verif()
        {
            if ((textBoxUser.Text.Trim() == "") || (textBoxPass.Text.Trim() == "") || (textBoxRePass.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void DoiMKForm_Load(object sender, EventArgs e)
        {
            MY_DB mydb = new MY_DB();
            labelTenKh.Text = "Khách hàng: " + tenkh;
            SqlCommand command = new SqlCommand("SELECT * FROM KHACHHANG WHERE mskh="+mskh, mydb.getConnection);
            mydb.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                textBoxUser.Text = reader["username"]+"";
                textBoxPass.Text = reader["password"]+"";
            }
            reader.Close();
            mydb.closeConnection();
        }
    }
}
