using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesMac.Migrations
{
    public partial class PopularLaches : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl," +
                "ImagemUrl,IsLanchePreferido,Nome,Preco) VALUES(1, 'Pão, hamburger, ovo, presunto, queijo e batata palha'," +
                "'delicioso pão de hambúrger com ovo frito; prejunto e queijo de primeira qualidade acompanhado com batata palha'," +
                "1,'http://www.macoratti.net/Imagens/lanches/cheeseslada1.jpg','http://www.macoratti.net/Imagens/lanches/cheeseslada1.jpg'," +
                "0,'Cheese Salada', 12.50)");
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl," +
                "ImagemUrl,IsLanchePreferido,Nome,Preco) VALUES(1, 'Pão, hamburger, ovo, presunto, queijo e batata palha'," +
                "'delicioso pão de hambúrger com ovo frito; prejunto e queijo de primeira qualidade acompanhado com batata palha'," +
                "1,'http://www.macoratti.net/Imagens/lanches/mistoquente4.jpg','http://www.macoratti.net/Imagens/lanches/mistoquente4.jpg'," +
                "0,'Cheese Salada', 8.00)");
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl," +
                "ImagemUrl,IsLanchePreferido,Nome,Preco) VALUES(1, 'Pão, hamburger, ovo, presunto, queijo e batata palha'," +
                "'delicioso pão de hambúrger com ovo frito; prejunto e queijo de primeira qualidade acompanhado com batata palha'," +
                "1,'http://www.macoratti.net/Imagens/lanches/cheeseburguer1.jpg','http://www.macoratti.net/Imagens/lanches/cheeseburguer1.jpg'," +
                "0,'Cheese Salada', 11.00)");
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl," +
                "ImagemUrl,IsLanchePreferido,Nome,Preco) VALUES(2, 'Pão, hamburger, ovo, presunto, queijo e batata palha'," +
                "'delicioso pão de hambúrger com ovo frito; prejunto e queijo de primeira qualidade acompanhado com batata palha'," +
                "1,'http://www.macoratti.net/Imagens/lanches/lanchenatural1.jpg','http://www.macoratti.net/Imagens/lanches/lanchenatural1.jpg'," +
                "1,'Cheese Salada', 15.00)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Lanches");
        }
    }
}
