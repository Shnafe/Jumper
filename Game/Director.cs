using System;
using System.Collections.Generic;


namespace Jumper.Game
{
    // <summary>
    // A person who directs the game. 
    //
    // The responsibility of a Director is to control the sequence of play.
    // </summary>
    public class Director
    {
        bool firstPlay = true;
        public char choiceLetter;
        public bool lostGame = false;

        // <summary>
        // Constructs a new instance of Director.
        // </summary>
        public Director()
        {
        }

        // <summary>
        // Starts the game by running the main game loop.
        // </summary>
        public void StartGame()
        {
            while (!(lostGame))
            {
                
                Console.WriteLine("Here");
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

    
        public void GetInputs()
        {   
            if (firstPlay)
            {
                return;
            }
            
            Console.Write("Guess a letter [a-z]: ");
            string userInput = Console.ReadLine();
            choiceLetter = char.Parse(userInput);
        }


        public void DoUpdates()
        {   
            Services services = new Services();
            
            if (firstPlay)
            {   
                services.GenerateWord();
                services.SplitWord();
                services.CreateLine();
                firstPlay = false;
                return;
            }
            
            services.GuessLetter();
        }


        public void DoOutputs()
        {   
            Actor actor = new Actor();
            
            actor.DrawLine();
            actor.DrawParachute();
            actor.DrawPerson();
            actor.DrawTrees();
        }
    }
}