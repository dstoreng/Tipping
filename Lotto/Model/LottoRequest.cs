using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace Lotto.Model
{
    public class LottoRequest
    {
        String lottoUrl = "https://www.norsk-tipping.no/api-lotto/getResultInfo.json?gameID=1&winnerDetails=true";
        String vikingUrl = "https://www.norsk-tipping.no/api-vikinglotto/getGameInformation.json";
        String jokerUrl = "https://www.norsk-tipping.no/api-joker/getGameInformation.json";


        public String ParseClean(String result)
        {
            int x = result.IndexOf('{');
            int y = result.LastIndexOf('}');

            return result.Substring(x, (y - x)+1);
        }

        public async Task<String> GetLottoResults()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(lottoUrl);
            string result;

            using (var response = (HttpWebResponse)(await Task<WebResponse>.Factory.FromAsync(request.BeginGetResponse, request.EndGetResponse, null)))
            {
                using (var responseStream = response.GetResponseStream())
                {
                    using (var sr = new StreamReader(responseStream))
                    {

                        result = await sr.ReadToEndAsync();
                    }
                }
            }
            return ParseClean(result);
        }

    }
}
