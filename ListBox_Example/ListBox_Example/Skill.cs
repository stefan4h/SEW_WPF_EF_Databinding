using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ListBox_Example.Annotations;

namespace ListBox_Example
{
    public class Skill:INotifyPropertyChanged
    {
        private string name;
        public string Name
        {
            get => name;
            set { name = value; OnPropertyChanged(); }
        }

        private int percent;
        public int Percent
        {
            get => percent;
            set { percent = value; OnPropertyChanged(); }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
