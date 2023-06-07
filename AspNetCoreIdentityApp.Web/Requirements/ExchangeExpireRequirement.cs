using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace AspNetCoreIdentityApp.Web.Requirements
{
    public class ExchangeExpireRequirement : IAuthorizationRequirement
    {

    }

    public class ExchangeExpireRequirementHandler : AuthorizationHandler<ExchangeExpireRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, ExchangeExpireRequirement requirement)
        {

            if (!context.User.HasClaim(x => x.Type == "ExhangeExpireDate"))
            {
                context.Fail();
                return Task.CompletedTask;
            }

            var exchangeExpireDate = context.User.FindFirst("ExhangeExpireDate")!;

            if (DateTime.Now > Convert.ToDateTime(exchangeExpireDate.Value))
            {
                context.Fail();
                return Task.CompletedTask;
            }

            context.Succeed(requirement);
            return Task.CompletedTask;

        }
    }
}
