﻿namespace System.ServiceModel.Security
{
    using System.ServiceModel;
    using System.ServiceModel.Channels;

    public interface ISecuritySession : ISession
    {
        EndpointIdentity RemoteIdentity { get; }
    }
}

