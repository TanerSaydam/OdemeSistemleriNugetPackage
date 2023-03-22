using Iyzipay.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OdemeSistemiService;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Test()
        {
            RequestIyzico request = new();

            Payment payment = OdemeService.IyzicoOdeme(request);
            return Ok(payment);
        }
    }
}
