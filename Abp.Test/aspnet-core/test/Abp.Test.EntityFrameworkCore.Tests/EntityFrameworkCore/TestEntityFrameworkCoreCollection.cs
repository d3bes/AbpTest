﻿using Xunit;

namespace Abp.Test.EntityFrameworkCore;

[CollectionDefinition(TestTestConsts.CollectionDefinitionName)]
public class TestEntityFrameworkCoreCollection : ICollectionFixture<TestEntityFrameworkCoreFixture>
{

}