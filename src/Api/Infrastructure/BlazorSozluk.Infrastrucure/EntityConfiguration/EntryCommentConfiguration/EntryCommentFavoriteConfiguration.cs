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
    public  class EntryCommentFavoriteConfiguration:BaseEntityConfiguration<EntryCommentFavorite>
    {
        public override void Configure(EntityTypeBuilder<EntryCommentFavorite> builder)
        {
            base.Configure(builder);
            builder.ToTable("entryCommentfavorite", BlazorSozlukContext.DEFAULT_CHEMA);
            
            builder.HasOne(x=>x.CreatedBy).WithMany(x=>x.EntryCommentFavorites).HasForeignKey(x=>x.CreatedBy);
            builder.HasOne(x=>x.EntryComment).WithMany(x=>x.EntryCommentsFavorites).HasForeignKey(x=>x.EntryCommentId);
        }
    }
}
