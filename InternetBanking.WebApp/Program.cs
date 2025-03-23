using InternetBanking.Infrastructure.Persistence;
using InternetBanking.Infrastructure.Identity;

namespace InternetBanking.WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddPersistenceLayer(builder.Configuration);
            builder.Services.AddIdentityInfrastructure(builder.Configuration);
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddHealthChecks();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseHealthChecks("/health");


            app.MapControllers();

            app.Run();
        }
    }
}
