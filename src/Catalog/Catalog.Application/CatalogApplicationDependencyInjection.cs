using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Catalog.Application
{
    public static class CatalogApplicationDependencyInjection
    {
        public static IServiceCollection AddCatalogApplicationDependencyInjection(this IServiceCollection service)
        {
            service.AddMediatR(Assembly.GetExecutingAssembly());

            return service;
        }
    }
}
