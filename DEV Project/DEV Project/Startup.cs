using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DEV_DataAccess.Entities;
using DEV_DataAccess.Repository;
using DEV_Library.Interface;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;


namespace DEV_Project
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        readonly string AllMyOrigins = "_allMyOrigins";

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            string connectionString = Configuration.GetConnectionString("DefaultConnection");

            //register db Context
            services.AddDbContext<DEVContext>(options =>
                options.UseSqlServer(connectionString));

            //register repos 
            services.AddTransient<IStudentRepository, StudentRepository>();
            services.AddTransient<IInstructorRepository, InstructorRepository>();
            services.AddTransient<ICourseRepository, CourseRepository>();
            services.AddTransient<IRegistrationRepository, RegistrationRepository>();
            services.AddTransient<ITaskRepository, TaskRepository>();

            services.AddControllers(options =>
            {
                /*
                 By default, when the framework detects that the request is coming from a browser:
                        The Accept header is ignored. The content is returned in JSON, unless otherwise configured*/
                options.RespectBrowserAcceptHeader = true; // false by default
            });

          

            services.AddCors(options =>
            {
                options.AddPolicy(AllMyOrigins, b => b.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
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
