using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextClassification.ProcessingClass.SplitFilesIntoFolder
{
    public class SplitFile
    {
        public void Split(DataGridView DGV)
        {
            for (int i = 0; i < DGV.RowCount; i++)
            {
                var Parant = Directory.GetParent(DGV.Rows[0].Cells[6].Value.ToString());
                var Directories = Path.GetFileNameWithoutExtension(Parant.FullName);
                var NewFolder = Directory.CreateDirectory(Parant + "\\" + Directories + DateTime.Now.ToShortDateString() + "\\" + DGV.Rows[i].Cells[1].Value.ToString()).FullName;
                FileCopyToNewDirectory(DGV.Rows[i].Cells[6].Value.ToString(), NewFolder);
            }


        }
        public void FileCopyToNewDirectory(string FileName,string NewFolder)
        {
            File.Create(NewFolder+"\\"+Path.GetFileName(FileName)).Dispose();
            File.Copy(FileName, NewFolder + "\\" + Path.GetFileName(FileName),true);
        }


    }
}
