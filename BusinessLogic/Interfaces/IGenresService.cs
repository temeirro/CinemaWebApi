using Core.DTOs;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IGenresService
    {
        Task<IEnumerable<GenreDto>> GetAllAsync();
        Task<GenreDto?> GetByIdAsync(int id);
        Task CreateAsync(GenreDto genre);
        Task EditAsync(GenreDto genre);
        Task DeleteAsync(int id);
    }
}
