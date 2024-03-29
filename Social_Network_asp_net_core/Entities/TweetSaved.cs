using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Social_Network_asp_net_core.Entities
{
    [Table("TweetSaved")]
    public class TweetSaved
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long idTSaved { get; set; }
        public long idUser { get; set; }
        public long idTweet { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [DefaultValue("CURRENT_TIMESTAMP")]
        public DateTime timestamp { get; set; }

        // relationships
        public User user { get; set; }
        public Tweet tweet { get; set; }
    }
}
