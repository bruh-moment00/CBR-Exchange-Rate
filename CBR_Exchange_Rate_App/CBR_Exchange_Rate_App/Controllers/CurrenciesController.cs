using CBR_Exchange_Rate_App.Data.Models.ResponseObjects;
using CBR_Exchange_Rate_App.Domain.Models.Pagination;
using CBR_Exchange_Rate_App.Domain.Services.CBR_Rate;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using Result2;

namespace CBR_Exchange_Rate_App.API.Controllers
{
    [Route("api/exchange_rate")]
    [ApiController]
    public class ExchangeRateController : ControllerBase
    {
        private readonly ICbrService _cbrService;
        public ExchangeRateController(ICbrService cbrService)
        {
            _cbrService = cbrService;
        }

        [Route("currencies")]
        [HttpGet]
        public IActionResult GetCurrencies(int pageSize = 5, int pageIndex = 1)
        {
            IResult<IEnumerable<CbrExchangeRate>> result = _cbrService.ReturnExchangeRates();

            JsonResult jsonResult;

            if (result.Ok)
            {
                //IEnumerable<CbrExchangeRate> values = result.Value.ReturnExchangeRates();
                jsonResult = new JsonResult(Pagination<CbrExchangeRate>.GetPaginatedData(result.Value, pageSize, pageIndex));
            }
            else
            {
                jsonResult = new JsonResult(result.Reason);
            }

            //JsonResult jsonResult = new JsonResult(new PaginatedData<CbrExchangeRate>(5, 1,
            //    new CbrFullResponse(DateTime.Now, DateTime.UtcNow, "bruh", DateTime.Now, new Dictionary<string, CbrExchangeRate>()
            //    {
            //        {
            //            "asd", new CbrExchangeRate("RWWW", "ASD", "ASD", 2, "ASD", 4, 5)
            //        }

            //    })));
            return jsonResult;

        }

        [Route("currency/{id}")]
        [HttpGet]
        public IActionResult GetCurrencyById(string id)
        {
            IResult<CbrExchangeRate> result = _cbrService.ReturnExchangeRateById(id);

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
