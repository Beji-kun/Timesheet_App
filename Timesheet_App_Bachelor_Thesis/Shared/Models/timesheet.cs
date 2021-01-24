using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Timesheet_App_Bachelor_Thesis.Shared.Models
{
    class timesheet
    {
        [Key]
        public int TimeSheetID { get; set; }
        public string User { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime DateCreate { get; set; }
    }
}
