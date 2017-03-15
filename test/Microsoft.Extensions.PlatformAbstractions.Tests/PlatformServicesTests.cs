// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using Xunit;

namespace Microsoft.Extensions.PlatformAbstractions.Tests
{
    public class PlatformServicesTests
    {
        [Fact]
        public void ApplicationNameIsNotNullInAppDomain()
        {
            Assert.NotNull(PlatformServices.Default.Application.ApplicationName);
        }
    }
}
