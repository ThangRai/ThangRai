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
    public partial class MenuForm : Form
    {
        MY_DB mydb = new MY_DB();
        private DateTime giovao;
        public MenuForm()
        {
            InitializeComponent();
        }
        public MenuForm(DateTime giovao)
        {
            InitializeComponent();
            this.giovao = giovao;
        }
        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMenu.Controls.Clear();
            panelMenu.Controls.Add(new QuanLyKHForm());
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            panelMenu.Controls.Clear();
            panelMenu.Controls.Add(new MatHangForm());
        }

        private void muaHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
       
        private void MenuForm_Load(object sender, EventArgs e)
        {
            
        }
        string laytennv(int msnv)
        {
            msnv = GLOBALS.GlobalUserId;
            string tennv = "";
            SqlCommand command2 = new SqlCommand("SELECT * FROM dbo.NHANVIEN WHERE msnv=" + msnv, mydb.getConnection);
            mydb.openConnection();
            SqlDataReader reader = command2.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                tennv = reader["hoten"].ToString();
            }
            reader.Close();
            return tennv;
        }
        private void buttonThoat_Click_1(object sender, EventArgs e)
        {
            CHAMCONG cc = new CHAMCONG();
            int msnv = GLOBALS.GlobalUserId;
            string tennv = laytennv(msnv);
            DateTime giora = DateTime.Now;
            TimeSpan check = giovao - giora;
            int sogio = Math.Abs(check.Hours);
            cc.insertGioRa(msnv,tennv, giora,giovao,sogio);
            Close();
        }

        private void buttonDangXuat_Click(object sender, EventArgs e)
        {
            CHAMCONG cc = new CHAMCONG();
            int msnv = GLOBALS.GlobalUserId;
            string tennv = laytennv(msnv);
            DateTime giora = DateTime.Now;
            TimeSpan check = giovao - giora;
            int sogio = Math.Abs(check.Hours);
            cc.insertGioRa(msnv, tennv, giora, giovao,sogio);
            this.Hide();
            Form1 lo = new Form1();
            lo.ShowDialog();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMenu.Controls.Clear();
            panelMenu.Controls.Add(new HoaDonForm());
        }
    }
}
