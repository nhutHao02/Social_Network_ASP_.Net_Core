using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Social_Network_asp_net_core.Entities
{
    public enum MessType
    {
        message = 0,
        image = 1,
        audio = 2
    }
    [Table("message")]
    public class Message
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long id_mes { get; set; }
        [Required]
        public long idSender { get; set; }
        [Required]
        public long idReciver { get; set; }
        public string? content { get; set; }
        public MessType messType { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [DefaultValue("CURRENT_TIMESTAMP")]
        public DateTime timestamp { get; set; }
    }
}
