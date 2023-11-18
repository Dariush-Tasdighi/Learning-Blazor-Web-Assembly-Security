using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.Extensions.DependencyInjection;

var builder =
	Microsoft.AspNetCore.Components.WebAssembly
	.Hosting.WebAssemblyHostBuilder.CreateDefault(args: args);

builder.RootComponents.Add<Client.App>(selector: "#app");

builder.RootComponents.Add<Microsoft.AspNetCore
	.Components.Web.HeadOutlet>(selector: "head::after");

builder.Services.AddOptions();

// New
builder.Services.AddBlazoredLocalStorage();

builder.Services.AddAuthorizationCore(options =>
{
	options.AddPolicy(name: "CanBuy",
		configurePolicy: policy => policy.RequireClaim(claimType: "Over21"));

	options.AddPolicy(name: "CanDelete",
		configurePolicy: policy => policy.RequireRole(roles: "Administrator"));
});

// New
//builder.Services.AddScoped
//	<Microsoft.AspNetCore.Components.Authorization.AuthenticationStateProvider,
//	Providers.CustomAuthenticationStateProvider>();

// New
builder.Services.AddScoped<Providers.CustomAuthenticationStateProvider>();
builder.Services.AddScoped<AuthenticationStateProvider>
	(current => current.GetRequiredService<Providers.CustomAuthenticationStateProvider>());

builder.Services.AddScoped
	(sp => new System.Net.Http.HttpClient
	{
		BaseAddress = new System.Uri
			(uriString: builder.HostEnvironment.BaseAddress),
	});

await builder.Build().RunAsync();
