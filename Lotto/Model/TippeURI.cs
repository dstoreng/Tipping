using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto.Model
{
    static class TippeURI
    {
        public static string LottoUri()
        {
            return "https://www.norsk-tipping.no/api-lotto/getResultInfo.json?gameID=1&winnerDetails=true";
        }

        public static string JokerUri()
        {
            return "https://www.norsk-tipping.no/api-joker/getGameInformation.json";
        }

        public static string VikingUri()
        {
            return "https://www.norsk-tipping.no/api-vikinglotto/getResultInfo.json?gameID=2&winnerDetails=true";
        }
    }
}
