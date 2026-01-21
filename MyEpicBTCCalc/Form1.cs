using System.Net;
using System.Security.Cryptography.X509Certificates;
using Newtonsoft.Json;
using static System.Net.WebRequestMethods;

namespace MyEpicBTCCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BitcoinResultLabel_Click(object sender, EventArgs e)
        {

        }

        private void dddd_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public static BitcoinRates BitcoinRates()
        {
            string URL = "https://data-api.coindesk.com/index/cc/v1/latest/tick?market=cadli&instruments=BTC-USD,BTC-EUR&apply_mapping=true&api_key=ab3d58242e7d80130fedcaa95d62b44d72a68172cbf73f428a647c519e5490b6";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
            var webResponse = request.GetResponse();
            var webstream = webResponse.GetResponseStream();

            BitcoinRates newbitcoin;
            using (var responseReader = new StreamReader(webstream))
            {
                var data = responseReader.ReadToEnd();
                newbitcoin = JsonConvert.DeserializeObject<BitcoinRates>(data);
            }
            return newbitcoin;
        }

        private void getRate_Click(object sender, EventArgs e)
        {
            try
            {
                if (
                   (currencySelector.SelectedItem.ToString() != "USD" &&
                   currencySelector.SelectedItem.ToString() != "EUR") ||
                   currencySelector.SelectedItem.ToString() == null
                   )
                {
                    MessageBox.Show("Error", "VALUUTA ON VALIMATA");
                }
                else if (currencySelector.SelectedItem.ToString() == "USD")
                {
                    BitcoinRates newRate = BitcoinRates();
                    float result = (float)(float.Parse(bitcoinAmountInput.Text) * newRate.Data.BTCUSD.VALUE);
                    bitcoinResultLabel.Text = result.ToString();
                }
                else if (currencySelector.SelectedItem.ToString() == "EUR")
                {
                    BitcoinRates newRate = BitcoinRates();
                    float result = (float)(float.Parse(bitcoinAmountInput.Text) * newRate.Data.BTCEUR.VALUE);
                    bitcoinResultLabel.Text = result.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Tekkis viga, vea detailid: {ex.Message}", $"{ex}");
            }
        }
    }
}