﻿// Copyright 2020 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using NUnit.Framework;
using Google.Ads.GoogleAds.Examples.V4;

namespace Google.Ads.GoogleAds.Tests.Examples.V4
{
    /// <summary>
    /// Tests the GetArtifactMetadata code example.
    /// </summary>
    [TestFixture]
    [Category("CodeExamples")]
    internal class GetArtifactMetadataTest : ExampleTestsBase
    {
        /// <summary>
        /// Inits this instance.
        /// </summary>
        [SetUp]
        public void Init()
        {
        }

        /// <summary>
        /// Tests the Run method.
        /// </summary>
        [Test]
        public void TestRun()
        {
            RunExample(delegate ()
            {
                new GetArtifactMetadata().Run(client, client.Config.ClientCustomerId, "campaign");
            });
        }
    }
}
