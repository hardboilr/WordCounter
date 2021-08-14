using System.Collections.Generic;

namespace WordCounter.Web.Interfaces
{
    public interface IStringCountWordsService
    {
        Dictionary<int, int> CountOccurrencesOfWordLengthInString(string stringInput);
    }
}
