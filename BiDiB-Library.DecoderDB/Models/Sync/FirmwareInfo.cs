using System.Runtime.Serialization;

namespace org.bidib.Net.DecoderDB.Models.Sync;

[DataContract]
public class FirmwareInfo : BaseInfo
{
    [DataMember(Name = "manufacturerId")]
    public string ManufacturerId { get; set; }

    [DataMember(Name = "manufacturerExtendedId")]
    public string ManufacturerExtendedId { get; set; }

    [DataMember(Name = "version")]
    public string Version { get; set; }

    [DataMember(Name = "versionExtension")]
    public string VersionExtension { get; set; }
}