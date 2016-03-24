using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateIdentify
{
    public class IdetifyBLL
    {
        public void InsertData(List<Identify_Model> list)
        {
            string sql=SpellSQL(list);
            int count = DAL.ExecuteNonQuery(sql);
        }
        string SpellSQL(List<Identify_Model> list)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Identify_Model item in list)
            {
                sb.AppendLine("insert into ID (Identify) values ('" + item.Identify + "')");
            }
            return sb.ToString();
        }
    }
}
