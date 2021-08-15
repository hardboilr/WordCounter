using System.ComponentModel.DataAnnotations;

namespace WordCounter.Web.Models
{
    public class WordCountRequest
    {
        [Required]
        public string StringInput { get; set; }
    }
}
