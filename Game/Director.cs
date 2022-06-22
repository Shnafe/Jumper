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
        bool isPlaying = true;
        string choiceLetter = "";
        Actor actor = new Actor();
        Service service = new Service();
        bool guessIsHigher = false;

        // <summary>
        // Constructs a new instance of Director.
        // </summary>
        public Director()
        {
            actor.DrawPerson();
        }

        // <summary>
        // Starts the game by running the main game loop.
        // </summary>
        public void StartGame()
        {
            
            while (isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        // <summary>
        // Asks the user if they want to play again and their guess.
        // </summary>
        public void GetInputs()
        {   
            if (firstPlay)
            {
                return;
            }
            
            choiceLetter = Console.ReadLine();
        }

        // Services file
        public void DoUpdates()
        {   
            if (firstPlay)
            {
                service.GenerateWord();
            }
            service.DrawLine();
            actor.DrawParachute();
            actor.DrawPerson();
        }

        // Actor file
        public void DoOutputs()
        {   
            
        }
    }
}