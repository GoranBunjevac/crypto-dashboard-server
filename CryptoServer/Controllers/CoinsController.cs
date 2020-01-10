using System;
using System.Collections.Generic;
using System.Net;
using System.Web;
using CryptoServer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace CryptoServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoinsController : ControllerBase
    {
        private static string API_KEY = "2037ccf0-b158-48d5-80d8-3f0ca5a3c8c1";
        private readonly ILogger<CoinsController> _logger;

        public CoinsController(ILogger<CoinsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("{currency}")]
        public IEnumerable<Coin> GetCoins(string currency)
        {
            var URL = new UriBuilder($"https://pro-api.coinmarketcap.com/v1/cryptocurrency/listings/latest");

            var queryString = HttpUtility.ParseQueryString(string.Empty);
            queryString["start"] = "1";
            queryString["limit"] = "100";
            queryString["convert"] = currency;

            URL.Query = queryString.ToString();

            var client = new WebClient();
            client.Headers.Add("X-CMC_PRO_API_KEY", API_KEY);
            client.Headers.Add("Accepts", "application/json");

            var response = client.DownloadString(URL.ToString());

            var result = JsonConvert.DeserializeObject<CoinResponse>(response);

            return result.Coins;
        }
    }
}
