using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Microsoft.EntityFrameworkCore;
using Tree.Models;

namespace AnimalShelter
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
            services.AddDbContext<TreesContext>(opt =>
                opt.UseMySql(Configuration["ConnectionStrings:DefaultConnection"], ServerVersion.AutoDetect(Configuration["ConnectionStrings:DefaultConnection"])));

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                    c.SwaggerDoc("v1", new OpenApiInfo { 
                        Title = "AnimalShelter", 
                        Version = "v1",
                        Description = "A simple Animal Shelter API",
                        Contact = new OpenApiContact
                        {
                            Name = "Ben Dunham",
                            Email = "bendunhampdx@gmail.com"
                            Url = new Uri("https://www.linkedin.com/in/ben-dunham-dev/") 
                        },
                        License = new OpenApiLicense
                        {
                        Name = "Use under AFL",
                        Url = new Uri("https://opensource.org/licenses/AFL-3.0"),
                        }
                    });
                });
            services.AddApiVersioning(o =>
            {
                o.ReportApiVersions = true;
                o.AssumeDefaultVersionWhenUnspecified = true;
                o.DefaultApiVersion = new ApiVersion(1, 0);
            });
    }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "AnimalShelter.Solution");
                c.RoutePrefix = string.Empty;
            });

            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    } 
}