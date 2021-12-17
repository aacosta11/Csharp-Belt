using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Csharp_Belt.Models;
namespace Csharp_Belt
{
    public class Startup
    {
        public IConfiguration Configuration {get;}
        public Startup (IConfiguration conf) {Configuration = conf;}
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<Context>(options=>options.UseMySql(Configuration["DBInfo:ConnectionString"]));
            services.AddSession();
            services.AddMvc(options=>options.EnableEndpointRouting = false);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())  app.UseDeveloperExceptionPage();
            app.UseStaticFiles();
            app.UseSession();
            app.UseMvc();
        }
    }
}
