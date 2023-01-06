using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace ConsoleApp2
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddTransient<CustomMiddelware1>();

        }

        public void Configure(IApplicationBuilder app,IWebHostEnvironment env)
        {
           // app.UseMiddleware<CustomMiddelware1>();
//            app.Map("/aman", CustomCode);
//            if (env.IsDevelopment())
//            {
//                app.UseDeveloperExceptionPage();//Middleware
//            }
////***************************************************
//            app.Use(async (context, next) =>
//            {
//                await context.Response.WriteAsync("Hello Use class 1\n");
//                await next();

//            });
////***************************************************
//            app.Use(async (context, next) =>
//            {
//                await context.Response.WriteAsync("Hello Use class 2\n");
//                await next();

//            });
////****************************************************
//            app.Run(async context =>
//            {
//                await context.Response.WriteAsync("Hello Run Class\n");
//            });

//*****************************************************            
            //app.Run(async context =>
            //{
            //    await context.Response.WriteAsync("Hello Run2");
            //});
//*****************************************************
           
            app.UseRouting();//Enabling Routing
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                //endpoints.MapControllers();
                //endpoints.MapGet("/", async context =>
                //{
                //    await context.Response.WriteAsync("Hello from new web API app");
                //});
                //endpoints.MapGet("/test", async context =>
                //{
                //    await context.Response.WriteAsync("Hello from new web API app test");
                //});

            }); 
        }

        private void CustomCode(IApplicationBuilder app)
        {
            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Hello from aman!!!");
                await next();
            });
        }
    }
} 
