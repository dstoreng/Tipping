using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Lotto.Model
{
    public class Lottorekke : INotifyPropertyChanged
    {
        private int _number1;
        private int _number2;
        private int _number3;
        private int _number4;
        private int _number5;
        private int _number6;
        private int _number7;

        private int _extra1;
        private int _extra2;
        private int _extra3;

        private int _prize7;
        private int _prize6_1;
        private int _prize6;
        private int _prize5;
        private int _prize4_1;

        private string _caption7;
        private string _caption6_1;
        private string _caption6;
        private string _caption5;
        private string _caption4_1;

        private string _joker;
        private string _date;
        private string _header;


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
        public int Number6
        {
            get { return _number6; }
            set
            {
                _number6 = value;
                OnPropertyChanged("number6");
            }
        }
        public int Number7
        {
            get { return _number7; }
            set
            {
                _number7 = value;
                OnPropertyChanged("number7");
            }
        }

        public int Extra1
        {
            get { return _extra1; }
            set
            {
                _extra1 = value;
                OnPropertyChanged("extra1");
            }
        }
        public int Extra2
        {
            get { return _extra2; }
            set
            {
                _extra2 = value;
                OnPropertyChanged("extra2");
            }
        }
        public int Extra3
        {
            get { return _extra3; }
            set
            {
                _extra3 = value;
                OnPropertyChanged("extra3");
            }
        }

        public int Prize7
        {
            get { return _prize7; }
            set
            {
                _prize7 = value;
                OnPropertyChanged("_prize7");
            }
        }
        public int Prize6_1
        {
            get { return _prize6_1; }
            set
            {
                _prize6_1 = value;
                OnPropertyChanged("_prize6_1");
            }
        }
        public int Prize6
        {
            get { return _prize6; }
            set
            {
                _prize6 = value;
                OnPropertyChanged("_prize6");
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
        public int Prize4_1
        {
            get { return _prize4_1; }
            set
            {
                _prize4_1 = value;
                OnPropertyChanged("_prize4_1");
            }
        }

        public string Caption7
        {
            get { return _caption7; }
            set
            {
                _caption7 = value;
                OnPropertyChanged("_caption7");
            }
        }
        public string Caption6_1
        {
            get { return _caption6_1; }
            set
            {
                _caption6_1 = value;
                OnPropertyChanged("_caption6_1");
            }
        }
        public string Caption6
        {
            get { return _caption6; }
            set
            {
                _caption6 = value;
                OnPropertyChanged("_caption6");
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
        public string Caption4_1
        {
            get { return _caption4_1; }
            set
            {
                _caption4_1 = value;
                OnPropertyChanged("_caption4_1");
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

        public string Header
        {
            get { return _header; }
            set
            {
                _header = value;
                OnPropertyChanged("_header");
            }
        }

        public string Joker
        {
            get { return _joker; }
            set
            {
                _joker = value;
                OnPropertyChanged("_joker");
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
