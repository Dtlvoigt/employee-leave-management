using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace employee_leave_management.Data
{
    public class LeaveType
    {
        [Key] //shows that this is the primary key for this table
        public int Id { get; set; }
        [Required] //this column cannot be null
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
