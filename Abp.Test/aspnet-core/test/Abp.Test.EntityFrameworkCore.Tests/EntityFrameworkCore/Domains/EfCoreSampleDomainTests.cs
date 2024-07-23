using Abp.Test.Samples;
using Xunit;

namespace Abp.Test.EntityFrameworkCore.Domains;

[Collection(TestTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<TestEntityFrameworkCoreTestModule>
{

}
