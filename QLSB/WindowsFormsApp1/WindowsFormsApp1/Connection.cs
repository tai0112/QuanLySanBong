using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Connection
    {
        string strConn = @"Data Source=DESKTOP-0UQBJGA;Initial Catalog=qlsbmn;Integrated Security=True";
        public SqlConnection GetConnection()
        {
            return new SqlConnection(strConn);
        }
    }
}
