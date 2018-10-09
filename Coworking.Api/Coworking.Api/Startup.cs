using Coworking.Api.Config;
using Coworking.Api.CrossCutting.Middlewares;
using Coworking.Api.CrossCutting.Register;
using Coworking.Api.DataAccess;
using Coworking.Api.DataAccess.Contracts;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Coworking.Api
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
            services.AddScoped<ICoworkingDbContext, CoworkingDbContext>();
            services.AddDbContext<CoworkingDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DataBaseConnection")));

            IOCRegister.AddRegistration(services);
            SwaggerConfing.AddRegistration(services);

            services.AddAuthentication("Bearer")
                .AddIdentityServerAuthentication(options =>
                {
                    options.Authority = "http://localhost:5000/";
                    options.RequireHttpsMetadata = false;
                    options.ApiName = "api1";
                });

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            SwaggerConfing.AddRegistration(app);

            app.UseEjemploMiddleware();
            //app.UseLogMiddleware();

            app.UseAuthentication();

            app.UseMvc();
        }
    }
}
