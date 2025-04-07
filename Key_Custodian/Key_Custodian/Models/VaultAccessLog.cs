using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Key_Custodian.Models
{
	public class VaultAccessLog
	{
        public int VaultAccessLogId { get; set; }
        public string AccessReason{ get; set; }
        public string Name { get; set; }
        public string EmployeeeId { get; set; }
        public string Comment { get; set; }
        public DateTime AccessDate { get; set; }
        public DateTime AccessTime { get; set; } 

        public int UserId { get; set; }
        public User User { get; set; }

    }
}