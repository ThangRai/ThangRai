using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quản_lý_bán_hàng
{
    class KHACHHANG
    {
        MY_DB mydb = new MY_DB();
        public bool themKH(int mskh, string hoten, string gioitinh, DateTime namsinh, string diachi, string sdt, string username, string password)
        {
            SqlCommand command = new SqlCommand("INSERT INTO KHACHHANG (mskh, hoten, gioitinh, namsinh, diachi, sdt, username, password)" + "VALUES (@mskh, @ht, @gt, @ns, @dc, @sdt, @user, @pass)", mydb.getConnection);
            command.Parameters.Add("@mskh", SqlDbType.Int).Value = mskh;
            command.Parameters.Add("@ht", SqlDbType.NVarChar).Value = hoten;
            command.Parameters.Add("@gt", SqlDbType.NVarChar).Value = gioitinh;
            command.Parameters.Add("@ns", SqlDbType.DateTime).Value = namsinh;
            command.Parameters.Add("@dc", SqlDbType.NVarChar).Value = diachi;
            command.Parameters.Add("@sdt", SqlDbType.VarChar).Value = sdt;
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
        public bool checkID(int id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM KHACHHANG WHERE mskh=" + id, mydb.getConnection);
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
        public DataTable layKH(SqlCommand command)
        {

            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }
        public bool XoaKH(int mskh)
        {

            SqlCommand command = new SqlCommand("DELETE FROM KHACHHANG where mskh=" + mskh, mydb.getConnection);
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
        public bool capnhatKH_chua_user_pass(int mskh, string hoten, string gioitinh, DateTime namsinh, string diachi, string sdt)
        {

            SqlCommand command = new SqlCommand("UPDATE KHACHHANG SET hoten=@ht,gioitinh=@gt,namsinh=@ns,diachi=@dc,sdt=@sdt WHERE mskh=@mskh", mydb.getConnection);
            command.Parameters.Add("@mskh", SqlDbType.Int).Value = mskh;
            command.Parameters.Add("@ht", SqlDbType.NVarChar).Value = hoten;
            command.Parameters.Add("@gt", SqlDbType.NVarChar).Value = gioitinh;
            command.Parameters.Add("@ns", SqlDbType.DateTime).Value = namsinh;
            command.Parameters.Add("@dc", SqlDbType.NVarChar).Value = diachi;
            command.Parameters.Add("@sdt", SqlDbType.VarChar).Value = sdt;

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
        public bool update_user_pass(int mskh, string username, string password)
        {
            SqlCommand command = new SqlCommand("UPDATE KHACHHANG SET username=@user,password=@pass WHERE mskh=@mskh", mydb.getConnection);
            command.Parameters.Add("@mskh", SqlDbType.Int).Value = mskh;
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
