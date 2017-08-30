using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace vega.Migrations
{
    public partial class SeedDataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Make (Name) VALUES('Make1')");
            migrationBuilder.Sql("INSERT INTO Make (Name) VALUES('Make2')");
            migrationBuilder.Sql("INSERT INTO Make (Name) VALUES('Make3')");


            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES('Make1-ModelA', (SELECT ID FROM Make WHERE Name = 'Make1'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES('Make1-ModelB', (SELECT ID FROM Make WHERE Name = 'Make1'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES('Make1-ModelC', (SELECT ID FROM Make WHERE Name = 'Make1'))");

            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES('Make2-ModelA', (SELECT ID FROM Make WHERE Name = 'Make2'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES('Make2-ModelB', (SELECT ID FROM Make WHERE Name = 'Make2'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES('Make2-ModelC', (SELECT ID FROM Make WHERE Name = 'Make2'))");

            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES('Make3-ModelA', (SELECT ID FROM Make WHERE Name = 'Make3'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES('Make3-ModelB', (SELECT ID FROM Make WHERE Name = 'Make3'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES('Make3-ModelC', (SELECT ID FROM Make WHERE Name = 'Make3'))");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from Make WHERE Name IN ('Make1','Make2','Make3')"); //migrationBuilder.Sql("Delete from Models");            
        }
    }
}
