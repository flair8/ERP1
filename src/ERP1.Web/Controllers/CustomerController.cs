using ERP1.Application.Customer;
using ERP1.Models;
using ERP1.Validators.Customer;
using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ERP1.Controllers
{
    [Authorize]
    public class CustomerController : Controller
    {
        private readonly CreateCustomerCommandHandler _handler;

        public CustomerController(CreateCustomerCommandHandler handler)
        {
            _handler = handler;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateCustomerCommand command)
        {
            var handle = await _handler.Handle(command);

            if(!handle.IsSuccess)
            {
                foreach (var error in handle.Errors)
                {
                    ModelState.AddModelError(error.Property, error.Message);
                }

                return View("Index", command);
            }

            // Passar o handler
            return RedirectToAction(nameof(Index));
        }


    }
}
