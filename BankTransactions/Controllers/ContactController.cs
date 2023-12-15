using Microsoft.AspNetCore.Mvc;

namespace BankTransactions.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
