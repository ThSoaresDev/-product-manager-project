using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUD_produtos.Migrations
{
    /// <inheritdoc />
    public partial class SeedProductEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("Insert into Products(name,description,price,imageUrl,stock,registrationDate,categoryId)" +
                " Values ('Coca-cola Zero','Refrigerante Coca-cola lata 350 ml',4.50,'bebidasF.jpg',50,GETDATE(),1)");
            mb.Sql("Insert into Products(name,description,price,imageUrl,stock,registrationDate,categoryId)" +
               " Values ('Cerveja Skol','Cerveja Skol long neck 400 ml',6.10,'skol.jpg',24,GETDATE(),1)");
            mb.Sql("Insert into Products(name,description,price,imageUrl,stock,registrationDate,categoryId)" +
               " Values ('Pacote Papel Higienico','Pacote papel higienico leblanc contém 6 rolos',4.50,'pctPapelHigienico.jpg',28,GETDATE(),2)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from Products");
        }
    }
}
