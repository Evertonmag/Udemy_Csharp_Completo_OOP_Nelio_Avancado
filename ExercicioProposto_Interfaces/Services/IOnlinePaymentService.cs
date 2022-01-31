using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioProposto_Interfaces.Services
{
    internal interface IOnlinePaymentService
    {
        public double Interest(double amount, int months);
        public double PaymentFee(double amount);
    }
}
