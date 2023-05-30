using DocumentFormat.OpenXml.Drawing.ChartDrawing;
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
    class MATHANG
    {
        MY_DB mydb = new MY_DB();
        public bool themhang(int mahang,string loaihang, string tenhang,MemoryStream hinh,double gia,int soluong)
        {
            SqlCommand command = new SqlCommand("INSERT INTO HANGHOA (mahang,loaihang,tenhang,hinh,gia,soluong)" + "VALUES (@mh,@lh,@th,@hinh,@gia,@sl)", mydb.getConnection);
            command.Parameters.Add("@mh", SqlDbType.Int).Value = mahang;
             command.Parameters.Add("@lh", SqlDbType.NVarChar).Value = loaihang;
             command.Parameters.Add("@th", SqlDbType.NVarChar).Value = tenhang;
            command.Parameters.Add("@hinh", SqlDbType.Image).Value = hinh.ToArray();
            command.Parameters.Add("@gia", SqlDbType.Float).Value = gia;
             command.Parameters.Add("@sl", SqlDbType.Int).Value = soluong;
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
        public bool checkID(int id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM HANGHOA WHERE mahang=" + id, mydb.getConnection);
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
            SqlCommand command = new SqlCommand("SELECT * FROM HANGHOA WHERE tenhang=@th", mydb.getConnection);
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
        public bool Xoahang(int id )
        { 
            SqlCommand command = new SqlCommand("DELETE FROM HANGHOA where mahang=" + id, mydb.getConnection);
            mydb.openConnection();

            if ((command.ExecuteNonQuery() == 1))
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
        public bool updateHang(int mahang, string loaihang, string tenhang, MemoryStream hinh, double gia, int soluong)
        {

            SqlCommand command = new SqlCommand("UPDATE HANGHOA SET loaihang=@lh,tenhang=@th,hinh=@hinh,gia=@gia,soluong=@sl WHERE mahang=@mh", mydb.getConnection);
            command.Parameters.Add("@mh", SqlDbType.Int).Value = mahang;
            command.Parameters.Add("@lh", SqlDbType.NVarChar).Value = loaihang;
            command.Parameters.Add("@th", SqlDbType.NVarChar).Value = tenhang;
            command.Parameters.Add("@hinh", SqlDbType.Image).Value = hinh.ToArray();
            command.Parameters.Add("@gia", SqlDbType.Float).Value = gia;
            command.Parameters.Add("@sl", SqlDbType.Int).Value = soluong;

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
        public Int32 totalCourse()
        {
            Int32 count = 0;
            SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM courses", mydb.getConnection);
            mydb.openConnection();
            count = (Int32)command.ExecuteScalar();
            mydb.closeConnection();
            return count;
        }
        public String TenCourse()
        {
            string count = "";
            SqlCommand command = new SqlCommand("SELECT lable FROM courses", mydb.getConnection);
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
        public string tongmathang()
        {
            string count = "";
            SqlCommand command = new SqlCommand("SELECT COUNT(tenhang) FROM dbo.HANGHOA", mydb.getConnection);
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
        public bool themmagiamgia(int mahang, string magiamgia)
        {
            SqlCommand command = new SqlCommand("UPDATE HANGHOA SET magiamgia=@mgg WHERE mahang=@mh", mydb.getConnection);
            command.Parameters.Add("@mh", SqlDbType.Int).Value = mahang;
            command.Parameters.Add("@mgg", SqlDbType.NVarChar).Value = magiamgia;
            
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
    }
}
