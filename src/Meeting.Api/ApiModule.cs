using Meeting.Application;
using Meeting.Application.Contracts;

namespace Meeting.Api
{
    public static class ApiModule
    {
        public static void Register(this IServiceCollection services, IConfiguration configuration)
        {
            ApplicationModule.Register(services, configuration);
            ApplicationContractsModule.Register(services, configuration);
        }
    }
}
