using AutoMapper;
using exploreMostar.Model.Requests;
using exploreMostar.WebAPI.Database;
using exploreMostar.WebAPI.Filters;
using exploreMostar.WebAPI.Security;
using exploreMostar.WebAPI.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            services.AddAutoMapper();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Explore Mostar", Version = "v1" });

                c.AddSecurityDefinition("basic", new OpenApiSecurityScheme
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.Http,
                    Scheme = "basic",
                    In = ParameterLocation.Header,
                    Description = "Basic Authorization header using the Bearer scheme."
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "basic"
                            }
                        },
                        new string[] {}
                    }
                });
            });
            // statički konekšn string
            // var connection =  @"Server=DESKTOP-HB2VMU2\ADNASQLSERVER;Database=exploreMostar;Trusted_Connection=true;ConnectRetryCount=0";
            services.AddAuthentication("BasicAuthentication").AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);

           
            services.AddScoped<IKorisniciService, KorisniciService>();
            services.AddScoped<IDodatneOpcijeService, DodatneOpcijeService>();
            services.AddScoped<IService<Model.KorisnickaUloga, object>, BaseService<Model.KorisnickaUloga,object,KorisnickaUloga>>();
           
           
            services.AddScoped<IMarkeriService, MarkeriService>();
            
        
           
           
            
           
           
          
            services.AddScoped<ICRUDService<Model.Apartmani,ByNameSearchRequest,ApartmaniUpsertRequest, ApartmaniUpsertRequest>,ApartmaniService>();
            services.AddScoped<ICRUDService<Model.Atrakcije, ByNameSearchRequest, AtrakcijeUpsertRequest, AtrakcijeUpsertRequest>, AtrakcijeService>();
            services.AddScoped<ICRUDService<Model.Drzave, ByNameSearchRequest, DrzaveUpsertRequest, DrzaveUpsertRequest>, DrzaveService>();
            services.AddScoped<ICRUDService<Model.Gradovi, ByNameSearchRequest, GradoviUpsertRequest, GradoviUpsertRequest>, GradoviService>();
            services.AddScoped<ICRUDService<Model.Hoteli, ByNameSearchRequest, HoteliUpsertRequest, HoteliUpsertRequest>, HoteliService>();
            services.AddScoped<ICRUDService<Model.Jela, ByNameSearchRequest, JelaUpsertRequest, JelaUpsertRequest>, JelaService>();
            services.AddScoped<ICRUDService<Model.JeloMeni, ByNameSearchRequest, JeloMeniUpsertRequest, JeloMeniUpsertRequest>, JeloMeniService>();
            services.AddScoped<ICRUDService<Model.Kategorije, ByNameSearchRequest, KategorijeUpsertRequest, KategorijeUpsertRequest>, KategorijeService>();
            services.AddScoped<ICRUDService<Model.KorisnikKategorija, ByNameSearchRequest, KorisnikKategorijaUpsertRequest, KorisnikKategorijaUpsertRequest>, KorisnikKategorijaService>();
            services.AddScoped<ICRUDService<Model.Menu, ByNameSearchRequest, MenuUpsertRequest, MenuUpsertRequest>, MenuService>();
            services.AddScoped<ICRUDService<Model.Nightclubs, ByNameSearchRequest, NightClubsUpsertRequest, NightClubsUpsertRequest>, NightClubsService>();
            services.AddScoped<ICRUDService<Model.Prevoz, ByNameSearchRequest, PrevozUpsertRequest, PrevozUpsertRequest>, PrevozService>();
            services.AddScoped<ICRUDService<Model.Restorani, ByNameSearchRequest, RestoraniUpsertRequest, RestoraniUpsertRequest>, RestoraniService>();
            services.AddScoped<ICRUDService<Model.Kafici, ByNameSearchRequest, KaficiUpsertRequest, KaficiUpsertRequest>, KaficiService>();
            services.AddScoped<ICRUDService<Model.Jelovnik, ByNameSearchRequest, JelovnikUpsertRequest, JelovnikUpsertRequest>, JelovnikService>();
            services.AddScoped<ICRUDService<Model.Objava, ByNameSearchRequest, ObjavaUpsertRequest, ObjavaUpsertRequest>, ObjavaService>();
            services.AddScoped<ICRUDService<Model.Poruke, ByNameSearchRequest, PorukeUpsertRequest, PorukeUpsertRequest>, PorukeService>();
            services.AddScoped<ICRUDService<Model.Recenzije, ByNameSearchRequest, RecenzijeUpsertRequest, RecenzijeUpsertRequest>, RecenzijeService>();
            services.AddScoped<ICRUDService<Model.MojiFavoriti, ByNameSearchRequest, MojiFavoritiUpsertRequest, MojiFavoritiUpsertRequest>, MojiFavoritiService>();
            services.AddScoped<ICRUDService<Model.UserActivity, ByNameSearchRequest, UserActivityUpsertRequest, UserActivityUpsertRequest>, UserActivityService>();
            services.AddScoped<ICRUDService<Model.Search, ByNameSearchRequest, SearchUpsertRequest, SearchUpsertRequest>, SearchService>();

            services.AddScoped<IService<Model.KorisnickaUloga, ByNameSearchRequest>, KorisnickaUlogaService>();
            services.AddScoped<IService<Model.VrstaAtrakcija, ByNameSearchRequest>, VrstaAtrakcijaService>();
            services.AddScoped<IService<Model.VrstaRestorana, ByNameSearchRequest>, VrstaRestoranaService>();
            services.AddScoped<IService<Model.KategorijeJela, ByNameSearchRequest>, KategorijeJelaService>();
            services.AddScoped<IService<Model.Uloge, ByNameSearchRequest>, UlogeService>();
            services.AddScoped<IService<Model.KorisniciUloge, ByNameSearchRequest>, KorisniciUlogeService>();
            //.AddScoped<IService<Model.Recenzije, ByNameSearchRequest>, RecenzijeService>();

         


            var connection = Configuration.GetConnectionString("exploreMostar");
            services.AddDbContext<exploreMostarContext>(options => options.UseSqlServer(connection));

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
            app.UseAuthentication();

            //  app.UseHttpsRedirection();
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
