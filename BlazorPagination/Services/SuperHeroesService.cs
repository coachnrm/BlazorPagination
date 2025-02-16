using System;
using BlazorPagination.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorPagination.Services;

public class SuperHeroesService : ISuperHeroesService
{
    private readonly UserContext _userContext;
    public SuperHeroesService(UserContext userContext)
    {
        _userContext = userContext;
    }

    public async Task<SuperHero> CreateSuperHeroesAsync(SuperHero newSuperHeroes)
    {
        _userContext.SuperHeroes.Add(newSuperHeroes);
        await _userContext.SaveChangesAsync();
        return newSuperHeroes;
    }

    public Task<List<SuperHero>> GetSuperHeroesAsync()
    {
        return _userContext.SuperHeroes.ToListAsync();
    }
}
