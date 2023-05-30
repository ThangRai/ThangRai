using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quản_lý_bán_hàng
{
    
    class CHAMCONG
    {
        MY_DB mydb = new MY_DB();
        public bool insertGioVao(int msnv,DateTime giovao)
        {

            SqlCommand command = new SqlCommand("INSERT INTO CHAMCONG (msnv,giovao)" + "VALUES (@msnv,@gv)", mydb.getConnection);
            command.Parameters.Add("@msnv", SqlDbType.Int).Value = msnv;
            
            command.Parameters.Add("@gv", SqlDbType.DateTime).Value = giovao;
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
        public DataTable laydanhsach(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }
        public bool insertGioRa(int msnv, string hoten,DateTime giora,DateTime giovao,int sogio)
        {

            SqlCommand command = new SqlCommand("UPDATE CHAMCONG SET hoten=@ht,giora=@gr,sogio=@sg WHERE giovao=@gv AND msnv=@msnv", mydb.getConnection);
            command.Parameters.Add("@msnv", SqlDbType.Int).Value = msnv;
            command.Parameters.Add("@gr", SqlDbType.DateTime).Value = giora;
            command.Parameters.Add("@gv", SqlDbType.DateTime).Value = giovao;
            command.Parameters.Add("@ht", SqlDbType.NVarChar).Value = hoten;
            command.Parameters.Add("@sg", SqlDbType.Int).Value = sogio;
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
