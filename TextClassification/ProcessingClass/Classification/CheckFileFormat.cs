using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using SautinSoft;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextClassification.ProcessingClass.Classification
{
    internal class CheckFileFormat
    {
        private string getingText { get; set; }
        protected string fileExtension { get; private set; }
        protected string GetTextFromFile(string LoadFile)
        {
            PdfFocus ReadPDF = new PdfFocus();
            
            try
            {
                if (Path.GetExtension(LoadFile) == ".txt")
                {
                    fileExtension = Path.GetExtension(LoadFile);
                    getingText = File.ReadAllText(LoadFile);
                }
                if (Path.GetExtension(LoadFile) == ".docx")
                {
                    using (WordprocessingDocument ReadDoc = WordprocessingDocument.Open(LoadFile, false))
                    {
                        fileExtension = Path.GetExtension(LoadFile);
                        Body docBody = ReadDoc.MainDocumentPart.Document.Body;
                        getingText = docBody.InnerText.ToString();
                    } 
                }
                if (Path.GetExtension(LoadFile) == ".pdf")
                {
                    fileExtension = Path.GetExtension(LoadFile);
                    ReadPDF.OpenPdf(File.ReadAllBytes(LoadFile));
                    getingText =ReadPDF.ToText();
                }
            }
            catch(Exception ex)
            {
                Log log = new();
                log.Add("Вызванна ошибка при получении текста из файла", "GetTextFromFile");
            }
            return getingText;
        }

    }
}
