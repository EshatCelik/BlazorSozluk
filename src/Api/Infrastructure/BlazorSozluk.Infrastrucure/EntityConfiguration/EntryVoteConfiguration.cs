using BlazorSozluk.Application.Model;
using BlazorSozluk.Infrastrucure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorSozluk.Infrastrucure.Persistence.EntityConfiguration
{
    public class EntryVoteConfiguration:BaseEntityConfiguration<EntryVote>
    {
        public override void Configure(EntityTypeBuilder<EntryVote> builder)
        {
            base.Configure(builder);

            builder.ToTable("entryvote", BlazorSozlukContext.DEFAULT_CHEMA);

            builder.HasOne(x=>x.Entry).WithMany(x=>x.EntryVotes).HasForeignKey(x=>x.EntryId);
        }
    }
}
