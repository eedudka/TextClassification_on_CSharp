using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TextClassification.ProcessingClass
{
    internal class HttpPostRequest
    {
        public string TextLanguage { get; set; }
        public string TextVector { get; set; }
        public string UserName { get; set; }
        public float[] GetVectorFromWebAPI(string textLanguage, string[] Text)
        {
            try
            {    
                using (var client = new HttpClient())
                {
                    var adressToApi = new Uri("https://localhost:5001/api/Vectorize");
                    var SendParam = new HttpPostRequest()
                    {
                        TextLanguage = textLanguage,
                        TextVector = string.Join(" ", Text),
                        UserName = Environment.UserName
                    };
                    var NewJsonObject = JsonConvert.SerializeObject(SendParam);
                    var payLoad = new StringContent(NewJsonObject, Encoding.UTF8, "application/json");
                    var result = client.PostAsync(adressToApi, payLoad).Result.Content
                        .ReadAsStringAsync().Result;

                    float[] WebAPIrequest = ClearJsonAnser(result)
                        .ConvertAll(x => float.Parse(x))
                        .ToArray();

                    return WebAPIrequest;
                }
               
            }
            catch (Exception ex)
            {
                Log log = new Log();
                log.Add("Ошибка при получении запроса с WebAPI.", "GetVectorFromWebAPI");
                return null;
            }

        }
        public bool isServerRunning()
        {
            try
            {
                var result = string.Empty;
                using (var client = new HttpClient())
                {
                    var adressToMainServer = File.ReadAllText("ConnectString.txt");
                    var adressToApi = new Uri(adressToMainServer + "/api/Vectorize");
                    var resultGetMethod = client.GetAsync(adressToApi).Result;
                    result = resultGetMethod.Content.ReadAsStringAsync().Result;
                }
                return true;
            }
            catch { return false; }

        }
        private List<string> ClearJsonAnser(string rquestResult)
        {
            return rquestResult.Replace("[", "")
                        .Replace("]", "")
                        .Replace(",", "/")
                        .Replace(".", ",")
                        .Split('/')
                        .ToList();
                        
        }
    }
}
