using KoperasiBadBoy.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KoperasiBadBoy.Forms
{
    public partial class MemberPage : UserControl
    {
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Username { get; set; } = string.Empty;

        [Required]
        public string PasswordHash { get; set; } = string.Empty;

        [Required, MaxLength(200)]
        public string FullName { get; set; } = string.Empty;

        public bool IsActive { get; set; } = true;

        public DateTime JoinDate { get; set; } = DateTime.UtcNow;

        public string MemberId { get; set; } = string.Empty;

        public string IdCard { get; set; } = string.Empty;

        public string Phone { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        public string PhoneAlt { get; set; } = string.Empty;

        public DateTime ModDate { get; set; }

        public string Status { get; set; } = string.Empty;

        public string ReferenceId { get; set; } = string.Empty;

        public string Level { get; set; } = string.Empty;

        [Required, MaxLength(100)]
        public string Quest1 { get; set; } = null!;

        [Required, MaxLength(100)]
        public string Quest2 { get; set; } = null!;

        public ICollection<Loan> Loans { get; set; } = new List<Loan>();

        public ICollection<Access> Accesses { get; set; } = new List<Access>();

        public ICollection<Saving> Savings { get; set; } = new List<Saving>();

        public ICollection<Inhouse> OriginTransactions { get; set; } = new List<Inhouse>();

        public ICollection<Inhouse> DestinationTransactions { get; set; } = new List<Inhouse>();

        public ICollection<MemberPage> Exchanges { get; set; } = new List<MemberPage>();

        private void MemberPage_Load(object sender, EventArgs e)
        {

        }
    }
}