using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DTApiLoadCounter.Data;
using DTApiLoadCounter.Data.Repositories;
using DTApiLoadCounter.Domain.Services;
using DTApiLoadCounter.DTO;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Swagger;

namespace DTApiLoadCounter.WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public static string ConnectionString { get; private set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
      
            services.AddOptions();

            services.AddDbContext<DTApiLoadCounterContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"), b => b.UseRowNumberForPaging()));
            services.AddScoped<IDailyJobRepository, DailyJobRepositoryImpl>();
            services.AddScoped<IDailyJobService, DailyJobServiceImpl>();
            services.AddScoped<IDailyJobDriversRepository, DailyJobDriversRepositoryImpl>();
            services.AddScoped<IDailyJobDriversService, DailyJobDriversServiceImpl>();
            services.AddScoped<ICommentsRepository, CommentsRepositoryImpl>();
            services.AddScoped<ICommentsService, CommentsServiceImpl>();
            services.AddScoped<IUnitTypeRepository, UnitTypeRepositoryImpl>();
            services.AddScoped<IUnitTypeService, UnitTypeServiceImpl>();
            services.AddScoped<ISiteRepository, SiteRepositoryImpl>();
            services.AddScoped<ISiteService, SiteServiceImpl>();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "DTApiLoadCounter", Description = "Swagger Core API" });
            });

            var mappingConfig = new MapperConfiguration(mc =>
            {

            });
            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
            app.UseSwagger();
            app.UseSwaggerUI(C =>
            {
                C.SwaggerEndpoint("/swagger/v1/swagger.json", "Core API");
            });

            ConnectionString = Configuration["ConnectionStrings:DefaultConnection"];
        }
    }
}
