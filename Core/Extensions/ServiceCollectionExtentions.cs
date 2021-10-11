using Core.Utilities.IoC;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Extensions
{
    public static class ServiceCollectionExtentions
    {
        public static IServiceCollection AddDependencyResolvers
            (this IServiceCollection serviceColletions, ICoreModule[] modules)
        {
            foreach (var module in modules)
            {
                module.Load(serviceColletions);
            }

            return ServiceTool.Create(serviceColletions);
        }
    }
}
