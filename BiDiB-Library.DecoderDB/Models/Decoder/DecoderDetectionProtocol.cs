﻿using System;
using System.Diagnostics;
using System.Xml.Serialization;
using org.bidib.Net.Core.Models;
using org.bidib.Net.Core.Models.Common;
using org.bidib.Net.Core.Models.Decoder;

namespace org.bidib.Net.DecoderDB.Models.Decoder;

[Serializable]
[DebuggerStepThrough]
[XmlType(Namespace = Namespaces.DecoderDetectionNamespaceUrl, TypeName = "DecoderDetectionProtocolType")]
public class DecoderDetectionProtocol : Protocol
{
    [XmlArray("default")]
    [XmlArrayItem("detection", IsNullable = false)]
    public Detection[] Default { get; set; }

    [XmlElement("manufacturer")]
    public Manufacturer[] Manufacturer { get; set; }
}