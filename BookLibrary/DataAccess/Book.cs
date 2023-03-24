using System;
using System.Collections.Generic;

namespace BookLibrary.DataAccess;

public partial class Book
{
    public int BookId { get; set; }

    public string BookName { get; set; } = null!;

    public string? Author { get; set; }

    public string? Title { get; set; }

    public string? Describe { get; set; }

    public decimal Price { get; set; }

    public double? Discount { get; set; }

    public DateTime? ReleaseDate { get; set; }

    public int? CategoryId { get; set; }

    public int? Sold { get; set; }

    public double? RatingPoint { get; set; }

    public virtual ICollection<CartDetail> CartDetails { get; } = new List<CartDetail>();

    public virtual Category? Category { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; } = new List<OrderDetail>();

    public virtual ICollection<Review> Reviews { get; } = new List<Review>();
}
