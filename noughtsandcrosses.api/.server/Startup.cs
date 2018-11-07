using System.IO;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Nancy;
using Nancy.Owin;
using NoughtsAndCrosses.Server.Src.Repositories;
using IApplicationBuilder = Microsoft.AspNetCore.Builder.IApplicationBuilder;

namespace App.server
{
    public class Startup
    {
        private readonly IConfiguration config;
        public Startup(IHostingEnvironment env)
        {
            using (var client = new DataContext())
            {
                client.Database.EnsureCreated();
            }

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(".server/appsettings.json")
                .AddEnvironmentVariables();

            config = builder.Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddEntityFrameworkSqlite().AddDbContext<DataContext>();
            services.AddMvc();
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader()
                        .AllowCredentials());
            });
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseCors("CorsPolicy");
            app.UseOwin(x => x.UseNancy(opt => opt.Bootstrapper = new DefaultNancyBootstrapper()));
            app.UseDefaultFiles();
            app.UseStaticFiles();
        }
    }
}
