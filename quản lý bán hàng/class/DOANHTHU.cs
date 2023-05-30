using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quản_lý_bán_hàng
{
    class DOANHTHU
    {
        MY_DB mydb = new MY_DB();
        public bool addDoanhthu(double tien,DateTime ngay)
        {
            SqlCommand command = new SqlCommand("INSERT INTO DOANHTHU (tien,ngay)" + "VALUES (@tien,@ngay)", mydb.getConnection);
            command.Parameters.Add("@tien", SqlDbType.Float).Value = tien;
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
        public DataTable layDoanhThu(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }
        public Int32 doanhthutungthang()
        {
            Int32 count = 0;
            SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM std", mydb.getConnection);
            mydb.openConnection();
            count = (Int32)command.ExecuteScalar();
            mydb.closeConnection();
            return count;
        }
    }
}
