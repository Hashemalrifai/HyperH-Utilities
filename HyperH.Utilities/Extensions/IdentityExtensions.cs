using System;
using System.Security.Claims;
using System.Security.Principal;


namespace HyperH.Utilities.Extensions
{
	public class IdentityExtensions
	{
		public static string GetUserId(ClaimsPrincipal identity)
		{
			return identity.FindFirstValue(ClaimTypes.NameIdentifier);
        }
	}
}

