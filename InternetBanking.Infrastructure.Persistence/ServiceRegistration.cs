using InternetBanking.Core.Application.Interfaces.Repositories;
using InternetBanking.Core.Application.Interfaces.Services;
using InternetBanking.Core.Application.Services;
using InternetBanking.Infrastructure.Persistence.Contexts;
using InternetBanking.Infrastructure.Persistence.Repositories;
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
            services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<ITransactionsRepository, TransactionRepository>();
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<IBeneficiaryRepository, BeneficiaryRepository>();


            //Servicies
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<ITransactionService, TransactionService>();
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<IBeneficiaryService, BeneficiaryService>();

        }
    }
}
