using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Problem
{
    class PointGuard : Player
    {
        public override void Substitution(Player teammate)
        {
            if(teammate is PointGuard)
            {
                Console.WriteLine($"{FirstName} {LastName}, you're in for {teammate.FirstName} {teammate.LastName}");
            }
            else
            {
                Console.WriteLine($"{teammate.FirstName} {teammate.LastName} is not a Point Guard");
            }

        }
    }
}
