using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC5
{
    class Program
    {
        static void Main(string[] args)
        {
            const int NO_PLAY = 1;
            const int MOVES_AHEAD = 2;
            const int MOVES_BEHIND = 3;
            int position = 0;

            while (position <= 100)
            {
                Random random = new Random();
                int dice = random.Next(1, 7);
                int checkOption = random.Next(1, 4);
                int previousPosition = position;
                switch (checkOption)
                {
                    case NO_PLAY:
                        position = 0;
                        break;
                    case MOVES_AHEAD:
                        position = position + dice;
                        break;
                    case MOVES_BEHIND:
                        position = position - dice;
                        break;

                    default:
                        position = 0;
                        break;
                }
                if (position > 100)
                {
                    position = previousPosition;
                    Console.WriteLine("PLAYER STAYS IN SAME POSITION: " + position);
                }
                else
                {
                    position = 100;
                }
            }
        }
    }
}
