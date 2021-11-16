using System;
using System.Collections.Generic;
using System.Text;

namespace Homework12
{
    //Base class : represents a monster
    class Alien
    {
        public enum AlienType {Snake, Ogre, MarshmallowMan};

        private int damage = 0;

        private int type;
        private int health; //0 = dead, 100 = full
        private string name;

        public int Type
        {
            get { return type; }
            set { type = value; }
        }
        
        public int Health   
        {
            get { return health; }
            set
            {
                if (value < 0)
                {
                    value = 1;
                }
                else if (value > 100)
                {
                    value = 100;
                }
                health = value;
            }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //Constructors
        public Alien()
        {
            Type = 0;
            Health = 100;
            Name = "Alien";
        }

        public Alien(int type, int health, string name) : this()
        {
            this.type = type;
            this.health = health;
            this.name = name;
        }

        public virtual int GetDamage()
        {
            return damage;
        }

        public override string ToString()
        {
            return String.Format("Type: {0}\nHealth: {1}\nName: {2}\nDamage: {3}\n",
                Enum.GetName(typeof(AlienType), Type), Health, Name, GetDamage());
        }

        public override bool Equals(object obj)
        {
            var alien = obj as Alien;
                return alien != null &&
                Type == alien.Type &&
                Health == alien.Health &&
                Name == alien.Name;
        }
    }
}
