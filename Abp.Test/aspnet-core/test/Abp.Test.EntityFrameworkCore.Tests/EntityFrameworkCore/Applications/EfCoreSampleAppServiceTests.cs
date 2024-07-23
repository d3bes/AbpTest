using Abp.Test.Samples;
using Xunit;

namespace Abp.Test.EntityFrameworkCore.Applications;

[Collection(TestTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<TestEntityFrameworkCoreTestModule>
{

}
