namespace Kata_Decorator._7_ReportGeneration
{
    public class WatermarkDecorator : ReportDecorator
    {
        private string watermark;

        public WatermarkDecorator(Report report, string watermark) : base(report)
        {
            this.watermark = watermark;
        }

        public override void Generate()
        {
            base.Generate();
            Console.WriteLine($"Marca de agua: {watermark}");
        }
    }
}
