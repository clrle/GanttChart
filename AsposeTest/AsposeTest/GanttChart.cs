using Aspose.Tasks.Visualization;
using Aspose.Tasks;

namespace AsposeTest
{
    public class GanttChart
    {
        private readonly Project _project;
        private readonly GanttChartOptions _ganttChartOptions;

        public GanttChart()
        {
            _ganttChartOptions = new GanttChartOptions();
            _project = new Project { CalculationMode = CalculationMode.None };
        }

        public void CreateProject(DateTime startDate, int duration)
        {
            CreateGanttChartView();

            _project.Set(Prj.DateFormat, DateFormat.Custom);
            _project.Set(Prj.DurationFormat, TimeUnitType.Month);
            _project.Set(Prj.CustomDateFormat, "dd.MM.yyyy");
            _project.Set(Prj.StartDate, startDate);
            _project.Set(Prj.TimescaleFinish, startDate.AddMonths(duration));
        }

        private void CreateGanttChartView()
        {
            var view = new GanttChartView
            {
                MiddleTimescaleTier = new TimescaleTier(),
                BottomTimescaleTier = new TimescaleTier()
            };

            view.MiddleTimescaleTier.Count = 1;
            view.MiddleTimescaleTier.Unit = TimescaleUnit.Years;
            view.MiddleTimescaleTier.Label = DateLabel.YearYyyy;
            view.MiddleTimescaleTier.ShowTicks = true;
            view.MiddleTimescaleTier.UsesFiscalYear = true;

            view.BottomTimescaleTier.Unit = TimescaleUnit.Months;
            view.BottomTimescaleTier.Label = DateLabel.MonthMmm;
            view.BottomTimescaleTier.Count = 1;
            view.BottomTimescaleTier.ShowTicks = true;

            _project.Views.Add(view);
        }

        public MemoryStream Save()
        {
            var options = _ganttChartOptions.GetOptions();
            var memoryStream = new MemoryStream();
            _project.Save(memoryStream, options);

            return memoryStream;
        }
    }
}
