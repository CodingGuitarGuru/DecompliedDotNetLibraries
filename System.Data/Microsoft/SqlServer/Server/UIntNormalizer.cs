﻿namespace Microsoft.SqlServer.Server
{
    using System;
    using System.IO;
    using System.Reflection;

    internal sealed class UIntNormalizer : Normalizer
    {
        internal override void DeNormalize(FieldInfo fi, object recvr, Stream s)
        {
            byte[] buffer = new byte[4];
            s.Read(buffer, 0, buffer.Length);
            if (!base.m_skipNormalize)
            {
                Array.Reverse(buffer);
            }
            base.SetValue(fi, recvr, BitConverter.ToUInt32(buffer, 0));
        }

        internal override void Normalize(FieldInfo fi, object obj, Stream s)
        {
            byte[] bytes = BitConverter.GetBytes((uint) base.GetValue(fi, obj));
            if (!base.m_skipNormalize)
            {
                Array.Reverse(bytes);
            }
            s.Write(bytes, 0, bytes.Length);
        }

        internal override int Size
        {
            get
            {
                return 4;
            }
        }
    }
}

