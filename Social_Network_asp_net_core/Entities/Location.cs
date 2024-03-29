using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Social_Network_asp_net_core.Entities
{
    [Table("location")]
    public class Location
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long idLocation { get; set; }
        public long idUser { get; set; }
        public string city { get; set; }
        public string district { get; set; }
        public string ward { get; set; }
        public string description { get; set; }

        // relationships
        public User user { get; set; }

    }
}
