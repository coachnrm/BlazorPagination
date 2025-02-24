using System;
using BlazorPagination.Dtos;
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

    public async Task<int> DeleteSuperHeroesAsync(int id)
    {
        await _userContext.SuperHeroes.Where(_ => _.Id == id).ExecuteDeleteAsync();
        return id;
    }

    public async Task<SuperHero> GetSuperHeroById(int id)
    {
        return await _userContext.SuperHeroes.FirstOrDefaultAsync(_ => _.Id == id);
    }

    public async Task<List<SuperHero>> GetSuperHeroesAsync(SuperHeroesFilterDto superHeroesFilter)
    {
        var superHeroes = _userContext.SuperHeroes.AsQueryable();

        if(!string.IsNullOrEmpty(superHeroesFilter.Sort) &&
            !string.IsNullOrEmpty(superHeroesFilter.OrderBy))
        {
            if(superHeroesFilter.Sort.ToLower() == "id" && superHeroesFilter.OrderBy.ToLower() == "desc")
            {
                superHeroes = superHeroes.OrderByDescending(x => x.Id);
            }
            else if (superHeroesFilter.Sort.ToLower() == "id" && superHeroesFilter.OrderBy.ToLower() == "asc")
            {
                superHeroes = superHeroes.OrderBy(x => x.Id);
            }
            else if (superHeroesFilter.Sort.ToLower() == "franchise" && superHeroesFilter.OrderBy.ToLower() == "asc")
            {
                superHeroes = superHeroes.OrderByDescending(x => x.Franchise);
            }
            else if (superHeroesFilter.Sort.ToLower() == "franchise" && superHeroesFilter.OrderBy.ToLower() == "asc")
            {
                superHeroes = superHeroes.OrderBy(x => x.Franchise);
            }
        }

        return await superHeroes.ToListAsync();
    }

    public async Task<SuperHero> UpdateSuperHeroesAsync(SuperHero updateSuperHeroes)
    {
        _userContext.SuperHeroes.Update(updateSuperHeroes);
        await _userContext.SaveChangesAsync();
        return updateSuperHeroes;
    }
}
