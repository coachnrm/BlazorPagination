using System;
using System.Collections.Generic;

namespace BlazorPagination.Models;

public partial class SuperHero
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Franchise { get; set; }

    public string? Gender { get; set; }

    public string? ImageUrl { get; set; }
}
