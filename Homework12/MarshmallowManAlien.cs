using System;
using System.Collections.Generic;
using System.Text;

namespace Homework12
{
    //Derived class
    class MarshmallowManAlien : Alien
    {
        
        private int damage = 1;

        //Constructors
        public MarshmallowManAlien() : base()
        {

        }

        public MarshmallowManAlien(int type, int health, string name) : base(type, health, name)
        {

        }

        //GetDamage method
        public override int GetDamage()
        {
            return damage;
        }

        
        public override string ToString()
        {
            return base.ToString();
        }
    }
}

  
