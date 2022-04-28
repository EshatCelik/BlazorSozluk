using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorSozluk.Application.Model
{
    public class EntryComment:BaseEntity
    {
        public string Content { get; set; }
        public Guid  EntryId { get; set; }
        public virtual Entry Entry { get; set; }
        public virtual User CreatedBy { get; set; }

        public virtual ICollection<EntryCommentVote> EntryCommentsVotes { get; set; }
        public virtual ICollection<EntryCommentFavorite> EntryCommentsFavorites { get; set; }

    }
}
