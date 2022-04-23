using System;

namespace MembershipApplication.Models
{
    public class AdultMember
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime Birthday { get; set; }
        public string Birthplace { get; set; }
        public string Profession { get; set; }
        /// <summary>
        /// Street and HouseNumber
        /// </summary>
        public string FullStreet { get; set; }
        /// <summary>
        /// Zip and Place
        /// </summary>
        /// <value></value>
        public string FullPlace { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
    }
}