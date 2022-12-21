using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payers.Entities
{
    class Individual : Payer
    {
        public double HealthSpending { get; set; }

        public Individual(string name, double annualIncome, double healthSpending) : base(name, annualIncome)
        {
            HealthSpending=healthSpending;
        }

        public override double Taxes()
        {
            if(AnnualIncome < 20000.0)
            {
                return AnnualIncome * 0.15 - HealthSpending * 0.5;
            }
            else
            {
                return AnnualIncome * 0.25 - HealthSpending * 0.5;
            }
        }
    }
}
