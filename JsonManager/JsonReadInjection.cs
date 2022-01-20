using Microsoft.Extensions.DependencyInjection;
using ShowInvoice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowInvoice.JsonManager
{
    public static class JsonReadInjection
    {
        public static IServiceCollection AddJsonRead(this IServiceCollection services)
        {
            services.AddScoped<IJsonRead<User>, JsonRead<User>>();
            services.AddScoped<IJsonRead<Invoice>, JsonRead<Invoice>>();
            services.AddScoped<IJsonRead<Product>, JsonRead<Product>>();
            services.AddScoped<IJsonRead<Invoiceline>, JsonRead<Invoiceline>>();
            return services;
        }
    }
}
