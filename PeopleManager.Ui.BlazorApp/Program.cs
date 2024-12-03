using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using PeopleManager.Sdk.Extensions;
using PeopleManager.Ui.BlazorApp;
using PeopleManager.Ui.BlazorApp.Settings;
using PeopleManager.Ui.BlazorApp.Stores;
using Vives.Presentation.Authentication;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

var apiSettings = new ApiSettings();
builder.Configuration.GetSection(nameof(ApiSettings)).Bind(apiSettings);
builder.Services.AddApi(apiSettings.BaseUrl);

builder.Services.AddScoped<IBearerTokenStore, TokenStore>();

builder.Services.AddBlazoredLocalStorage();

await builder.Build().RunAsync();
