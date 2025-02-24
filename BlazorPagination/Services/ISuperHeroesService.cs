using System;
using BlazorPagination.Models;

namespace BlazorPagination.Services;

public interface ISuperHeroesService
{
    Task<List<SuperHero>> GetSuperHeroesAsync();
    Task<SuperHero> CreateSuperHeroesAsync(SuperHero newSuperHeroes);
    Task<SuperHero> GetSuperHeroById(int id);
    Task<SuperHero> UpdateSuperHeroesAsync(SuperHero updateSuperHeroes);
}
