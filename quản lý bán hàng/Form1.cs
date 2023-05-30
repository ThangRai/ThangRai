using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quản_lý_bán_hàng
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void buttonLogin_Click(object sender, EventArgs e)
        {
            MY_DB mydb = new MY_DB();
            if (radioButtonAdmin.Checked)
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand("SELECT * FROM QUANLY WHERE username = @User AND password = @Pass", mydb.getConnection);
                command.Parameters.Add("@User", SqlDbType.VarChar).Value = textBoxUsername.Text;
                command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = textBoxPassword.Text;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                if ((table.Rows.Count > 0))
                {
                    QuanLyForm admin = new QuanLyForm();
                    this.Hide();
                    admin.ShowDialog();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Invalid Username or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (radioButtonNV.Checked)
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand("SELECT * FROM NHANVIEN WHERE username = @User AND password = @Pass", mydb.getConnection);
                command.Parameters.Add("@User", SqlDbType.VarChar).Value = textBoxUsername.Text;
                command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = textBoxPassword.Text;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                if ((table.Rows.Count > 0))
                {

                    int userid = Convert.ToInt16(table.Rows[0][0].ToString()); //mã số nhân viên
                    GLOBALS.setGlobalUserId(userid);
                    //
                    CHAMCONG chamcong = new CHAMCONG();
                    DateTime giovao = DateTime.Now;
                    chamcong.insertGioVao(userid, giovao);
                    //
                    MenuForm menu = new MenuForm(giovao);
                    this.Hide();
                    menu.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if(radioButtonKH.Checked)
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand("SELECT * FROM KHACHHANG WHERE username = @User AND password = @Pass", mydb.getConnection);
                command.Parameters.Add("@User", SqlDbType.VarChar).Value = textBoxUsername.Text;
                command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = textBoxPassword.Text;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                if ((table.Rows.Count > 0))
                {
                    int userid = Convert.ToInt16(table.Rows[0][0].ToString());
                    GLOBALS.setGlobalUserId(userid);
                    KHForm khfrm = new KHForm();
                    this.Hide();
                    khfrm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }    
            else
            {
                MessageBox.Show("Chọn quyền đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabelDki_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DKiKHForm dki = new DKiKHForm();
            dki.ShowDialog();
        }
    }
}
