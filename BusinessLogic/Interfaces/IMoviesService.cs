﻿using Core.DTOs;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IMoviesService
    {
        Task<IEnumerable<MovieDto>> GetAllAsync();
        Task<IEnumerable<GenreDto>> GetGenresAsync();
        Task<MovieDto?> GetByIdAsync(int id);
        Task CreateAsync(CreateMovieDto movie);
        Task EditAsync(MovieDto movieDto);
        Task DeleteAsync(int id);
    }
}
