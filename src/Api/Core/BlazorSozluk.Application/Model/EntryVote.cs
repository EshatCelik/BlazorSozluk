using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BlazorSozluk.Common.ViewModels.Enums;

namespace BlazorSozluk.Application.Model
{
    public class EntryVote:BaseEntity
    {
        public Guid EntryId { get; set; }
        public Guid CreatedById { get; set; }

        public VoteType VoteType { get; set; }

        public virtual Entry Entry { get; set; }

    }
}
