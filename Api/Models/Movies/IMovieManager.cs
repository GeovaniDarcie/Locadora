using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Models.Movies
{
    public interface IMovieManager
    {
        Task<List<Movie>> GetAll();
        Task<Movie> GetById(long id);
        Task<bool> Create(Movie movie);
        Task<bool> Update(Movie movie);
        Task<bool> Remove(long id);
    }
}