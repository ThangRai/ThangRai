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
    public partial class XoaNVForm : Form
    {
        public XoaNVForm()
        {
            InitializeComponent();
        }

        private void buttonXoaNV_Click(object sender, EventArgs e)
        {
            NHANVIEN nv = new NHANVIEN();
            if(textBoxXoaNV.Text.Trim()=="")
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                decimal check;
                if (decimal.TryParse(textBoxXoaNV.Text, out check) == false)
                {
                    MessageBox.Show("nhập đúng định dạng mã số nhân viên", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    int manv = Convert.ToInt32(textBoxXoaNV.Text);
                    if(nv.XoaNV(manv))
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Kiểm tra lại mã nhân viên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }    
                }    
            }    
        }
    }
}
