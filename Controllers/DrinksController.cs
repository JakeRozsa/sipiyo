using Sipiyo.Services;
using Microsoft.AspNetCore.Mvc;
using sipiyo.Controllers;

namespace Sipiyo.Controller
{
    public class DrinksController : BaseApiController
    {
        private readonly IDrinkService Service;
        public DrinksController(IDrinkService service) {
            Service = service ?? throw new ArgumentNullException(nameof(service));
        }
        public async Task<IActionResult> GetDrinksAsync()
        {
            var drinks = await Service.GetDrinksAsync();
            return Ok(drinks);
        }
    }
}