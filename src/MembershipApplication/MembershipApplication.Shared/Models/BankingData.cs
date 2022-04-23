using System;

namespace MembershipApplication.Models
{
    public class BankingData
    {
        public int ContributionScale { get; set; } = 1;

        public int FamilyMemberNumber { get; set; } = 1;

        public DateTime SignatureDateApplication { get; set; }

        public string AccountOwner { get; set; }

        public string IBAN { get; set; }

        /// <summary>
        /// Signature date of the SEPA mandate
        /// </summary>
        /// <value></value>
        public DateTime SignatureDateSepa { get; set; }
    }
}