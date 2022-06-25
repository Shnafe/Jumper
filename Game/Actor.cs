
// Actor is the jumper sprite
using System;

namespace Jumper.Game // Note: actual namespace depends on the project name.
{
    public class Actor
    {
        // Director director = new Director();
        Services services;
        

        public Actor(Services services)
        {
            setServices(services);
        }

        private void setServices(Services servicesInstance){

            services = servicesInstance;
        }

        public void DrawOutput () {
            DrawLine();
            DrawParachute();

            bool lostGame = services.checkLossCondition();

            DrawPerson(lostGame);
            
            DrawTrees();
        }

        private void DrawLine()
        {
            for (int i = 0; i < services.currentProgress.Length; i++)
            {
                Console.Write($"{services.currentProgress[i]} ");
            }

            Console.WriteLine();
        }

        private void DrawParachute()
        {
            switch(services.numWrongGuesses)
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

        private void DrawPerson(bool lostGame)
        {
            if (lostGame)
            {
                Console.WriteLine("  X");
                Console.WriteLine(@" /|\");
                Console.WriteLine(@" / \");
                return;
            }
            
            Console.WriteLine("  O");
            Console.WriteLine(@" /|\");
            Console.WriteLine(@" / \");
            
        }

        private void DrawTrees()
        {
            Console.WriteLine("^^^^^^^");
        }
        
    }
}