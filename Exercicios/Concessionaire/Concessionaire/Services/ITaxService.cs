using System;
using System.Globalization;

namespace Concessionaire.Services
{
    interface ITaxService
    {
        double Tax(double amount);
    }
}
