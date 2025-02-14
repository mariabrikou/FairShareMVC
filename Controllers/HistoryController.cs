using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using FairShare.Models;

namespace FairShare.Controllers{
    public class HistoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult UserHistory()
        {
            PaymentModel paymentModel = new PaymentModel();
            List<Payment> payments = paymentModel.GetPayments(1);
            
            return View(payments);
        }
    }
}