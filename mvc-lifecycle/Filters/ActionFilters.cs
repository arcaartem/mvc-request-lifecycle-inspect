using Microsoft.AspNetCore.Mvc.Filters;

namespace mvc_lifecycle.Filters
{
    public class ActionFilterBase : FilterBase, IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            Executing(context.HttpContext.Request.Path);
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            Executed(context.HttpContext.Request.Path);
        }
    }
    
    public class ActionFilter1 : ActionFilterBase
    {
    }
    
    public class ActionFilter2 : ActionFilterBase
    {
    }
}