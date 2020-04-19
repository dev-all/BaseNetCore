using Application.ApiCaller;
using Application.Configuration;
using Application.Contracts.ApiCaller;
using Application.Contracts.Services;
using Application.Services;
using DataAccess.Contracts.Repositories;
using DataAccess.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrossCutting.Register
{
    public static class IoCRegister
    {
        //IoC invercion de control
        public static IServiceCollection AddRegistration(this IServiceCollection services)
        {
            AddRegisterServices(services);
            AddRegisterRepositories(services);
            AddRegisterOthers(services);

            return services;

        }

        private static IServiceCollection AddRegisterServices(IServiceCollection services)
        {

            services.AddTransient<IPersonaService, PersonaService>();


            return services;
        }

        private static IServiceCollection AddRegisterRepositories(IServiceCollection services)
        {

            services.AddTransient<IPersonaRepository, PersonaRepository>();

            return services;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        private static IServiceCollection AddRegisterOthers(IServiceCollection services)
        {
            //Configuración fuertemente tipada con Polly, basicamnete permite declarar variables el appsettings
            // los camibos no necesitan que pares la app para q impacten
            services.AddTransient<IAppConfig, AppConfig>();

            services.AddTransient<IApiCaller, ApiCaller>();


            return services;
        }





    }
}
