using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quản_lý_bán_hàng
{
    public partial class ThemNVForm : Form
    {
        NHANVIEN nv = new NHANVIEN();
        public ThemNVForm()
        {
            InitializeComponent();
        }
        void refresh()
        {
            textBoxDiaChi.Text = "";
            textBoxHoten.Text = "";
            textBoxMsnv.Text = "";
            textBoxPassword.Text = "";
            textBoxUsername.Text = "";
            radioButtonNam.Checked = false;
            radioButtonNu.Checked = false;
            pictureBoxAnhDaiDien.Image = null;
        }
        private void buttonThem_Click(object sender, EventArgs e)
        {
            if (verif() == false)
            {
                MessageBox.Show("Nhập thông tin", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                decimal check;
                if (decimal.TryParse(textBoxMsnv.Text, out check) == false)
                {
                    MessageBox.Show("nhập đúng định dạng mã số nhân viên", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    int msnv = Convert.ToInt32(textBoxMsnv.Text);
                    string hoten = textBoxHoten.Text;
                    string diachi = textBoxDiaChi.Text;
                    DateTime namsinh = dateTimePickerNamSinh.Value;
                    string username = textBoxUsername.Text;
                    string password = textBoxPassword.Text;
                    string gioitinh = "Nam";

                    if (radioButtonNu.Checked)
                    {
                        gioitinh = "Nữ";
                    }

                    MemoryStream hinh = new MemoryStream();
                    int born_year = dateTimePickerNamSinh.Value.Year;
                    int this_year = DateTime.Now.Year;
                    //ràng buộc dữ liệu về độ tuổi(ko cho người dùng nhập sai)
                    //svv từ 10-100
                    if (((this_year - born_year) < 10) || ((this_year - born_year) > 100))
                    {
                        MessageBox.Show("Độ tuổi phải trong khoảng từ 10-100", "Nhập sai", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (nv.checkID(msnv) == false)
                    {
                        MessageBox.Show("Trùng ID", "Nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (verif())
                    {
                        pictureBoxAnhDaiDien.Image.Save(hinh, pictureBoxAnhDaiDien.Image.RawFormat);
                        if (nv.themNV(msnv,hoten,gioitinh,namsinh,diachi,hinh,username,password))
                        {
                            MessageBox.Show("Thêm thành công", "Nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            refresh();
                        }
                        else
                        {
                            MessageBox.Show("Lỗi", "Nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Empty Fields", "Nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void ButtonUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofp = new OpenFileDialog();
            ofp.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((ofp.ShowDialog() == DialogResult.OK))
            {
                pictureBoxAnhDaiDien.Image = Image.FromFile(ofp.FileName);
            }
        }
        bool verif()
        {
            if ((textBoxMsnv.Text.Trim() == "") || (textBoxHoten.Text.Trim() == "") || (textBoxDiaChi.Text.Trim() == "") || (textBoxPassword.Text.Trim() == "") || (textBoxUsername.Text.Trim() == "") || (pictureBoxAnhDaiDien.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void buttonDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
