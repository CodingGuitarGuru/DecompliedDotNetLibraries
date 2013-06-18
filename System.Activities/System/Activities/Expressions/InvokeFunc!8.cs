﻿namespace System.Activities.Expressions
{
    using System;
    using System.Activities;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Windows.Markup;

    [ContentProperty("Func")]
    public sealed class InvokeFunc<T1, T2, T3, T4, T5, T6, T7, TResult> : NativeActivity<TResult>
    {
        protected override void Execute(NativeActivityContext context)
        {
            if ((this.Func != null) && (this.Func.Handler != null))
            {
                context.ScheduleFunc<T1, T2, T3, T4, T5, T6, T7, TResult>(this.Func, this.Argument1.Get(context), this.Argument2.Get(context), this.Argument3.Get(context), this.Argument4.Get(context), this.Argument5.Get(context), this.Argument6.Get(context), this.Argument7.Get(context), new CompletionCallback<TResult>(this.OnActivityFuncComplete), null);
            }
        }

        private void OnActivityFuncComplete(NativeActivityContext context, System.Activities.ActivityInstance completedInstance, TResult resultValue)
        {
            if (completedInstance.State == ActivityInstanceState.Closed)
            {
                base.Result.Set(context, resultValue);
            }
        }

        [RequiredArgument]
        public InArgument<T1> Argument1 { get; set; }

        [RequiredArgument]
        public InArgument<T2> Argument2 { get; set; }

        [RequiredArgument]
        public InArgument<T3> Argument3 { get; set; }

        [RequiredArgument]
        public InArgument<T4> Argument4 { get; set; }

        [RequiredArgument]
        public InArgument<T5> Argument5 { get; set; }

        [RequiredArgument]
        public InArgument<T6> Argument6 { get; set; }

        [RequiredArgument]
        public InArgument<T7> Argument7 { get; set; }

        [DefaultValue((string) null)]
        public ActivityFunc<T1, T2, T3, T4, T5, T6, T7, TResult> Func { get; set; }
    }
}

