using Core.DTOs;
using Core.Interfaces;
using Core.Services;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenresController : ControllerBase
    {
        private readonly IGenresService _genresService;
        public GenresController(IGenresService genresService)
        {
            _genresService = genresService;
        }

        [HttpGet] //GET: ~/api/movies
        //[HttpGet("all")] //GET: ~/api/movies/all
        //[HttpGet("/movies")] //GET: ~/movies
        public async Task<IActionResult> Get()
        {
            //    Movies.Include(x => x.Genres).ThenInclude(x => x.Genre);

            return Ok(await _genresService.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromRoute] int id)  //default FromQuery   => ~/api/movies?id=2   //FromRoute => ~/api/movies/2
        {
            return Ok(await _genresService.GetByIdAsync(id));
        }
        [HttpPost("Create")]
        public async Task<IActionResult> Create(GenreDto genre)
        {
            await _genresService.CreateAsync(genre);
            return Ok();
        }

        [HttpPut("Edit")]
        public async Task<IActionResult> Edit(GenreDto genre)
        {
            await _genresService.EditAsync(genre);
            return Ok();
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            await _genresService.DeleteAsync(id);
            return Ok();
        }

    }
}
