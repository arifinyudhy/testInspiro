using Microsoft.EntityFrameworkCore.Migrations;

namespace testInspiro.Migrations
{
    public partial class insertData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Foods (FoodName,FoodPrice,Stock) VALUES('Biskuit',6000,15)");
            migrationBuilder.Sql("INSERT INTO Foods (FoodName,FoodPrice,Stock) VALUES('Chips',8000,12)");
            migrationBuilder.Sql("INSERT INTO Foods (FoodName,FoodPrice,Stock) VALUES('Oreo',10000,7)");
            migrationBuilder.Sql("INSERT INTO Foods (FoodName,FoodPrice,Stock) VALUES('Tango',12000,9)");
            migrationBuilder.Sql("INSERT INTO Foods (FoodName,FoodPrice,Stock) VALUES('Cokelat',15000,8)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Foods");
        }
    }
}
