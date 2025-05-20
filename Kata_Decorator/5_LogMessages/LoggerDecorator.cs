namespace Kata_Decorator._5_LogMessages
{
    public abstract class LoggerDecorator : Logger
    {
        protected Logger logger;

        public LoggerDecorator(Logger logger)
        {
            this.logger = logger;
        }

        public virtual void Log(string message)
        {
            logger.Log(message);
        }
    }
}
