using System;
using System.Collections.Generic;

#nullable disable

namespace Library.Entities.Models
{
    public partial class Comment
    {
        public Comment()
        {
            Likes = new HashSet<Like>();
        }

        public int Id { get; set; }
        public string Comment1 { get; set; }
        public DateTime? Datetime { get; set; }
        public bool? IsApproved { get; set; }
        public int? MemberId { get; set; }
        public int? BookId { get; set; }

        public virtual Book Book { get; set; }
        public virtual Member Member { get; set; }
        public virtual ICollection<Like> Likes { get; set; }
    }
}
