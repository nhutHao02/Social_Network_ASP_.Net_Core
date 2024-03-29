using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Social_Network_asp_net_core.Entities
{
    [Table("tweet")]
    public class Tweet
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long idTweet { get; set; }
        public long idUser { get; set; }
        public string? content { get; set; }
        public string? urlImage { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [DefaultValue("CURRENT_TIMESTAMP")]
        public DateTime timestamp { get; set; }

        // relatrionships
        public User user { get; set; }
        public ICollection<TweetSaved> tweetSaveds { get; set; }
        public ICollection<Love> loves { get; set; }
        public ICollection<Comment> comments { get; set; }

        public Tweet()
        {
            tweetSaveds = new List<TweetSaved>();
            loves = new List<Love>();
            comments = new List<Comment>();
        }
    }
}
