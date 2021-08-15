using System.Collections.Generic;

namespace WordCounter.Web.Interfaces
{
    public interface IWordCountService
    {
        /// <summary>
        /// Enumerates stringInput and count occurrences of words with same length
        /// </summary>
        /// <param name="stringInput">the string to enumerate</param>
        /// <returns>dictionary where key is word-length and value is occurrences</returns>
        Dictionary<int, int> CountOccurrencesOfWordLengthInString(string stringInput);
    }
}
