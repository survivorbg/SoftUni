﻿using System.ComponentModel.DataAnnotations;

namespace Footballers.Data.Models;

public class Coach
{
    [Key]
    public int Id { get; set; }
    [Required]
    [MaxLength(40)]
    public string Name { get; set; }
    [Required]
    public string Nationality { get; set; }

    public ICollection<Footballer> Footballers { get; set; } = new HashSet<Footballer>();



}
