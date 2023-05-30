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
    public partial class ChonGioHang : Form
    {
        public int magh;
        MUAHANG muahang = new MUAHANG();
        MY_DB mydb = new MY_DB();
        
        public ChonGioHang()
        {
            InitializeComponent();
        }
        public ChonGioHang(int magh)
        {
            InitializeComponent();
            this.magh = magh;
        }
       
        private void pictureBoxGH1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
        void formload_hinh(int magh,PictureBox pic)
        {
            int count = 0;
            SqlCommand command2 = new SqlCommand("SELECT * FROM dbo.GIOHANG WHERE magiohang="+magh, mydb.getConnection);
            mydb.openConnection();
            SqlDataReader reader = command2.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    count++;
                }
                
            }
            reader.Close();
            //count = (Int32)command.ExecuteScalar();
            mydb.closeConnection();
            if (count > 0)
            {
                pic.Image = Properties.Resources._192538898_870335780587167_3162353575899320839_n;
            }
        }
        private void pictureBoxGH1_Click(object sender, EventArgs e)
        {
           DialogResult result=MessageBox.Show("Bạn chọn giỏ hàng này phải không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
           if(result==DialogResult.Yes)
            {
                magh = 1;
                if (muahang.kiemtragiohang(magh) == false)
                {
                    MessageBox.Show("Giỏ hàng này đang có người chọn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    this.Hide();
                    KHForm khform = new KHForm(magh);
                    khform.ShowDialog();
                    this.Close();
                }
            }    
        }

        private void pictureBoxGH2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chọn giỏ hàng này phải không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                magh = 2;
                if (muahang.kiemtragiohang(magh) == false)
                {
                    MessageBox.Show("Giỏ hàng này đang có người chọn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    this.Hide();
                    KHForm khform = new KHForm(magh);
                    khform.ShowDialog();
                    this.Close();
                }
            }
        }

        private void pictureBoxGH3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chọn giỏ hàng này phải không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                magh = 3;
                if (muahang.kiemtragiohang(magh) == false)
                {
                    MessageBox.Show("Giỏ hàng này đang có người chọn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    this.Hide();
                    KHForm khform = new KHForm(magh);
                    khform.ShowDialog();
                    this.Close();
                }
            }
        }

        private void pictureBoxGH4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chọn giỏ hàng này phải không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                magh = 4;
                if (muahang.kiemtragiohang(magh) == false)
                {
                    MessageBox.Show("Giỏ hàng này đang có người chọn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    this.Hide();
                    KHForm khform = new KHForm(magh);
                    khform.ShowDialog();
                    this.Close();
                }
            }
        }

        private void pictureBoxGH5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chọn giỏ hàng này phải không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                magh = 5;
                if (muahang.kiemtragiohang(magh) == false)
                {
                    MessageBox.Show("Giỏ hàng này đang có người chọn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    this.Hide();
                    KHForm khform = new KHForm(magh);
                    khform.ShowDialog();
                    this.Close();
                }
            }
        }

        private void pictureBoxGH6_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chọn giỏ hàng này phải không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                magh = 6;
                if (muahang.kiemtragiohang(magh) == false)
                {
                    MessageBox.Show("Giỏ hàng này đang có người chọn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    this.Hide();
                    KHForm khform = new KHForm(magh);
                    khform.ShowDialog();
                    this.Close();
                }
            }
        }

        private void pictureBoxGH7_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chọn giỏ hàng này phải không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                magh = 7;
                if (muahang.kiemtragiohang(magh) == false)
                {
                    MessageBox.Show("Giỏ hàng này đang có người chọn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    this.Hide();
                    KHForm khform = new KHForm(magh);
                    khform.ShowDialog();
                    this.Close();
                }
            }
        }

        private void pictureBoxGH8_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chọn giỏ hàng này phải không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                magh = 8;
                if (muahang.kiemtragiohang(magh) == false)
                {
                    MessageBox.Show("Giỏ hàng này đang có người chọn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    this.Hide();
                    KHForm khform = new KHForm(magh);
                    khform.ShowDialog();
                    this.Close();
                }
            }
        }

        private void pictureBoxGH9_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chọn giỏ hàng này phải không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                magh = 9;
                if (muahang.kiemtragiohang(magh) == false)
                {
                    MessageBox.Show("Giỏ hàng này đang có người chọn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    this.Hide();
                    KHForm khform = new KHForm(magh);
                    khform.ShowDialog();
                    this.Close();
                }
            }
        }

        private void ChonGioHang_Load(object sender, EventArgs e)
        {
            formload_hinh(1, pictureBoxGH1);
            formload_hinh(2, pictureBoxGH2);
            formload_hinh(3, pictureBoxGH3);
            formload_hinh(4, pictureBoxGH4);
            formload_hinh(5, pictureBoxGH5);
            formload_hinh(6, pictureBoxGH6);
            formload_hinh(7, pictureBoxGH7);
            formload_hinh(8, pictureBoxGH8);
            formload_hinh(9, pictureBoxGH9);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
