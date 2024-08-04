using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BanHangOnline.Models.EF
{
    [Table("tb_SystemSetting")]
    public class SystemSetting
    {
        [Key]
        [StringLength(50)]
        public string StringKey { get; set; }
        [StringLength(4000)]
        public string StringValue { get; set; }
        [StringLength(4000)]
        public string SettingDescription { get; set; }

    }
}