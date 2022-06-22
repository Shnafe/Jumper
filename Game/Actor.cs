
// Actor is the jumper sprite
using System;

namespace Jumper.Game // Note: actual namespace depends on the project name.
{
    public class Actor
    {
         int guessesWrong = 0;

        public Actor()
        {
        }

        public void DrawParachute()
        {
            if (guessesWrong == 0)
            {
                Console.WriteLine(" ___");
                Console.WriteLine(@"/___\");
                Console.WriteLine(@"\   /");
                Console.WriteLine(@" \ /"); 
            }

            if (guessesWrong == 1)
            {
                Console.WriteLine(@"/___\");
                Console.WriteLine(@"\   /");
                Console.WriteLine(@" \ /");
            }

            if (guessesWrong == 2)
            {
                Console.WriteLine(@"\   /");
                Console.WriteLine(@" \ /");
            }

            if (guessesWrong == 3)
            {
                Console.WriteLine(@"\   /");
                Console.WriteLine(@" \ /");
            }
        }

        public void DrawPerson()
        {
            Console.WriteLine(" O");
            Console.WriteLine(@"/|\");
            Console.WriteLine(@"/ \");
        }
        
    }
}