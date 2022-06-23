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
        Actor actor = new Actor();
        Service service = new Service();
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
            
            Console.Write("Guess a letter [a-z]: ");
            string userInput = Console.ReadLine();
            choiceLetter = char.Parse(userInput);
        }

        // Services file
        public void DoUpdates()
        {   
            if (firstPlay)
            {   
                service.GenerateWord();
                firstPlay = false;
            }
            service.CreateLine();
        }

        // Actor file
        public void DoOutputs()
        {   
            actor.DrawParachute();
            actor.DrawPerson();
            actor.DrawTrees();
        }
    }
}