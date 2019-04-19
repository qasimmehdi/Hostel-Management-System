using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace HostelManagement
{
     public class Connection
    {
        public static SqlConnection ab;

        public static SqlConnection get()
        {
            if (ab == null)
            {
                ab = new SqlConnection();
                ab.ConnectionString = "Data Source=COMPRO-PC\\SQLEXPRESS12; Initial Catalog=HostelManagement; Integrated Security=SSPI;";
                ab.Open();

            }
            return ab;
        }
    }
}