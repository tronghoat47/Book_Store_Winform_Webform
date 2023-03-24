using System;
using System.Collections.Generic;

namespace BookLibrary.DataAccess;

public partial class Category
{
    public int CategoryId { get; set; }

    public string CategoryName { get; set; } = null!;

    public string? Image { get; set; }

    public virtual ICollection<Book> Books { get; } = new List<Book>();
}
