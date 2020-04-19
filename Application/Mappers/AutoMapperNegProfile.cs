
using DataAccess.Contracts.Entities;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Mappers
{
    class AutoMapperNegProfile : AutoMapper.Profile
    {
        public AutoMapperNegProfile()
        {
            CreateMap<PersonaModel, Persona>();
            CreateMap<Persona, PersonaModel>();

        }
    }
}
