using Core.Contracts;
using Microsoft.Extensions.DependencyInjection;

namespace Services
{
    public static class InfrastructureExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IPokerService, PokerService>();
            return services;
        }
    }
}