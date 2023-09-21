using LiteraryWings.ClienteBlazor;
using LiteraryWings.ClienteBlazor.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://www.LiteraryWings.somee.com/api/") });
builder.Services.AddScoped<ILibroService, LibroService>();

builder.Services.AddMudServices(); //Importación de los servicios de MudBlazor

await builder.Build().RunAsync();
