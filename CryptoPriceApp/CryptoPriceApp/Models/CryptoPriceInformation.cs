namespace CryptoPriceApp.Models
{
    public class CryptoPriceInformation
    {
        public int bitcoinPrice;
        public double cardanoPrice, dogecoinPrice, ethereumPrice, litecoinPrice, tetherPrice, solanaPrice;
        public double bitcoinChange, cardanoChange, dogecoinChange, ethereumChange, litecoinChange, tetherChange, solanaChange;
        protected string? url = new ConfigurationBuilder().AddJsonFile("appsettings.json")
                                            .Build()
                                            .GetSection("CryptoPriceURL")["cryptoPrice"];
        HttpClient client = new HttpClient();
        Root? cryptoPrice;
        public async Task CryptoPrice()
        {
            cryptoPrice = await client.GetFromJsonAsync<Root>(url);

            if (cryptoPrice is not null)
            {
                bitcoinPrice = cryptoPrice.bitcoin!.usd;
                bitcoinChange = Math.Round(cryptoPrice.bitcoin!.usd_24h_change, 3);

                cardanoPrice = Math.Round(cryptoPrice.cardano!.usd, 4);
                cardanoChange = Math.Round(cryptoPrice.cardano!.usd_24h_change, 3);

                dogecoinPrice = Math.Round(cryptoPrice.dogecoin!.usd, 4);
                dogecoinChange = Math.Round(cryptoPrice.dogecoin!.usd_24h_change, 3);

                ethereumPrice = Math.Round(cryptoPrice.ethereum!.usd, 2);
                ethereumChange = Math.Round(cryptoPrice.ethereum!.usd_24h_change, 3);

                litecoinPrice = Math.Round(cryptoPrice.litecoin!.usd, 4);
                litecoinChange = Math.Round(cryptoPrice.litecoin!.usd_24h_change, 3);

                tetherPrice = Math.Round(cryptoPrice.tether!.usd, 4);
                tetherChange = Math.Round(cryptoPrice.tether!.usd_24h_change, 3);

                solanaPrice = Math.Round(cryptoPrice.solana!.usd, 4);
                solanaChange = Math.Round(cryptoPrice.solana!.usd_24h_change, 3);
            }
        }

        public string? GetURL()
        {
            if (url is not null)
                return url;
            return null;
        }
    }
}
