using ContactManagemet.Cli.Services.Implementations;
using ContactManagemet.Cli.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace ContactManagemet.Cli.Composition
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddContactManagementServices(this IServiceCollection services)
        {
            services.AddSingleton<IContactService, ContactService>();
            return services;
        }
    }
}
