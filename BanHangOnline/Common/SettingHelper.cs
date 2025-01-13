using BanHangOnline.Models;
using System.Linq;

namespace BanHangOnline.Common
{
    public class SettingHelper
    {
        private static ApplicationDbContext db = new ApplicationDbContext();

        public static string GetValue(string key)
        {
            var item = db.SystemSettings.SingleOrDefault(x => x.StringKey == key);
            if (item != null)
            {
                return item.StringValue;
            }
            return "";
        }
    }
}