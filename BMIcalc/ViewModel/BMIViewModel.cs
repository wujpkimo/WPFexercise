using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace BMIcalc.ViewModel
{
    public class BMIViewModel : NotifyPropertyBase
    {
        private double _height;

        public double Height
        {
            get { return _height; }
            set
            {
                SetProperty(ref _height, value);
            }
        }

        private double _weight;

        public double Weight
        {
            get { return _weight; }
            set
            {
                SetProperty(ref _weight, value);
            }
        }

        private double _bMIvalue;

        public double BMIvalue
        {
            get { return _bMIvalue; }
            set
            {
                SetProperty(ref _bMIvalue, value);
            }
        }

        private ICommand _calcCommand;

        public ICommand CalcCommand
        {
            get
            {
                if (_calcCommand == null)
                {
                    _calcCommand = new RelayCommand((x) => this.BMIvalue =
                    Weight / ((Height / 100) * (Height / 100))
                    );
                }
                return _calcCommand;
            }
        }
    }
}