using System;
using System.Collections.Generic;

namespace FreshKart.Api.Models;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public decimal Price { get; set; }

    public decimal? Was { get; set; }

    public string? Weight { get; set; }

    public string? Pic { get; set; }

    public bool? Popular { get; set; }

    public string Type { get; set; } = null!;
}
