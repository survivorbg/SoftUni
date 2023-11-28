﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Invoices.Data.Models;

public class Address
{
    [Key]
    public int Id { get; set; }
    [Required]
    [StringLength(20)]
    public string StreetName { get; set; } = null!;
    [Required]
    public int StreetNumber { get; set; }
    [Required]
    public string PostCode { get; set; } = null!;
    [Required]
    [StringLength(15)]
    public string City { get; set; } = null!;
    [Required]
    [StringLength(15)]
    public string Country { get; set; } = null!;
    [Required]
    public int ClientId { get; set; }
    [ForeignKey(nameof(ClientId))]
    public virtual Client Client { get; set; } = null!;

}
