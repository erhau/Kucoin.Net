using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using CryptoExchange.Net.Converters;

namespace Kucoin.Net.Objects.Models.Spot
{
    /// <summary>
    /// Borrow outstanding record
    /// </summary>
    public class KucoinBorrowUnrepaid
    {
        /// <summary>
        /// Trade ID
        /// </summary>
        public string TradeId { get; set; } = string.Empty;

        /// <summary>
        /// Currency
        /// </summary>
        [JsonProperty("currency")]
        public string Asset { get; set; } = string.Empty;

        /// <summary>
        /// Total liabilities
        /// </summary>
        [JsonProperty("liability")]
        public decimal Liabilities { get; set; }

        /// <summary>
        /// Principal
        /// </summary>
        public decimal Principal { get; set; }

        /// <summary>
        /// Accrued interest
        /// </summary>
        [JsonProperty("accruedInterest")]
        public decimal Interests { get; set; }

        /// <summary>
        /// Term
        /// </summary>
        public int Term { get; set; }

        /// <summary>
        /// Repaid size
        /// </summary>
        [JsonProperty("repaidSize")]
        public decimal Repaid { get; set; }

        /// <summary>
        /// Daily interest rate
        /// </summary>
        [JsonProperty("dailyIntRate")]
        public decimal DailyInterestRate { get; set; }

        /// <summary>
        /// Execution time
        /// </summary>
        [JsonProperty("createdAt"), JsonConverter(typeof(DateTimeConverter))]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Maturity time
        /// </summary>
        [JsonProperty("maturityTime"), JsonConverter(typeof(DateTimeConverter))]
        public DateTime MaturityTime { get; set; }
    }
}
