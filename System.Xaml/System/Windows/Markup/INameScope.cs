﻿namespace System.Windows.Markup
{
    using System;
    using System.Runtime.CompilerServices;

    [TypeForwardedFrom("WindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
    public interface INameScope
    {
        object FindName(string name);
        void RegisterName(string name, object scopedElement);
        void UnregisterName(string name);
    }
}

