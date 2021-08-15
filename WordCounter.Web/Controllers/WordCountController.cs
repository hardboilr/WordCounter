using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WordCounter.Web.Interfaces;
using WordCounter.Web.Models;

namespace WordCounter.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WordCountController : ControllerBase
    {
        private readonly IWordCountService _wordsCountService;

        public WordCountController(IWordCountService wordsCountService)
        {
            _wordsCountService = wordsCountService;
        }

        [HttpPost]
        public Dictionary<int, int> StringWordsCount(WordCountRequest req)
        {
            return _wordsCountService.CountOccurrencesOfWordLengthInString(req.StringInput)
                .OrderBy(x => x.Key)
                .ToDictionary(y => y.Key, y => y.Value);
        }
    }
}
