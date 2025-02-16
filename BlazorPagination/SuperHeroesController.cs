using System;
using BlazorPagination.Models;
using BlazorPagination.Services;
using Microsoft.AspNetCore.Mvc;

namespace BlazorPagination;

[Route("api/[controller]")]
[ApiController]
public class SuperHeroesController : ControllerBase
{
    private readonly ISuperHeroesService _superHeroesService;
    public SuperHeroesController(ISuperHeroesService superHeroesService)
    {
        _superHeroesService = superHeroesService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAsync()
    {
        var results = await _superHeroesService.GetSuperHeroesAsync();
        return Ok(results);
    }

    [HttpPost]
    public async Task<IActionResult> PostAsync(SuperHero newSuperHeroes)
    {
        var result = await _superHeroesService.CreateSuperHeroesAsync(newSuperHeroes);
        return Ok(result);
    }
}
