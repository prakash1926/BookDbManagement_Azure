using System;
using System.Collections.Generic;

namespace BooksDataManagement.Models
{
    public partial class BookCategory
    {
        public BookCategory()
        {
            Books = new HashSet<book>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = null!;

        public virtual ICollection<book> Books { get; set; }
    }
}
