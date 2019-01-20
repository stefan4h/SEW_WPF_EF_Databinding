using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RadioButtonCheckBox_Example
{
    public abstract class AViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void CallPropertyChanged(string property) { if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(property)); }
    }

    public class RadioButtonCheckBoxVM : AViewModel
    {
        private ESelection selection;
        private bool visible;
        //Currently selected enum value
        public ESelection Selection{
            get
            {
                return selection;
            }
            set
            {
                selection = value;
                CallPropertyChanged("Selection");
            }
        }
        //Bool which determines if groupbox is visible or not
        public bool Visible
        {
            get
            {
                return visible;
            }
            set
            {
                visible = value;
                CallPropertyChanged("Visible");
            }
        }

        public RadioButtonCheckBoxVM()
        {
            selection = ESelection.SECOND_SELECTION;
            visible = true;
        }
        //Shows the currently selected enum value
        public RelayCommand ShowSelection
        {
            get
            {
                return new RelayCommand(
                    o =>
                    {
                        MessageBox.Show(selection.ToString());
                    },
                    o => true);
            }
        }
    }
}
