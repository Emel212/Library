using System;
using System.Collections.Generic;

#nullable disable

namespace Library.Entities.Models
{
    public partial class Personel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string JobDescription { get; set; }
        public string Phone { get; set; }
        public string Adress { get; set; }
    }
}
