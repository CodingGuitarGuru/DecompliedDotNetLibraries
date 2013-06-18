﻿namespace System.Windows.Forms
{
    using System;
    using System.Runtime.InteropServices;

    [ComVisible(true), Flags]
    public enum MouseButtons
    {
        Left = 0x100000,
        Middle = 0x400000,
        None = 0,
        Right = 0x200000,
        XButton1 = 0x800000,
        XButton2 = 0x1000000
    }
}

