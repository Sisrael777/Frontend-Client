using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using VideoDa.ClienteBlazor;
using VideoDa.ClienteBlazor.Services;



var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7163/api/") });
builder.Services.AddScoped<IProductoServices, ProductoServices>();
builder.Services.AddScoped<IConsolaServices, ConsolaServices>();

builder.Services.AddScoped<IArticuloServices, ArticuloServices>();

builder.Services.AddScoped<ICategoriaServices,CategoriaServices>();

builder.Services.AddMudServices();//Importacion de los servicios de MudBlazor
await builder.Build().RunAsync();
