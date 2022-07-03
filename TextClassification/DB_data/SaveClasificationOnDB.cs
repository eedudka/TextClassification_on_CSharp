using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextClassification.DB_data
{
    public class SaveClasificationOnDB
    {
        public int id { get; set; }
        public string? documentName { get; set; }
        public string? documentClass { get; set; }
        public DateTime? dateProcessingDocument { get; set; }
        public DateTime? dateCreateDocument { get; set; }
        public string? UserName { get; set; }
        public string? DocLang { get; set; }

    }
}
