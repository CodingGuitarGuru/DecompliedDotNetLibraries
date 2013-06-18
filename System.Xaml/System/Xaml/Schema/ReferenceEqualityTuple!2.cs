﻿namespace System.Xaml.Schema
{
    using System;

    internal class ReferenceEqualityTuple<T1, T2> : Tuple<T1, T2>
    {
        public ReferenceEqualityTuple(T1 item1, T2 item2) : base(item1, item2)
        {
        }

        public override bool Equals(object obj)
        {
            return this.Equals(obj, ReferenceEqualityComparer<object>.Singleton);
        }

        public override int GetHashCode()
        {
            return this.GetHashCode(ReferenceEqualityComparer<object>.Singleton);
        }
    }
}

