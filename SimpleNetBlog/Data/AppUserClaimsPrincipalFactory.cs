using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using SimpleNetBlog.Models;

namespace SimpleNetBlog.Data
{
    public class AppUserClaimsPrincipalFactory : UserClaimsPrincipalFactory<ApplicationUser>
    {
        public AppUserClaimsPrincipalFactory(UserManager<ApplicationUser> userManager, IOptions<IdentityOptions> optionsAccessor) : base(userManager, optionsAccessor)
        {
        }

        protected override async Task<ClaimsIdentity> GenerateClaimsAsync(ApplicationUser user)
        {
            var identity = await base.GenerateClaimsAsync(user);
            identity.AddClaim(new Claim("DisplayName", user.DisplayName ?? ""));
            return identity;
        }
    }
}