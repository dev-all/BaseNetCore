
using DataAccess.Contracts;
using DataAccess.Contracts.Entities;
using DataAccess.Contracts.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
   public class PersonaRepository : IPersonaRepository
    {
        //metodos para el crud https://www.youtube.com/watch?v=wfpdH0EiUzI&list=PLU3UD_RM_1Abkcw8jjCl4o179jfyD47mj&index=18

        private readonly IAppDBContext _appDBContext;

        public PersonaRepository(IAppDBContext shopDBContext)
        {
            _appDBContext = shopDBContext;
        }

        public async Task<Persona> Get(int idEntity)
        {
            var result = await _appDBContext.Personas.FirstOrDefaultAsync( x => x.Id == idEntity);
            return result;

        }

        public async Task<Persona> Add(Persona userEntity)
        {
            // fozar la ejecucion de la RetryPolity
            // throw new Exception("test politica de Re intento RetryPolity");


            await _appDBContext.Personas.AddAsync(userEntity);
            await _appDBContext.SaveChangesAsync();
            return userEntity;
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _appDBContext.Personas.SingleAsync(x => x.Id == id);

            _appDBContext.Personas.Remove(entity);

            await _appDBContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Persona>> GetAll()
        {
            return await  _appDBContext.Personas.ToListAsync();
        }


        public Task<bool> Exist(int id)
        {
            throw new NotImplementedException();
        }
                    
        public async Task<Persona> Update(int idEntity, Persona updateUserEntity)
        {
            var entity = await Get(idEntity);
            entity.NombreApellido = updateUserEntity.NombreApellido;
            _appDBContext.Personas.Update(entity);
            await _appDBContext.SaveChangesAsync();
            return entity;
        }
        public async Task<Persona> Update(Persona updateUserEntity)
        {

            var updateEntity = _appDBContext.Personas.Update(updateUserEntity);

            await _appDBContext.SaveChangesAsync();

            return updateEntity.Entity;
        }

       
    }
}
