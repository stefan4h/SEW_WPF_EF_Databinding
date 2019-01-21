using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Slider_Databinding_Example
{
    class SliderVM:INotifyPropertyChanged
    {
        private int redValue;
        public int RedValue
        {
            get { return redValue; }
            set
            {
                redValue = value;
                OnPropertyChanged();
            }
        }
        private int greenValue;
        public int GreenValue
        {
            get { return greenValue; }
            set
            {
                greenValue = value;
                OnPropertyChanged();
            }
        }

        private int blueValue;
        public int BlueValue
        {
            get { return blueValue; }
            set
            {
                blueValue = value;
                OnPropertyChanged();
            }
        }

        //private SolidColorBrush background;
        //public SolidColorBrush Background
        //{
        //    get => background;
        //    set { background}
        //}

        public RelayCommand RandomColourCommand
        {
            get
            {
                return new RelayCommand(
                    o =>
                    {
                        Random rnd = new Random();
                        RedValue = rnd.Next(1, 255);
                        GreenValue = rnd.Next(1, 255);
                        BlueValue = rnd.Next(1, 255);
                    },
                    o => true 
                );
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
