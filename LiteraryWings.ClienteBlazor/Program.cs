using LiteraryWings.ClienteBlazor;
using LiteraryWings.ClienteBlazor.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://www.LiteraryWings.somee.com/api/") });
builder.Services.AddScoped<ILibroService, LibroService>();
builder.Services.AddScoped<ISugerenciaService, SugerenciaService>();
<<<<<<< HEAD
builder.Services.AddScoped<IEditorialService, EditorialService>();
=======
builder.Services.AddScoped<ICategoriaService, CategoriaService>();
>>>>>>> 9af8463d861d433401d11622279722c4815900c7

builder.Services.AddMudServices(); //Importación de los servicios de MudBlazor

await builder.Build().RunAsync();
