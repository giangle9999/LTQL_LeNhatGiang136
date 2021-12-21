namespace LTQL_1721050136.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_LopHoc : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LopHoc136",
                c => new
                    {
                        MaLop = c.Int(nullable: false, identity: true),
                        TenLop = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.MaLop);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.LopHoc136");
        }
    }
}
