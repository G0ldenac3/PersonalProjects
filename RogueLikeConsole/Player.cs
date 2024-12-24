using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLikeConsole
{
    internal class Player
    {
        private int PlayerHealth;
        public int Health
        {
            get { return PlayerHealth; }
            set { PlayerHealth = value; }
        }
    }
}
