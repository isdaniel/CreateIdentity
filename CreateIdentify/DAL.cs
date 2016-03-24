using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;
using System.Data.SqlClient;
namespace CreateIdentify
{
    public class DAL
    {
        private static readonly string sqlconn = WebConfigurationManager.AppSettings["conn"];
        public static DataTable GetDataTable(string sql,params SqlParameter[] para){
            using (SqlConnection conn = new SqlConnection(sqlconn))
            { 
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql,conn))
                {
                    DataTable dt = new DataTable();
                    cmd.Parameters.AddRange(para);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
            }
        }
        public static int ExecuteNonQuery(string sql, params SqlParameter[] para)
        {
            using (SqlConnection conn = new SqlConnection(sqlconn))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                   int count= cmd.ExecuteNonQuery();
                   return count;
                }
            }
        }
    }
}
