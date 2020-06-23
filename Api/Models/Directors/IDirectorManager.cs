using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Models.Directors;

namespace Api.Models.Directors
{
    public interface IDirectorManager
    {
        Task<List<Director>> GetAll();
        Task<Director> GetById(long id);
        Task<bool> Create(Director director);
        Task<bool> Update(Director director);
        Task<bool> Remove(Director director);
    }
}