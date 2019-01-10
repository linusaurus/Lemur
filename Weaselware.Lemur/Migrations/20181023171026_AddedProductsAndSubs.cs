using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Weaselware.Lemur.Migrations
{
    public partial class AddedProductsAndSubs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {








            




            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProjectID = table.Column<int>(nullable: true),
                    ProductName = table.Column<string>(nullable: true),
                    ProductionDate = table.Column<DateTime>(nullable: true),
                    Width = table.Column<decimal>(nullable: true),
                    Height = table.Column<decimal>(nullable: true),
                    Depth = table.Column<decimal>(nullable: true),
                    ArchRef = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    Make = table.Column<bool>(nullable: true),
                    CPD_id = table.Column<int>(nullable: true),
                    Omit = table.Column<bool>(nullable: true),
                    SystemFamilyID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_Product_Project_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "Project",
                        principalColumn: "ProjectID",
                        onDelete: ReferentialAction.Restrict);
                });





            migrationBuilder.CreateTable(
                name: "SubAssembly",
                columns: table => new
                {
                    SubAssemblyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProductID = table.Column<int>(nullable: true),
                    SubAssemblyName = table.Column<string>(nullable: true),
                    MakeFile = table.Column<string>(nullable: true),
                    UnitID = table.Column<int>(nullable: true),
                    W = table.Column<decimal>(nullable: true),
                    H = table.Column<decimal>(nullable: true),
                    D = table.Column<decimal>(nullable: true),
                    CPD_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubAssembly", x => x.SubAssemblyID);
                    table.ForeignKey(
                        name: "FK_SubAssembly_Product_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Restrict);
                });


        }
          
          
    }
}
