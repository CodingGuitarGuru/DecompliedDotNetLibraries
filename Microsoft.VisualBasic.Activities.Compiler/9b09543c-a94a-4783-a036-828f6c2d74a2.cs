﻿using Microsoft.VisualC;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential, Size=4), MiscellaneousBits(0x40), NativeCppClass, DebugInfoInPDB]
internal static class IReadOnlyList<LambdaParamHandle *> : ValueType
{
}

