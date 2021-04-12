using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using employee_leave_management.Contracts;
using employee_leave_management.Data;
using Microsoft.AspNetCore.Identity;

namespace employee_leave_management.Repository
{
    public class LeaveTypeRepository : ILeaveTypeRepository
    {
        private readonly ApplicationDbContext _db;

        public LeaveTypeRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool Create(LeaveType entity)
        {
            _db.LeaveTypes.Add(entity);
            return Save();
        }

        public bool Delete(LeaveType entity)
        {
            _db.LeaveTypes.Remove(entity);
            return Save();
        }

        public ICollection<LeaveType> FindAll()
        {
            return _db.LeaveTypes.ToList();
        }

        public LeaveType FindById(int id)
        {
            return _db.LeaveTypes.Find(id);
        }

        public ICollection<LeaveType> GetEmployeesByLeaveType(int id)
        {
            throw new NotImplementedException();
        }

        //SaveChanges() returns an int equal to the number of changes. If there are no changes, the save fails.
        public bool Save()
        {
            int changes = _db.SaveChanges();
            if (changes > 0)
                return true;
            else
                return false;
        }

        public bool Update(LeaveType entity)
        {
            _db.LeaveTypes.Update(entity);
            return Save();
        }
    }
}
