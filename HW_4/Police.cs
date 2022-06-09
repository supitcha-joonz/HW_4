using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4
{
    public class Police : Job
    {
        public Police(string name, string occuration, decimal salary, int tax) : base(name, occuration, salary, tax)
        {
        }

        public string WhoamI()
        {
            return "I am a Police";
        }

        public override decimal GetTax()
        {
            return (this.Tax * this.Salary) / 100;
        }
    }
}
