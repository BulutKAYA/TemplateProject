using InteraktifGrup.Interfaces.Payment;
using System;
using System.Collections.Generic;
using System.Text;

namespace InteraktifGrup.Business.BPayment
{
    public class PaymentManegerBll
    {
        IPaymentService paymentService;
        public PaymentManegerBll(bool isPaymentByCart)
        {
            if (isPaymentByCart)
                paymentService = new PaymentByCartBll();
            else
                paymentService = new PaymentByCashBll();
        }

        public string DoPayment()
        {
            return paymentService.DoPayment();
        }

    }
}
