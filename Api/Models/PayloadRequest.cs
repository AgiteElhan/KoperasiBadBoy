using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoperasiBadBoy.Api.Models
{
    public class TransferPayload
    {
        public string CoopCode { get; set; } = "";
        public string MemberCode { get; set; } = "";
        public string BenefCode { get; set; } = "";
        public double Amount { get; set; }
        public double Fee { get; set; }
        public string TransferRef { get; set; } = "";
        public string Remarks { get; set; } = "";
    }

    public class BalancePayload
    {
        public string MemberCode { get; set; } = "";
        public double Amount { get; set; }
    }

    public class MemberPayload
    {
        public string Name { get; set; } = "";
        public string Address { get; set; } = "";
        public string Code { get; set; } = "";
        public string CoopCode { get; set; } = "";
    }

    public class CoopPayload
    {
        public string Name { get; set; } = "";
        public string Address { get; set; } = "";
        public string Code { get; set; } = "";
    }

}