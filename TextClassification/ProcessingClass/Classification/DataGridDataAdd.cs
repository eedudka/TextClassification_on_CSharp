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
        private DataGridView SelectedDGV;
        private string DocDateCreate { get; set; }
        private string DataProcess { get; set; }

        private DataBaseContext _context = new();

        public DataGridDataAdd(DataGridView _selectedDGV)
        {
            SelectedDGV = _selectedDGV;
        }

        public void AddData(string DocPath, string DocClass, string DocLang)
        {
            
            DataProcess = DateTime.Now.ToShortDateString();
            DocDateCreate = File.GetCreationTime(DocPath).ToShortDateString();
            try
            {
                SelectedDGV.Rows.Add(
                    Path.GetFileNameWithoutExtension(DocPath),
                    DocClass,
                    DocLang,
                    DataProcess,
                    DocDateCreate,
                    isDuplicate(DocPath),
                    DocPath
                    );
               
            }
            catch
            {
                Log log = new();
                log.Add("Вызванна ошибка при отображении в таблице", "AddData");
            }
            
        }
        private string isDuplicate(string DocPath)
        {
            try
            {
                var FindDoc =_context.DocumentClassification.First(x => x.documentName == Path.GetFileNameWithoutExtension(DocPath));
                
                return "Дублируется";
            }
            catch { return "Добавлен"; }
        }
        public async void ChengeColor()
        {
            for (int rowIndex = 0; rowIndex < SelectedDGV.RowCount; rowIndex++)
            {
                if (SelectedDGV.Rows[rowIndex].Cells[5].Value.ToString() == "Дублируется")
                {
                    await Task.Run(() => SelectedDGV.Rows[rowIndex].Cells[5].Style.BackColor = Color.LightBlue);
                }
            }
        }

    }
}
