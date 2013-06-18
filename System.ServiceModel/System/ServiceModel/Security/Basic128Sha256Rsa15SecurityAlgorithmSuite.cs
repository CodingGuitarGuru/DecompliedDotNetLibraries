﻿namespace System.ServiceModel.Security
{
    using System;
    using System.ServiceModel;
    using System.Xml;

    internal class Basic128Sha256Rsa15SecurityAlgorithmSuite : Basic128Rsa15SecurityAlgorithmSuite
    {
        public override string ToString()
        {
            return "Basic128Sha256Rsa15";
        }

        internal override XmlDictionaryString DefaultAsymmetricSignatureAlgorithmDictionaryString
        {
            get
            {
                return XD.SecurityAlgorithmDictionary.RsaSha256Signature;
            }
        }

        internal override XmlDictionaryString DefaultDigestAlgorithmDictionaryString
        {
            get
            {
                return XD.SecurityAlgorithmDictionary.Sha256Digest;
            }
        }

        internal override XmlDictionaryString DefaultSymmetricSignatureAlgorithmDictionaryString
        {
            get
            {
                return XD.SecurityAlgorithmDictionary.HmacSha256Signature;
            }
        }
    }
}

