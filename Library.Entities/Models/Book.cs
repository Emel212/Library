using System;
using System.Collections.Generic;

#nullable disable

namespace Library.Entities.Models
{
    public partial class Book
    {
        public Book()
        {
            BookStatuses = new HashSet<BookStatus>();
            Comments = new HashSet<Comment>();
            Images = new HashSet<Image>();
            Likes = new HashSet<Like>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public int? PublisherId { get; set; }
        public int? CategoryId { get; set; }

        public virtual Category Category { get; set; }
        public virtual Publisher Publisher { get; set; }
        public virtual ICollection<BookStatus> BookStatuses { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Image> Images { get; set; }
        public virtual ICollection<Like> Likes { get; set; }
    }
}
