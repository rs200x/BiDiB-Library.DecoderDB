using System;
using System.Runtime.Serialization;

namespace org.bidib.Net.DecoderDB.Models.Sync;

[DataContract]
public class BaseInfo
{
    [DataMember(Name = "filename")]
    public string FileName { get; set; }

    [DataMember(Name = "link")]
    public Uri Link { get; set; }

    [DataMember(Name = "lastUpdate")]
    public string LastUpdate { get; set; }

    [DataMember(Name = "valid")]
    public bool IsValid { get; set; }
}