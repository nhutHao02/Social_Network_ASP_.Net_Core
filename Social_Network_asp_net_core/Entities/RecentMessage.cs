using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Social_Network_asp_net_core.Entities
{
    [Table("recentMessage")]
    public class RecentMessage
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long idRecentMess { get; set; }
        public long idUser { get; set; }
        public long withId { get; set; }
        public string? content { get; set; }
        public long idSender { get; set; }
        public MessType messType { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [DefaultValue("CURRENT_TIMESTAMP")]
        public DateTime timestamp { get; set; }

        //relationships
        public User user { get; set; }
    }
}
