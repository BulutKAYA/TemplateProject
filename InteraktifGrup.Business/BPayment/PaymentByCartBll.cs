using InteraktifGrup.Interfaces.Payment;
using System;
using System.Collections.Generic;
using System.Text;

namespace InteraktifGrup.Business.BPayment
{
    public class PaymentByCartBll : IPaymentService
    {
        public string DoPayment()
        {
            return "Kart ile ödeme yapıldı!";
        }
    }
}
