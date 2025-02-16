using System;
using BlazorPagination.Models;

namespace BlazorPagination.Services;

public interface ISuperHeroesService
{
    Task<List<SuperHero>> GetSuperHeroesAsync();
    Task<SuperHero> CreateSuperHeroesAsync(SuperHero newSuperHeroes);
}
