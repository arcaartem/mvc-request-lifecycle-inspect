using System.Diagnostics;

namespace mvc_lifecycle.Filters
{
    public class FilterBase
    {
        private readonly ConsoleLogger _logger;

        protected FilterBase() => _logger = new ConsoleLogger();

        protected void Executing(string path) => _logger.IndentAndLog(CreateMessage(path));
        
        protected void Executed(string path) => _logger.OutdentAndLog(CreateMessage(path));
        
        protected void Execute(string path) => _logger.Log(CreateMessage(path));
        
        private string CreateMessage(string path)
        {
            var typeName = GetType().Name;
            var stackTrace = new StackTrace();
            var methodName = stackTrace.GetFrame(2).GetMethod().Name;
            var message = $"{typeName}.{methodName} (Path: {path})";
            return message;
        }
    }
}