using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Checker.Services;
using Checker;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddSessionStorageServices();
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddScoped<FetchService>();


await builder.Build().RunAsync();
