using System;
using System.Collections.Generic;

namespace BookLibrary.DataAccess;

public partial class Review
{
    public int BookId { get; set; }

    public int AccountId { get; set; }

    public string? Comment { get; set; }

    public double? Rating { get; set; }

    public virtual Book Book { get; set; } = null!;
}
