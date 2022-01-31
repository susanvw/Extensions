using MediatR;
using Microsoft.Extensions.DependencyInjection;
using SvwDesign.Extensions.Behaviours;
using SvwDesign.Extensions.Interfaces;
using SvwDesign.Extensions.Services;
using System.Reflection;

namespace SvwDesign.Extensions
{
    public static class DependencyInjection
    {
        public static void AddExtensionsModule(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
           services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(UnhandledExceptionBehaviour<,>));
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));
            services.AddTransient<IDateTime, DateTimeService>();
        }
    }
}
