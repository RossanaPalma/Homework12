using System;
using System.Collections.Generic;
using System.Text;

namespace Homework12
{
    //represents a band of aliens and how much damage they can inflict.
    class AlienPack
    {
        private Alien[] aliens;

        public AlienPack(int numberOfAliens)
        {
            aliens = new Alien[numberOfAliens];
        }
           
        public void AddAlien(Alien newAlien, int index)
        {
            aliens[index] = newAlien;
        }

        public Alien[] GetAliens()
        {
            return aliens;
        }

        //CalculateDamage method
        public int CalculateDamage()
        {
            int damage = 0;
                   
            foreach (Alien a in aliens)
            {   
                if (a != null)
                {
                    damage += a.GetDamage();
                }
                
            }
            return damage;
        }
    }
}
