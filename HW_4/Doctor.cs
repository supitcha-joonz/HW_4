using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4
{
    //implement ":"
    public class Doctor : Job
    {
        //constructor
        public Doctor(string name, string occuration, decimal salary, int tax) : base(name, occuration, salary, tax) { 
        }

        //method
        public string WhoamI() {
            return "I am a Doctor";

        }
        public override decimal GetTax()
        {
            return (this.Tax * this.Salary) / 100;
        }
    }
}
