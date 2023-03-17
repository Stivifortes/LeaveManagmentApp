using Microsoft.AspNetCore.Identity;

namespace LeaveManagmentApp.Data
{
    public class Employee : IdentityUser
    {
        public string TaxId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateJoined { get; set; }



    }
}
