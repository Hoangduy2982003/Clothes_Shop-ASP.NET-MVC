using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace BanHangOnline.Models.EF
{
    [Table("tb_Post")]

    public class Posts : CommonAbstract
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(150)]
        public string Title { get; set; }
        [StringLength(150)]
        public string Alias { get; set; }
        public string Description { get; set; }
        [AllowHtml]
        public string Detail { get; set; }
        [StringLength(250)]
        public string Image { get; set; }
        public int CategoryId { get; set; }
        [StringLength(150)]
        public string SeoTitle { get; set; }
        [StringLength(500)]
        public string SeoDescription { get; set; }
        [StringLength(250)]
        public string SeoKeyword { get; set; }
        public bool IsActive { get; set; }

        public Category Category { get; set; }
    }
}