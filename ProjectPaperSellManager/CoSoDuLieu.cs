using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProjectPaperSellManager
{

    public class CoSoDuLieu
    {
        string strConn;
        SqlConnection conn;
        SqlDataAdapter da;
        public CoSoDuLieu(string strConn)
        {
            this.strConn = strConn;
        }
        public DataTable DocDuLieu(string strSql)
        {
            conn = new SqlConnection(strConn);
            da = new SqlDataAdapter(strSql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Dispose();
            return dt;
        }
        public void CapNhatDuLieu(DataTable dt, string strSql)
        {
            conn = new SqlConnection(strConn);
            da = new SqlDataAdapter(strSql, conn);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Update(dt);
            conn.Dispose();
        }
    }
}
