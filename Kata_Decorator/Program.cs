using Kata_Decorator._5_LogMessages;
using Kata_Decorator._7_ReportGeneration;

class Program
{
    static void Main(string[] args)
    {
        #region Kata 5: LogMessages

        Console.WriteLine("Kata 5: LogMessages");

        Logger logger = new BasicLogger();

        logger = new DateLogger(logger);
        logger = new TimeLogger(logger);
        logger = new SeverityLogger(logger, "ERROR");

        logger.Log("Mensaje de error");

        #endregion

        Console.WriteLine("\n" + "=====================================" + "\n");

        #region Kata 7: ReportGeneration

        Console.WriteLine("Kata 7: ReportGeneration");

        Report report = new BasicReport();

        report = new HeaderDecorator(report, "Reporte Anual");
        report = new FooterDecorator(report, "Página 1");
        report = new WatermarkDecorator(report, "Confidencial");

        report.Generate();

        #endregion
    }
}