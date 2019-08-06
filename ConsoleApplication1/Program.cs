using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            XO xo = new XO();

            do
            {
                xo.DrawInstructions();
                xo.DrawField();
                xo.ChooseOfPlayer();
                xo.numbers++;
                xo.GameOverAll();
                xo.ChooseOfAI();
                xo.numbers++;
                xo.GameOverAll();
                Console.Clear();
            }
            while (xo.GameOver == false);
           
        }
      

    
    }
}
