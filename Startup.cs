using LmsApi.DataAccessLayer_;
using LmsApi.Helper;
using LmsApi.Repository.Crud;
using LmsApi.Repository.Employee;
using LmsApi.Repository.Leave;
using LmsApi.Repository.Manager;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LmsApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
           services.AddAutoMapper(typeof(LeaveMapper));
            //services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddScoped<ILeave, LeaveRepo>();
            services.AddScoped<ICrud, CrudRepo>();
            services.AddScoped<IManager, ManagerRepo>();
            services.AddScoped<IEmployee, EmployeeRepo>();
            services.AddCors(option => option.AddDefaultPolicy(b => b.WithOrigins("*").AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin()));
            services.AddDbContextPool<DataAccessLayer_LMS>(options => options.UseSqlServer(Configuration.GetConnectionString("MYConnection")));

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "LmsApi", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "LmsApi v1"));
            }
        
            app.UseRouting();

            app.UseAuthorization();
            app.UseCors();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
