﻿namespace System.Net.NetworkInformation
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    internal struct MibTcpTable
    {
        internal uint numberOfEntries;
    }
}

