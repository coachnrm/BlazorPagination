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

    public async Task<SuperHero> GetSuperHeroById(int id)
    {
        return await _userContext.SuperHeroes.FirstOrDefaultAsync(_ => _.Id == id);
    }

    public Task<List<SuperHero>> GetSuperHeroesAsync()
    {
        return _userContext.SuperHeroes.ToListAsync();
    }

    public async Task<SuperHero> UpdateSuperHeroesAsync(SuperHero updateSuperHeroes)
    {
        _userContext.SuperHeroes.Update(updateSuperHeroes);
        await _userContext.SaveChangesAsync();
        return updateSuperHeroes;
    }
}
