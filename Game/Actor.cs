
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
            switch(guessesWrong)
            {
                case 0:
                    Console.WriteLine(" ___");
                    Console.WriteLine(@"/___\");
                    Console.WriteLine(@"\   /");
                    Console.WriteLine(@" \ /");
                    break;
                case 1:
                    Console.WriteLine(@"/___\");
                    Console.WriteLine(@"\   /");
                    Console.WriteLine(@" \ /");
                    break;
                case 2:
                    Console.WriteLine(@"\   /");
                    Console.WriteLine(@" \ /");
                    break;
                case 3:
                    Console.WriteLine(@" \ /");
                    break;
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