﻿namespace System.Runtime.Serialization.Json
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Xml;

    internal delegate void JsonFormatGetOnlyCollectionReaderDelegate(XmlReaderDelegator xmlReader, XmlObjectSerializerReadContextComplexJson context, XmlDictionaryString emptyDictionaryString, XmlDictionaryString itemName, CollectionDataContract collectionContract);
}

