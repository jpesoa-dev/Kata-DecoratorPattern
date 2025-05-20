namespace Kata_Decorator._7_ReportGeneration
{
    public abstract class ReportDecorator : Report
    {
        protected Report report;

        public ReportDecorator(Report report)
        {
            this.report = report;
        }

        public virtual void Generate()
        {
            report.Generate();
        }
    }
}
