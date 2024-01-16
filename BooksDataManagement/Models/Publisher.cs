using System;
using System.Collections.Generic;

namespace BooksDataManagement.Models
{
    public partial class Publisher
    {
        public Publisher()
        {
            Books = new HashSet<book>();
        }

        public int PublisherId { get; set; }
        public string PublisherName { get; set; } = null!;
        public string? Address { get; set; }

        public virtual ICollection<book> Books { get; set; }
    }
}
