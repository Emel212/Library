using System;
using System.Collections.Generic;

#nullable disable

namespace Library.Entities.Models
{
    public partial class BookStatus
    {
        public int Id { get; set; }
        public DateTime? DateTime { get; set; }
        public DateTime? LoanPeriod { get; set; }
        public int? MemberId { get; set; }
        public int? BookId { get; set; }
        public bool? IsBorrowed { get; set; }
        public bool? IsAvailable { get; set; }
        public bool? IsOnHold { get; set; }

        public virtual Book Book { get; set; }
        public virtual Member Member { get; set; }
    }
}
