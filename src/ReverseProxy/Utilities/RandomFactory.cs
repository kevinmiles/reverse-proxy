// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using System;

namespace Microsoft.ReverseProxy.Utilities
{
    /// <summary>
    /// Factory for creating random class. This factory let us able to inject random class into other class.
    /// So that we can mock the random class for unit test.
    /// </summary>
    public class RandomFactory : IRandomFactory
    {
        /// <inheritdoc/>
        public Random CreateRandomInstance()
        {
            return ThreadStaticRandom.Instance;
        }
    }
}
