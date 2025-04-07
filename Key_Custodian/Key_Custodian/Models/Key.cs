using System;

namespace Key_Custodian.Models
{
    public class Key
    {
        public int KeyId { get; set; }
        public string KeyIdentificationNumber { get; set; }
        public bool IsActive { get; set; }


        public int VaultId { get; set; }
        public Vault Vault { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

        public DateTime AssignmetDate { get; set; }


    }

 
}