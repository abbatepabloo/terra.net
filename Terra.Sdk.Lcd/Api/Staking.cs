using System;
using System.Threading.Tasks;
using Terra.Sdk.Lcd.Models;
using Terra.Sdk.Lcd.Models.Entities;

namespace Terra.Sdk.Lcd.Api
{
    public class Staking
    {
        private readonly LcdClient _client;

        internal Staking(LcdClient client)
        {
            _client = client;
        }

        public Task<PaginatedResult<Delegation>> GetDelegations(string delegator = null, string validator = null,
            string paginationKey = null, int? pageNumber = null, bool? getTotalCount = null, bool? isDescending = null)
        {
            throw new NotImplementedException();
        }

        public Task<Result<Delegation>> GetDelegation(string delegator, string validator)
        {
            throw new NotImplementedException();
        }

        public Task<PaginatedResult<UnbondingDelegation>> GetUnbondingDelegations(string delegator = null, string validator = null,
            string paginationKey = null, int? pageNumber = null, bool? getTotalCount = null, bool? isDescending = null)
        {
            throw new NotImplementedException();
        }

        public Task<Result<UnbondingDelegation>> GetUnbondingDelegation(string delegator = null, string validator = null)
        {
            throw new NotImplementedException();
        }

        public Task<PaginatedResult<Redelegation>> GetRedelegations(string delegator = null, string validatorSrc = null, string validatorDst = null,
            string paginationKey = null, int? pageNumber = null, bool? getTotalCount = null, bool? isDescending = null)
        {
            throw new NotImplementedException();
        }

        public Task<PaginatedResult<Validator>> GetBondedValidators(string delegator = null,
            string paginationKey = null, int? pageNumber = null, bool? getTotalCount = null, bool? isDescending = null)
        {
            throw new NotImplementedException();
        }

        public Task<PaginatedResult<Validator>> GetValidators(
            string paginationKey = null, int? pageNumber = null, bool? getTotalCount = null, bool? isDescending = null)
        {
            throw new NotImplementedException();
        }

        public Task<Result<Validator>> GetValidator(string address)
        {
            throw new NotImplementedException();
        }

        public Task<Result<StakingPool>> GetPool()
        {
            throw new NotImplementedException();
        }

        public Task<Result<StakingParams>> GetParameters()
        {
            throw new NotImplementedException();
        }
    }
}
