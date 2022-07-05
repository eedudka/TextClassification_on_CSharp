using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextClassification.ProcessingClass.Classification
{
    internal class TextSegmentation : TextLanguage 
    {
        
        public string filePath 
        {
            get;set;
        }
        private string textFromPath 
        { 
            get;
            set;
        }
        public string loadedTextLanguage 
        {
            get; private set;
        }
        private string[] stopWords 
        {
            get;set;
        }
        private string[] tokenizeText 
        { 
            get;
            set;
        }
        private string loadTextFormat
        {
            get { return fileExtension; }
        }

        public string[] GetTokenize()
        {
            var splitSeparator = new char[]
                {
                ',',
                '.',
                ' ',
                '\r',
                '\n',
                ':',
                ')',
                '(',
                '%' ,
                '"',
                '-',
                '�',
                '\t'
                };
            var tempTokenz = Array.Empty<string>();

            TextClear();
            TextNormalizeAsync();

            tempTokenz = textFromPath.ToString()
                                   .Trim()
                                   .Split
                                    (
                                    splitSeparator,
                                    System.StringSplitOptions.RemoveEmptyEntries
                                    );
            if (loadTextFormat == ".pdf")
            {
                tempTokenz = PdfCleaner(tempTokenz);
                return tokenizeText= tempTokenz;
            }

            return tokenizeText = tempTokenz;
        }
        private async void TextNormalizeAsync()
        {
            try
            {
                await File.WriteAllTextAsync("Data/input.txt", textFromPath.ToString(), Encoding.Default);
                using (var MySt = new Process())
                {
                    MySt.StartInfo.FileName = "Data/mystem.exe";
                    MySt.StartInfo.Arguments = "-lc Data/input.txt Data/output.txt";
                    MySt.StartInfo.UseShellExecute = false;
                    MySt.StartInfo.CreateNoWindow = true;
                    MySt.Start();
                    MySt.WaitForExit();
                    MySt.Close();
                }
                var textAfterMyStem =await File.ReadAllTextAsync("Data/output.txt", Encoding.Default);
                foreach (var el in new[] { "{", "}", "|", "?", "??" })
                {
                    textAfterMyStem = textAfterMyStem.Replace(el, "");
                }
                textFromPath = textAfterMyStem;
            }
            catch (Exception ex)
            {
                Log log = new();
                log.Add("Вызванна ошибка при нормализации текста", "TextNormalize");
            }
        }
        private void TextClear()
        {
            try
            {
                textFromPath = GetTextFromFile(filePath);
                loadedTextLanguage = GetTextLanguage(textFromPath);
                if (loadedTextLanguage == "Английский") stopWords = File.ReadAllLines("Data/StopListEng.txt", Encoding.Default);
                if (loadedTextLanguage == "Русский") stopWords = File.ReadAllLines("Data/StopListRus.txt", Encoding.Default);


                if (loadedTextLanguage.Length != 0 && stopWords.Length != 0)
                {
                    string tempText =string.Empty;
                    foreach (var el in stopWords)
                    {
                        tempText = textFromPath.Replace(el, ""); //loadedText=loadedText.Replace(el, "");
                    }
                    textFromPath = tempText;
                }
            }
            catch (Exception ex)
            {
                Log log = new();
                log.Add("Вызванна ошибка при очистки текста", "TextClear");
            }
        }
        private string[] PdfCleaner(string[] tempTokenz)
        {
            var delPdfString = new[]
                {
                    "��",
                    "Copyright  2022 Breitbart",
                    "PDF Focus .Net 8.3.4.19 trial.",
                    "Have questions Email us: support@sautinsoft.com",
                    "Discussions, free help and custom examples for you."
                };
            foreach (var el in delPdfString)
            {
                tempTokenz = tempTokenz.Where(str => str != el).ToArray();
            }
            return tempTokenz;
        }
      
        /*
          public async Task<string> TextNormalize(string Text)
        {
            try
            {
                File.WriteAllText("Data/input.txt", Text, Encoding.Default);

                using (var MySt = new Process())
                {
                    MySt.StartInfo.FileName = "Data/mystem.exe";
                    MySt.StartInfo.Arguments = "-lc Data/input.txt Data/output.txt";
                    MySt.StartInfo.UseShellExecute = false;
                    MySt.StartInfo.CreateNoWindow = true;
                    MySt.Start();
                    MySt.WaitForExit();
                    MySt.Close();
                }
                var TextAfterMyStem =await File.ReadAllTextAsync("Data/output.txt", Encoding.Default);
                var CharForDelete = new string[] { "{", "}", "|", "?", "??" };
                foreach (var el in CharForDelete)
                {
                    TextAfterMyStem = TextAfterMyStem.Replace(el, "");
                }

                return TextAfterMyStem;
            }
            catch (Exception ex)
            {
                Log log = new();
                log.Add("Вызванна ошибка при нормализации текста", "TextNormalize", ex.ToString());
                return null;
            }
        }
        public string[] TextTokenize(string NormalizeText)
        {
            try 
            {
                NormalizeText = NormalizeText.Replace("��", "")
                                             .Replace("Copyright  2022 Breitbart", "")
                                             .Replace("PDF Focus .Net 8.3.4.19 trial.", "")
                                             .Replace("Have questions Email us: support@sautinsoft.com", "")
                                             .Replace("Discussions, free help and custom examples for you.", "");
                var SplitSeparator = new char[] {
                ',',
                '.',
                ' ',
                '\r',
                '\n',
                ':',
                ')',
                '(',
                '%' ,
                '"',
                '-',
                '�',
            };

                var Tokenz = NormalizeText.ToLower()
                                          .Trim()
                                          .Split
                    (
                        SplitSeparator,
                        System.StringSplitOptions.RemoveEmptyEntries
                    );


                return Tokenz;
            }
            catch (Exception ex)
            {
                Log log = new();
                log.Add("Вызванна ошибка при токенизации текста", "TextTokenize", ex.ToString());
                return null;
            }
           
        }
      
         private string[] TextClear(string TxtLang,string[] TokenizeText)
          {
              try
              {
                  var StopList = Array.Empty<string>();
                  if (TxtLang == "Английский") StopList = File.ReadAllLines("Data/StopListEng.txt", Encoding.Default);
                  if (TxtLang == "Русский") StopList = File.ReadAllLines("Data/StopListRus.txt", Encoding.Default);

                  foreach (var el in StopList)
                  {
                      TokenizeText = TokenizeText.Where(element => element != el).ToArray();
                  }
                  return TokenizeText;
              }


          }
         */       

    }
}
