using LiveChartsCore.Defaults;
using LiveChartsCore.Kernel;
using LiveChartsCore.SkiaSharpView;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace TextClassification.ProcessingClass.Vizualization
{
    public class CreateChart
    {
        public List<PieSeries<int>> BuildPieData(Dictionary<string,int> PieData)
        {
            Form1 Format = new Form1();
            try 
            {
                var PieChartSeries = new List<PieSeries<int>>();
                foreach (var el in PieData.Keys)
                {
                    PieChartSeries.Add(new PieSeries<int>
                    {
                        Values = new int[] { PieData[el] },
                        Name = Format.ChangeClassValueFormat(int.Parse(el))
                    });
                }

                return PieChartSeries;
            }
            catch (Exception ex)
            {
                Log log = new();
                log.Add("Вызванна ошибка при построении PIECHART", "BuildPieData");
                return null;
            }
            

        }
        public List<ColumnSeries<DateTimePoint>> BuildColumnChartData(Dictionary<string, int> ColumnChartData)
        {
            try 
            {
                var ColumnSeries = new List<ColumnSeries<DateTimePoint>>();
                foreach (var Date in ColumnChartData)
                {
                    int year = int.Parse(Date.Key.Split('.', ' ')[2]);
                    int month = int.Parse(Date.Key.Split('.')[1]);
                    int day = int.Parse(Date.Key.Split('.')[0]);

                    ColumnSeries.Add(new ColumnSeries<DateTimePoint>
                    {
                        TooltipLabelFormatter =
                        chartPoint => $"{new DateTime((long)chartPoint.SecondaryValue):MMMM dd}: {chartPoint.PrimaryValue}",
                        Values = new ObservableCollection<DateTimePoint> { new DateTimePoint(new DateTime(year, month, day), Date.Value) }

                    });
                }

                return ColumnSeries;
            }
            catch (Exception ex)
            {
                Log log = new();
                log.Add("Вызванна ошибка при построении ColumnChart", "BuildColumnChartData");
                return null;
            }
            
        }

        
        
    }
}
