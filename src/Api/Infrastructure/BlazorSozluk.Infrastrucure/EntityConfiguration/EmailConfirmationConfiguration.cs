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
    public class EmailConfirmationConfiguration:BaseEntityConfiguration<EmailConfirmation>
    {
        public override void Configure(EntityTypeBuilder<EmailConfirmation> builder)
        {
            base.Configure(builder);
            builder.ToTable("emailconfirmation", BlazorSozlukContext.DEFAULT_CHEMA);
        }
    }
}
