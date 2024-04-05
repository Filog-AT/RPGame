using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.GameModels
{
    public class Entity : INotifyPropertyChanged
    {
        private int _experiencePoints;
        public string Name { get; set; }
        public string CharacterClass { get; set; }
        public int HitPoints { get; set; }
        public int ExperiencePoints { get; set; }
        public int Level 
        {
            get
            {
                return _experiencePoints;
            }
            set
            {
                _experiencePoints = value;
                OnPropertyChanged("ExperiencePoints");
            } 
        }
        public int Gold { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
