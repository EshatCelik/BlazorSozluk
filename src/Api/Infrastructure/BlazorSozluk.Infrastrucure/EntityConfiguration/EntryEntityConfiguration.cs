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
    public class EntryEntityConfiguration : BaseEntityConfiguration<Entry>
    {
        public override void Configure(EntityTypeBuilder<Entry> builder)
        {
            base.Configure(builder);

            builder.ToTable("entry", BlazorSozlukContext.DEFAULT_CHEMA);

            builder.HasOne(x => x.CreatedBy).WithMany(x => x.Entries).HasForeignKey(x => x.CreatedById);
        }
    }
}
