namespace CryptoPriceApp.Models
{
    public class Bitcoin
    {
        public int usd { get; set; }
        public double usd_market_cap { get; set; }
        public double usd_24h_vol { get; set; }
        public double usd_24h_change { get; set; }
        public int last_updated_at { get; set; }
    }

    public class Cardano
    {
        public double usd { get; set; }
        public double usd_market_cap { get; set; }
        public double usd_24h_vol { get; set; }
        public double usd_24h_change { get; set; }
        public int last_updated_at { get; set; }
    }

    public class Dogecoin
    {
        public double usd { get; set; }
        public double usd_market_cap { get; set; }
        public double usd_24h_vol { get; set; }
        public double usd_24h_change { get; set; }
        public int last_updated_at { get; set; }
    }

    public class Ethereum
    {
        public double usd { get; set; }
        public double usd_market_cap { get; set; }
        public double usd_24h_vol { get; set; }
        public double usd_24h_change { get; set; }
        public int last_updated_at { get; set; }
    }

    public class Litecoin
    {
        public double usd { get; set; }
        public double usd_market_cap { get; set; }
        public double usd_24h_vol { get; set; }
        public double usd_24h_change { get; set; }
        public int last_updated_at { get; set; }
    }

    public class Root
    {
        public Bitcoin? bitcoin { get; set; }
        public Cardano? cardano { get; set; }
        public Dogecoin? dogecoin { get; set; }
        public Ethereum? ethereum { get; set; }
        public Litecoin? litecoin { get; set; }
        public Solana? solana { get; set; }
        public Tether? tether { get; set; }
    }

    public class Solana
    {
        public double usd { get; set; }
        public double usd_market_cap { get; set; }
        public double usd_24h_vol { get; set; }
        public double usd_24h_change { get; set; }
        public int last_updated_at { get; set; }
    }

    public class Tether
    {
        public double usd { get; set; }
        public double usd_market_cap { get; set; }
        public double usd_24h_vol { get; set; }
        public double usd_24h_change { get; set; }
        public int last_updated_at { get; set; }
    }


}
