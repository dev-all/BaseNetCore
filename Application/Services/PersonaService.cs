using Polly;
using Application.Configuration;
using Application.Contracts.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using DataAccess.Contracts.Entities;
using DataAccess.Contracts.Repositories;
using AutoMapper;

namespace Application.Services
{
   public  class PersonaService: IPersonaService

    {
        private readonly IPersonaRepository _personaRepository;
        public readonly IAppConfig _appConfig;
        //private readonly IConfiguration _configuration;
        public PersonaService(IPersonaRepository personaRepository, IAppConfig appConfig)
        {
            _personaRepository = personaRepository;
            _appConfig = appConfig;
        }

        public async Task<PersonaModel> AddPersona(PersonaModel persona)
        {
            // nu usa automaper pero se podria utilizar 
            // este metodo es mas laborioso pero mas claro
            //var entidad = await _userRepository.Add(UserMapper.Map(user));
            //return UserMapper.Map(entidad);


            //solo para evaluar y aprender la utilizacion de polly 
            //EL Ejemplo usa la policita de reintento es decir se ejecuta las veces q diga el maxTrys a un intervalo de tiempo especificado en timeToWait
            // ideal para cuaando se consulta proeedores externos 
            //var maxActual = _configuration.GetSection("Polly:MaxTrys").Value;
            var maxTrys = _appConfig.MaxTrys;
            var timeToWait =TimeSpan.FromSeconds(_appConfig.SecondsToWait);
            var retryPility = Policy.Handle<Exception>().WaitAndRetryAsync(maxTrys,i=> timeToWait);
            return await retryPility.ExecuteAsync(async () =>
                     {
                         var entidad = await _personaRepository.Add( Mapper.Map<PersonaModel ,Persona >(persona));
                         return Mapper.Map<Persona,PersonaModel >(entidad);
                     });
          


        }

        public async Task<PersonaModel> GetPersona(int id)
        {
            var entidad = await _personaRepository.Get(id);
            return Mapper.Map<Persona, PersonaModel>(entidad);
        }

        public async Task<IEnumerable<PersonaModel>> GetPersonaAll()
        {
            var entidadList = await _personaRepository.GetAll();            
            return Mapper.Map<IEnumerable<Persona>, IEnumerable<PersonaModel>>(entidadList);
        }

        public async Task DeletePersona(int id)
        {
             await _personaRepository.DeleteAsync(id);
        }

        public async Task<PersonaModel> UpdatePersona(PersonaModel persona)
        {
            var entidad = await _personaRepository.Update(Mapper.Map<PersonaModel,Persona>(persona));
            return Mapper.Map<Persona, PersonaModel>(entidad);
        }

     
    }
}
