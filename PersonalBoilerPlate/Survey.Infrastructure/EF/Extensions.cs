using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Survey.Infrastructure.EF
{
    internal static class Extensions
    {
        //TODO: Remove or call it from the global extension
        public static IServiceCollection AddSurveyDatabase(IServiceCollection service, IConfiguration configuration)
        {
            service.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnectionString")));
            return service;
        }
    }
}