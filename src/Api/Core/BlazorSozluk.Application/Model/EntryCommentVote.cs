using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BlazorSozluk.Common.ViewModels.Enums;

namespace BlazorSozluk.Application.Model
{
    public class EntryCommentVote:BaseEntity
    {
        public Guid EntryCommentId { get; set; }
        public Guid CreatedById { get; set; }

        public VoteType VoteType { get; set; }

        public virtual EntryComment Entry { get; set; }

    }
}
