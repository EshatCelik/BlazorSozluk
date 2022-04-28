using BlazorSozluk.Application.Model;
using BlazorSozluk.Infrastrucure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorSozluk.Infrastrucure.Persistence.EntityConfiguration.EntryCommentConfiguration
{
    public class EntryCommentVoteConfiguration:BaseEntityConfiguration<EntryCommentVote>
    {
        public override void Configure(EntityTypeBuilder<EntryCommentVote> builder)
        {
            base.Configure(builder);
            builder.ToTable("entrycommentvote", BlazorSozlukContext.DEFAULT_CHEMA);

            builder.HasOne(x=>x.Entry).WithMany(x=>x.EntryCommentsVotes).HasForeignKey(x=>x.EntryCommentId);

        }
    }
}
