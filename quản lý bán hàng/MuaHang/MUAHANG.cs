using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quản_lý_bán_hàng
{

    class MUAHANG
    {
        MY_DB mydb = new MY_DB();
        public bool themhangvaogio(int magiohang,int mahang, string tenhang,int soluong,double gia,int mskh)
        {
            SqlCommand command = new SqlCommand("INSERT INTO GIOHANG (magiohang,mahang,tenhang,soluong,gia,mskh)" + "VALUES (@mgh,@mh,@th,@sl,@gia,@mskh)", mydb.getConnection);
            command.Parameters.Add("@mgh", SqlDbType.Int).Value = magiohang;
            command.Parameters.Add("@mh", SqlDbType.Int).Value = mahang;
            command.Parameters.Add("@th", SqlDbType.NVarChar).Value = tenhang;
            command.Parameters.Add("@gia", SqlDbType.Float).Value = gia;
            command.Parameters.Add("@sl", SqlDbType.Int).Value = soluong;
            command.Parameters.Add("@mskh", SqlDbType.Int).Value = mskh;
            mydb.openConnection();
            //()
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
        public bool lichsugiohang(int magiohang, int mahang, string tenhang, int soluong, double gia, int mskh,DateTime ngay)
        {
            SqlCommand command = new SqlCommand("INSERT INTO LICHSU_GIOHANG (magiohang,mahang,tenhang,soluong,gia,mskh,ngay)" + "VALUES (@mgh,@mh,@th,@sl,@gia,@mskh,@ngay)", mydb.getConnection);
            command.Parameters.Add("@mgh", SqlDbType.Int).Value = magiohang;
            command.Parameters.Add("@mh", SqlDbType.Int).Value = mahang;
            command.Parameters.Add("@th", SqlDbType.NVarChar).Value = tenhang;
            command.Parameters.Add("@gia", SqlDbType.Float).Value = gia;
            command.Parameters.Add("@sl", SqlDbType.Int).Value = soluong;
            command.Parameters.Add("@mskh", SqlDbType.Int).Value = mskh;
            command.Parameters.Add("@ngay", SqlDbType.DateTime).Value = ngay;
            mydb.openConnection();
            //()
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
        public DataTable layHangHoa(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }
        public bool checkten(string tenhang)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM GIOHANG WHERE tenhang=@th", mydb.getConnection);
            command.Parameters.Add("@th", SqlDbType.VarChar).Value = tenhang;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                //neu phat hien cos 1 dong ton tai trung ten
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool checkID(int id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM GIOHANG WHERE mahang=" + id, mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            if ((table.Rows.Count == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Xoahang(int stt,int mahang,int magiohang)
        {
            SqlCommand command = new SqlCommand("DELETE FROM GIOHANG where mahang=" + mahang+"AND magiohang="+magiohang +"AND stt="+stt, mydb.getConnection);
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
        public bool kiemtragiohang(int magiohang)
        {

            SqlCommand command = new SqlCommand("SELECT * FROM GIOHANG WHERE magiohang=" + magiohang, mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            if ((table.Rows.Count == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool updateHang(int magiohang, int mahang, string tenhang, int soluong, double gia, int mskh)
        {

            SqlCommand command = new SqlCommand("UPDATE GIOHANG SET mahang=@mh,tenhang=@th,soluong=@sl,gia=@gia,msnv=@msnv,mskh=@mskh WHERE magiohang=@mgh", mydb.getConnection);
            command.Parameters.Add("@mgh", SqlDbType.Int).Value = magiohang;
            command.Parameters.Add("@mh", SqlDbType.Int).Value = mahang;
            command.Parameters.Add("@th", SqlDbType.NVarChar).Value = tenhang;
            command.Parameters.Add("@gia", SqlDbType.Float).Value = gia;
            command.Parameters.Add("@sl", SqlDbType.Int).Value = soluong;
            command.Parameters.Add("@mskh", SqlDbType.Int).Value = mskh;

            mydb.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }


        }
        public string tongtien(int mskh)
        {
            string count = "";
            SqlCommand command = new SqlCommand("SELECT SUM(gia) FROM dbo.GIOHANG WHERE mskh="+mskh, mydb.getConnection);
            mydb.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    count = reader[0].ToString();
                }
            }
            reader.Close();
            //count = (Int32)command.ExecuteScalar();
            mydb.closeConnection();
            return count;
        }
    }
}
