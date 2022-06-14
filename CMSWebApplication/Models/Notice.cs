using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CMSWebApplication.Models
{
    public class Notice
    {
        [DisplayName("ID")]
        public int ID { get; set; }
        [DisplayName("标题")]
        [Required]
        public string Title { get; set; } = string.Empty;
        [DisplayName("摘要")]
        [Required]
        public string Absract { get; set; } = string.Empty;
        [DisplayName("内容")]
        [Required]
        public string HtmlText { get; set; } = string.Empty;

        [DisplayName("重要性")]
        public Importance Importance { get; set; } = Importance.Medium;

        [DisplayName("创建日期")]
        public DateTime CreatedOn { get; set; }

        [DisplayName("更新日期")]
        public DateTime UpdatedOn { get; set; }

        [DisplayName("过期日期")]
        public DateTime ExpiredOn { get; set; }

        [DisplayName("是否展示")]
        public bool Display { get; set; } = false;
    }

    public enum Importance
    {
        Low,
        Medium,
        High,
        VeryHigh
    }
}
