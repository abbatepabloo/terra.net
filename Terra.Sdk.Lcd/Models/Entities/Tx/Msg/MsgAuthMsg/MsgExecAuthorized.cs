using System.Collections.Generic;
using ProtoBuf;

namespace Terra.Sdk.Lcd.Models.Entities.Tx.Msg.MsgAuthMsg
{
    [ProtoContract]
    public class MsgExecAuthorized : Msg
    {
        [ProtoMember(1, Name = "grantee")] public string Grantee { get; set; }
        [ProtoMember(2, Name = "msgs")] public List<Msg> Msgs { get; set; }
    }
}
