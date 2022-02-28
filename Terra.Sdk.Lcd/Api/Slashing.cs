using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Terra.Sdk.Lcd.Models;
using Terra.Sdk.Lcd.Models.Entities;

namespace Terra.Sdk.Lcd.Api
{
    public class Slashing
    {
        private readonly LcdClient _client;

        public Slashing(LcdClient client)
        {
            _client = client;
        }

        public async Task<Result<SigningInfo>> GetSigningInfo(string valConsAddress)
        {
            throw new NotImplementedException();
        }

        public async Task<Result<List<SigningInfo>>> GetSigningInfos()
        {
            throw new NotImplementedException();
        }

        public async Task<Result<SlashingParams>> GetParameters()
        {
            throw new NotImplementedException();
        }
    }
}