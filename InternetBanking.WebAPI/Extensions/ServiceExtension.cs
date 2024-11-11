using Asp.Versioning;
using Microsoft.OpenApi.Models;

namespace InternetBanking.WebAPI.Extensions
{
    public static class ServiceExtension
    {
        public static void AddSwaggerExtension(this IServiceCollection services)
        {
            services.AddSwaggerGen(options =>
            {
                List<string> xmlFiles = Directory.GetFiles(AppContext.BaseDirectory, "*.xml", searchOption: SearchOption.TopDirectoryOnly).ToList();
                xmlFiles.ForEach(xmlFiles => options.IncludeXmlComments(xmlFiles));

                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1.0",
                    Title = "InternetBanking",
                    Description = "This API will be responsible for overall data distribution",
                    Contact = new OpenApiContact
                    {
                        Name = "Rainel Ramírez, Valerie Capellan, Mario Soriano",
                        Email = "20231054@itla.edu.do",
                        Url = new Uri("https://itla.edu.do")
                    }
                });

                options.DescribeAllParametersInCamelCase(); 
            });
        }

        public static void AddApiVersioningExtension(this IServiceCollection services)
        {
            services.AddApiVersioning(config =>
            {
                config.DefaultApiVersion = new ApiVersion(1, 0);
                config.AssumeDefaultVersionWhenUnspecified = true;
                config.ReportApiVersions = true;
                config.ApiVersionReader = ApiVersionReader.Combine(
                    new UrlSegmentApiVersionReader(),
                    new HeaderApiVersionReader("X-Api-Version")
                    );
            }).AddApiExplorer(opt =>
            {
                opt.GroupNameFormat = "'v'VVV";
                opt.SubstituteApiVersionInUrl = true;
            });
        }
    }
}
