﻿namespace System.Activities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    public sealed class ActivityFunc<T1, T2, T3, T4, T5, T6, TResult> : ActivityDelegate
    {
        protected internal override DelegateOutArgument GetResultArgument()
        {
            return this.Result;
        }

        internal override IList<RuntimeDelegateArgument> InternalGetRuntimeDelegateArguments()
        {
            return new List<RuntimeDelegateArgument>(7) { new RuntimeDelegateArgument(ActivityDelegate.Argument1Name, typeof(T1), 0, this.Argument1), new RuntimeDelegateArgument(ActivityDelegate.Argument2Name, typeof(T2), 0, this.Argument2), new RuntimeDelegateArgument(ActivityDelegate.Argument3Name, typeof(T3), 0, this.Argument3), new RuntimeDelegateArgument(ActivityDelegate.Argument4Name, typeof(T4), 0, this.Argument4), new RuntimeDelegateArgument(ActivityDelegate.Argument5Name, typeof(T5), 0, this.Argument5), new RuntimeDelegateArgument(ActivityDelegate.Argument6Name, typeof(T6), 0, this.Argument6), new RuntimeDelegateArgument(ActivityDelegate.ResultArgumentName, typeof(TResult), 1, this.Result) };
        }

        [DefaultValue((string) null)]
        public DelegateInArgument<T1> Argument1 { get; set; }

        [DefaultValue((string) null)]
        public DelegateInArgument<T2> Argument2 { get; set; }

        [DefaultValue((string) null)]
        public DelegateInArgument<T3> Argument3 { get; set; }

        [DefaultValue((string) null)]
        public DelegateInArgument<T4> Argument4 { get; set; }

        [DefaultValue((string) null)]
        public DelegateInArgument<T5> Argument5 { get; set; }

        [DefaultValue((string) null)]
        public DelegateInArgument<T6> Argument6 { get; set; }

        [DefaultValue((string) null)]
        public DelegateOutArgument<TResult> Result { get; set; }
    }
}

