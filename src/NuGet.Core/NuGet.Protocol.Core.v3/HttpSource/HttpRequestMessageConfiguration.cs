// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using NuGet.Common;

namespace NuGet.Protocol
{
    public class HttpRequestMessageConfiguration
    {
        public HttpRequestMessageConfiguration()
        {
            Logger = NullLogger.Instance;
            PromptOn403 = true;
        }

        public ILogger Logger { get; set; }
        public bool PromptOn403 { get; set; }
    }
}
