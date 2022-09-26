using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class dalbaglanti
    {
        public static SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-FLQRUHO;Initial Catalog=nkatmanlihastane;Integrated Security=True");
    }
}
