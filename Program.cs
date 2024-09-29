using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Checker.Services;
using Checker;
using Fluxor;
using Fluxor.Blazor.Web.ReduxDevTools;




var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddSessionStorageServices();
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddFluxor(o =>
{
    o.ScanAssemblies(typeof(Program).Assembly);
    o.UseReduxDevTools();
});


builder.Services.AddScoped<FetchService>();
builder.Services.AddScoped<AuthenticationTocken>();

builder.Logging.SetMinimumLevel(LogLevel.Information);
// Remove the unsupported AddConsole logging provider

await builder.Build().RunAsync();
