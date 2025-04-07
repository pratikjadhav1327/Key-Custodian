using System.Collections.Generic;

namespace Key_Custodian.Models
{
    public class Vault
    {
        public int VaultId { get; set; }
        public string VaultNumber { get; set; }

        //public string VaultLocation { get; set; }
        public ICollection<Key> Keys { get; set; }
        public ICollection<User> Users { get; set; }

    }
}