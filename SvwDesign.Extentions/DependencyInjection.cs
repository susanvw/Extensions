using SvwDesign.Extensions.Behaviours;

namespace SvwDesign.Extensions;

public static class DependencyInjection
{
    public static void AddExtensions(this IServiceCollection services)
    {
        services.AddMediatR(Assembly.GetExecutingAssembly());
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddTransient(typeof(IPipelineBehavior<,>), typeof(UnhandledExceptionBehaviour<,>));
        services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));

        services.AddScoped<IDateTime, DateTimeService>();
    }
}
