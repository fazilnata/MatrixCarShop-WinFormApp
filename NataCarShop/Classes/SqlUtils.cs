using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;

namespace NataCarShop.Classes
{
    class SqlUtils
    {
        private static SqlUtils sqlUtils;
        public string conString { get; set; }
        private SqlUtils()
        {
            conString = ConfigurationManager.ConnectionStrings["MainConString"].ConnectionString;
        }
        public static SqlUtils getInstance()
        {
            if (sqlUtils == null)
            {
                sqlUtils = new SqlUtils();
            }
            return sqlUtils;
        }

        public DataTable GetDataWithAdapter(string query)
        {
            SqlConnection sqlConnection = new SqlConnection(conString);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
            DataTable dtTable = new DataTable();
            sqlDataAdapter.Fill(dtTable);
            return dtTable;
        }


       
    }
}
