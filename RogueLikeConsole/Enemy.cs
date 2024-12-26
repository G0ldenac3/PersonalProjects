using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace RogueLikeConsole
{
    internal class Enemy
    {
        private int maxHealth;
        private int currentHealth;
        private int Enemydamage;

        // Constructor
        public Enemy(int maxHealth, int initialdamage)
        {
            this.maxHealth = maxHealth;
            this.currentHealth = maxHealth;
            this.Enemydamage = initialdamage;
        }

        // Taking damage
        public void TakeDamage(int damage)
        {
            currentHealth -= damage;
            if (currentHealth < 0)
            {
                currentHealth = 0;
            }
        }

        // Displaying health
        public void DisplayHealth()
        {
            Console.WriteLine("Enemy Health: " + currentHealth + "/" + maxHealth);
        }

        public bool IsDead()
        {
            return currentHealth == 0;
        }


        // Getting enemy damage
        public int GetDamage()
        {
            return Enemydamage;
        }

        // Setting enemy damage
        public void SetDamage(int newDamage)
        {
            Enemydamage = newDamage;
        }

        // Attacking the player
        public void Attack(Player player)
        {
            player.TakeDamage(Enemydamage);
        }
    }
}
