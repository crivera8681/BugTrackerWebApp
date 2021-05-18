using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BugTrackerWebApp.Models
{
    public class Bug
    {
        public int Id { get; set; }

        public string BugType { get; set; }

        public string BugDescription { get; set; }

        public string Email { get; set; }

        public DateTime ReportDate { get; set; }

        public Bug()
        {

        }
    }
}