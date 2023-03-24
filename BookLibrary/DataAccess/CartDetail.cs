﻿using System;
using System.Collections.Generic;

namespace BookLibrary.DataAccess;

public partial class CartDetail
{
    public int CartId { get; set; }

    public int BookId { get; set; }

    public int? Quantity { get; set; }

    public virtual Book Book { get; set; } = null!;

    public virtual Cart Cart { get; set; } = null!;
}
