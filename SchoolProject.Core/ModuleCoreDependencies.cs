﻿using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace SchoolProject.Core;
public static class ModuleCoreDependencies
{
    public static IServiceCollection AddCoreDependencies(this IServiceCollection services)
    {
        // mediator configuration
        services.AddMediatR(cfg =>
            cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));

        // 

        return services;
    }
}
