using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    internal class FitnessCentrum
    {
        private static int fitnessCentrumId = 1;
        private string fitnessCentrumName;
        private List<Employee> employees = new List<Employee>();
        private List<Customer> customers = new List<Customer>();

        public FitnessCentrum(string fitnessCentrumName)
        {
            fitnessCentrumId += 1;
            this.fitnessCentrumName = fitnessCentrumName;
        }

    }
}
