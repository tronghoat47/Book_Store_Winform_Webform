using System;
using System.Collections.Generic;

namespace BookLibrary.DataAccess;

public partial class Cart
{
    public int CartId { get; set; }

    public int? AccountId { get; set; }

    public decimal? TotalMoney { get; set; }

    public virtual Account? Account { get; set; }

    public virtual ICollection<CartDetail> CartDetails { get; } = new List<CartDetail>();
}
