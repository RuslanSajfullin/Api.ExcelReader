using Entity;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using ParsExcel;
using Syncfusion.XlsIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.ExcelReader
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            using var context = MyDbContext.Create(configuration);
           // context.Database.Migrate();
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            //services.AddDbContext<MyDbContext>(options =>
            //{
            //    options.UseSqlServer(Configuration.GetConnectionString("connectionstring"));
            //}, ServiceLifetime.Transient);

            services.AddEntityFrameworkNpgsql().AddDbContext<MyDbContext>(opt =>
        opt.UseNpgsql(Configuration.GetConnectionString("connectionstring")));

            // services.AddDbContext<MyDbContext>(options =>
            //options.UseNpgsql(Configuration.GetConnectionString("connectionstring")));

            services.AddTransient<MunicipalMovableEstate>();

            services.AddTransient<MunicipalMovableEstateExcelD>();
            services.AddTransient<MunicipalImmovableEstateExcelD2>();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Api.ExcelReader", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Api.ExcelReader v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
