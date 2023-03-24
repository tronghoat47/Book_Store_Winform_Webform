using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookLibrary.DataAccess;

public partial class Account
{
    public int AccountId { get; set; }

    [Required(ErrorMessage = "You must be input username")]
    public string Username { get; set; } = null!;

    [Required(ErrorMessage = "You must be input password")]
    [DataType(DataType.Password)]
    public string Password { get; set; } = null!;

    [Required(ErrorMessage = "You must be input repassword")]
    [Compare("Password", ErrorMessage ="Repassword must be match to Password")]
    [DataType(DataType.Password)]
    [NotMapped]
    public string RePassword { get; set; } = null!;

    public string? Name { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public string? Address { get; set; }

    public int? RoleId { get; set; }

    public virtual ICollection<Cart> Carts { get; } = new List<Cart>();

    public virtual ICollection<Order> Orders { get; } = new List<Order>();

    public virtual Role? Role { get; set; }
}
