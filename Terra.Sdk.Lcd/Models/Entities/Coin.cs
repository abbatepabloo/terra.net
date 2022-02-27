using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Terra.Sdk.Lcd.Models.Entities
{
    public class Coin
    {
        private readonly LcdClient _lcdClient;

        [JsonProperty("denom")]
        public string Denom { get; set; }

        [JsonProperty("amount")]
        public decimal Amount { get; set; }

        /// <remarks>
        /// For serialization.
        /// </remarks>
        public Coin()
        {
        }

        public Coin(LcdClient lcdClient)
        {
            _lcdClient = lcdClient;
        }

        public async Task<PaginatedResult<Coin>> Get(string address, string paginationKey = null, int? pageNumber = null, bool? getTotalCount = null, bool? isDescending = null)
        {
            var response = await _lcdClient.HttpClient.GetAsync($"/cosmos/bank/v1beta1/balances/{address}{_lcdClient.GetPaginationQueryString(paginationKey, pageNumber, getTotalCount, isDescending)}");
            if (!response.IsSuccessStatusCode)
                return new PaginatedResult<Coin> { Error = $"Fetch failed: {response.ReasonPhrase}" };

            var json = JsonConvert.DeserializeAnonymousType(await response.Content.ReadAsStringAsync(), new
            {
                data = new List<Coin>(),
                pagination = new { next_key = "", total = 0 }
            });

            return new PaginatedResult<Coin>
            {
                Value = json.data,
                TotalCount = json.pagination?.total,
                NextPageKey = json.pagination?.next_key,
                NextPageNumber = pageNumber + 1
            };
        }

        public async Task<PaginatedResult<Coin>> GetAll(string paginationKey = null, int? pageNumber = null, bool? getTotalCount = null, bool? isDescending = null)
        {
            var response = await _lcdClient.HttpClient.GetAsync($"/cosmos/bank/v1beta1/supply{_lcdClient.GetPaginationQueryString(paginationKey, pageNumber, getTotalCount, isDescending)}");
            if (!response.IsSuccessStatusCode)
                return new PaginatedResult<Coin> {  Error = $"Fetch failed: {response.ReasonPhrase}" };

            var json = JsonConvert.DeserializeAnonymousType(await response.Content.ReadAsStringAsync(), new
            {
                supply = new List<Coin>(),
                pagination = new { next_key = "", total = 0 }
            });

            return new PaginatedResult<Coin>
            {
                Value = json.supply,
                TotalCount = json.pagination?.total,
                NextPageKey = json.pagination?.next_key,
                NextPageNumber = pageNumber + 1
            };
        }
    }
}
