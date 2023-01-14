using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

namespace Web.Infrastructure.JwtUtil;

public static class JwtAuthenticationConfig
{
    public static void AddJwtAuthentication(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddAuthentication(option =>
        {
            option.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            option.DefaultSignInScheme = JwtBearerDefaults.AuthenticationScheme;
            option.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        }).AddJwtBearer(option =>
        {
            option.TokenValidationParameters = new TokenValidationParameters()
            {
                IssuerSigningKey =
                    new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JwtConfig:SignInKey"])),
                ValidIssuer = configuration["JwtConfig:Issuer"],
                ValidAudience = configuration["JwtConfig:Audience"],
                ValidateLifetime = true,
                ValidateAudience = false,
                ValidateIssuer = false,
                ValidateIssuerSigningKey = false
            };
            option.SaveToken = true;


        });


    }
}