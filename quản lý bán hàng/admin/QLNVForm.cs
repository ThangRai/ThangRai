using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quản_lý_bán_hàng
{
    public partial class QLNVForm : Form
    {
        NHANVIEN nv = new NHANVIEN();
        MY_DB mydb = new MY_DB();
        public QLNVForm()
        {
            InitializeComponent();
        }

        private void textBoxCustom4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void QLNVForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT msnv as 'Mã nhân viên',hoten as 'Họ và tên',gioitinh as 'Giới tính',namsinh as 'Ngày sinh',diachi as 'Địa chỉ',hinh as 'Hình',username,password FROM NHANVIEN");
            dataGridViewNV.DataSource = nv.layNV(command);
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            picCol = (DataGridViewImageColumn)dataGridViewNV.Columns[5];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            StyleDatagridview();
        }
        void refresh()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM NHANVIEN");
            dataGridViewNV.DataSource = nv.layNV(command);
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            picCol = (DataGridViewImageColumn)dataGridViewNV.Columns[5];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            StyleDatagridview();
        }
        void StyleDatagridview()
        {
            dataGridViewNV.ReadOnly = true;

            dataGridViewNV.BorderStyle = BorderStyle.None;
            dataGridViewNV.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewNV.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewNV.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            dataGridViewNV.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewNV.BackgroundColor = Color.FromArgb(148, 184, 184);
            dataGridViewNV.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewNV.EnableHeadersVisualStyles = false;
            dataGridViewNV.AllowUserToAddRows = false;
            dataGridViewNV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewNV.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 12);
            dataGridViewNV.RowTemplate.Height = 60;
            //dòng tiêu đề của bảng
            dataGridViewNV.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(58, 95, 95);
            dataGridViewNV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //căn giữa 
           
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofp = new OpenFileDialog();
            ofp.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((ofp.ShowDialog() == DialogResult.OK))
            {
                pictureBoxHinh.Image = Image.FromFile(ofp.FileName);
            }
        }
        private void buttonSua_Click(object sender, EventArgs e)
        {
            if (verif() == false)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                decimal check;
                if (decimal.TryParse(textBoxMaNV.Text, out check) == false)
                {
                    MessageBox.Show("nhập đúng định dạng mã số nhân viên", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    int msnv = Convert.ToInt32(textBoxMaNV.Text);
                    string hoten = textBoxHoTen.Text.ToString();
                    string gioitinh = "Nam";
                    if (radioButtonNu.Checked)
                    {
                        gioitinh = "Nữ";
                    }
                    DateTime namsinh = dateTimePickerNamSinh.Value;
                    string diachi = textBoxDiaChi.Text.ToString();
                    MemoryStream pic = new MemoryStream();
                    pictureBoxHinh.Image.Save(pic, pictureBoxHinh.Image.RawFormat);
                    string user = textBoxUser.Text.ToString();
                    string pass = textBoxPass.Text.ToString();
                    try
                    {
                        if (nv.suaNV(msnv, hoten, gioitinh, namsinh, diachi, pic, user, pass))
                        {
                            MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Sửa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            bool verif()
            {
                if (textBoxMaNV.Text.Trim() == "" || textBoxHoTen.Text.Trim() == "" || textBoxDiaChi.Text.Trim() == "" || textBoxPass.Text.Trim() == "" || textBoxUser.Text.Trim() == "" || pictureBoxHinh.Image == null)
                {
                    return false;
                }
                else
                    return true;
            }
        }

        private void dataGridViewNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxMaNV.Text = dataGridViewNV.CurrentRow.Cells[0].Value.ToString();
            textBoxHoTen.Text = dataGridViewNV.CurrentRow.Cells[1].Value.ToString();
            if ((dataGridViewNV.CurrentRow.Cells[2].Value.ToString() == "Nam"))
            {

                radioButtonNam.Checked = true;
                radioButtonNu.Checked = false;
            }
            else
            {
                radioButtonNam.Checked = false;
                radioButtonNu.Checked = true;
            }
            dateTimePickerNamSinh.Value = (DateTime)dataGridViewNV.CurrentRow.Cells[3].Value;
            textBoxDiaChi.Text = dataGridViewNV.CurrentRow.Cells[4].Value.ToString();
            byte[] pic;
            pic = (byte[])dataGridViewNV.CurrentRow.Cells[5].Value;
            MemoryStream picture = new MemoryStream(pic);
            pictureBoxHinh.Image = Image.FromStream(picture);
            textBoxUser.Text = dataGridViewNV.CurrentRow.Cells[6].Value.ToString();
            textBoxPass.Text = dataGridViewNV.CurrentRow.Cells[7].Value.ToString();
        }
    }
}
