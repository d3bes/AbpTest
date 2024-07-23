using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abp.Test.Documents
{
    public class DocumentDto
    {
        public int Id { get; set;}
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public string path { get; set; }
        public string DescriptionAr { get; set; }
        public string DescriptionEn { get; set;}
        public bool isSigned { get; set; }
    
    }
}