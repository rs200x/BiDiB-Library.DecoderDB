using System.Runtime.Serialization;

namespace org.bidib.Net.DecoderDB.Models.Sync;

[DataContract]
public class DecoderInfo : BaseInfo
{
    [DataMember(Name = "manufacturerId")]
    public string ManufacturerId { get; set; }

    [DataMember(Name = "manufacturerExtendedId")]
    public string ManufacturerExtendedId { get; set; }

    [DataMember(Name = "name")]
    public string Name { get; set; }
}