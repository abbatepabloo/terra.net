using JsonSubTypes;
using Newtonsoft.Json;
using ProtoBuf;
using Terra.Sdk.Lcd.Models.Entities.Tx.Msg.BankMsg;
using Terra.Sdk.Lcd.Models.Entities.Tx.Msg.DistributionMsg;
using Terra.Sdk.Lcd.Models.Entities.Tx.Msg.FeeGrantMsg;
using Terra.Sdk.Lcd.Models.Entities.Tx.Msg.GovMsg;
using Terra.Sdk.Lcd.Models.Entities.Tx.Msg.IbcChannelMsg;
using Terra.Sdk.Lcd.Models.Entities.Tx.Msg.IbcClientMsg;
using Terra.Sdk.Lcd.Models.Entities.Tx.Msg.IbcConnectionMsg;
using Terra.Sdk.Lcd.Models.Entities.Tx.Msg.IbcTransferMsg;
using Terra.Sdk.Lcd.Models.Entities.Tx.Msg.MarketMsg;
using Terra.Sdk.Lcd.Models.Entities.Tx.Msg.MsgAuthMsg;
using Terra.Sdk.Lcd.Models.Entities.Tx.Msg.OracleMsg;
using Terra.Sdk.Lcd.Models.Entities.Tx.Msg.SlashingMsg;
using Terra.Sdk.Lcd.Models.Entities.Tx.Msg.StakingMsg;
using Terra.Sdk.Lcd.Models.Entities.Tx.Msg.WasmMsg;

namespace Terra.Sdk.Lcd.Models.Entities.Tx.Msg
{
    [JsonConverter(typeof(JsonSubtypes), "@type")]
    [JsonSubtypes.KnownSubType(typeof(MsgSend), "/cosmos.bank.v1beta1.MsgSend")]
    [JsonSubtypes.KnownSubType(typeof(MsgMultiSend), "/cosmos.bank.v1beta1.MsgMultiSend")]
    [JsonSubtypes.KnownSubType(typeof(MsgFundCommunityPool), "/cosmos.distribution.v1beta1.MsgFundCommunityPool")]
    [JsonSubtypes.KnownSubType(typeof(MsgSetWithdrawAddress), "/cosmos.distribution.v1beta1.MsgSetWithdrawAddress")]
    [JsonSubtypes.KnownSubType(typeof(MsgWithdrawDelegatorReward), "/cosmos.distribution.v1beta1.MsgWithdrawDelegatorReward")]
    [JsonSubtypes.KnownSubType(typeof(MsgWithdrawValidatorCommission), "/cosmos.distribution.v1beta1.MsgWithdrawValidatorCommission")]
    [JsonSubtypes.KnownSubType(typeof(MsgGrantAllowance), "/cosmos.feegrant.v1beta1.MsgGrantAllowance")]
    [JsonSubtypes.KnownSubType(typeof(MsgRevokeAllowance), "/cosmos.feegrant.v1beta1.MsgRevokeAllowance")]
    [JsonSubtypes.KnownSubType(typeof(MsgDeposit), "/cosmos.gov.v1beta1.MsgDeposit")]
    [JsonSubtypes.KnownSubType(typeof(MsgSubmitProposal), "/cosmos.gov.v1beta1.MsgSubmitProposal")]
    [JsonSubtypes.KnownSubType(typeof(MsgVote), "/cosmos.gov.v1beta1.MsgVote")]
    [JsonSubtypes.KnownSubType(typeof(MsgVoteWeighted), "/cosmos.gov.v1beta1.MsgVoteWeighted")]
    [JsonSubtypes.KnownSubType(typeof(MsgAcknowledgement), "/ibc.core.channel.v1.MsgAcknowledgement")]
    [JsonSubtypes.KnownSubType(typeof(MsgChannelCloseConfirm), "/ibc.core.channel.v1.MsgChannelCloseConfirm")]
    [JsonSubtypes.KnownSubType(typeof(MsgChannelCloseInit), "/ibc.core.channel.v1.MsgChannelCloseInit")]
    [JsonSubtypes.KnownSubType(typeof(MsgChannelOpenAck), "/ibc.core.channel.v1.MsgChannelOpenAck")]
    [JsonSubtypes.KnownSubType(typeof(MsgChannelOpenConfirm), "/ibc.core.channel.v1.MsgChannelOpenConfirm")]
    [JsonSubtypes.KnownSubType(typeof(MsgChannelOpenInit), "/ibc.core.channel.v1.MsgChannelOpenInit")]
    [JsonSubtypes.KnownSubType(typeof(MsgChannelOpenTry), "/ibc.core.channel.v1.MsgChannelOpenTry")]
    [JsonSubtypes.KnownSubType(typeof(MsgRecvPacket), "/ibc.core.channel.v1.MsgRecvPacket")]
    [JsonSubtypes.KnownSubType(typeof(MsgTimeout), "/ibc.core.channel.v1.MsgTimeout")]
    [JsonSubtypes.KnownSubType(typeof(MsgTimeoutOnClose), "/ibc.core.channel.v1.MsgTimeoutOnClose")]
    [JsonSubtypes.KnownSubType(typeof(MsgCreateClient), "/ibc.core.client.v1.MsgCreateClient")]
    [JsonSubtypes.KnownSubType(typeof(MsgSubmitMisbehaviour), "/ibc.core.client.v1.MsgSubmitMisbehaviour")]
    [JsonSubtypes.KnownSubType(typeof(MsgUpdateClient), "/ibc.core.client.v1.MsgUpdateClient")]
    [JsonSubtypes.KnownSubType(typeof(MsgUpgradeClient), "/ibc.core.client.v1.MsgUpgradeClient")]
    [JsonSubtypes.KnownSubType(typeof(MsgConnectionOpenAck), "/ibc.core.connection.v1.MsgConnectionOpenAck")]
    [JsonSubtypes.KnownSubType(typeof(MsgConnectionOpenConfirm), "/ibc.core.connection.v1.MsgConnectionOpenConfirm")]
    [JsonSubtypes.KnownSubType(typeof(MsgConnectionOpenInit), "/ibc.core.connection.v1.MsgConnectionOpenInit")]
    [JsonSubtypes.KnownSubType(typeof(MsgConnectionOpenTry), "/ibc.core.connection.v1.MsgConnectionOpenTry")]
    [JsonSubtypes.KnownSubType(typeof(MsgTransfer), "/ibc.applications.transfer.v1.MsgTransfer")]
    [JsonSubtypes.KnownSubType(typeof(MsgSwap), "/terra.market.v1beta1.MsgSwap")]
    [JsonSubtypes.KnownSubType(typeof(MsgSwapSend), "/terra.market.v1beta1.MsgSwapSend")]
    [JsonSubtypes.KnownSubType(typeof(MsgExecAuthorized), "/cosmos.authz.v1beta1.MsgExecAuthorized")]
    [JsonSubtypes.KnownSubType(typeof(MsgGrantAuthorization), "/cosmos.authz.v1beta1.MsgGrantAuthorization")]
    [JsonSubtypes.KnownSubType(typeof(MsgRevokeAuthorization), "/cosmos.authz.v1beta1.MsgRevokeAuthorization")]
    [JsonSubtypes.KnownSubType(typeof(MsgAggregateExchangeRatePrevote), "/terra.oracle.v1beta1.MsgAggregateExchangeRatePrevote")]
    [JsonSubtypes.KnownSubType(typeof(MsgAggregateExchangeRateVote), "/terra.oracle.v1beta1.MsgAggregateExchangeRateVote")]
    [JsonSubtypes.KnownSubType(typeof(MsgDelegateFeedConsent), "/terra.oracle.v1beta1.MsgDelegateFeedConsent")]
    [JsonSubtypes.KnownSubType(typeof(MsgUnjail), "/cosmos.slashing.v1beta1.MsgUnjail")]
    [JsonSubtypes.KnownSubType(typeof(MsgBeginRedelegate), "/cosmos.staking.v1beta1.MsgBeginRedelegate")]
    [JsonSubtypes.KnownSubType(typeof(MsgCreateValidator), "/cosmos.staking.v1beta1.MsgCreateValidator")]
    [JsonSubtypes.KnownSubType(typeof(MsgDelegate), "/cosmos.staking.v1beta1.MsgDelegate")]
    [JsonSubtypes.KnownSubType(typeof(MsgEditValidator), "/cosmos.staking.v1beta1.MsgEditValidator")]
    [JsonSubtypes.KnownSubType(typeof(MsgUndelegate), "/cosmos.staking.v1beta1.MsgUndelegate")]
    [JsonSubtypes.KnownSubType(typeof(MsgClearContractAdmin), "/terra.wasm.v1beta1.MsgClearContractAdmin")]
    [JsonSubtypes.KnownSubType(typeof(MsgExecuteContract), "/terra.wasm.v1beta1.MsgExecuteContract")]
    [JsonSubtypes.KnownSubType(typeof(MsgInstantiateContract), "/terra.wasm.v1beta1.MsgInstantiateContract")]
    [JsonSubtypes.KnownSubType(typeof(MsgMigrateCode), "/terra.wasm.v1beta1.MsgMigrateCode")]
    [JsonSubtypes.KnownSubType(typeof(MsgMigrateContract), "/terra.wasm.v1beta1.MsgMigrateContract")]
    [JsonSubtypes.KnownSubType(typeof(MsgStoreCode), "/terra.wasm.v1beta1.MsgStoreCode")]
    [JsonSubtypes.KnownSubType(typeof(MsgUpdateContractAdmin), "/terra.wasm.v1beta1.MsgUpdateContractAdmin")]

    [ProtoContract]
    [ProtoInclude(1, typeof(MsgSend))]
    [ProtoInclude(2, typeof(MsgMultiSend))]
    [ProtoInclude(3, typeof(MsgFundCommunityPool))]
    [ProtoInclude(4, typeof(MsgSetWithdrawAddress))]
    [ProtoInclude(5, typeof(MsgWithdrawDelegatorReward))]
    [ProtoInclude(6, typeof(MsgWithdrawValidatorCommission))]
    [ProtoInclude(7, typeof(MsgGrantAllowance))]
    [ProtoInclude(8, typeof(MsgRevokeAllowance))]
    [ProtoInclude(9, typeof(MsgDeposit))]
    [ProtoInclude(10, typeof(MsgSubmitProposal))]
    [ProtoInclude(11, typeof(MsgVote))]
    [ProtoInclude(12, typeof(MsgVoteWeighted))]
    [ProtoInclude(13, typeof(MsgAcknowledgement))]
    [ProtoInclude(14, typeof(MsgChannelCloseConfirm))]
    [ProtoInclude(15, typeof(MsgChannelCloseInit))]
    [ProtoInclude(16, typeof(MsgChannelOpenAck))]
    [ProtoInclude(17, typeof(MsgChannelOpenConfirm))]
    [ProtoInclude(18, typeof(MsgChannelOpenInit))]
    [ProtoInclude(19, typeof(MsgChannelOpenTry))]
    [ProtoInclude(20, typeof(MsgRecvPacket))]
    [ProtoInclude(21, typeof(MsgTimeout))]
    [ProtoInclude(22, typeof(MsgTimeoutOnClose))]
    [ProtoInclude(23, typeof(MsgCreateClient))]
    [ProtoInclude(24, typeof(MsgSubmitMisbehaviour))]
    [ProtoInclude(25, typeof(MsgUpdateClient))]
    [ProtoInclude(26, typeof(MsgUpgradeClient))]
    [ProtoInclude(27, typeof(MsgConnectionOpenAck))]
    [ProtoInclude(28, typeof(MsgConnectionOpenConfirm))]
    [ProtoInclude(29, typeof(MsgConnectionOpenInit))]
    [ProtoInclude(30, typeof(MsgConnectionOpenTry))]
    [ProtoInclude(31, typeof(MsgTransfer))]
    [ProtoInclude(32, typeof(MsgSwap))]
    [ProtoInclude(33, typeof(MsgSwapSend))]
    [ProtoInclude(34, typeof(MsgExecAuthorized))]
    [ProtoInclude(35, typeof(MsgGrantAuthorization))]
    [ProtoInclude(36, typeof(MsgRevokeAuthorization))]
    [ProtoInclude(37, typeof(MsgAggregateExchangeRatePrevote))]
    [ProtoInclude(38, typeof(MsgAggregateExchangeRateVote))]
    [ProtoInclude(39, typeof(MsgDelegateFeedConsent))]
    [ProtoInclude(40, typeof(MsgUnjail))]
    [ProtoInclude(41, typeof(MsgBeginRedelegate))]
    [ProtoInclude(42, typeof(MsgCreateValidator))]
    [ProtoInclude(43, typeof(MsgDelegate))]
    [ProtoInclude(44, typeof(MsgEditValidator))]
    [ProtoInclude(45, typeof(MsgUndelegate))]
    [ProtoInclude(46, typeof(MsgClearContractAdmin))]
    [ProtoInclude(47, typeof(MsgExecuteContract))]
    [ProtoInclude(48, typeof(MsgInstantiateContract))]
    [ProtoInclude(49, typeof(MsgMigrateCode))]
    [ProtoInclude(50, typeof(MsgMigrateContract))]
    [ProtoInclude(51, typeof(MsgStoreCode))]
    [ProtoInclude(52, typeof(MsgUpdateContractAdmin))]
    public abstract class Msg
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
    }
}
