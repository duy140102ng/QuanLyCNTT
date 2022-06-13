using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class Lop_DAL
    {
        public SqlConnection getConnect()
        {
            return new SqlConnection(@"Data Source=LAPTOP-3EGD2A3H\SQLEXPRESS;Initial Catalog=QLKhoaCNTT;Integrated Security=True");
        }
        //lệnh sql trả về 1 bảng
        public DataTable GetTable(string sql)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = getConnect();
            conn.Open();
            SqlDataAdapter ad = new SqlDataAdapter(sql, conn);
            ad.Fill(dt);
            return dt;
        }
        public void ExcuteNonQuery(string sql)
        {
            SqlConnection conn = getConnect();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }
    }
}
