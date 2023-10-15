namespace OpenAIAPI.Models
{
    public class HomeIndexViewModel
    {
       
        public string Prompt{ get; set; }
        public int ImageCount { get; set; }
        public List<string> ImageUrl { get; set; }
        public HomeIndexViewModel()
        {
            ImageUrl = new List<string>();
        }

    }
}
