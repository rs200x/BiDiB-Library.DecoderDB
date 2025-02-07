using System.Runtime.Serialization;

namespace org.bidib.Net.DecoderDB.Models.Sync;

[DataContract]
public class ManufacturersInfo : BaseInfo
{
    [DataMember(Name = "nmraListDate")]
    public string NmraListDate { get; set; }
}