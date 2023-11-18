using System.Linq;

namespace Providers;
//namespace Client.Providers;

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
		var claimsIdentity =
			new System.Security.Claims
			.ClaimsIdentity(authenticationType: "googooli");

		// دستور ذیل کار می‌کند
		//var claimsIdentity =
		//	new System.Security.Claims.ClaimsIdentity
		//	(claims: claims, authenticationType: "googooli");
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

//		claim = new System.Security.Claims.Claim
//			(type: System.Security.Claims.ClaimTypes.Name, value: "DariushTasdighi");

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

//		//claim = new System.Security.Claims.Claim
//		//	(type: "Name", value: "DariushTasdighi");

//		claim = new System.Security.Claims.Claim
//			(type: System.Security.Claims.ClaimTypes.Name, value: "DariushTasdighi");

//		claims.Add(item: claim);

//		claim = new System.Security.Claims.Claim
//			(type: System.Security.Claims.ClaimTypes.Role, value: "Administrator");

//		claims.Add(item: claim);

//		//claim = new System.Security.Claims.Claim
//		//	(type: System.Security.Claims.ClaimTypes.Role, value: "Supervisor");

//		//claims.Add(item: claim);
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
///// Solution (4)
/////
///// Note:
/////
/////		Name = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name"
/////		Role = "http://schemas.microsoft.com/ws/2008/06/identity/claims/role";
/////
/////	https://www.javaguides.net/p/online-jwt-generator.html
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

//		//string? jwtToken = null;
//		//string? jwtToken = "";
//		//string? jwtToken = "     ";

//		// Just Name and Role
//		//string? jwtToken = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJJc3N1ZXIgKGlzcykiOiJJc3N1ZXIiLCJJc3N1ZWQgQXQgKGlhdCkiOiIyMDIzLTExLTE4VDA2OjQxOjA5LjE4OVoiLCJFeHBpcmF0aW9uIFRpbWUgKGV4cCkiOiIyMDIzLTExLTE4VDA3OjQxOjA5LjE4OVoiLCJTdWJqZWN0IChzdWIpIjoiU3ViamVjdCIsIlVzZXJuYW1lIChhdWQpIjoiSmF2YUd1aWRlcyIsIlJvbGUiOiJBRE1JTiIsIk5hbWUiOiJEYXJpdXNoIn0.y4h6L58ox4xE976opW3fq_vbTaGQ02taHuvHtvJHK4g";

//		// Name and Role with schemas
//		string? jwtToken = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJJc3N1ZXIgKGlzcykiOiJJc3N1ZXIiLCJJc3N1ZWQgQXQgKGlhdCkiOiIyMDIzLTExLTE4VDA2OjQxOjA5LjE4OVoiLCJFeHBpcmF0aW9uIFRpbWUgKGV4cCkiOiIyMDIzLTExLTE4VDA3OjQxOjA5LjE4OVoiLCJTdWJqZWN0IChzdWIpIjoiU3ViamVjdCIsIlVzZXJuYW1lIChhdWQpIjoiSmF2YUd1aWRlcyIsImh0dHA6Ly9zY2hlbWFzLm1pY3Jvc29mdC5jb20vd3MvMjAwOC8wNi9pZGVudGl0eS9jbGFpbXMvcm9sZSI6IkFkbWluaXN0cmF0b3IiLCJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoiRGFyaXVzaCJ9.FKH-GWnFRjxs5AKhI_ERMxNmg3mtM60xd9-wooevvgU";

//		var claims =
//			ParseClaimsFromJwtToken(jwtToken: jwtToken);

//		System.Security.Claims.ClaimsIdentity claimsIdentity;

//		if(claims is null)
//		{
//			// Anonymous
//			claimsIdentity =
//				new System.Security.Claims.ClaimsIdentity();
//		}
//		else
//		{
//			claimsIdentity =
//				new System.Security.Claims.ClaimsIdentity
//				(claims: claims, authenticationType: "googooli");
//		}

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

//	/// <summary>
//	/// Created by Mr. Steve Sanderson
//	/// </summary>
//	private static System.Collections.Generic.IEnumerable
//		<System.Security.Claims.Claim>? ParseClaimsFromJwtToken(string? jwtToken)
//	{
//		if (string.IsNullOrWhiteSpace(value: jwtToken))
//		{
//			return null;
//		}

//		var payload = jwtToken.Split('.')[1];

//		var jsonBytes = ParseBase64WithoutPadding(base64: payload);

//		var keyValuePairs = System.Text.Json.JsonSerializer.Deserialize
//			<System.Collections.Generic.Dictionary<string, object>>(jsonBytes);

//		if (keyValuePairs is null)
//		{
//			return null;
//		}

//		// **************************************************
//		var result =
//			new System.Collections.Generic.List
//			<System.Security.Claims.Claim>();

//		foreach (var keyValuePair in keyValuePairs)
//		{
//			var key = keyValuePair.Key;

//			var keyValuePairValue = keyValuePair.Value is null ?
//				string.Empty : keyValuePair.Value.ToString();

//			string value = string.Empty;

//			if (keyValuePairValue is not null)
//			{
//				value = keyValuePairValue.ToString();
//			}

//			var claim =
//				new System.Security.Claims
//				.Claim(type: key, value: value);

//			result.Add(item: claim);
//		}
//		// **************************************************

//		// **************************************************
//		//var result =
//		//	keyValuePairs.Select(current =>
//		//		new System.Security.Claims.Claim
//		//		(current.Key, current.Key.ToString()));
//		// **************************************************

//		return result;
//	}

//	/// <summary>
//	/// Created by Mr. Steve Sanderson
//	/// </summary>
//	private static byte[] ParseBase64WithoutPadding(string base64)
//	{
//		switch (base64.Length % 4)
//		{
//			case 2:
//			{
//				base64 += "==";
//				break;
//			}

//			case 3:
//			{
//				base64 += "=";
//				break;
//			}
//		}

//		var result =
//			System.Convert.FromBase64String(s: base64);

//		return result;
//	}
//}
