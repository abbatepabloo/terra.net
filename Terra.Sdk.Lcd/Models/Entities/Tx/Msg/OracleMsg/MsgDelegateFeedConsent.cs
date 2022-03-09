using ProtoBuf;

namespace Terra.Sdk.Lcd.Models.Entities.Tx.Msg.OracleMsg
{
    [ProtoContract]
    public class MsgDelegateFeedConsent : Msg
    {
        [ProtoMember(1, Name = "operator")] public string Operator { get; set; }
        [ProtoMember(2, Name = "delegate")] public string Delegate { get; set; }
    }
}
