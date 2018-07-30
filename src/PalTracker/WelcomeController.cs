using Microsoft.AspNetCore.Mvc;

namespace PalTracker
{
    [Route("/")]
    public class WelcomeController : Controller
    {
        private readonly WelcomeMessage _welcomeMessage;

        public WelcomeController(WelcomeMessage welcomeMessage)
        {
            _welcomeMessage = welcomeMessage;
        }
        
        [HttpGet]
        public string SayHello() => _welcomeMessage.Message;
    }
}