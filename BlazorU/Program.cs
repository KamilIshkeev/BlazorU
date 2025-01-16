using BlazorU;
using BlazorU.ApiRequest;
using BlazorU.ApiRequest.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Http;


var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7088/") });/*builder.HostEnvironment.BaseAddress*/ 

builder.Services.AddScoped<ApiRequestService>();


await builder.Build().RunAsync();
