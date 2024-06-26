﻿using Biblioteca.Domain.Contracts.Repositories;
using Biblioteca.Infra.Data.Context;
using Biblioteca.Infra.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Biblioteca.Infra.Data;

public static class DependencyInjection
{
    public static void ConfigureDbContext(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            var serverVersion = ServerVersion.AutoDetect(connectionString);

            options.UseMySql(connectionString, serverVersion);
            options.EnableDetailedErrors();
            options.EnableSensitiveDataLogging();
        });
    }

    public static void RepositoryDependency(this IServiceCollection services)
    {
        services
            .AddScoped<IAdministradorRepository, AdministradorRepository>()
            .AddScoped<IUsuarioRepository, UsuarioRepository>()
            .AddScoped<ILivroRepository, LivroRepository>()
            .AddScoped<IEmprestimoRepository, EmprestimoRepository>();
    }
}