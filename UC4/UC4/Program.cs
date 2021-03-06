using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC4
{
    class Program
    {
        static void Main(string[] args)
        {
            const int NO_PLAY = 1;
            const int LADDER = 2;
            const int SNAKE_BITE = 3;
            int position = 0;

            while (position <= 100)
            {
                Random random = new Random();
                int dice = random.Next(1, 7);
                int checkOption = random.Next(1, 4);
                switch (checkOption)
                {
                    case NO_PLAY:
                        position = 0;
                        break;
                    case LADDER:
                        position = position + dice;
                        break;
                    case SNAKE_BITE:
                        position = position - dice;
                        break;
                    default:
                        position = 0;
                        break;
                }
                if (position < 0)
                {
                    Console.WriteLine("Player restarts from 0");
                }
                else
                {
                    Console.WriteLine("Player stays in same postion");
                }
            }
        }
    }
}
