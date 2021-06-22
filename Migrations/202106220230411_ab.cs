namespace CadastroPet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ab : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pet",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nome = c.String(maxLength: 1000, unicode: false),
                        idade = c.Int(nullable: false),
                        sexo = c.String(maxLength: 1000, unicode: false),
                        tutor = c.String(maxLength: 1000, unicode: false),
                        dataNascimento = c.DateTime(nullable: false, precision: 0),
                        especie = c.String(maxLength: 1000, unicode: false),
                        raca = c.String(maxLength: 1000, unicode: false),
                        porte = c.String(maxLength: 1000, unicode: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Pet");
        }
    }
}
