namespace Kata_Decorator._5_LogMessages
{
    public class SeverityLogger : LoggerDecorator
    {
        private string severity;

        public SeverityLogger(Logger logger, string severity) : base(logger)
        {
            this.severity = severity.ToUpper();
        }

        public override void Log(string message)
        {
            base.Log($"[{severity}] {message}");
        }
    }
}
