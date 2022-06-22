// Service is random word generator
using System;
using System.Collections.Generic;

namespace Jumper.Game // Note: actual namespace depends on the project name.
{
    public class Service
    {
        public List<string> wordChoices;
        public string randomWord;
        public Service()
        {

        }

        public void InitWords()
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

            List<string> wordChoices = new List<string>(words);
        }

        public void GenerateWord()
        {
            var randomChoice = new Random();
            int randomIndex = randomChoice.Next(wordChoices.Count);
            string randomWord = wordChoices[randomIndex];
        }

        public void GenerateLine()
        {
            string[] lines = {};
            List<string> letterLines = new List<string>(lines);
            int numLines = randomWord.Length;
            for (int i = 0; i < numLines; i++)
            {
                
            }
        }
    }
}