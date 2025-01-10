using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUD_produtos.Migrations
{
    /// <inheritdoc />
    public partial class SeedCategoryEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("Insert into Categories(Name,ImageUrl) Values ('Bebidas','bebidasF.jpg')");
            mb.Sql("Insert into Categories(Name,ImageUrl) Values ('Higiene','higiene.jpg')");
            mb.Sql("Insert into Categories(Name,ImageUrl) Values ('Roupas e Acessórios','roupasAcessórios.jpg')");
            mb.Sql("Insert into Categories(Name,ImageUrl) Values ('Saúde e Beleza','saúdeBeleza.jpg')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from Categories");
        }
    }
}
