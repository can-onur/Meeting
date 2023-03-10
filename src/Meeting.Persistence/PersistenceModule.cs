using Meeting.Domain;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Meeting.Persistence
{
    public static class PersistenceModule
    {
        public static void Register(this IServiceCollection services, IConfiguration configuration)
        {
            DomainModule.Register(services, configuration);
        }
    }
}
