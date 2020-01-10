using Newtonsoft.Json;

namespace CryptoServer.Models
{
    public class Status
    {
        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("error_code")]
        public string ErrorCode { get; set; }

        [JsonProperty("error_message")]
        public string ErrorMessage { get; set; }

        [JsonProperty("elapsed")]
        public int Elapsed { get; set; }

        [JsonProperty("credit_count")]
        public int CreditCount { get; set; }

        [JsonProperty("notice")]
        public string Notice { get; set; }
    }
}
