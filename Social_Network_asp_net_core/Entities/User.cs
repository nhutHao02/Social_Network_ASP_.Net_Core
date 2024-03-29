using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Social_Network_asp_net_core.Entities
{
    public enum Sex
    {
        Male = 0
            , Female = 1,
    }
    [Table("user")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long idUser { get; set; }
        public string userName { get; set; }
        public string pass { get; set; }
        public string? fullName { get; set; }
        public string? email { get; set; }
        public Sex sex { get; set; }
        public string? urlAvt { get; set; }
        public string? urlBackground { get; set; }

        // relationships
        public Location location { get; set; }
        public ICollection<Notification> notifications { get; set; }
        public ICollection<RecentMessage> recentMessages { get; set; }
        public ICollection<Tweet> tweets { get; set; }
        public ICollection<TweetSaved> tweetSaveds { get; set; }


        public User()
        {
            notifications = new List<Notification>();
            recentMessages = new List<RecentMessage>();
            tweets = new List<Tweet>();
            tweetSaveds = new List<TweetSaved>();
        }
    }
}
