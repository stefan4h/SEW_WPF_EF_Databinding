using ProgressBarExample;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;

namespace ProgressBarVMSpace
{
    public abstract class AViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void CallPropertyChanged(string property) { if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(property)); }
    }

    public class ProgressBarVM:AViewModel
    {
        private System.Timers.Timer aTimer;

        private int currentValue;
        private int minValue;
        private int maxValue;

        public ProgressBarVM()
        {
            minValue = 0;
            maxValue = 100;
            currentValue = 99;
        }
        //Current value of the progressbar
        public int CurrentValue
        {
            get
            {
                return currentValue;
            }
            set
            {
                currentValue = value;
                CallPropertyChanged("CurrentValue");
            }
        }
        //Minimum of the progressbar
        public int MinValue
        {
            get
            {
                return minValue;
            }
        }
        //Maximumn of the progressbar
        public int MaxValue
        {
            get
            {
                return maxValue;
            }
        }
        //Command that sets the timer
        public RelayCommand IncreaseToMax
        {
            get
            {
                return new RelayCommand(
                    o =>
                    {
                        aTimer = new System.Timers.Timer(1000);
                        aTimer.Elapsed += Increase;
                        aTimer.AutoReset = true;
                        aTimer.Enabled = true;
                    },
                    o => true);
            }
        }
        //Command that stops and disposes the timer
        public RelayCommand StopIncreaseToMax
        {
            get
            {
                return new RelayCommand(
                    o =>
                    {
                        aTimer.Stop();
                        aTimer.Dispose();
                    },
                    o => true);
            }
        }
        //Method that is called every second by the timer
        private void Increase(Object source, ElapsedEventArgs e)
        {
            if (CurrentValue < MaxValue)
            {
                CurrentValue=CurrentValue+1;
            }
            else
            {
                CurrentValue = MinValue;
            }
        }
    }
}
