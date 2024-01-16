using System;
using System.Collections.Generic;

namespace BooksDataManagement.Models
{
    public partial class Author
    {
        public Author()
        {
            Books = new HashSet<book>();
        }

        public int AuthorId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<book> Books { get; set; }
    }
}
