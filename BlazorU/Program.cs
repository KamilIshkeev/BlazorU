using BlazorU;
using BlazorU.ApiRequest;
using BlazorU.ApiRequest.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using System.Net.Http;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddScoped<ApiRequestService>();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:5205/") });/*builder.HostEnvironment.BaseAddress*/ 
builder.Services.AddScoped<UserService>();



await builder.Build().RunAsync();
