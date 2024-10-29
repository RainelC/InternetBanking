using InternetBanking.Infrastructure.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace InternetBanking.Infrastructure.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceLayer(this IServiceCollection services, IConfiguration config)
        {

            if (config.GetValue<bool>("UseDatabaseinMemory"))
            {
                var connectionString = config.GetConnectionString("DefaultConnection");
                services.AddDbContext<AppDbContext>(opt =>
                                    opt.UseInMemoryDatabase("AppDb"));
            }
            else
            {
                var connectionString = config.GetConnectionString("DefaultConnection");
                services.AddDbContext<AppDbContext>(opt =>
                                    opt.UseSqlServer(connectionString,
                                    m => m.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName)
                                    ));
            }


            //Repositories



            //Servicies


        }
    }
}
