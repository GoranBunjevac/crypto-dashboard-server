using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace CryptoServer.Models
{
    public class CoinResponse
    {
        [JsonProperty("status")]
        public Status RequestStatus { get; set; }

        [JsonProperty("data")]
        public Coin[] Coins { get; set; }
    }
}
