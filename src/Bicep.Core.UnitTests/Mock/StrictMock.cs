// Copyright (c) Mark Nichols.  All Rights Reserved. 
//  Licensed under the MIT License.

using Moq;

namespace Bicep.Core.UnitTests.Mock
{
    public static class StrictMock
    {
        public static Mock<T> Of<T>() where T : class => new(MockBehavior.Strict);
    }
}
