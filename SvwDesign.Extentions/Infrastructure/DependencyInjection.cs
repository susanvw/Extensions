using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using SvwDesign.Extensions.ApiFilters;
using SvwDesign.Extensions.Behaviours;
using SvwDesign.Extensions.Interfaces;
using SvwDesign.Extensions.Services;

namespace SvwDesign.Extensions
{
    public static class DependencyInjection
    {
        public static void AddControllersWithValdiation(this IServiceCollection services)
        {
            services.AddControllers(options => options.Filters.Add<ApiExceptionFilterAttribute>())
             .AddFluentValidation(x => x.AutomaticValidationEnabled = false);
        }

        public static void AddApiDefaultBehaviours(this IServiceCollection services)
        {
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(UnhandledExceptionBehaviour<,>));
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));
        }


        public static void AddExtensionsModule(this IServiceCollection services)
        {
            services.AddTransient<IDateTime, DateTimeService>();
        }
    }
}
