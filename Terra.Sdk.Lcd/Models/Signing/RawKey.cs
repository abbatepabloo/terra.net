using System;
using System.Threading.Tasks;
using Nethereum.Signer;
using Terra.Sdk.Lcd.Models.Entities.PubKey;

namespace Terra.Sdk.Lcd.Models.Signing
{
    public class RawKey : Key
    {
        private readonly byte[] _privateKey;

        public RawKey(byte[] privateKey) : base(CreatePublicKey(privateKey))
        {
            _privateKey = privateKey;
        }

        private static SimplePublicKey CreatePublicKey(byte[] privateKey)
        {
            var publicKey = new EthECKey(privateKey, true);
            return new SimplePublicKey
            {
                Key = Convert.ToBase64String(publicKey.GetPubKey())
            };
        }

        public Tuple<byte[], long> EcdsaSign(byte[] payload)
        {
            var key = new EthECKey(_privateKey, true);
            var sig = key.SignAndCalculateV(payload);
            return Tuple.Create(sig.To64ByteArray(), (long)sig.V[0]);
        }

        public override Task<byte[]> Sign(byte[] payload)
        {
            return Task.FromResult(EcdsaSign(payload).Item1);
        }
    }
}