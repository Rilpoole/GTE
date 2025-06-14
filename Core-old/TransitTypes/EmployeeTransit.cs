using Core.People;
using Core.Places;

namespace Core.TransitTypes
{
    ///
    public class EmployeeTransit : Transit
    {
        public EmployeeTransit(int iD, Employee employee, Location startLocation, Location endLocation, int startDate, int completedDate)
        {
            ID = iD;
            Employee = employee;
            StartLocation = startLocation;
            EndLocation = endLocation;
            StartDate = startDate;
            CompletedDate = completedDate;
        }
        public Employee Employee { get; private set; }
    }
}
