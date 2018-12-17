using System.IO;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using noughtsandcrosses.api.Repositories;
using Nancy;
using Nancy.Owin;
using IApplicationBuilder = Microsoft.AspNetCore.Builder.IApplicationBuilder;

namespace noughtsandcrosses.api
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
                .AddJsonFile("appsettings.json")
                .AddEnvironmentVariables();

            config = builder.Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddEntityFrameworkSqlite().AddDbContext<DataContext>();
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
