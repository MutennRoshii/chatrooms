using Microsoft.AspNetCore.Mvc;

namespace ChatApp.UI.Web.Controllers;

public class ChatAppController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}