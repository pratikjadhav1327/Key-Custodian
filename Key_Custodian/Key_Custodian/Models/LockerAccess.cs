using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Key_Custodian.Models
{
	public class LockerAccess
	{
        public int LockerAccessId { get; set; }
        public string AccessReason { get; set; }
        public string PouchNumber { get; set; }
        public DateTime AccessDate { get; set; }
        public DateTime AccessTime { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

    }
}