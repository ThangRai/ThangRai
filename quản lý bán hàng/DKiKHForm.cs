using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quản_lý_bán_hàng
{
    public partial class DKiKHForm : Form
    {
        public DKiKHForm()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void buttonDki_Click(object sender, EventArgs e)
        {
            KHACHHANG kh = new KHACHHANG();
            if (verif() == false)
            {
                MessageBox.Show("Nhập thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return false;

            }
            else
            {
                decimal check;
                if (decimal.TryParse(textBoxMaKH.Text, out check) == false)
                {
                    MessageBox.Show("nhập đúng định dạng Mã sinh viên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {


                    string hoten = textBoxHoTen.Text;
                    string diachi = textBoxDiaChi.Text;
                    string gioitinh = "Nam";

                    if (radioButtonNu.Checked)
                    {
                        gioitinh = "Nu";
                    }
                    int mskh = Convert.ToInt32(textBoxMaKH.Text);
                    string sdt = textBoxSDT.Text;

                    DateTime namsinh = dateTimePicker1.Value;
                    int born_year = dateTimePicker1.Value.Year;
                    int this_year = DateTime.Now.Year;
                    string user = textBoxUser.Text;
                    string pass = textBoxPass.Text;

                    //ràng buộc dữ liệu về năm xuất bản(ko cho người dùng nhập sai)
                    //năm xuất bản < năm hiện tại
                    if (((this_year - born_year) < 18) || ((this_year - born_year) > 100))
                    {
                        MessageBox.Show("Độ tuổi phải trong khoảng 18-100", "Khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    //ràng buộc dữ liệu về năm xuất bản(ko cho người dùng nhập sai)
                    //năm xuất bản < năm hiện tại

                    if(kh.checkID(mskh)==true)
                    {  
                        if (kh.themKH(mskh, hoten, gioitinh, namsinh, diachi, sdt,user,pass))
                        {
                            MessageBox.Show("Thêm thành công", "Khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            refresh();
                        }
                        else
                        {
                            MessageBox.Show("Lỗi", "Khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Empty Fields", "Khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }
        bool verif()
        {
            if ((textBoxMaKH.Text.Trim() == "") || (textBoxHoTen.Text.Trim() == "") || (textBoxDiaChi.Text.Trim() == "") || (textBoxSDT.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void refresh()
        {
            textBoxMaKH.Text = "";
            textBoxHoTen.Text = "";
            radioButtonNam.Checked = false;
            radioButtonNu.Checked = false;
            dateTimePicker1.Value = DateTime.Now;
            textBoxDiaChi.Text = "";
            textBoxSDT.Text = "";
           
        }

        private void buttonDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
    
}
