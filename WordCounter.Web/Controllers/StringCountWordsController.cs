using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WordCounter.Web.Interfaces;
using WordCounter.Web.Models;

namespace WordCounter.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StringCountWordsController : ControllerBase
    {
        private readonly IStringCountWordsService _wordsCountService;

        public StringCountWordsController(IStringCountWordsService wordsCountService)
        {
            _wordsCountService = wordsCountService;
        }

        [HttpPost]
        public Dictionary<int, int> StringWordsCount(StringCountWordsRequest req)
        {
            return _wordsCountService.CountOccurrencesOfWordLengthInString(req.StringInput)
                .OrderBy(x => x.Key)
                .ToDictionary(y => y.Key, y => y.Value);
        }
    }
}
