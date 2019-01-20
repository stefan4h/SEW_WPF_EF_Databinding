using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Datagrid_Databinding_Example.ViewModel;

namespace Datagrid_Databinding_Example.View
{
    /// <summary>
    /// Interaktionslogik für CreateUserView.xaml
    /// </summary>
    public partial class CreateUserView : Window
    {
        public CreateUserView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void dp_birthdate_Loaded(object sender, RoutedEventArgs e)
        {
            dp_birthdate = sender as DatePicker;
            dp_birthdate.DisplayDate=DateTime.Now;
            dp_birthdate.SelectedDate=DateTime.Now;
        }
    }
}
