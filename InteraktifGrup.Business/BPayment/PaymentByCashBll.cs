using InteraktifGrup.Interfaces.Payment;
using System;
using System.Collections.Generic;
using System.Text;

namespace InteraktifGrup.Business.BPayment
{
    public class PaymentByCashBll : IPaymentService
    {
        public string DoPayment()
        {
            return "Nakit olarak ödeme yapıldı!";
        }
    }
}
