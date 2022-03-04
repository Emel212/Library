using System;
using System.Collections.Generic;

#nullable disable

namespace Library.Entities.Models
{
    public partial class Like
    {
        public int Id { get; set; }
        public int? BookId { get; set; }
        public int? CommentId { get; set; }
        public int? MemberId { get; set; }

        public virtual Book Book { get; set; }
        public virtual Comment Comment { get; set; }
        public virtual Member Member { get; set; }
    }
}
