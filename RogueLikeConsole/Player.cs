using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace RogueLikeConsole
{
    internal class Player
    {
        private int maxHealth;
        private int currentHealth;
        private int Playerdamage;

        //constructor
        public Player(int maxHealth, int initialdamage)
        {
            this.maxHealth = maxHealth;
            this.currentHealth = maxHealth;
            this.Playerdamage = initialdamage;
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
        // Getting player damage
        public int GetDamage()
        {
            return Playerdamage;
        }

        // Setting player damage
        public void SetDamage(int newDamage)
        {
            Playerdamage = newDamage;
        }

        // Attacking an enemy
        public void Attack(Enemy enemy)
        {
            enemy.TakeDamage(Playerdamage);
        }
        public void AddDamage(int amount)
        {
            Playerdamage += amount;
        }
    }
}
