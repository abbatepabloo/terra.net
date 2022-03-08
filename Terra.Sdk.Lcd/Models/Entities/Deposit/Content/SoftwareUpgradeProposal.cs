using ProtoBuf;

namespace Terra.Sdk.Lcd.Models.Entities.Deposit.Content
{
    [ProtoContract]public class SoftwareUpgradeProposal : Content
    {
        [ProtoMember(2)]public string Title { get; set; }
        [ProtoMember(3)]public string Description { get; set; }
        [ProtoMember(4)]public Plan Plan { get; set; }
    }
}
