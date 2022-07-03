using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextClassification.DB_data;

namespace TextClassification.ProcessingClass.Classification
{
    public class DataGridDataAdd
    {
        public void AddData(DataGridView DGV, string DocPath, string DocClass, string DocLang)
        {
            string DataProcess = DateTime.Now.ToShortDateString();
            string DataCreate = File.GetCreationTime(DocPath).ToShortDateString();
            try
            {
                DGV.Rows.Add(
                    Path.GetFileNameWithoutExtension(DocPath),
                    DocClass,
                    DocLang,
                    DataProcess,
                    DataCreate,
                    isDuplicate(DocPath),
                    DocPath
                    );
                
            }
            catch (Exception ex) 
            {
                Log log = new();
                log.Add("Вызванна ошибка при отображении в таблице", "AddData", ex.ToString());
            }
            
        }
        public static string isDuplicate(string DocPath)
        {
            DataBaseContext _context = new();

            try
            {
                var FindDoc = _context.DocumentClassification.First(x => x.documentName == Path.GetFileNameWithoutExtension(DocPath));
                return "Дублируется";
            }
            catch { return "Добавлен"; }
        }
        public static async void ChengeColor(DataGridView DGV)
        {
            for (int i = 0; i < DGV.RowCount; i++)
            {
                if (DGV.Rows[i].Cells[5].Value.ToString() == "Дублируется")
                await Task.Run(() => DGV.Rows[i].Cells[5].Style.BackColor = Color.LightBlue);
            }
        }


    }
}
