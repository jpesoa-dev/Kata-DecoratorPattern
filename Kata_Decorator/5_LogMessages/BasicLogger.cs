namespace Kata_Decorator._5_LogMessages
{
    public class BasicLogger : Logger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
