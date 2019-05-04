using GarageApi.Business;
using GarageApi.Business.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using Microsoft.Extensions.Logging.Debug;

namespace GarageApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<DataAccess>(opts => opts
                .UseLoggerFactory(new LoggerFactory(new[] {new DebugLoggerProvider()}))
                .UseSqlServer("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=Garage;Integrated Security=SSPI"));

            services.AddScoped<IDataAccess, DataAccess>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseExceptionHandlingMiddleware();

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
