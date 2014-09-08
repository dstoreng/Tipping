using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto.Model
{
    public class Jokerrekke
    {
        private int _number1;
        private int _number2;
        private int _number3;
        private int _number4;
        private int _number5;

        private int _prizeWinner;
        private int _prize5;
        private int _prize4;
        private int _prize3;
        private int _prize2;

        private string _captionWinner;
        private string _caption5;
        private string _caption4;
        private string _caption3;
        private string _caption2;

        private string _header;
        private string _date;


        public int Number1
        {
            get { return _number1; }
            set
            {
                _number1 = value;
                OnPropertyChanged("number1");
            }
        }
        public int Number2
        {
            get { return _number2; }
            set
            {
                _number2 = value;
                OnPropertyChanged("number2");
            }
        }
        public int Number3
        {
            get { return _number3; }
            set
            {
                _number3 = value;
                OnPropertyChanged("number3");
            }
        }
        public int Number4
        {
            get { return _number4; }
            set
            {
                _number4 = value;
                OnPropertyChanged("number4");
            }
        }
        public int Number5
        {
            get { return _number5; }
            set
            {
                _number5 = value;
                OnPropertyChanged("number5");
            }
        }

        public int PrizeWinner
        {
            get { return _prizeWinner; }
            set
            {
                _prizeWinner = value;
                OnPropertyChanged("_prizeWinner");
            }
        }
        public int Prize5
        {
            get { return _prize5; }
            set
            {
                _prize5 = value;
                OnPropertyChanged("_prize5");
            }
        }
        public int Prize4
        {
            get { return _prize4; }
            set
            {
                _prize4 = value;
                OnPropertyChanged("_prize4");
            }
        }
        public int Prize3
        {
            get { return _prize3; }
            set
            {
                _prize3 = value;
                OnPropertyChanged("_prize3");
            }
        }
        public int Prize2
        {
            get { return _prize2; }
            set
            {
                _prize2 = value;
                OnPropertyChanged("_prize2");
            }
        }

        public string CaptionWinner
        {
            get { return _captionWinner; }
            set
            {
                _captionWinner = value;
                OnPropertyChanged("_captionWinner");
            }
        }

        public string Caption5
        {
            get { return _caption5; }
            set
            {
                _caption5 = value;
                OnPropertyChanged("_caption5");
            }
        }
        public string Caption4
        {
            get { return _caption4; }
            set
            {
                _caption4 = value;
                OnPropertyChanged("_caption4");
            }
        }
        public string Caption3
        {
            get { return _caption3; }
            set
            {
                _caption3 = value;
                OnPropertyChanged("_caption3");
            }
        }
        public string Caption2
        {
            get { return _caption2; }
            set
            {
                _caption2 = value;
                OnPropertyChanged("_caption2");
            }
        }
        
        public string Header
        {
            get { return _header; }
            set
            {
                _header = value;
                OnPropertyChanged("_header");
            }
        }

        public string Date
        {
            get { return _date; }
            set
            {
                _date = value;
                OnPropertyChanged("_date");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }

    }
}
