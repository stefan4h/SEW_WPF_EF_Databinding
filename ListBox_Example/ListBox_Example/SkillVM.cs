using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ListBox_Example.Annotations;

namespace ListBox_Example
{
    class SkillVM:INotifyPropertyChanged
    {
        private Skill skill;
        public Skill Skill
        {
            get => skill;
            set
            {
                skill = value;
                OnPropertyChanged();
            }
        }

        private Skill selectedSkill=null;
        public Skill SelectedSkill
        {
            get => selectedSkill;
            set
            {
                selectedSkill = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Skill> Skills { get; set; }=new ObservableCollection<Skill>();

        public SkillVM()
        {
            Skill=new Skill();
        }

        public SkillVM(List<Skill> skills)
        {
            Skills=new ObservableCollection<Skill>(skills);
            Skill=new Skill();
        }

        public void AddSkills(List<Skill>skills)
        {
            foreach (var item in skills)
            {
                Skills.Add(item);
            }        
        }

        public ICommand AddSkillCommand
        {
            get { return new RelayCommand(o=>AddSkill(),o=>!string.IsNullOrEmpty(skill.Name));}
        }

        private void AddSkill()
        {
            Skills.Add(new Skill(){Name = skill.Name,Percent = 0});
            Skill=new Skill();
        }

        public ICommand AddPercentageCommand
        {
            get { return new RelayCommand(o=>AddPercentage(),o=>SelectedSkill!=null&&SelectedSkill.Percent<91);}
        }

        private void AddPercentage()
        {
            SelectedSkill.Percent += 10;
        }
        public ICommand RemovePercentageCommand
        {
            get { return new RelayCommand(o => RemovePercentage(), o => SelectedSkill != null && SelectedSkill.Percent >9); }
        }

        private void RemovePercentage()
        {
            SelectedSkill.Percent -= 10;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
