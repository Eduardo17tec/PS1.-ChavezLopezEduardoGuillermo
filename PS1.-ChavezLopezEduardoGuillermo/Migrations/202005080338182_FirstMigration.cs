namespace PS1._ChavezLopezEduardoGuillermo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Events", name: "Ciudad_Id", newName: "IdCiudad_Id");
            RenameIndex(table: "dbo.Events", name: "IX_Ciudad_Id", newName: "IX_IdCiudad_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Events", name: "IX_IdCiudad_Id", newName: "IX_Ciudad_Id");
            RenameColumn(table: "dbo.Events", name: "IdCiudad_Id", newName: "Ciudad_Id");
        }
    }
}
