using Flurl.Http;
namespace DeckOfCards.Models
{
    public class DeckApi
    {
        public string deck_id { get; set; }
        public List<CardApi> cards { get; set; }
    }
}
