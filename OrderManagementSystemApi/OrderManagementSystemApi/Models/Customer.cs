using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OrderManagementSystemApi.Models;

[Table("Customer")]
[Index("UserName", Name = "UQ__Customer__C9F284564B02FA38", IsUnique = true)]
public partial class Customer
{
    [Key]
    [Column("Cust_Id")]
    public int CustId { get; set; }

    [StringLength(50)]
    public string Name { get; set; } = null!;

    [StringLength(100)]
    public string? Address { get; set; }

    [Column("Contact_num")]
    [StringLength(13)]
    public string? ContactNum { get; set; }

    [StringLength(20)]
    public string UserName { get; set; } = null!;

    [StringLength(20)]
    public string Password { get; set; } = null!;
}
