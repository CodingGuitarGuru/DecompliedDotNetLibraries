﻿namespace System.ServiceModel.ComIntegration
{
    using System;

    internal enum DtcIsolationLevel
    {
        ISOLATIONLEVEL_BROWSE = 0x100,
        ISOLATIONLEVEL_CHAOS = 0x10,
        ISOLATIONLEVEL_CURSORSTABILITY = 0x1000,
        ISOLATIONLEVEL_ISOLATED = 0x100000,
        ISOLATIONLEVEL_READCOMMITTED = 0x1000,
        ISOLATIONLEVEL_READUNCOMMITTED = 0x100,
        ISOLATIONLEVEL_REPEATABLEREAD = 0x10000,
        ISOLATIONLEVEL_SERIALIZABLE = 0x100000,
        ISOLATIONLEVEL_UNSPECIFIED = -1
    }
}

