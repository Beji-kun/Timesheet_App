using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Timesheet_App_Bachelor_Thesis.Shared.Models
{
    public class Roles
    {
        [Key]
        public int RolesID { get; set; }
        [Required]
        public string RoleName { get; set; }  
        //public virtual List<UsersAcc> UsersAccID { get; set; }
    }
}
