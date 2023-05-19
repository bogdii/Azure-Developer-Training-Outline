using Microsoft.AspNetCore.Mvc;
using P01PlayersMVCWebApp.Models;

namespace P01PlayersMVCWebApp.Controllers
{
    public class NewCalculatorController : Controller
    {
        public IActionResult Index()
        {
            OperationModel model = new OperationModel();

            return View(model);
        }

        [HttpPost]
        public IActionResult Index(OperationModel operationModel)
        {
            operationModel.Result = operationModel.Number1 + operationModel.Number2;

            return View(operationModel);
        }
    }
}
