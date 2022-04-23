namespace MembershipApplication.Models
{
    public class MembershipApplicationData
    {
        public int Id { get; set; }

        public bool IsChildApplication {get;set;}

        public AdultMember AdultMember {get;set;}

        public ChildMember ChildMember { get; set; }

        public BankingData BankingData { get; set; }
    }
}