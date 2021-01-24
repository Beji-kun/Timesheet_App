using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Timesheet_App_Bachelor_Thesis.Shared.Models
{
    class UsersAcc
    {
        [Key]
        public int UserAccID { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public DateTime DateCreate { get; set; }
        [Required]
        public string Description { get; set; }

    }
}
