﻿namespace <CrtImplementationDetails>
{
    using System;
    using System.Collections;
    using System.Runtime.CompilerServices;
    using System.Runtime.ConstrainedExecution;
    using System.Security;

    internal class ModuleUninitializer : Stack
    {
        internal static <CrtImplementationDetails>.ModuleUninitializer _ModuleUninitializer = new <CrtImplementationDetails>.ModuleUninitializer();
        private static object @lock = new object();

        [SecuritySafeCritical]
        private ModuleUninitializer()
        {
            EventHandler handler = new EventHandler(this.SingletonDomainUnload);
            AppDomain.CurrentDomain.DomainUnload += handler;
            AppDomain.CurrentDomain.ProcessExit += handler;
        }

        [SecuritySafeCritical]
        internal void AddHandler(EventHandler handler)
        {
            RuntimeHelpers.PrepareDelegate(handler);
            this.Push(handler);
        }

        [PrePrepareMethod, SecurityCritical]
        private void SingletonDomainUnload(object source, EventArgs arguments)
        {
            using (IEnumerator enumerator = this.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    ((EventHandler) enumerator.Current)(source, arguments);
                }
            }
        }
    }
}

