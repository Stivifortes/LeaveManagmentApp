using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagmentApp.Data
{
    public class LeaveAllocation : BaseEntity
    {
        public int NumberOfDays { get; set; }

        [ForeignKey("LeaveTypeId")]
        public LeaveType LeaveType { get; set; }        //Related with LeaveType Identity
        public int LeaveTypeId { get; set; }         //Related with LeaveType Identity

        public string EmployeeId { get; set; }

    }
}
