﻿namespace System.Activities.XamlIntegration
{
    using System;
    using System.Activities;
    using System.ComponentModel;

    public sealed class InOutArgumentConverter : TypeConverterBase
    {
        public InOutArgumentConverter() : base(typeof(InOutArgument<>), typeof(InOutArgumentConverterHelper))
        {
        }

        public InOutArgumentConverter(Type type) : base(type, typeof(InOutArgument<>), typeof(InOutArgumentConverterHelper))
        {
        }

        internal sealed class InOutArgumentConverterHelper<T> : TypeConverterBase.TypeConverterHelper<InOutArgument<T>>
        {
            private ActivityWithResultConverter.ExpressionConverterHelper<Location<T>> expressionHelper;

            public InOutArgumentConverterHelper()
            {
                this.expressionHelper = new ActivityWithResultConverter.ExpressionConverterHelper<Location<T>>(true);
            }

            public override InOutArgument<T> ConvertFromString(string text, ITypeDescriptorContext context)
            {
                return new InOutArgument<T> { Expression = this.expressionHelper.ConvertFromString(text.Trim(), context) };
            }
        }
    }
}

