using Microsoft.EntityFrameworkCore.Migrations;

namespace testInspiro.Migrations
{
    public partial class insertData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Foods (Id,FoodName,FoodPrice,Stock) VALUES(1,'Biskuit',6000,15)");
            migrationBuilder.Sql("INSERT INTO Foods (Id,FoodName,FoodPrice,Stock) VALUES(2,'Chips',8000,12)");
            migrationBuilder.Sql("INSERT INTO Foods (Id,FoodName,FoodPrice,Stock) VALUES(3,'Oreo',10000,7)");
            migrationBuilder.Sql("INSERT INTO Foods (Id,FoodName,FoodPrice,Stock) VALUES(4,'Tango',12000,9)");
            migrationBuilder.Sql("INSERT INTO Foods (Id,FoodName,FoodPrice,Stock) VALUES(5,'Cokelat',15000,8)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Foods");
        }
    }
}
