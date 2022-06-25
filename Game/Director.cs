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
        public char userGuess;
        public bool gameEnd = false;
        Services services = new Services();
        
        Actor actor;

        // <summary>
        // Constructs a new instance of Director.
        // </summary>
        public Director()
        {
            actor = new Actor(services);
        }

        // <summary>
        // Starts the game by running the main game loop.
        // </summary>
        public void StartGame()
        {
            // Loop while game is running.
            while (!(gameEnd))
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

    
        public void GetInputs()
        {   
            // If its first turn do nothing.
            if (firstPlay)
            {
                return;
            }
            
            // Ask user for their guess. 
            Console.Write("Guess a letter [a-z]: ");

            // Read in the users input then parse from string to char.
            string tempUserInput = Console.ReadLine();
            userGuess = char.Parse(tempUserInput);

        }

        public void DoUpdates()
        {   
            if (firstPlay){
                firstPlay = false;
                return;
            }

            services.checkGuess(userGuess);
        }

        public void DoOutputs()
        {   
            actor.DrawOutput();

            gameEnd = services.checkForCompleteAnswer() || services.checkLossCondition();
        }
    }
}