using System;
using BlazorPagination.Dtos;
using BlazorPagination.Models;

namespace BlazorPagination.Services;

public interface ISuperHeroesService
{
    Task<List<SuperHero>> GetSuperHeroesAsync(SuperHeroesFilterDto superHeroesFilter);
    Task<SuperHero> CreateSuperHeroesAsync(SuperHero newSuperHeroes);
    Task<SuperHero> GetSuperHeroById(int id);
    Task<SuperHero> UpdateSuperHeroesAsync(SuperHero updateSuperHeroes);
    Task<int> DeleteSuperHeroesAsync(int id);
}
