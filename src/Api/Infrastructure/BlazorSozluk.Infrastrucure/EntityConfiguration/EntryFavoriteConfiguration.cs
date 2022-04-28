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
    public class EntryFavoriteConfiguration:BaseEntityConfiguration<EntryFavorite>
    {
        public override void Configure(EntityTypeBuilder<EntryFavorite> builder)
        {
            base.Configure(builder);
            builder.ToTable("entryfavotite", BlazorSozlukContext.DEFAULT_CHEMA);

            builder.HasOne(x => x.Entry).WithMany(x => x.EntryFavorites).HasForeignKey(x => x.EntryId);
            builder.HasOne(x => x.CreatedBy).WithMany(x => x.EntryFavorites).HasForeignKey(x => x.CreatedBy);
        }
    }
}
