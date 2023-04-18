using System.ComponentModel.DataAnnotations.Schema;

namespace Leavemanagement.Web.Data
{
    public class LeaveAllocation:BaseEntity
    {

        public int NumberOfDays { get; set; }

        //The order is imp here.
        //By looking at this entity framework core will understand
        //that it is a foreign key.
        [ForeignKey("LeaveTypeId")]
        public LeaveType LeaveType { get; set; }

        public int LeaveTypeId { get; set; }

        //We need allocate leave type to an employee

        public string EmployeeId { get; set; }

    }
}
