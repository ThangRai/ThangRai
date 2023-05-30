using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quản_lý_bán_hàng
{
    class THANHTOAN
    {
        MY_DB mydb = new MY_DB();
        public bool thanhtoan(int mahoadon,int msnv,DateTime ngaythanhtoan,double tongtien)
        {
            SqlCommand command = new SqlCommand("INSERT INTO THANHTOAN (mahoadon,msnv,ngaythanhtoan,tongtien)" + "VALUES (@mhd,@msnv,@ntt,@tt)", mydb.getConnection);
            command.Parameters.Add("@mhd", SqlDbType.Int).Value = mahoadon;
            command.Parameters.Add("@msnv", SqlDbType.Int).Value = msnv;
            command.Parameters.Add("@ntt", SqlDbType.DateTime).Value = ngaythanhtoan;
            command.Parameters.Add("@tt", SqlDbType.Int).Value = tongtien;
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == -1))
            {
                mydb.closeConnection();
                return false;
            }
            else
            {
                mydb.closeConnection();
                return true;
            }
          
        }
        public bool updatetrangthai(int mahoadon, int mskh)
        {
            SqlCommand command = new SqlCommand("UPDATE HOADON SET trangthai=1 WHERE mahoadon=@mhd AND mskh=@mskh", mydb.getConnection);
            command.Parameters.Add("@mhd", SqlDbType.Int).Value = mahoadon;
            command.Parameters.Add("@mskh", SqlDbType.Int).Value = mskh;
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == -1))
            {
                mydb.closeConnection();
                return false;
            }
            else
            {
                mydb.closeConnection();
                return true;
            }

        }
        public bool kiguihoadon(int mahoadon, int mskh)
        {
            SqlCommand command = new SqlCommand("UPDATE HOADON SET trangthai=2 WHERE mahoadon=@mhd AND mskh=@mskh", mydb.getConnection);
            command.Parameters.Add("@mhd", SqlDbType.Int).Value = mahoadon;
            command.Parameters.Add("@mskh", SqlDbType.Int).Value = mskh;
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == -1))
            {
                mydb.closeConnection();
                return false;
            }
            else
            {
                mydb.closeConnection();
                return true;
            }

        }
        public bool mokiguihoadon(int mahoadon, int mskh)
        {
            SqlCommand command = new SqlCommand("UPDATE HOADON SET trangthai=0 WHERE mahoadon=@mhd AND mskh=@mskh", mydb.getConnection);
            command.Parameters.Add("@mhd", SqlDbType.Int).Value = mahoadon;
            command.Parameters.Add("@mskh", SqlDbType.Int).Value = mskh;
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == -1))
            {
                mydb.closeConnection();
                return false;
            }
            else
            {
                mydb.closeConnection();
                return true;
            }

        }
        public bool xoahethangtronggio(int magiohang, int mskh)
        {
            SqlCommand command = new SqlCommand("DELETE FROM dbo.GIOHANG WHERE magiohang="+magiohang+ "AND mskh="+mskh, mydb.getConnection);
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == -1))
            {
                mydb.closeConnection();
                return false;
            }
            else
            {
                mydb.closeConnection();
                return true;
            }

        }
        public bool trangthaithanhtoan(int magiohang, int mskh)
        {
            SqlCommand command = new SqlCommand("UPDATE GIOHANG SET thanhtoan=1 WHERE magiohang=@mgh AND mskh=@mskh", mydb.getConnection);
            command.Parameters.Add("@mgh", SqlDbType.Int).Value = magiohang;
            command.Parameters.Add("@mskh", SqlDbType.Int).Value = mskh;
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == -1))
            {
                mydb.closeConnection();
                return false;
            }
            else
            {
                mydb.closeConnection();
                return true;
            }

        }

    }
}
