using Aspose.Tasks.Saving;
using Aspose.Tasks.Visualization;

namespace AsposeTest
{
    public class GanttChartOptions
    {
        private readonly ImageSaveOptions _options;

        public GanttChartOptions()
        {
            _options = new ImageSaveOptions(SaveFileFormat.Jpeg)
            {
                RenderToSinglePage = true,
                BarStyles = new List<BarStyle>(),
                PresentationFormat = PresentationFormat.GanttChart,
                LegendOnEachPage = false,
                RollUpGanttBars = false,
                UseGradientBrush = false,
                DrawNonWorkingTime = true,
                Timescale = Timescale.DefinedInView,
                FitContent = true,
                HorizontalResolution = 300,
                VerticalResolution = 300
            };
        }

        public SaveOptions GetOptions()
        {
            return _options;
        }
    }
}
