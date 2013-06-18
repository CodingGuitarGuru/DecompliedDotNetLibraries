﻿namespace System.Activities.Validation
{
    using System;
    using System.Activities;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    public sealed class AddValidationError : NativeActivity
    {
        protected override void CacheMetadata(NativeActivityMetadata metadata)
        {
            Collection<RuntimeArgument> arguments = new Collection<RuntimeArgument>();
            RuntimeArgument argument = new RuntimeArgument("Message", typeof(string), ArgumentDirection.In);
            metadata.Bind(this.Message, argument);
            arguments.Add(argument);
            RuntimeArgument argument2 = new RuntimeArgument("IsWarning", typeof(bool), ArgumentDirection.In, false);
            metadata.Bind(this.IsWarning, argument2);
            arguments.Add(argument2);
            RuntimeArgument argument3 = new RuntimeArgument("PropertyName", typeof(string), ArgumentDirection.In, false);
            metadata.Bind(this.PropertyName, argument3);
            arguments.Add(argument3);
            metadata.SetArgumentsCollection(arguments);
        }

        protected override void Execute(NativeActivityContext context)
        {
            bool isWarning = false;
            string propertyName = string.Empty;
            if (this.IsWarning != null)
            {
                isWarning = this.IsWarning.Get(context);
            }
            if (this.PropertyName != null)
            {
                propertyName = this.PropertyName.Get(context);
            }
            Constraint.AddValidationError(context, new ValidationError(this.Message.Get(context), isWarning, propertyName));
        }

        [DefaultValue((string) null)]
        public InArgument<bool> IsWarning { get; set; }

        public InArgument<string> Message { get; set; }

        [DefaultValue((string) null)]
        public InArgument<string> PropertyName { get; set; }
    }
}

