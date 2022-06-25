// Service is random word generator
using System;
using System.Collections.Generic;

namespace Jumper.Game // Note: actual namespace depends on the project name.
{
    public class Services
    {
        // Declare Variables. 
        private string[] wordBank;
        private string randomWord;
        public string currentProgress;
        public int numWrongGuesses = 0;
        

        // Builds class instance.
        public Services()
        {
            // Build word bank.
            InitWords();
            //Get a random word.
            GetRandomWord();
            // Provide an initial value for guess progress.
            InitCurrentProgress();
        }

        private void InitWords()
        {
            
            string[] words = 
            {
                "time", "year", "people", "way", "day", "man", "thing", "woman", "life", "child",
                "world", "school", "state", "family", "student", "group", "country", "problem", "hand", "part",
                "place", "case", "week", "company", "system", "program", "question", "work", "government", "number",
                "night", "point", "home", "water", "room", "mother", "area", "money", "story", "fact",
                "month", "lot", "right", "study", "book", "eye", "job", "word", "business", "issue",
                "side", "kind", "head", "house", "service", "friend", "father", "power", "hour", "game",
                "line", "end", "member", "law", "car", "city", "community", "name", "president", "team",
                "minute", "idea", "kid", "body", "information", "back", "parent", "face", "others", "level",
                "office", "door", "health", "person", "art", "war", "history", "party", "result", "change",
                "morning", "reason", "research", "girl", "guy", "moment", "air", "teacher", "force", "education"
            };

             wordBank = words;
        }

        private void GetRandomWord()
        {

            Random randomChoice = new Random();
            int randomIndex = randomChoice.Next(0, wordBank.Length);
            randomWord = wordBank[randomIndex];
        }


        private void InitCurrentProgress()
        {
            for (int i = 0; i < randomWord.Length; i++)
            {
                currentProgress += "_";
            }
        }

        public void checkGuess(char userGuess)
        {
            bool guessedCorrectly = false;

            for (int i = 0; i < randomWord.Length; i++)
            {
                if (randomWord[i] == userGuess)
                {   
                    setCurrentProgress(userGuess);
                    guessedCorrectly = true;
                }
            }

            if (!(guessedCorrectly))
            {
                numWrongGuesses += 1;
            }
        }

        private void setCurrentProgress(char userGuess){
            

            // Temporary array to hold guess information.
            char[] tempPlaceHolder = new char[randomWord.Length];

            for (int i = 0; i < randomWord.Length; i++){
                
                // If the answer at the index is not the guess fill with old progress.
                if (userGuess != randomWord[i]) {

                    tempPlaceHolder[i] = currentProgress[i];

                }
                // Else fill in with the guess.
                else {

                    tempPlaceHolder[i] = userGuess;
                }

            }

            // Put the final guess progress into a string.
            currentProgress = new string ( tempPlaceHolder);
            
        }

        public bool checkLossCondition () {
            
            if (numWrongGuesses >= 4) {
                return true;

            } else {
                return false;
            }
        }

        public bool checkForCompleteAnswer() {

            bool gotAnswer = true;

            for(int i = 0; i < currentProgress.Length; i++){

                if (currentProgress[i] == '_'){

                    gotAnswer = false;
                }
            }

            return gotAnswer;
        }
    }
}