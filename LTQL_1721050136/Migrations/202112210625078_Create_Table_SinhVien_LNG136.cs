namespace LTQL_1721050136.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_SinhVien_LNG136 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SinhViens",
                c => new
                    {
                        MaSinhVien = c.Int(nullable: false, identity: true),
                        HoTen = c.String(maxLength: 50),
                        MaLop = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaSinhVien)
                .ForeignKey("dbo.LopHoc136", t => t.MaLop, cascadeDelete: true)
                .Index(t => t.MaLop);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SinhViens", "MaLop", "dbo.LopHoc136");
            DropIndex("dbo.SinhViens", new[] { "MaLop" });
            DropTable("dbo.SinhViens");
        }
    }
}
