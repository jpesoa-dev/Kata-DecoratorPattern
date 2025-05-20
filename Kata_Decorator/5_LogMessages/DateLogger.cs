namespace Kata_Decorator._5_LogMessages
{
    public class DateLogger : LoggerDecorator
    {
        public DateLogger(Logger logger) : base(logger) { }

        public override void Log(string message)
        {
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            base.Log($"[{date}] {message}");
        }
    }
}
