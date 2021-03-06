﻿namespace System.Management
{
    using System;
    using System.Runtime;

    public class DeleteOptions : ManagementOptions
    {
        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        public DeleteOptions()
        {
        }

        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        public DeleteOptions(ManagementNamedValueCollection context, TimeSpan timeout) : base(context, timeout)
        {
        }

        public override object Clone()
        {
            ManagementNamedValueCollection context = null;
            if (base.Context != null)
            {
                context = base.Context.Clone();
            }
            return new DeleteOptions(context, base.Timeout);
        }
    }
}

