using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBoxTextBlockLabel_Example
{
    public abstract class AViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void CallPropertyChanged(string property) { if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(property)); }
    }

    public class TextBoxTextBlockLabelVM:AViewModel
    {
        private string heading;

        private string content;

        public string Content
        {
            get
            {
                return content;
            }
            set
            {
                content = value;
                CallPropertyChanged("Content");
            }
        }

        public string Heading
        {
            get
            {
                return heading;
            }
            set
            {
                heading = value;
                CallPropertyChanged("Heading");
            }
        }

        public TextBoxTextBlockLabelVM()
        {
            heading = "Beispiel";
            content = "Das ist ein Beispiel!Das ist ein Beispiel!Das ist ein Beispiel!Das ist ein Beispiel!Das ist ein Beispiel!Das ist ein Beispiel!Das ist ein Beispiel!";
        }

        public RelayCommand ClearHeading
        {
            get
            {
                return new RelayCommand(
                    o =>
                    {
                        Heading = "";
                    },
                    o => true);
            }
        }
        public RelayCommand ClearContent
        {
            get
            {
                return new RelayCommand(
                    o =>
                    {
                        Content = "";
                    },
                    o => true);
            }
        }
        public RelayCommand ClearBoth
        {
            get
            {
                return new RelayCommand(
                    o =>
                    {
                        Heading = "";
                        Content = "";
                    },
                    o => true);
            }
        }

    }
}
