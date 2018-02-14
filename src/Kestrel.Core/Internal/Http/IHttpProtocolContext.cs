// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Buffers;
using System.IO.Pipelines;
using System.Net;
using System.Threading;
using Microsoft.AspNetCore.Http.Features;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http
{
    public interface IHttpProtocolContext
    {
        string ConnectionId { get; set; }
        ServiceContext ServiceContext { get; set; }
        IFeatureCollection ConnectionFeatures { get; set; }
        MemoryPool MemoryPool { get; set; }
        IPEndPoint RemoteEndPoint { get; set; }
        IPEndPoint LocalEndPoint { get; set; }
        PipeScheduler ApplicationScheduler { get; set; }
    }
}
