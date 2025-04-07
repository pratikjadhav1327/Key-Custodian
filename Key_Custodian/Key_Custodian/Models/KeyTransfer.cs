using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Key_Custodian.Models
{
	public class KeyTransfer
	{
		public int KeyTransferId { get; set; }
		public string VaultNumber { get; set; }
        public string KeyIdentificationNumber { get; set; }
        public int CurrentKeyHolderId { get; set; }
        public int NewKeyHolderId { get; set; }

        public User CurrentKeyHolder { get; set; }
        public User NewKeyHolder { get; set; }

        public Key Key { get; set; }


        //public DateTime TransferDate { get; set; }
    }
}