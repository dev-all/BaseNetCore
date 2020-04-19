
using Domain.Models;
using FrontEnd.Models;

namespace FrontEnd.Mappers
{
    public class AutoMapperWebProfile : AutoMapper.Profile
    {
        public AutoMapperWebProfile()
        {
            CreateMap<PersonaModel, PersonaViewModel>();
        }

        public static void Run()
        {
            AutoMapper.Mapper.Initialize(cfg => cfg.AddProfiles(new[] {
                                                        "FrontEnd",
                                                        "Application"
                                                    }));

        }
    }
}
