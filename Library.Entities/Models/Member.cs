using System;
using System.Collections.Generic;

#nullable disable

namespace Library.Entities.Models
{
    public partial class Member
    {
        public Member()
        {
            BookStatuses = new HashSet<BookStatus>();
            Comments = new HashSet<Comment>();
            Likes = new HashSet<Like>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Adress { get; set; }
        public DateTime? MemberSince { get; set; }

        public virtual ICollection<BookStatus> BookStatuses { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Like> Likes { get; set; }
    }
}
