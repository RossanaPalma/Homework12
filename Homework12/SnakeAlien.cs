using System;
using System.Collections.Generic;
using System.Text;

namespace Homework12
{
    //Derived class
    class SnakeAlien : Alien
    {
        
        private int damage = 10;
        
        //Constructors
        public SnakeAlien() : base()
        {

        }

        public SnakeAlien(int type, int health, string name) :
            base(type, health, name)
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
