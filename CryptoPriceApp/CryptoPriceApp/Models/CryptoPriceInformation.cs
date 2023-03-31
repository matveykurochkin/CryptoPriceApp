namespace CryptoPriceApp.Models
{
    public class CryptoPriceInformation
    {
        public int bitcoinPrice;
        public double cardanoPrice, dogecoinPrice, ethereumPrice, litecoinPrice, tetherPrice;
        public double bitcoinChange;
        public async Task CryptoPrice()
        {
            string url = new ConfigurationBuilder().AddJsonFile("appsettings.json")
                                            .Build()
                                            .GetSection("CryptoPriceURL")["cryptoPrice"];

            HttpClient client = new HttpClient();

            Root? cryptoPrice = await client.GetFromJsonAsync<Root>(url);

            if (cryptoPrice is not null)
            {
                bitcoinPrice = cryptoPrice.bitcoin!.usd;
                bitcoinChange = cryptoPrice.bitcoin!.usd_24h_change;

                cardanoPrice = cryptoPrice.cardano!.usd;

                dogecoinPrice = cryptoPrice.dogecoin!.usd;

                ethereumPrice = cryptoPrice.ethereum!.usd;

                litecoinPrice = cryptoPrice.litecoin!.usd;

                tetherPrice = cryptoPrice.tether!.usd;
            }

        }

    }
}
