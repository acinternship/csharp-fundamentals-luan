using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Test.Serveces;
using Test.Entities;
using Microsoft.EntityFrameworkCore;

namespace Test
{
    public class Startup
    {
        private object routeBuilder;

        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                           .SetBasePath(env.ContentRootPath)
                           .AddJsonFile("appsettings.json");
            Configuration = builder.Build();
        }

        public IConfiguration Configuration { get; set; }



        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddDbContext<TestDbContext>(options => options.UseSqlServer(Configuration ["Database:connection"]));

            services.AddSingleton(provider => Configuration);
            services.AddSingleton<IGreeter, Greeter>();
            services.AddScoped<IRestaurantData, SqlRestaurantData>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app,
            IHostingEnvironment env,
            ILoggerFactory loggerFactory,
            IGreeter greeter)
        {
            loggerFactory.AddConsole();
            // app.UseIIPlataformHandler();


            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseFileServer();
            app.UseMvc(ConfigureRoute);
           

        }

        private void ConfigureRoute(IRouteBuilder routeBuilder)
        {
            //Home/Index/
            routeBuilder.MapRoute("Default",
                "{controller=Home}/{action=Index}/{id?}");
            

        }

        
        //Entry point for the application.
        /*public static void Main(string[] args) => WebApplication.Run<Startup>
        {

        }*/
    }
}
