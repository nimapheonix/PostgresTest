using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebApplicationPostgresTest.Data;
using WebApplicationPostgresTest.Logic;
using WebApplicationPostgresTest.Repository;

namespace WebApplicationPostgresTest
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
            services.AddDbContext<DatabaseContext>(options =>
            options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection")));


            services.AddMvc();
            // services.AddEntityFrameworkNpgsql().AddDbContext<DatabaseContext>().BuildServiceProvider();
            services.AddScoped<IDeviceRepository, DeviceRepository>();
            services.AddScoped<IDeviceLogic, DeviceLogic>();
            services.AddScoped<IPositionRepository, PositionRepository>();
            services.AddScoped<IPositionLogic, PositionLogic>();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>()
                    .CreateScope())
                {
                    using (var context = serviceScope.ServiceProvider.GetService<DatabaseContext>())
                    {
                        context.Database.EnsureCreated();
                    }
                }

                app.UseDeveloperExceptionPage();
            }
            app.UseMvc();

        }
    }
}
