using BlazorSozluk.Application.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BlazorSozluk.Infrastrucure.Persistence.Context
{
    public class BlazorSozlukContext:DbContext
    {
        public const string DEFAULT_CHEMA = "dbo";

        public BlazorSozlukContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Entry> Entries { get; set; }

        public DbSet<EntryVote> EntryVotes{ get; set; }
        public DbSet<EntryFavorite> EntryFavorites { get; set; }

        public DbSet<EntryComment> EntryComments { get; set; }
        public DbSet<EntryCommentVote> EntryCommentVotes { get; set; }
        public DbSet<EntryCommentFavorite> EntryCommentFavorites { get; set; }

        public DbSet<EmailConfirmation> EmailConfirmations{ get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }

        public override int SaveChanges()
        {
            OnBeforSaveChange();
            return base.SaveChanges();
        }

        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            OnBeforSaveChange();

            return base.SaveChanges(acceptAllChangesOnSuccess);
        }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            OnBeforSaveChange();
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            OnBeforSaveChange();
            return base.SaveChangesAsync(cancellationToken);
        }

        private void OnBeforSaveChange()
        {

            var addedEntry = ChangeTracker.Entries().Where(x => x.State == EntityState.Added).Select(y => (BaseEntity)y.Entity);
            PrepareEntityBeforeAdded(addedEntry);
        }

        private void PrepareEntityBeforeAdded(IEnumerable<BaseEntity> entities)
        {
            foreach (var entity in entities)
            {
                if(entity.CreateDate==DateTime.MinValue)
                entity.CreateDate=DateTime.Now;
            }
        }

    }
}
