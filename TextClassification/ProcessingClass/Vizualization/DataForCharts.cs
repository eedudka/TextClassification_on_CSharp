using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextClassification.DB_data;

namespace TextClassification.ProcessingClass.Vizualization
{
    public class DataForCharts
    {
        readonly DataBaseContext context = new();

        public Dictionary<string,int> GetAllDataFromDB()
        {

            try {
                var ClassCount = new Dictionary<string, int>();

                var AllClass = context.DocumentClassification.Select(x => x.documentClass).ToList();
                foreach (var el in AllClass)
                {
                    if (!ClassCount.ContainsKey(el)) ClassCount.Add(el, 1);
                    else ClassCount[el]++;
                }

                return ClassCount;
            }
            catch (Exception ex)
            {
                Log log = new();
                log.Add("Вызванна ошибка при составлении выборки для PIECHART", "GetAllDataFromDB");
                return null;
            }
            
        }
        public Dictionary<string,int> GetSelectDataFromDBForPie(DateTime StartDate,DateTime EndDate)
        {
            try {
                var SelectClass = context.DocumentClassification.Where(x => x.dateProcessingDocument.Value.Date >= StartDate.Date)
                                                            .Where(x => x.dateProcessingDocument.Value.Date <= EndDate.Date)
                                                            .Select(x => x.documentClass).ToList();

                Dictionary<string, int> ClassCount = new();

                foreach (var el in SelectClass)
                {
                    if (!ClassCount.ContainsKey(el)) ClassCount.Add(el, 1);
                    else ClassCount[el]++;
                }
                return ClassCount;
            }
            catch (Exception ex)
            {
                Log log = new();
                log.Add("Вызванна ошибка при составлении выборки для PIECHART", "GetSelectDataFromDBForPie");
                return null;
            }
            
        }
        public Dictionary<string, int> GetAllDataFromDBForColumnChart(string ClassName)
        {
            try {
                var SelectClass = context.DocumentClassification.Where(x => x.documentClass == ClassName)
                                                            .Select(x => x.dateProcessingDocument.Value.Date)
                                                            .ToList()
                                                            .ConvertAll<string>(x => x.ToString());

                Dictionary<string, int> ClassCount = new();

                foreach (var el in SelectClass)
                {
                    if (!ClassCount.ContainsKey(el)) ClassCount.Add(el, 1);
                    else ClassCount[el]++;
                }
                return ClassCount;
            }
            catch (Exception ex)
            {
                Log log = new();
                log.Add("Вызванна ошибка при составлении выборки для ColumnChart", "GetAllDataFromDBForColumnChart");
                return null;
            }
            
        }
        public Dictionary<string, int> GetSelectDataFromDBForColumnChart(DateTime StartDate, DateTime EndDate, string ClassName)
        {
            try {
                var SelectClass = context.DocumentClassification.Where(x => x.documentClass == ClassName)
                                                            .Where(x => x.dateProcessingDocument.Value.Date >= StartDate.Date)
                                                            .Where(x => x.dateProcessingDocument.Value.Date <= EndDate.Date)
                                                            .Select(x => x.dateProcessingDocument.Value.Date)
                                                            .ToList()
                                                            .ConvertAll<string>(x => x.ToString());

                Dictionary<string, int> ClassCount = new();

                foreach (var el in SelectClass)
                {
                    if (!ClassCount.ContainsKey(el)) ClassCount.Add(el, 1);
                    else ClassCount[el]++;
                }
                return ClassCount;
            }
            catch (Exception ex)
            {
                Log log = new();
                log.Add("Вызванна ошибка при составлении выборки для ColumnChart", "GetSelectDataFromDBForColumnChart");
                return null;
            }
            
        }
    }
}
