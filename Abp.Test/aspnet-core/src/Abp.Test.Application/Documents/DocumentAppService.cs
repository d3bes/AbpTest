using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Test.Models;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Abp.Test.Documents
{
    public class DocumentAppService : CrudAppService<Document, DocumentDto, int, PagedAndSortedResultRequestDto>, IDocumentAppService
    {
        public DocumentAppService(IRepository<Document, int> repository) : base(repository)
        {
        }
    }
}