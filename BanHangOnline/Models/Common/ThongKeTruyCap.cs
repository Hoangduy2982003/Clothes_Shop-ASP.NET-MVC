using Dapper;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BanHangOnline.Models.Common
{
    public class ThongKeTruyCap
    {
        private static string strConnection = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
        public static ThongKeViewModel ThongKe()
        {
            using (var connect = new SqlConnection(strConnection))
            {
                var item = connect.QueryFirstOrDefault<ThongKeViewModel>("sp_ThongKe", commandType: CommandType.StoredProcedure);
                return item;
            };
        }
    }
}