using Blazored.LocalStorage;
using BookStoreApi.Blazor.WebAssembly.UI.Services.Authentication;
using BookStoreApi.Blazor.WebAssembly.UI;
using BookStoreApi.Blazor.WebAssembly.UI.Configurations;
using BookStoreApi.Blazor.WebAssembly.UI.Providers;
using BookStoreApi.Blazor.WebAssembly.UI.Services;
using BookStoreApi.Blazor.WebAssembly.UI.Services.Base;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7215") });

builder.Services.AddBlazoredLocalStorage();

builder.Services.AddScoped<ApiAuthenticationStateProvider>();
builder.Services.AddScoped<AuthenticationStateProvider>(p =>
                p.GetRequiredService<ApiAuthenticationStateProvider>());
builder.Services.AddAuthorizationCore();

builder.Services.AddScoped<IClient, Client>();
builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();
builder.Services.AddScoped<IAuthorService, AuthorService>();
builder.Services.AddScoped<IBookService, BookService>();

builder.Services.AddAutoMapper(typeof(MapperConfig));

await builder.Build().RunAsync();
