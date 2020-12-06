using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITEnterprDataBase
{
    class DBConnection
    {
        public void DBconn()
        {
            var conn = new SqlConnection();
            conn.ConnectionString =
                  "Data Source=legko.database.windows.net;" +
                  "Initial Catalog=LegkoDB;" +
                  "User id=legko;" +
                  "Password=mzipf2005!;";
            conn.Open();
        }
    }
}
