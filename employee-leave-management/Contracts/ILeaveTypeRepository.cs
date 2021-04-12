using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using employee_leave_management.Data;
using Microsoft.AspNetCore.Identity;

namespace employee_leave_management.Contracts
{
    public interface ILeaveTypeRepository : IRepositoryBase<LeaveType>
    {
        ICollection<LeaveType> GetEmployeesByLeaveType(int id);
    }
}