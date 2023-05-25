using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class Connection
    {
        public static SqlConnection conn = new SqlConnection(@"Data Source=BARIS\SQLEXPRESS;Initial Catalog=DBHospitalAutomatisation;Integrated Security=True");
    }
}
