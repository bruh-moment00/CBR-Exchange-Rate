using CBR_Exchange_Rate_App.Domain.Services.CBR_Rate;
using Microsoft.AspNetCore.Mvc;
using Result2;
using CBR_Exchange_Rate_App.Data.Currencies.Models.CurrencyObjects;
using CBR_Exchange_Rate_App.Domain.Pagination.Models;

namespace CBR_Exchange_Rate_App.API.Controllers
{
    [Route("api/exchange_rate")]
    [ApiController]
    public class ExchangeRateController : ControllerBase
    {
        private readonly ICbrCurrenciesService _cbrService;
        public ExchangeRateController(ICbrCurrenciesService cbrService)
        {
            _cbrService = cbrService;
        }

        [Route("currencies")]
        [HttpGet]
        public IActionResult GetCurrencies(int pageSize = 5, int pageIndex = 1)
        {
            IResult<IEnumerable<CbrCurrency>> result = _cbrService.ReturnCurrencies();

            JsonResult jsonResult;

            if (result.Ok)
            {
                jsonResult = new JsonResult(Pagination<CbrCurrency>.GetPaginatedData(result.Value, pageSize, pageIndex));
            }
            else
            {
                jsonResult = new JsonResult(result.Reason);
            }
            return jsonResult;

        }

        [Route("currency/{id}")]
        [HttpGet]
        public IActionResult GetCurrencyById(string id)
        {
            IResult<CbrCurrency> result = _cbrService.ReturnCurrencyById(id);

            JsonResult jsonResult;

            if (result.Ok)
            {
                jsonResult = new JsonResult(result.Value);
            }
            else
            {
                jsonResult = new JsonResult(result.Reason);
            }
            return jsonResult;
        }
    }
}
