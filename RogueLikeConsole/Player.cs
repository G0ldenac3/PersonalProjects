using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLikeConsole
{
    internal class Player
    {
        private int maxHealth;
        private int currentHealth;

        //constructor
        public Player(int maxHealth)
        {
            this.maxHealth = maxHealth;
            this.currentHealth = maxHealth;
        }

        //Taking damage

        public void TakeDamage(int damage)
        {
            currentHealth -= damage;
            if (currentHealth < 0)
            {
                currentHealth = 0;
            }
        }

        //Healing

        public void Heal(int healAmount)
        {
            currentHealth += healAmount;
            if (currentHealth > maxHealth)
            {
                currentHealth = maxHealth;
            }
        }

        //displaying health

        public void DisplayHealth()
        {
            Console.WriteLine("Player Health: " + currentHealth + "/" + maxHealth);
        }

        public bool IsDead()
        {
            return currentHealth == 0;
        }
    }
}
