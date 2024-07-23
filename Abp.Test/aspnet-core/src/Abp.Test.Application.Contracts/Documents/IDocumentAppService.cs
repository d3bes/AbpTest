using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Abp.Test.Documents
{
    public interface IDocumentAppService : ICrudAppService
                                     <DocumentDto,int, PagedAndSortedResultRequestDto>
    {
        
    }
}