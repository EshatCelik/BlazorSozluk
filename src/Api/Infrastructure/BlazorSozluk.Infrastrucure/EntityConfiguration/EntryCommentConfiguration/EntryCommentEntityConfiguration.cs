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
    public class EntryCommentEntityConfiguration:BaseEntityConfiguration<EntryComment>
    {
        public override void Configure(EntityTypeBuilder<EntryComment> builder)
        {
            base.Configure(builder);

            builder.ToTable("entrycomment", BlazorSozlukContext.DEFAULT_CHEMA);

            builder.HasOne(x=>x.Entry).WithMany(x=>x.EntryComments).HasForeignKey(x=>x.EntryId);

            builder.HasOne(x => x.CreatedBy).WithMany(x => x.EntryComments).HasForeignKey(x => x.CreatedBy);

        }

    }
}
