namespace Key_Custodian.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialcreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Keys",
                c => new
                    {
                        KeyId = c.Int(nullable: false, identity: true),
                        KeyIdentificationNumber = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        VaultId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        AssignmetDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.KeyId)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.Vaults", t => t.VaultId, cascadeDelete: true)
                .Index(t => t.VaultId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        MobileNumber = c.String(),
                        EmployeeCode = c.String(),
                        Role = c.Int(nullable: false),
                        Password = c.String(),
                        Vault_VaultId = c.Int(),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.Vaults", t => t.Vault_VaultId)
                .Index(t => t.Vault_VaultId);
            
            CreateTable(
                "dbo.Vaults",
                c => new
                    {
                        VaultId = c.Int(nullable: false, identity: true),
                        VaultNumber = c.String(),
                    })
                .PrimaryKey(t => t.VaultId);
            
            CreateTable(
                "dbo.KeyTransfers",
                c => new
                    {
                        KeyTransferId = c.Int(nullable: false, identity: true),
                        VaultNumber = c.String(),
                        KeyIdentificationNumber = c.String(),
                        CurrentKeyHolderId = c.Int(nullable: false),
                        NewKeyHolderId = c.Int(nullable: false),
                        CurrentKeyHolder_UserId = c.Int(),
                        Key_KeyId = c.Int(),
                        NewKeyHolder_UserId = c.Int(),
                    })
                .PrimaryKey(t => t.KeyTransferId)
                .ForeignKey("dbo.Users", t => t.CurrentKeyHolder_UserId)
                .ForeignKey("dbo.Keys", t => t.Key_KeyId)
                .ForeignKey("dbo.Users", t => t.NewKeyHolder_UserId)
                .Index(t => t.CurrentKeyHolder_UserId)
                .Index(t => t.Key_KeyId)
                .Index(t => t.NewKeyHolder_UserId);
            
            CreateTable(
                "dbo.LockerAccesses",
                c => new
                    {
                        LockerAccessId = c.Int(nullable: false, identity: true),
                        AccessReason = c.String(),
                        PouchNumber = c.String(),
                        AccessDate = c.DateTime(nullable: false),
                        AccessTime = c.DateTime(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.LockerAccessId)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.VaultAccessLogs",
                c => new
                    {
                        VaultAccessLogId = c.Int(nullable: false, identity: true),
                        AccessReason = c.String(),
                        Name = c.String(),
                        EmployeeeId = c.String(),
                        Comment = c.String(),
                        AccessDate = c.DateTime(nullable: false),
                        AccessTime = c.DateTime(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.VaultAccessLogId)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.VaultAccessLogs", "UserId", "dbo.Users");
            DropForeignKey("dbo.LockerAccesses", "UserId", "dbo.Users");
            DropForeignKey("dbo.KeyTransfers", "NewKeyHolder_UserId", "dbo.Users");
            DropForeignKey("dbo.KeyTransfers", "Key_KeyId", "dbo.Keys");
            DropForeignKey("dbo.KeyTransfers", "CurrentKeyHolder_UserId", "dbo.Users");
            DropForeignKey("dbo.Users", "Vault_VaultId", "dbo.Vaults");
            DropForeignKey("dbo.Keys", "VaultId", "dbo.Vaults");
            DropForeignKey("dbo.Keys", "UserId", "dbo.Users");
            DropIndex("dbo.VaultAccessLogs", new[] { "UserId" });
            DropIndex("dbo.LockerAccesses", new[] { "UserId" });
            DropIndex("dbo.KeyTransfers", new[] { "NewKeyHolder_UserId" });
            DropIndex("dbo.KeyTransfers", new[] { "Key_KeyId" });
            DropIndex("dbo.KeyTransfers", new[] { "CurrentKeyHolder_UserId" });
            DropIndex("dbo.Users", new[] { "Vault_VaultId" });
            DropIndex("dbo.Keys", new[] { "UserId" });
            DropIndex("dbo.Keys", new[] { "VaultId" });
            DropTable("dbo.VaultAccessLogs");
            DropTable("dbo.LockerAccesses");
            DropTable("dbo.KeyTransfers");
            DropTable("dbo.Vaults");
            DropTable("dbo.Users");
            DropTable("dbo.Keys");
        }
    }
}
