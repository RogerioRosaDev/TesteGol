using Microsoft.Extensions.DependencyInjection;
using SIS_GOL.Application;
using SIS_GOL.Domain;
using SIS_GOL.Infra.DataAccess;

namespace SIS_GOL.Infra.CrossCutting.IOC
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddSingleton(typeof(IReading<>), typeof(RepositoryGeneric<>));
            services.AddSingleton(typeof(IRecording<>), typeof(RepositoryGeneric<>));

            services.AddScoped<IAirplaneApplication, AirplaneApplication>();
            services.AddScoped<IAirplaneRepository, AirplaneRepository>();
        }
    }
}
