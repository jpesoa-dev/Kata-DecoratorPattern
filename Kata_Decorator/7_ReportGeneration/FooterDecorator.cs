namespace Kata_Decorator._7_ReportGeneration
{
    public class FooterDecorator : ReportDecorator
    {
        private string footer;

        public FooterDecorator(Report report, string footer) : base(report)
        {
            this.footer = footer;
        }

        public override void Generate()
        {
            base.Generate();
            Console.WriteLine($"Pie de página: {footer}");
        }
    }
}
