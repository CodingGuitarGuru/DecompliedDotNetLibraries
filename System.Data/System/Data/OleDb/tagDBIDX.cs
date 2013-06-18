﻿namespace System.Data.OleDb
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, Pack=2)]
    internal struct tagDBIDX
    {
        internal Guid uGuid;
        internal int eKind;
        internal IntPtr ulPropid;
    }
}

