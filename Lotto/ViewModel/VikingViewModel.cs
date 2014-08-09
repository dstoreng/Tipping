using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Lotto.Model;
using Newtonsoft.Json;

namespace Lotto.ViewModel
{
    public class VikingViewModel
    {
        TippeRequest request;
        private Lottorekke _vikingrekke;
        public Lottorekke Vikingrekke
        {
            get { return _vikingrekke; }
            set
            {
                if(_vikingrekke != value){
                    _vikingrekke = value;
                    OnPropertyChanged("Vikingrekke");
                }
            }
        }

        public VikingViewModel()
        {
            Vikingrekke = new Lottorekke();
        }

        public async Task RetrieveDataAsync()
        {
            request = new TippeRequest();
            String jsonString = await request.GetLottoResults(TippeURI.VikingUri());
            dynamic data = JsonConvert.DeserializeObject(jsonString);
            var mainArray = data.mainTable;
            var luckyArray = data.luckyTable;
            var extraArray = data.addTable;
            var prizeArray = data.prizeTable;
            var captionArray = data.prizeCaptionTable;

            Vikingrekke.Number1 = mainArray[0];
            Vikingrekke.Number2 = mainArray[1];
            Vikingrekke.Number3 = mainArray[2];
            Vikingrekke.Number4 = mainArray[3];
            Vikingrekke.Number5 = mainArray[4];
            Vikingrekke.Number6 = mainArray[5];

            Vikingrekke.Extra1 = luckyArray[0];
            Vikingrekke.Extra2 = extraArray[0];
            Vikingrekke.Extra3 = extraArray[1];

            Vikingrekke.Joker = prizeArray[0];
            Vikingrekke.Prize6_1 = prizeArray[1];
            Vikingrekke.Prize6 = prizeArray[2];
            Vikingrekke.Prize5 = prizeArray[3];
            Vikingrekke.Prize4_1 = prizeArray[4];

            Vikingrekke.Caption7 = captionArray[0];
            Vikingrekke.Caption6_1 = captionArray[1];
            Vikingrekke.Caption6 = captionArray[2];
            Vikingrekke.Caption5 = captionArray[3];
            Vikingrekke.Caption4_1 = captionArray[4];

            Vikingrekke.Header = "PREMIEPROGNOSE";
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
