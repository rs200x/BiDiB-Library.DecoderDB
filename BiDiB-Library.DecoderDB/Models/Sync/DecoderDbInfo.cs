using System.Runtime.Serialization;

namespace org.bidib.Net.DecoderDB.Models.Sync;

[DataContract]
public class DecoderDbInfo
{
    [DataMember(Name = "version")]
    public int Version { get; set; }

    [DataMember(Name = "manufacturers")]
    public ManufacturersInfo Manufacturers { get; set; }

    [DataMember(Name = "decoderDetections")]
    public BaseInfo DecoderDetections { get; set; }

    [DataMember(Name = "decoder")]
    public DecoderInfo[] Decoders { get; set; }

    [DataMember(Name = "firmware")]
    public FirmwareInfo[] Firmware { get; set; }
}