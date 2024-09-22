namespace finalTaskCodeFirstSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Tasks", "ClassId", "dbo.Classes");
            DropIndex("dbo.Tasks", new[] { "ClassId" });
            RenameColumn(table: "dbo.Tasks", name: "ClassId", newName: "Class_ClassId");
            AddColumn("dbo.Tasks", "TaskName", c => c.String());
            AlterColumn("dbo.Tasks", "Class_ClassId", c => c.Int());
            CreateIndex("dbo.Tasks", "Class_ClassId");
            AddForeignKey("dbo.Tasks", "Class_ClassId", "dbo.Classes", "ClassId");
            DropColumn("dbo.Tasks", "TaskDescription");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tasks", "TaskDescription", c => c.String());
            DropForeignKey("dbo.Tasks", "Class_ClassId", "dbo.Classes");
            DropIndex("dbo.Tasks", new[] { "Class_ClassId" });
            AlterColumn("dbo.Tasks", "Class_ClassId", c => c.Int(nullable: false));
            DropColumn("dbo.Tasks", "TaskName");
            RenameColumn(table: "dbo.Tasks", name: "Class_ClassId", newName: "ClassId");
            CreateIndex("dbo.Tasks", "ClassId");
            AddForeignKey("dbo.Tasks", "ClassId", "dbo.Classes", "ClassId", cascadeDelete: true);
        }
    }
}
