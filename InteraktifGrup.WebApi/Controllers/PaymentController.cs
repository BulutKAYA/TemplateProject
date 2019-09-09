using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InteraktifGrup.Business.BPayment;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InteraktifGrup.WebApi.Controllers
{
    [Route("api/")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        [HttpGet]
        [Route("payment")]
        public string DoPayment(bool isPaymentByCart)
        {
            PaymentManegerBll paymentManegerBll = new PaymentManegerBll(isPaymentByCart);
            return paymentManegerBll.DoPayment();
        }
    }
}
