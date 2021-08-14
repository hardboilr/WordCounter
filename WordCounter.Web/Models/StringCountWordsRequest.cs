using System.ComponentModel.DataAnnotations;

namespace WordCounter.Web.Models
{
    public class StringCountWordsRequest
    {
        [Required]
        public string StringInput { get; set; }
    }
}
