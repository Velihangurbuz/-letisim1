using Iletisim.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;


namespace Iletisim.Controllers

{
    public class IletisimController : Controller
    {
        private readonly ILogger<IletisimController> _logger;
        private readonly Iletisimcontext _context;
        public IletisimController(ILogger<IletisimController> logger, Iletisimcontext context)
        {
            _logger = logger;
            _context = context;
        }


        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Iletisims iletisim)
        {

            _context.Add(iletisim);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }



    }
}
