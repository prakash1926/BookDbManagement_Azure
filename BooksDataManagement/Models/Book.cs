﻿using System;
using System.Collections.Generic;

namespace BooksDataManagement.Models
{
    public partial class book
    {
        public book()
        {
            Authors = new HashSet<Author>();
        }

        public int BookId { get; set; }
        public string Name { get; set; } = null!;
        public double? Price { get; set; }
        public int? CategoryId { get; set; }
        public int? PublisherId { get; set; }

        public virtual BookCategory? Category { get; set; }
        public virtual Publisher? Publisher { get; set; }

        public virtual ICollection<Author> Authors { get; set; }
    }
}
