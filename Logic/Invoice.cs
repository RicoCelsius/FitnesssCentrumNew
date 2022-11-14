using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    internal class Invoice
    {
        private static int invoiceId = 1;
        private DateTime invoiceDate;
        private double amount { get; set; }
        private Customer payer;

        public Invoice(Customer payer, double amount)
        {
            invoiceDate = DateTime.Now;
            this.payer = payer;
            invoiceId += 1;
            this.amount = amount;
        }
    }
}
