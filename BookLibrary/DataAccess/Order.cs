using System;
using System.Collections.Generic;

namespace BookLibrary.DataAccess;

public partial class Order
{
    public int OrderId { get; set; }

    public int AccountId { get; set; }

    public DateTime? OrderDate { get; set; }

    public string? Note { get; set; }

    public string? ShippingAddress { get; set; }

    public string? Status { get; set; }

    public decimal? TotalMoney { get; set; }

    public virtual Account Account { get; set; } = null!;

    public virtual ICollection<OrderDetail> OrderDetails { get; } = new List<OrderDetail>();
}
