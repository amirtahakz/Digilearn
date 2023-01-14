using Web.Infrastructure.JwtUtil;
using Web.Infrastructure.RazorUtils;

namespace Web.Infrastructure;

public static class RegisterDependencyServices
{
    public static IServiceCollection RegisterApiServices(this IServiceCollection services)
    {
        services.AddHttpContextAccessor();

        services.AddScoped<HttpClientAuthorizationDelegatingHandler>();
        services.AddTransient<IRenderViewToString, RenderViewToString>();

        services.AddAutoMapper(typeof(RegisterDependencyServices).Assembly);

        return services;
    }
}