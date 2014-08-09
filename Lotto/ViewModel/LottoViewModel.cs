using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Newtonsoft.Json;

namespace Lotto.Model
{
    public class LottoViewModel : INotifyPropertyChanged
    {
        TippeRequest request;
        private Lottorekke _lottorekke;
        public Lottorekke Lottorekke{
            get { return _lottorekke; }
            set{ 
                if(_lottorekke != value)
                {
                    _lottorekke = value;
                    OnPropertyChanged("Lottorekke changed");
                }
            }
        }

        public LottoViewModel()
        {
            Lottorekke = new Lottorekke();
        }

        public async Task RetrieveDataAsync()
        {
            request = new TippeRequest();
            String jsonString = await request.GetLottoResults(TippeURI.LottoUri());
            dynamic data = JsonConvert.DeserializeObject(jsonString);
            var mainArray = data.mainTable;
            var extraArray = data.addTable;
            var prizeArray = data.prizeTable;
            var captionArray = data.prizeCaptionTable;

            Lottorekke.Number1 = mainArray[0];
            Lottorekke.Number2 = mainArray[1];
            Lottorekke.Number3 = mainArray[2];
            Lottorekke.Number4 = mainArray[3];
            Lottorekke.Number5 = mainArray[4];
            Lottorekke.Number6 = mainArray[5];
            Lottorekke.Number7 = mainArray[6];

            Lottorekke.Extra1 = extraArray[0];
            Lottorekke.Extra2 = extraArray[1];
            Lottorekke.Extra3 = extraArray[2];

            Lottorekke.Prize7 = prizeArray[0];
            Lottorekke.Prize6_1 = prizeArray[1];
            Lottorekke.Prize6 = prizeArray[2];
            Lottorekke.Prize5 = prizeArray[3];
            Lottorekke.Prize4_1 = prizeArray[4];

            Lottorekke.Caption7 = captionArray[0];
            Lottorekke.Caption6_1 = captionArray[1];
            Lottorekke.Caption6 = captionArray[2];
            Lottorekke.Caption5 = captionArray[3];
            Lottorekke.Caption4_1 = captionArray[4];

            Lottorekke.Header = "PREMIEPROGNOSE";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
