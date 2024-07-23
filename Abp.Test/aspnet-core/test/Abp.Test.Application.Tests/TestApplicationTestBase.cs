using Volo.Abp.Modularity;

namespace Abp.Test;

public abstract class TestApplicationTestBase<TStartupModule> : TestTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
