using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payers.Entities
{
    class Company : Payer
    {
        public int NumberOfEmployees { get; set; }

        public Company(string name, double annualIncome,int numberOfEmployees) : base(name,annualIncome)
        {
            NumberOfEmployees=numberOfEmployees;
        }

        public override double Taxes()
        {
            if(NumberOfEmployees > 10)
            {
                double taxe = AnnualIncome * 0.14;
                return taxe;
            }
            else
            {
                double taxe = AnnualIncome * 0.16;
                return taxe;
            }
        }
    }
}
