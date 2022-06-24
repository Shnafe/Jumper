
// Actor is the jumper sprite
using System;

namespace Jumper.Game // Note: actual namespace depends on the project name.
{
    public class Actor
    {
        Director director = new Director();
        Services services = new Services();

        public Actor()
        {
        }

        public void DrawLine()
        {
            for (int i = 0; i < services.letterLines.Count; i++)
            {
                Console.Write(services.letterLines[i]);
            }
        }

        public void DrawParachute()
        {
            switch(services.guessesWrong)
            {
                case 0:
                    Console.WriteLine("");
                    Console.WriteLine(" ___");
                    Console.WriteLine(@"/___\");
                    Console.WriteLine(@"\   /");
                    Console.WriteLine(@" \ /");
                    break;
                case 1:
                    Console.WriteLine("");
                    Console.WriteLine(@"/___\");
                    Console.WriteLine(@"\   /");
                    Console.WriteLine(@" \ /");
                    break;
                case 2:
                    Console.WriteLine("");
                    Console.WriteLine(@"\   /");
                    Console.WriteLine(@" \ /");
                    break;
                case 3:
                    Console.WriteLine("");
                    Console.WriteLine(@" \ /");
                    break;
                default:
                    Console.WriteLine("");
                    break;
            }
            
        }

        public void DrawPerson()
        {
            if (director.lostGame)
            {
                Console.WriteLine(" X");
                Console.WriteLine(@"/|\");
                Console.WriteLine(@"/ \");
                return;
            }
            
            Console.WriteLine(" O");
            Console.WriteLine(@"/|\");
            Console.WriteLine(@"/ \");
            
        }

        public void DrawTrees()
        {
            Console.WriteLine("^^^^^^^");
        }
        
    }
}