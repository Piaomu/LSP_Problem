using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Problem
{
    class Player
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool NeedsOut { get; set; }
        public virtual void ShouldPlay(int fouls, int minutesPlayed)
        {
            if (minutesPlayed > 35)
            {
                Console.WriteLine($"{FirstName} {LastName}: Take me out, coach");
                NeedsOut = true;
            }

            else if (fouls > 5)
            {
                Console.WriteLine($"{FirstName} {LastName}: I fouled out, coach");
                NeedsOut = true;
            }

            else if (fouls > 3 && minutesPlayed < 20)
            {
                Console.WriteLine($"{FirstName} {LastName}: I played too hard, coach");
                NeedsOut = true;
            }
            else
            {
                Console.WriteLine($"{FirstName} {LastName}: Put me in, coach!");
                NeedsOut = false;
            }
        }
        public virtual void Substitution(Player teammate)
        {
            Console.WriteLine($"{FirstName} {LastName}, you're in for {teammate.FirstName} {teammate.LastName}");
        }
    }
}