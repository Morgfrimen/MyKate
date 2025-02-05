﻿using DbConnectionLib;

using GrpcService.Service;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace GrpcService
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            _ = services.AddGrpc();
            _ = services.AddDbContext<ContextDb>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment()) _ = app.UseDeveloperExceptionPage();
            _ = app.UseRouting();
            _ = app.UseEndpoints
            (
                endpoints =>
                {
                    _ = endpoints.MapGrpcService<TestConnectionService>();
                    _ = endpoints.MapGrpcService<UsersService>();
                    _ = endpoints.MapGrpcService<MuvoService>();
                    _ = endpoints.MapGet
                    (
                        "/",
                        async context => await context.Response.WriteAsync
                                         (
                                             "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909"
                                         )
                    );
                }
            );
        }
    }
}