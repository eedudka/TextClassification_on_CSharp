using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TextClassification.DB_data;

namespace TextClassification.ProcessingClass.dbComand
{
    public class dbLoadDocument
    {
        public async void AddToDbNewDoc(string DocPath, string DocClass,string DocLang)
        {
            try {

                if (!isDuplicat(DocPath))
                {
                    using (DataBaseContext DBcontext = new())
                    {
                        SaveClasificationOnDB DocumentAdd = new()
                        {
                            documentName = Path.GetFileNameWithoutExtension(DocPath),
                            documentClass = DocClass,
                            dateProcessingDocument = DateTime.Now,
                            dateCreateDocument = File.GetCreationTime(DocPath),
                            UserName = Environment.UserName,
                            DocLang = DocLang
                        };
                        await DBcontext.DocumentClassification.AddRangeAsync(DocumentAdd);
                        await DBcontext.SaveChangesAsync();
                    }
                }
            }
            catch (Exception ex)
            {
                Log log = new();
                log.Add("Вызванна ошибка при добавлении в БД", "AddToDbNewDoc");
               
            }
            

        }

        public bool isDuplicat(string DocPath)
        {
            DataBaseContext _context = new DataBaseContext();
            try
            {
                var FindDoc = _context.DocumentClassification.First(x => x.documentName == Path.GetFileNameWithoutExtension(DocPath));
                return true;
            }
            catch { return false; }

        }
    }

}
