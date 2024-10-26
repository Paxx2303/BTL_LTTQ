using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BTL
{
	internal class Connection
	{
		private  static string stringConnection = @"Data Source=DESKTOP-DQCNCI9\KHOADD;Initial Catalog=QLTuyenSinh;Integrated Security=True";
		public static SqlConnection GetSqlConnection()
		{
			return new SqlConnection(stringConnection);
		}
	}
}
