namespace Kata_Decorator._7_ReportGeneration
{
    public class HeaderDecorator : ReportDecorator
    {
        private string header;

        public HeaderDecorator(Report report, string header) : base(report)
        {
            this.header = header;
        }

        public override void Generate()
        {
            Console.WriteLine($"Encabezado: {header}");
            base.Generate();
        }
    }
}
