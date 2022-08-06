using CBR_Exchange_Rate_App.Domain.Models.Pagination;
using CBR_Exchange_Rate_App.Domain.Services.CBR_Rate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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

        [Route("[controller]/currencies")]
        [HttpGet]
        public Result GetCurrencies(int pageSize = 5, int pageIndex = 1)
        {
            try
            {
                var result = _cbrService.ReturnExchangeRatesPaginated(pageSize, pageIndex);
                return (Result)Result.Success(result);
            } 
            catch(Exception ex)
            {
                return (Result)Result.Failure(ex.Message);
            }

        }

        [Route("[controller]/currency/{id}")]
        [HttpGet]
        public Result GetCurrencyById(string id)
        {
            try
            {
                var result = _cbrService.ReturnExchangeRateById(id);
                return (Result)Result.Success(result);
            }
            catch (Exception ex)
            {
                return (Result)Result.Failure(ex.Message);
            }
        }
    }
}
