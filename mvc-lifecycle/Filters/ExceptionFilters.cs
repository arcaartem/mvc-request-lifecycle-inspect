using Microsoft.AspNetCore.Mvc.Filters;

namespace mvc_lifecycle.Filters
{
    public class ExceptionFilterBase : FilterBase, IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            Execute(context.HttpContext.Request.Path);
        }
    }
    
    public class ExceptionFilter1 : ExceptionFilterBase
    {
    }
    
    public class ExceptionFilter2 : ExceptionFilterBase
    {
    }
}