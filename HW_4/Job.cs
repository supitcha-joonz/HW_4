using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4
{
    public abstract class Job
    {
        //properties

        public string Name { get; set; }
        public string Occuration { get; set; }
        public decimal Salary { get; set; }
        public int Tax { get; set; }


        //constructor
        public Job(string name, string occuration, decimal salary, int tax)
        {
            Name = name;
            Occuration = occuration;
            Salary = salary;
            Tax = tax;
        }


        //method

        public string WhoamI() {

            return "I love my Job.";

        }

        public abstract decimal GetTax();
      
    }
}
