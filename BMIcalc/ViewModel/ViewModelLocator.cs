using System;
using System.Collections.Generic;
using System.Text;

namespace BMIcalc.ViewModel
{
    public class ViewModelLocator
    {
        public BMIViewModel BMIViewModel
        {
            get { return new BMIViewModel(); }
        }
    }
}