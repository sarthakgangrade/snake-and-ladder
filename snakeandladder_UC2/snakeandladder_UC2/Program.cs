using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakeandladder_UC2
{
    class Program
    {
        static void Main(string[] args)
        {
            int player1 = 0;
            Random random = new Random();
            player1 = random.Next(1, 6);
            Console.WriteLine(player1);
        }
    }
}
