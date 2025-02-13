using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace FairShare.Controllers;

public class HistoryController : Controller
{
    public IActionResult Index()
    {
    return View();
    }
    public IActionResult UserHistory()
    {
        return View();
    }
}