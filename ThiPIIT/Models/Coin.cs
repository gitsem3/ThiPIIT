using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThiPIIT.Models
{
    public class Coin
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string BaseAsset { get; set; }
        public string QuoteAsset { get; set; }
        public string LastPrice { get; set; }
        public string Volumn24h { get; set; }
        public int MarketId { get; set; }
        public DateTimeKind CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public int Status { get; set; }
    }
}