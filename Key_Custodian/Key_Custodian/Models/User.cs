using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Key_Custodian.Models
{
	public class User
	{
		public int UserId { get; set; }
		public string Name { get; set; }
		public string MobileNumber { get; set; }
		public string EmployeeCode { get; set; }
        public UserRole Role { get; set; }
		public string Password { get; set; }
		//public bool IsActive { get; set; }

        public ICollection<Key> Keys { get; set; }
		public Vault Vault { get; set; }
    }

	public enum UserRole
	{
        JLOKEY,
        OPSKEY,
        MGKEY,
        BMKEY
    }
}