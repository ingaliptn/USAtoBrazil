using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Domain.Repositories.Concrete
{
    public class EfDbContext : DbContext
    {
        public EfDbContext(DbContextOptions<EfDbContext> options)
            : base(options)
        {
        }

        public DbSet<Group> Groups { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserLogin> UserLogins { get; set; }
        public DbSet<TwilioAccount?> TwilioAccounts { get; set; }
        public DbSet<TwilioPhone> TwilioPhones { get; set; }
        public DbSet<Statistic> Statistics { get; set; }
        public DbSet<TwilioMessage> TwilioMessages { get; set; }
        public DbSet<TwilioCall> TwilioCalls { get; set; }
        public DbSet<Promoter> Promoters { get; set; }
        public DbSet<PromoterStatistic> PromoterStatistics { get; set; }
        public DbSet<FileStore> FileStores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<ContactGroup>()
                .HasKey(bc => new { bc.ContactId, bc.GroupId });
            modelBuilder.Entity<ContactGroup>()
                .HasOne(bc => bc.Contact)
                .WithMany(b => b.ContactGroups)
                .HasForeignKey(bc => bc.ContactId);
            modelBuilder.Entity<ContactGroup>()
                .HasOne(bc => bc.Group)
                .WithMany(c => c.ContactGroups)
                .HasForeignKey(bc => bc.GroupId);

            modelBuilder.Entity<Setting>().HasIndex(z => z.Name);
            modelBuilder.Entity<Contact>().HasIndex(z => z.Status);
            modelBuilder.Entity<Contact>().HasIndex(z => z.PhoneStatus);
            modelBuilder.Entity<Contact>().HasIndex(z => z.Phones);
            modelBuilder.Entity<Contact>().HasIndex(z => z.AccountSid);

            modelBuilder.Entity<TwilioPhone>().HasIndex(z => z.AccountSid);
            modelBuilder.Entity<TwilioPhone>().HasIndex(z => z.Sid);
            modelBuilder.Entity<TwilioPhone>().HasIndex(z => z.PhoneNumber);

            modelBuilder.Entity<Statistic>().HasIndex(z => z.AccountSid);
            modelBuilder.Entity<Statistic>().HasIndex(z => z.DateTime);

            modelBuilder.Entity<TwilioMessage>().HasIndex(z => z.AccountSid);
            modelBuilder.Entity<TwilioMessage>().HasIndex(z => z.Sid);
            modelBuilder.Entity<TwilioMessage>().HasIndex(z => z.DateCreated);
            modelBuilder.Entity<TwilioMessage>().HasIndex(z => z.From);
            modelBuilder.Entity<TwilioMessage>().HasIndex(z => z.To);

            modelBuilder.Entity<TwilioCall>().HasIndex(z => z.AccountSid);
            modelBuilder.Entity<TwilioCall>().HasIndex(z => z.Sid);
            modelBuilder.Entity<TwilioCall>().HasIndex(z => z.DateCreated);
            modelBuilder.Entity<TwilioCall>().HasIndex(z => z.From);
            modelBuilder.Entity<TwilioCall>().HasIndex(z => z.To);

            modelBuilder.Entity<User>().HasIndex(z => z.AdminUserName);

            base.OnModelCreating(modelBuilder);
        }
    }
}
