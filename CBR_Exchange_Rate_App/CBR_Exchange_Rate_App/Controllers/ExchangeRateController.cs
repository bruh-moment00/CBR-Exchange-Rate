using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CBR_Exchange_Rate_App.API.Controllers
{
    [Route("api/exchange_rate")]
    [ApiController]
    public class ExchangeRateController : ControllerBase
    {
        [Route("[controller]/currencies")]
        [HttpGet]
        public IActionResult GetCurrencies()
        {
            return null;
        }

        [Route("[controller]/currency/{id}")]
        [HttpGet]
        public IActionResult GetCurrencyById(int id)
        {
            return null;
        }
    }
}
