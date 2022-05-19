using System.Reflection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Survey.Application
{
    public static class Extension
    {
        public static IServiceCollection AddApplicationDependencies(this IServiceCollection service)
        {
            service.AddMediatR(Assembly.GetExecutingAssembly());
            return service;
        }
    }
}