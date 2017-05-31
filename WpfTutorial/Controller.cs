using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfTutorial
{
    class Controller: INotifyPropertyChanged
    {
        private int currentButtonPosition = 0;
        private double _potValue = 0;

        public double PotValue
        {
            get { return _potValue; }
        }

        private void SetPotValue(double value) {
            _potValue = value;
            OnPropertyChanged("PotValue");
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
