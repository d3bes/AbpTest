using Volo.Abp.Modularity;

namespace Abp.Test;

[DependsOn(
    typeof(TestDomainModule),
    typeof(TestTestBaseModule)
)]
public class TestDomainTestModule : AbpModule
{

}
