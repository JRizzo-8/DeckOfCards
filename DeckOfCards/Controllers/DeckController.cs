using DeckOfCards.Models;
using Flurl.Http;
using Microsoft.AspNetCore.Mvc;

namespace DeckOfCards.Controllers
{
    public class DeckController : Controller
    {
        public IActionResult Index()
        {
            string apiUri = "https://deckofcardsapi.com/api/deck/new/draw/?count=5";
            var apiTask = apiUri.GetJsonAsync<DeckApi>();
            apiTask.Wait();
            DeckApi result = apiTask.Result;
            return View(result.cards);
        }
    }
}
