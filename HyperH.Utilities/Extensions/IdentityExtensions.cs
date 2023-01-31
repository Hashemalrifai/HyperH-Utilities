using System;
using System.Security.Claims;
using System.Security.Principal;


namespace HyperH.Utilities.Extensions
{
	public static class IdentityExtensions
	{
		public static string GetUserId(this ClaimsPrincipal identity)
		{
			return identity.FindFirstValue(ClaimTypes.NameIdentifier);
        }
	}
}

