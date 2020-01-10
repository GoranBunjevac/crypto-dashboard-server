using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CryptoServer.Helpers;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace CryptoServer.Models
{
    [JsonConverter(typeof(FiatCurrencyConverter))]
    public class Quote
    {
        [JsonProperty("fiat_currency")]
        public FiatCurrency FiatCurrency { get; set; }
    }
}
