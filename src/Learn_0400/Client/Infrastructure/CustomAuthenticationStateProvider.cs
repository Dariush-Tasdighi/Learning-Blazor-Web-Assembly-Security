namespace Infrastructure;
//namespace Client.Infrastructure;

/// <summary>
/// Solution (1)
/// </summary>
public class CustomAuthenticationStateProvider :
	Microsoft.AspNetCore.Components.Authorization.AuthenticationStateProvider
{
	public CustomAuthenticationStateProvider() : base()
	{
	}

	public override async System.Threading.Tasks.Task
		<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>
		GetAuthenticationStateAsync()
	{
		// ایجاد یک وقفه تصنعی
		await System.Threading.Tasks.Task
			.Delay(millisecondsDelay: 2000);

		var claims =
			new System.Collections.Generic
			.List<System.Security.Claims.Claim>();

		System.Security.Claims.Claim claim;

		// **************************************************
		claim = new System.Security.Claims
			.Claim(type: "LastName", value: "Tasdighi");

		claims.Add(item: claim);

		claim = new System.Security.Claims
			.Claim(type: "FirstName", value: "Dariush");

		claims.Add(item: claim);
		// **************************************************

		// **************************************************
		// **************************************************
		// **************************************************
		// دستور ذیل کار نمی‌کند
		//var claimsIdentity =
		//	new System.Security.Claims.ClaimsIdentity();

		// دستور ذیل کار نمی‌کند
		//var claimsIdentity =
		//	new System.Security.Claims.ClaimsIdentity(claims: claims);

		// دستور ذیل کار می‌کند
		//var claimsIdentity =
		//	new System.Security.Claims.ClaimsIdentity(authenticationType: "jwt");

		// دستور ذیل کار می‌کند
		var claimsIdentity =
			new System.Security.Claims.ClaimsIdentity
			(claims: claims, authenticationType: "googooli");
		// **************************************************
		// **************************************************
		// **************************************************

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

///// <summary>
///// Solution (2)
///// </summary>
//public class CustomAuthenticationStateProvider :
//	Microsoft.AspNetCore.Components.Authorization.AuthenticationStateProvider
//{
//	public CustomAuthenticationStateProvider() : base()
//	{
//	}

//	public override async System.Threading.Tasks.Task
//		<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>
//		GetAuthenticationStateAsync()
//	{
//		// ایجاد یک وقفه تصنعی
//		await System.Threading.Tasks.Task
//			.Delay(millisecondsDelay: 2000);

//		var claims =
//			new System.Collections.Generic
//			.List<System.Security.Claims.Claim>();

//		System.Security.Claims.Claim claim;

//		// **************************************************
//		claim = new System.Security.Claims
//			.Claim(type: "LastName", value: "Tasdighi");

//		claims.Add(item: claim);

//		claim = new System.Security.Claims
//			.Claim(type: "FirstName", value: "Dariush");

//		claims.Add(item: claim);

//		claim = new System.Security.Claims
//			.Claim(type: System.Security.Claims.ClaimTypes.Name, value: "DariushTasdighi");

//		claims.Add(item: claim);
//		// **************************************************

//		var claimsIdentity =
//			new System.Security.Claims.ClaimsIdentity
//			(claims: claims, authenticationType: "googooli");

//		var claimsPrincipal =
//			new System.Security.Claims
//			.ClaimsPrincipal(identity: claimsIdentity);

//		var authenticationState =
//			new Microsoft.AspNetCore
//			.Components.Authorization
//			.AuthenticationState(user: claimsPrincipal);

//		var result =
//			await
//			System.Threading.Tasks.Task
//			.FromResult(result: authenticationState);

//		return result;
//	}
//}

///// <summary>
///// Solution (3)
///// </summary>
//public class CustomAuthenticationStateProvider :
//	Microsoft.AspNetCore.Components.Authorization.AuthenticationStateProvider
//{
//	public CustomAuthenticationStateProvider() : base()
//	{
//	}

//	public override async System.Threading.Tasks.Task
//		<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>
//		GetAuthenticationStateAsync()
//	{
//		// ایجاد یک وقفه تصنعی
//		await System.Threading.Tasks.Task
//			.Delay(millisecondsDelay: 2000);

//		var claims =
//			new System.Collections.Generic
//			.List<System.Security.Claims.Claim>();

//		System.Security.Claims.Claim claim;

//		// **************************************************
//		claim = new System.Security.Claims
//			.Claim(type: "LastName", value: "Tasdighi");

//		claims.Add(item: claim);

//		claim = new System.Security.Claims
//			.Claim(type: "FirstName", value: "Dariush");

//		claims.Add(item: claim);

//		claim = new System.Security.Claims.Claim
//			(type: System.Security.Claims.ClaimTypes.Name, value: "DariushTasdighi");

//		claims.Add(item: claim);

//		claim = new System.Security.Claims.Claim
//			(type: System.Security.Claims.ClaimTypes.Role, value: "Administrator");

//		claims.Add(item: claim);
//		// **************************************************

//		var claimsIdentity =
//			new System.Security.Claims.ClaimsIdentity
//			(claims: claims, authenticationType: "googooli");

//		var claimsPrincipal =
//			new System.Security.Claims
//			.ClaimsPrincipal(identity: claimsIdentity);

//		var authenticationState =
//			new Microsoft.AspNetCore
//			.Components.Authorization
//			.AuthenticationState(user: claimsPrincipal);

//		var result =
//			await
//			System.Threading.Tasks.Task
//			.FromResult(result: authenticationState);

//		return result;
//	}
//}
