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
    
    class NHANVIEN
    {
        MY_DB mydb = new MY_DB();
        public bool themNV(int msnv, string hoten, string gioitinh, DateTime namsinh, string diachi, MemoryStream hinh, string username, string password)
        {
            SqlCommand command = new SqlCommand("INSERT INTO NHANVIEN (msnv,hoten,gioitinh,namsinh,diachi,hinh,username,password)" + "VALUES (@msnv, @ht, @gt, @ns, @dc, @hinh, @user, @pass)", mydb.getConnection);
            command.Parameters.Add("@msnv", SqlDbType.Int).Value = msnv;
            command.Parameters.Add("@ht", SqlDbType.NVarChar).Value = hoten;
            command.Parameters.Add("@gt", SqlDbType.NVarChar).Value = gioitinh;
            command.Parameters.Add("@ns", SqlDbType.DateTime).Value = namsinh;
            command.Parameters.Add("@dc", SqlDbType.NVarChar).Value = diachi;
            command.Parameters.Add("@hinh", SqlDbType.Image).Value = hinh.ToArray();
            command.Parameters.Add("@user", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = password;
           

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
        public bool checkID(int msnv)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM NHANVIEN WHERE msnv=" + msnv, mydb.getConnection);
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

        public DataTable layNV(SqlCommand command)
        {

            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }
        public bool XoaNV(int msnv)
        {

            SqlCommand command = new SqlCommand("DELETE FROM NHANVIEN where msnv="+msnv, mydb.getConnection);
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
        public bool suaNV(int msnv, string hoten, string gioitinh, DateTime namsinh, string diachi, MemoryStream hinh, string username, string password)
        {

            SqlCommand command = new SqlCommand("UPDATE NHANVIEN SET hoten=@ht,gioitinh=@gt,namsinh=@ns,diachi=@dc,hinh=@hinh,username=@user,password=@pass WHERE msnv=@msnv", mydb.getConnection);
            command.Parameters.Add("@msnv", SqlDbType.Int).Value = msnv;
            command.Parameters.Add("@ht", SqlDbType.NVarChar).Value = hoten;
            command.Parameters.Add("@gt", SqlDbType.NVarChar).Value = gioitinh;
            command.Parameters.Add("@ns", SqlDbType.DateTime).Value = namsinh;
            command.Parameters.Add("@dc", SqlDbType.NVarChar).Value = diachi;
            command.Parameters.Add("@hinh", SqlDbType.Image).Value = hinh.ToArray();
            command.Parameters.Add("@user", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = password;

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
       
    }
}
