using Terra.Sdk.Lcd.Models.Entities.Tx.Msg.IbcChannelMsg.Primitives;

namespace Terra.Sdk.Lcd.Models.Entities.Tx.Msg.IbcChannelMsg
{
    public class MsgTimeout : Msg
    {
        public Packet Packet { get; set; }
        public string ProofUnreceived { get; set; }
        public Height ProofHeight { get; set; }
        public long NextSequenceRecv { get; set; }
        public string Signer { get; set; }
    }
}
