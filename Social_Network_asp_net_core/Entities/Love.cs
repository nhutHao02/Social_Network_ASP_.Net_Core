using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Social_Network_asp_net_core.Entities
{
    [Table("love")]
    public class Love
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long idLove { get; set; }
        public long idTweet { get; set; }
        public long idLover { get; set; }

        //relationships
        public Tweet tweet { get; set; }

    }
}
