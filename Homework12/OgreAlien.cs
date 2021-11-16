using System;
using System.Collections.Generic;
using System.Text;

namespace Homework12
{
    //Derived class
    class OgreAlien : Alien
    {
        
        private int damage = 6;

        //Constructors
        public OgreAlien() : base()
        {

        }

        public OgreAlien(int type, int health, string name) : base(type, health, name)
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
