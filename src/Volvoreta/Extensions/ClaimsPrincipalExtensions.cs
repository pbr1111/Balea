﻿using System.Collections.Generic;
using System.Linq;

namespace System.Security.Claims
{
    public static class ClaimsPrincipalExtensions
    {
        public static string GetSubjectId(this ClaimsPrincipal principal)
        {
            var claim = principal.FindFirst(Volvoreta.Claims.Subject);

            if (claim == null)
            {
                throw new InvalidOperationException("sub claim is missing");
            }
            
            return claim.Value;
        }

        public static IEnumerable<string> GetClaimRoleValues(this ClaimsPrincipal principal)
        {
            return principal.FindAll(ClaimTypes.Role).Select(x => x.Value);
        }
    }
}
