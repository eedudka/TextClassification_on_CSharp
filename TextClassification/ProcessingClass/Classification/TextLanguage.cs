using NTextCat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextClassification.ProcessingClass.Classification
{
    internal class TextLanguage : CheckFileFormat
    {
        private string Language { get; set; }
        protected string GetTextLanguage(string Text)
        {
            try 
            {
                var factory = new RankedLanguageIdentifierFactory();
                var identifier = factory.Load(Application.StartupPath + @"/LanguageModels/Core14.profile.xml");
                var languages = identifier.Identify(Text.ToString());
                var mostCertainLanguage = languages.FirstOrDefault();
                if (mostCertainLanguage.Item1.Iso639_2T == "eng")
                {
                    Language = "Английский";
                }
                if (mostCertainLanguage.Item1.Iso639_2T == "rus")
                {
                    Language = "Русский";
                }
                return Language;
            }
            catch(Exception ex) 
            {
                Log log = new();
                log.Add("Вызванна ошибка при определении языка", "GetTextLanguage");
                return string.Empty;
            }
            

        }


    }
}
