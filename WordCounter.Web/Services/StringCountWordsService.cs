using System;
using System.Collections.Generic;
using WordCounter.Web.Interfaces;

namespace WordCounter.Web.Services
{
    public class StringCountWordsService : IStringCountWordsService
    {
        public Dictionary<int, int> CountOccurrencesOfWordLengthInString(string stringInput)
        {
            if (stringInput == null) throw new ArgumentNullException(nameof(stringInput));
            
            Dictionary<int, int> countedWords = new Dictionary<int, int>();

            string[] words = stringInput.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in words)
            {
                int stringLength = word.Length;

                if (countedWords.ContainsKey(stringLength))
                {
                    countedWords[stringLength]++;
                }
                else
                {
                    countedWords[stringLength] = 1;
                }
            }

            return countedWords;
        }
    }
}
