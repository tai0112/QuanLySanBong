using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Modify
    {
        Connection cn = new Connection();
        public Modify() { }
        public DataTable GetData(string query)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = cn.GetConnection();
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query,conn);
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }
    }
}
