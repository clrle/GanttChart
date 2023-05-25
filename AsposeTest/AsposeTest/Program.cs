using Aspose.Tasks.Visualization;
using Aspose.Tasks;
using AsposeTest;
using System.IO;

public class Program
{
    private const string PublicKey = "xy";
    private const string PrivateKey = "yx";

    public static void Main(string[] args)
    {
        var meteredPdf = new Aspose.Pdf.Metered();
        meteredPdf.SetMeteredKey(PublicKey, PrivateKey);
        var meteredTask = new Aspose.Tasks.Metered();
        meteredTask.SetMeteredKey(PublicKey, PrivateKey);

        GanttChart ganttChart = new GanttChart();
        ganttChart.CreateProject(new DateTime(2023, 11, 02), 36);

        var newGanttChart = ganttChart.Save();
        newGanttChart.Position = 0;
        File.WriteAllBytes(@"C:\Temporary\ganttChartFromConsoleApplication.png", newGanttChart.ToArray());
    }
}
