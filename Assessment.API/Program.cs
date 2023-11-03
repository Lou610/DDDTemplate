using Assessment.DataAccessLayer;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.AspNetCore.Mvc;
using Assessment.DataAccessLayer.Interfaces;
using Assessment.DataAccessLayer.Repository;
using Microsoft.EntityFrameworkCore;
using Assessment.DataAccessLayer.Context;
using Assessment.BusinessApplicationLayer.ServiceExtension;
using Assessment.DataAccessLayer.ServiceExtensions;

namespace Assessment.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //Added in the ConfigurationManager so that we can use it to get the DB ConnectionDetails
            ConfigurationManager configuration = builder.Configuration;
            // Policy Name should not be default - MyPolicy
            string? MyAllowSpecificOrigins = "Assessment";

            builder.Services.AddCors(options =>
            {
                options.AddPolicy(name: MyAllowSpecificOrigins,
                                  policy =>
                                  {
                                      policy.WithOrigins("https://localhost:7155", "http://localhost:7155")
                                      .WithHeaders("Access-Control-Allow-Origin: *")
                                      .AllowAnyHeader()
                                      .AllowAnyMethod()
                                      .WithMethods("PUT", "DELETE", "GET", "PATCH", "POST")
                                      .SetIsOriginAllowedToAllowWildcardSubdomains();
                                  });
            });

            // Add services to the container.

            builder.Services.AddControllers();
            
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // For Entity Framework
            builder.Services.AddDbContext<AssessmentDBContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

           

            builder.Services.AddApiVersioning(config =>
            {
                config.DefaultApiVersion = new ApiVersion(1, 0);
                config.AssumeDefaultVersionWhenUnspecified = true;
                config.ReportApiVersions = true;
            });

            // Add ApiExplorer to discover versions
            builder.Services.AddVersionedApiExplorer(setup =>
            {
                setup.GroupNameFormat = "'v'VVV";
                setup.SubstituteApiVersionInUrl = true;
            });

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Version = "v1", Title = "Assessment API V1" });
                c.SwaggerDoc("v2", new OpenApiInfo { Version = "v2", Title = "Assessment API V2" });

            });

            builder.Services.AddDALContext();
            builder.Services.AddBALManagement();


            var app = builder.Build();

            var apiVersionDescriptionProvider = app.Services.GetRequiredService<IApiVersionDescriptionProvider>();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(options =>
                {
                    foreach (ApiVersionDescription apiVersionDescription in apiVersionDescriptionProvider.ApiVersionDescriptions.Reverse())
                    {
                        string isDeprecated = apiVersionDescription.IsDeprecated ? " (DEPRECATED)" : string.Empty;
                        options.SwaggerEndpoint($"{builder.Configuration["PathBase"]}/swagger/{apiVersionDescription.GroupName}/swagger.json",
                            $"{apiVersionDescription.GroupName.ToUpperInvariant()}{isDeprecated}");
                    }
                });
            }

            // Enable Cors though out the Controllers within the API
            app.UseCors(MyAllowSpecificOrigins);

            app.UseHttpsRedirection();

            app.UseAuthentication();

            // Configuring the Authorization Service
            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}