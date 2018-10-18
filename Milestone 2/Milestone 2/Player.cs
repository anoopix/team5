using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone_2
{
    class Player
    {
        // attributes
        private int money;
        private int strength;
        private int intelligence;
        private int charm;

        // properties
        public int Money
        {
            get
            {
                return money;
            }
            set
            {
                money = value;
            }
        }

        public int Strength
        {
            get
            {
                return strength;
            }
            set
            {
                strength = value;
            }
        }

        public int Intelligence
        {
            get
            {
                return intelligence;
            }
            set
            {
                intelligence = value;
            }
        }

        public int Charm
        {
            get
            {
                return charm;
            }
            set
            {
                charm = value;
            }
        }

        // methods
        public void ChangeMoney(int num)
        {
            money += num;
        }

        public void ChangeStrength(int num)
        {
            strength += num;
        }

        public void ChangeIntelligence(int num)
        {
            intelligence += num;
        }

        public void ChangeCharm(int num)
        {
            charm += num;
        }

        // constructor
        public Player(int money, int strength, int intelligence, int charm)
        {
            this.money = money;
            this.strength = strength;
            this.intelligence = intelligence;
            this.charm = charm;
        }
    }
}
