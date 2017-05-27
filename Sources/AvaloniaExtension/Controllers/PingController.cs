using Microsoft.AspNetCore.Mvc;

namespace AvaloniaExtension.Controllers
{
    public class PingController
    {
        [HttpGet]
        public string Index()
        {
            return "Hello, World";
        }
}
}