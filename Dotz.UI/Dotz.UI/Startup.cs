using Dotz.Infra.Data.Context;
using Dotz.Infra.IoC;
using Dotz.UI.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Configuration;
using System.Text;

namespace Dotz.UI
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
            string connectionStrings = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContextPool<ResgateContext>(options => options
                .UseMySql(connectionStrings, ServerVersion
                .AutoDetect(connectionStrings)));

            InjetorDependencia.Registrar(services);
            //services.AddAutoMapper(x => x.AddProfile(new MappingEntidade()));
            //services.AddMvc();

            services.AddControllers();

            //JWT
            var appSettingsSection = Configuration.GetSection("AppSettings");
            services.Configure<AppSettings>(appSettingsSection);

            var appsSettings = appSettingsSection.Get<AppSettings>();
            var key = Encoding.ASCII.GetBytes(appsSettings.Secret);

            services.AddAuthentication(x =>
            {
                //x.DefaultAuthenticateScheme = JwtBearerDefaults
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
