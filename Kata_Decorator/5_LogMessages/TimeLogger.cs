namespace Kata_Decorator._5_LogMessages
{
    public class TimeLogger : LoggerDecorator
    {
        public TimeLogger(Logger logger) : base(logger) { }

        public override void Log(string message)
        {
            string time = DateTime.Now.ToString("HH:mm:ss");
            base.Log($"[{time}] {message}");
        }
    }
}
