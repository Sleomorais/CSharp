using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concessionaire.Services
{
    class BrazilTaxService : ITaxService
    {
        public double Tax(double amout)
        {
            if (amout <= 100.0)
            {
                return amout * 0.2;
            }
            else
            {
                return amout * 0.15;
            }
        }
    }
}
