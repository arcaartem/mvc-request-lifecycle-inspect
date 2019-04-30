using Microsoft.AspNetCore.Mvc.Filters;

namespace mvc_lifecycle.Filters
{
    public class ResultFilterBase : FilterBase, IResultFilter
    {
        public void OnResultExecuting(ResultExecutingContext context)
        {
            Executing(context.HttpContext.Request.Path);
        }

        public void OnResultExecuted(ResultExecutedContext context)
        {
            Executed(context.HttpContext.Request.Path);
        }
    }
    
    public class ResultFilter1 : ResultFilterBase
    {
    }
    
    public class ResultFilter2 : ResultFilterBase
    {
    }
}