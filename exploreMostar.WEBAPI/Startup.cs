using AutoMapper;
using exploreMostar.WebAPI.Database;
using exploreMostar.WebAPI.Filters;
using exploreMostar.WebAPI.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exploreMostar.WEBAPI
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
            services.AddMvc(x=>x.Filters.Add<ErrorFilter>()).SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddSwaggerGen();
            // statički konekšn string
            var connection = @"Server=DESKTOP-HB2VMU2\ADNASQLSERVER;Database=exploreMostar;Trusted_Connection=true;ConnectRetryCount=0";
            services.AddDbContext<exploreMostarContext>(options => options.UseSqlServer(connection));
            services.AddScoped<IKorisniciServis, ProizvodServis>();
            services.AddScoped<IKorisniciService, KorisniciService>();
            services.AddScoped<IApartmaniService, ApartmaniService>();
            services.AddScoped<IAtrakcijeService, AtrakcijeService>();
            services.AddScoped<IDodatneOpcijeService, DodatneOpcijeService>();
            services.AddScoped<IDrzaveService, DrzaveService>();
            services.AddScoped<IGradoviService, GradoviService>();
            services.AddScoped<IHoteliService, HoteliService>();
            services.AddScoped<IJelaService, JelaService>();
            services.AddScoped<IKategorijeService, KategorijeService>();
            services.AddScoped<IKorisnickaUlogaService, KorisnickaUlogaService>();
            services.AddScoped<IMarkeriService, MarkeriService>();
            services.AddScoped<IMenuService, MenuService>();
            services.AddScoped<INightClubsService, NightClubsService>();
            services.AddScoped<IPrevozService, PrevozService>();
            services.AddScoped<IRestoraniService, RestoraniService>();

            services.AddAutoMapper();
           


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
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

        }
    }
}
