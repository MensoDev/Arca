using Arca;
using Arca.IoC;
using Arca.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;


var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddMudServices();
builder.Services.AddArcaServices("Data Source=ArcaMemoryDb;Mode=Memory;Cache=Shared");

builder.Services.AddScoped<IPdfService, PdfService>();
builder.Services.AddScoped<IBrokerageNoteService, BrokerageNoteService>();

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
