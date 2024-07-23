using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Abp.Test.Models
{
    public class Document : FullAuditedEntity<int>
    {
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public string path { get; set; }
        public string DescriptionAr { get; set; }
        public string DescriptionEn { get; set;}
        public bool isSigned { get; set; }
    


    }
}