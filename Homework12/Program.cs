/// Chapter No. 24 - Homework12
/// File Name: Homework12.java
/// @author: Rossana Palma
/// Date:  November 14, 2021
///
/// Problem Statement: Rewrite the code so that inheritance is used to 
/// represent the different types of aliens instead of the “type” parameter.
/// This should result in deletion of the “type” parameter.  Also rewrite 
/// the Alien class to hide the instance variables and create a GetDamage 
/// method for each derived class that returns the amount of damage the alien
/// inflicts. Finally, rewrite the CalculateDamage method to use GetDamage 
/// and write a Main method that tests the code.
/// 
/// 
/// Overall Plan:
/// 1) Split the given code into Alien and AlienPack
/// 2) Use inheritance to represent the different types of aliens
/// 3) Create a GetDamage method for each derived class that returns the amount of damage
/// 4) Create CalculateDamage method to use GetDamage 
/// 5) Test the code in main driver

using System;

namespace Homework12
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int numberOfAliens = 3;
            AlienPack aliens = new AlienPack(numberOfAliens);

            aliens.AddAlien(new SnakeAlien(2, 45, "Cascavel"), 0);
            aliens.AddAlien(new OgreAlien(1, 60, "OgrO"), 1);
            aliens.AddAlien(new MarshmallowManAlien(1, 30, "Ghost"), 2);
            
            
            foreach (Alien alien in aliens.GetAliens())
            {
                Console.WriteLine(alien);
            }
            
            Console.WriteLine(String.Format("Total Damage: {0}", aliens.CalculateDamage()));

            Console.ReadLine(); 

        }
    }
}
