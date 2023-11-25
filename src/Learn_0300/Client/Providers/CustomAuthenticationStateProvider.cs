namespace Providers;
//namespace Client.Providers;

public class CustomAuthenticationStateProvider :
	Microsoft.AspNetCore.Components.Authorization.AuthenticationStateProvider
{
	public CustomAuthenticationStateProvider() : base()
	{
	}

	//public override System.Threading.Tasks.Task
	//	<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>
	//	GetAuthenticationStateAsync()
	//{
	//	throw new System.NotImplementedException();
	//}

	public override async System.Threading.Tasks.Task
		<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>
		GetAuthenticationStateAsync()
	{
		// Anonymous User
		var claimsIdentity =
			new System.Security.Claims.ClaimsIdentity();

		var claimsPrincipal =
			new System.Security.Claims
			.ClaimsPrincipal(identity: claimsIdentity);

		var authenticationState =
			new Microsoft.AspNetCore
			.Components.Authorization
			.AuthenticationState(user: claimsPrincipal);

		var result =
			await
			System.Threading.Tasks.Task
			.FromResult(result: authenticationState);

		return result;
	}
}
