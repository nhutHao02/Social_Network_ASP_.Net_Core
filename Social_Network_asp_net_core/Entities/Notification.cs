using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Social_Network_asp_net_core.Entities
{
    [Table("notification")]
    public class Notification
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long idNotification { get; set; }
        public long idUser { get; set; }
        public string content { get; set; }
        public long idSender { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [DefaultValue("CURRENT_TIMESTAMP")]
        public DateTime timestamp { get; set; }

        // relationships
        public User user { get; set; }

    }
}
