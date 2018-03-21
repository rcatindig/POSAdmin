namespace TMAAdmin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        Epan = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                        Company = c.String(unicode: false),
                        TransactionDate = c.DateTime(nullable: false, precision: 0),
                        LicensePlate = c.String(unicode: false),
                        UserId = c.Int(nullable: false),
                        MachineId = c.String(unicode: false),
                        SerialNumber = c.String(unicode: false),
                        UniqueTransactionNumber = c.String(unicode: false),
                        ReceiptNumber = c.String(unicode: false),
                        EntryDateTime = c.DateTime(nullable: false, precision: 0),
                        ExitDateTime = c.DateTime(nullable: false, precision: 0),
                        Duration = c.String(unicode: false),
                        Tariff = c.Int(nullable: false),
                        TotalAmount = c.Single(nullable: false),
                        AcceptedTotal = c.Single(nullable: false),
                        NetTotal = c.Single(nullable: false),
                        Vat = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Epan);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Transactions");
        }
    }
}
