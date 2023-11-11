using Microsoft.Extensions.DependencyInjection;

var builder =
	Microsoft.AspNetCore.Components.WebAssembly
	.Hosting.WebAssemblyHostBuilder.CreateDefault(args: args);

builder.RootComponents.Add<Client.App>(selector: "#app");

builder.RootComponents.Add<Microsoft.AspNetCore
	.Components.Web.HeadOutlet>(selector: "head::after");

builder.Services.AddOptions();

// If we do not have Policy!
//builder.Services.AddAuthorizationCore();

// If we have Policy!
builder.Services.AddAuthorizationCore(options =>
{
	options.AddPolicy("CanBuy", policy =>
		policy.RequireClaim("Over21"));

	options.AddPolicy("CanDelete", policy =>
		policy.RequireRole("Administrator"));
});

builder.Services.AddScoped
	<Microsoft.AspNetCore.Components.Authorization.AuthenticationStateProvider,
	Infrastructure.CustomAuthenticationStateProvider>();

builder.Services.AddScoped
	(sp => new System.Net.Http.HttpClient
	{
		BaseAddress = new System.Uri
			(uriString: builder.HostEnvironment.BaseAddress),
	});

await builder.Build().RunAsync();
