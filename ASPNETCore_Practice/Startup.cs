using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoggerService;
using NLog;
using AutoMapper;
using System.IO;
using ASPNETCore_Practice.Services.IServices;
using ASPNETCore_Practice.Services;
using ASPNETCore_Practice.Models.DTO;

namespace ASPNETCore_Practice
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
            services.AddAutoMapper(typeof(Startup));
            services.AddControllers();
            //DI
            services.AddScoped<IAirportService, FakeAirportService>();
            services.AddScoped<IBookingService, FakeBookingService>();
            services.AddScoped<IClientService, FakeClientService>();
            services.AddScoped<IÑountryService, FakeCountryService>();
            services.AddScoped<IFlightService, FakeFlightService>();
            services.AddScoped<IFlightStatusService, FakeFlightStatusService>();
            services.AddScoped<IFlightSeatPriceService, FakeFlightSeatPriceService>();

            //services.AddScoped<IAirportRepository, AirportRepository>();
             
            services.AddScoped<ILoggerManager, LoggerManager>();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ASPNETCore_Practice", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            LogManager.LoadConfiguration(string.Concat(Directory.GetCurrentDirectory(), "/nlog.config"));

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ASPNETCore_Practice v1"));
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
