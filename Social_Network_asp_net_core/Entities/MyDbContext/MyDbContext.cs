using Microsoft.EntityFrameworkCore;

namespace Social_Network_asp_net_core.Entities.MyDbContext
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options)
        {
        }
        #region DbSet
        public DbSet<Message> Messages { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<RecentMessage> RecentMessages { get; set; }
        public DbSet<Tweet> Tweets { get; set; }
        public DbSet<TweetSaved> TweetSaveds { get; set; }
        public DbSet<Love> Loves { get; set; }
        public DbSet<Comment> Comments { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // realtionship between Location with User
            modelBuilder.Entity<Location>()
                .HasOne(e => e.user)
                .WithOne(e => e.location)
                .HasForeignKey<Location>(e => e.idUser)
                .OnDelete(DeleteBehavior.Cascade);

            // relationship between Notification with User
            modelBuilder.Entity<Notification>()
                .HasOne<User>(e => e.user)
                .WithMany(e => e.notifications)
                .HasForeignKey(e => e.idUser)
                .OnDelete(DeleteBehavior.Cascade);

            // relationship between User with RecentMessage
            modelBuilder.Entity<RecentMessage>()
                .HasOne<User>(e => e.user)
                .WithMany(e => e.recentMessages)
                .HasForeignKey(e => e.idUser)
                .OnDelete(DeleteBehavior.Cascade);

            // relationship between User with Tweet
            modelBuilder.Entity<Tweet>()
                .HasOne<User>(e => e.user)
                .WithMany(e => e.tweets)
                .HasForeignKey(e => e.idUser)
                .OnDelete(DeleteBehavior.Cascade);

            // relationships  TweetSaved with Tweet and User
            modelBuilder.Entity<TweetSaved>(entity =>
            {
                entity.HasOne<User>(e => e.user)
                .WithMany(e => e.tweetSaveds)
                .HasForeignKey(e => e.idUser)
                .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne<Tweet>(e => e.tweet)
                .WithMany(e => e.tweetSaveds)
                .HasForeignKey(e => e.idTweet)
                .OnDelete(DeleteBehavior.Cascade);

            });
            // relationship between Love and Tweet
            modelBuilder.Entity<Love>()
                .HasOne<Tweet>(e => e.tweet)
                .WithMany(e => e.loves)
                .HasForeignKey(e => e.idTweet)
                .OnDelete(DeleteBehavior.Cascade);

            // relationship between Comment and Tweet
            modelBuilder.Entity<Comment>()
                .HasOne<Tweet>(e => e.tweet)
                .WithMany(e => e.comments)
                .HasForeignKey(e => e.idTweet)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
