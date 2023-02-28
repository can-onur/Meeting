using Meeting.Domain.Shared;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Meeting.Application.Contracts
{
    public static class ApplicationContractsModule
    {
        public static void Register(this IServiceCollection services, IConfiguration configuration)
        {
            DomainSharedModule.Register(services, configuration);
        }
    }
}