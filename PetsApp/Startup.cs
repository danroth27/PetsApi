using Microsoft.AspNetCore.Blazor.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;

namespace PetsApp
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton(sp =>
                new PetsClient.Client(
                    baseUrl: "https://localhost:44343/",
                    sp.GetRequiredService<HttpClient>()));
        }

        public void Configure(IBlazorApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
