using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Social_Network_asp_net_core.Entities
{
    [Table("comment")]
    public class Comment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long idComment { get; set; }
        public long idTweet { get; set; }
        public string description { get; set; }
        public long idCommenter { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [DefaultValue("CURRENT_TIMESTAMP")]
        public DateTime timestamp { get; set; }

        // relationships
        public Tweet tweet { get; set; }
    }
}
