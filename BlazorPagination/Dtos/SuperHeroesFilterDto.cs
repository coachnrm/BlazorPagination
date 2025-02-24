using System;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlazorPagination.Dtos;

public class SuperHeroesFilterDto
{
    public string? Sort {get; set;}
    public string? OrderBy {get; set;}
}
