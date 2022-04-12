using Sipiyo.Services;
using Microsoft.AspNetCore.Mvc;

namespace Sipiyo.Controller
{
    public class DrinkController : ControllerBase
    {
        private readonly IDrinkService Service;
        public DrinkController(IDrinkService service) {
            Service = service ?? throw new ArgumentNullException(nameof(service));
        }
        [Route("api/Drinks")]
        public async Task<IActionResult> GetDrinksAsync()
        {
            var drinks = await Service.GetDrinksAsync();
            return Ok(drinks);
        }
    }
}