using Meeting.Application.Contracts;
using Meeting.Domain;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Meeting.Application
{
    public static class ApplicationModule
    {
        public static void Register(this IServiceCollection services, IConfiguration configuration)
        {
            DomainModule.Register(services, configuration);
            ApplicationContractsModule.Register(services, configuration);
        }
    }
}