namespace ProjetoBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Fornecedors", newName: "Fornecedor");
            RenameTable(name: "dbo.Produtoes", newName: "Produto");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Produto", newName: "Produtoes");
            RenameTable(name: "dbo.Fornecedor", newName: "Fornecedors");
        }
    }
}
