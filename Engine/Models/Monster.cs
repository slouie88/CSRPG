using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Engine.Models
{
    public class Monster : BaseNotifcationClass
    {
        private int _hitpoints;

        public string Name { get; private set; }
        public string ImageName { get; set; }
        public int MaxHitPoints { get; private set; }
        public int HitPoints
        {
            get { return _hitpoints; }
            private set
            {
                _hitpoints = value;
                OnPropertyChanged(nameof(HitPoints));
            }
        }
        public int RewardExperiencePoints { get; private set; }
        public int RewardGold { get; private set; }

        public ObservableCollection<ItemQuantity> Inventory { get; set; }

        public Monster(string name, string imageName, int maxHitPoints, int hitPoints, int rewardExperiencePoints, int rewardGold)
        {
            Name = name;
            ImageName = string.Format("/Engine;component/Images/Monsters/{0}", imageName);
            MaxHitPoints = maxHitPoints;
            RewardExperiencePoints = rewardExperiencePoints;
            RewardGold = rewardGold;

            Inventory = new ObservableCollection<ItemQuantity>();
        }
    }
}
