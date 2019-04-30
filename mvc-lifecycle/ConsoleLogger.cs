using System;

namespace mvc_lifecycle
{
    public class ConsoleLogger
    {
        private static int _indentationLevel;

        public void Log(string message)
        {
            var timestamp = DateTime.Now.ToString("O");
            var indentation = "".PadLeft(_indentationLevel * 4);
            var logLine = $"[{timestamp}] - {indentation}{message}";
            Console.WriteLine(logLine);
        }

        public void IndentAndLog(string message)
        {
            Indent();
            Log(message);
        }

        public void OutdentAndLog(string message)
        {
            Log(message);
            Outdent();
        }

        private void Indent()
        {
            _indentationLevel++;
        }

        private void Outdent()
        {
            if (_indentationLevel > 0)
                _indentationLevel--;
        }
    }
}