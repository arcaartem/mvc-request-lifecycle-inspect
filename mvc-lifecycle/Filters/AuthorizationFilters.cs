using Microsoft.AspNetCore.Mvc.Filters;

namespace mvc_lifecycle.Filters
{
    public class AuthorizationFilterBase : FilterBase, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            Execute(context.HttpContext.Request.Path);
        }
    }
    
    public class AuthorizationFilter1 : AuthorizationFilterBase
    {
    }
    
    public class AuthorizationFilter2 : AuthorizationFilterBase
    {
    }
}