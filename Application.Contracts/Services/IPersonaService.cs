using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contracts.Services
{
    public interface IPersonaService
    {       
        Task<PersonaModel> GetPersona(int id);
        Task<IEnumerable<PersonaModel>> GetPersonaAll();
        Task<PersonaModel> AddPersona(PersonaModel persona);
        Task DeletePersona(int id);
        Task<PersonaModel> UpdatePersona(PersonaModel persona);      
    }
}
