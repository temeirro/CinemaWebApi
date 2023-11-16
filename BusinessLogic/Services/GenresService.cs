using AutoMapper;
using Core.DTOs;
using Core.Interfaces;
using Core.Specifications;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class GenresService : IGenresService
    {
        private readonly IRepository<Genre> _repoGenre;
        private readonly IMapper _mapper;
        public GenresService(IRepository<Genre> repoGenre, IMapper mapper)
        {
            _repoGenre = repoGenre;
            _mapper = mapper;
        }
        public async Task CreateAsync(GenreDto genre)
        {
            await _repoGenre.InsertAsync(_mapper.Map<Genre>(genre));
            await _repoGenre.SaveAsync();
        }

        public async Task DeleteAsync(int id)
        {
            if (_repoGenre.GetByIDAsync(id) == null)
                return;
            await _repoGenre.DeleteAsync(id);
            await _repoGenre.SaveAsync();
        }

        public async Task EditAsync(GenreDto genre)
        {
            await _repoGenre.UpdateAsync(_mapper.Map<Genre>(genre));
            await _repoGenre.SaveAsync();
        }

        public async Task<IEnumerable<GenreDto>> GetAllAsync()
        {
            var genres = await _repoGenre.GetListBySpec(new GenresSpec.OrderByName());
            return _mapper.Map<IEnumerable<GenreDto>>(genres);
        }

        public async Task<GenreDto?> GetByIdAsync(int id)
        {
            if (await _repoGenre.GetByIDAsync(id) == null)
                return null;
            //throw new HttpRequestException("Not Found");
            return _mapper.Map<GenreDto>(await _repoGenre.GetByIDAsync(id));
        }
    }
}
