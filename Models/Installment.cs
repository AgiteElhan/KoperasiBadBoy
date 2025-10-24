using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoperasiBadBoy.Models
{
    public class Installment
    {
        public int id {  get; set; }
        public int LoanId { get; set; }
        public Loan Loan { get; set; }
        public decimal amount { get; set; }
        public DateTime PaymentDate { get; set; } = DateTime.UtcNow;
        public string? ProofPath { get; set; }
    }
}
