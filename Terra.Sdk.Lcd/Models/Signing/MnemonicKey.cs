using System;
using Terra.Sdk.Lcd.Extensions;

namespace Terra.Sdk.Lcd.Models.Signing
{
    public class MnemonicKey : RawKey
    {
        public string Mnemonic { get; set; }

        public MnemonicKey(MnemonicKeyOptions options) : base(CreatePrivateKey(options))
        {
            Mnemonic = options.Mnemonic;
        }

        private static byte[] CreatePrivateKey(MnemonicKeyOptions options)
        {
            var seed = MnemonicKeyOptions.Bip39.MnemonicToSeedHex(options.Mnemonic, "");
            Console.WriteLine($"***seed*** {seed}");
            var hdPathLuna = $"m/44'/{options.CoinType}'/{options.Account}'/0/{options.Index}";
            var terraHd = Bip32.CustomDerivePath(hdPathLuna, seed);
            return terraHd.Key;
        }
    }
}
