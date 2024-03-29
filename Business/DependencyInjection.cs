﻿
using Business.Behaviour;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace Business
{
    public static class DependencyInjection
    {
        public static IServiceCollection Business(this IServiceCollection services)
        {
            services.AddMediatR(e =>
            {
                e.RegisterServicesFromAssemblies(typeof(DependencyInjection).Assembly);
                e.AddOpenBehavior(typeof(ValidationBehaviour<,>));
            });

            services.AddValidatorsFromAssemblies(new[] { typeof(DependencyInjection).Assembly });
            return services;
        }
    }
}
