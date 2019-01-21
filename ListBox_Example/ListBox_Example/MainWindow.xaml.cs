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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ListBox_Example
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Skill> skills = new List<Skill>()
            {
                new Skill() {Name = "C#", Percent = 80},
                new Skill() {Name = "Java", Percent = 50},
                new Skill() {Name = "Python", Percent = 20},
                new Skill() {Name = "Entity Framework", Percent = 60},
                new Skill() {Name = "Angular", Percent = 70},
                new Skill() {Name = "Aurelia", Percent = 30},
                new Skill() {Name = "Backbone", Percent = 10},
                new Skill() {Name = "Ember", Percent = 0},
            };
            var skillVm = DataContext as SkillVM;
            skillVm.AddSkills(skills);
        }
    }
}