using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Employee:PersonBase
    {
        public decimal HourlyPay { get; set; }
    }
}
