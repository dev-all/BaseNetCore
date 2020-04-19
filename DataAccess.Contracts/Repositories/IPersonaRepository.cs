using DataAccess.Contracts.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.Contracts.Repositories
{
    public interface IPersonaRepository : IRepository<Persona>
    {

        Task<Persona> Get(int id);

        Task<IEnumerable<Persona>> GetAll();

        Task<Persona> Add(Persona user);

        Task<Persona> Update(Persona userEntity);

        Task DeleteAsync(int id);
    }
}
