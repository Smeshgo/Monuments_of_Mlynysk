using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Monuments_of_Mlynysk.Migrations
{
    public partial class foo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Appointment",
                columns: table => new
                {
                    id_appointment = table.Column<long>(type: "bigint", nullable: false),
                    name = table.Column<string>(type: "varchar(70)", unicode: false, maxLength: 70, nullable: false),
                    create_appointment = table.Column<DateTime>(type: "datetime", nullable: true),
                    update = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_appointment", x => x.id_appointment);
                });

            migrationBuilder.CreateTable(
                name: "Article",
                columns: table => new
                {
                    id_article = table.Column<long>(type: "bigint", nullable: false),
                    title = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    contents = table.Column<string>(type: "text", nullable: false),
                    create_article = table.Column<DateTime>(type: "datetime", nullable: true),
                    update_article = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_article", x => x.id_article);
                });

            migrationBuilder.CreateTable(
                name: "Category_material",
                columns: table => new
                {
                    id_category_material = table.Column<long>(type: "bigint", nullable: false),
                    name = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    create_category_material = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_category_material", x => x.id_category_material);
                });

            migrationBuilder.CreateTable(
                name: "Category_Photo",
                columns: table => new
                {
                    id_Category_Photo = table.Column<long>(type: "bigint", nullable: false),
                    name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    create_photo_photo = table.Column<DateTime>(type: "datetime", nullable: true),
                    update_category_photo = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_category_photo", x => x.id_Category_Photo);
                });

            migrationBuilder.CreateTable(
                name: "role",
                columns: table => new
                {
                    id_role = table.Column<long>(type: "bigint", nullable: false),
                    name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    status = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    create_role = table.Column<DateTime>(type: "datetime", nullable: true),
                    update_role = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_role", x => x.id_role);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    id_user = table.Column<long>(type: "bigint", nullable: false),
                    usernama = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    password = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    update = table.Column<DateTime>(type: "datetime", nullable: false),
                    create = table.Column<DateTime>(type: "datetime", nullable: false),
                    firstName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    lastName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    status = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    create_user = table.Column<DateTime>(type: "datetime", nullable: true),
                    update_user = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.id_user);
                });

            migrationBuilder.CreateTable(
                name: "worker",
                columns: table => new
                {
                    id_worker = table.Column<long>(type: "bigint", nullable: false),
                    firstName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    number_of_hours = table.Column<decimal>(type: "decimal(18,1)", nullable: false),
                    rete = table.Column<decimal>(type: "decimal(18,1)", nullable: false),
                    salary = table.Column<decimal>(type: "decimal(18,1)", nullable: false),
                    lastName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    create_worcer = table.Column<DateTime>(type: "datetime", nullable: true),
                    update_worker = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_worker", x => x.id_worker);
                });

            migrationBuilder.CreateTable(
                name: "Material",
                columns: table => new
                {
                    id_material = table.Column<long>(type: "bigint", nullable: false),
                    name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    height = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    length = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    color = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    width = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    price = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Number = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    status = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    create_material = table.Column<DateTime>(type: "datetime", nullable: true),
                    update_user = table.Column<DateTime>(type: "datetime", nullable: true),
                    id_appointment = table.Column<long>(type: "bigint", nullable: false),
                    id_category_material = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_material", x => x.id_material);
                    table.ForeignKey(
                        name: "FK_287",
                        column: x => x.id_appointment,
                        principalTable: "Appointment",
                        principalColumn: "id_appointment",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_296",
                        column: x => x.id_category_material,
                        principalTable: "Category_material",
                        principalColumn: "id_category_material",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Photo",
                columns: table => new
                {
                    id_photo = table.Column<long>(type: "bigint", nullable: false),
                    name = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    path_full = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    path_mini = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    uuid = table.Column<string>(type: "varchar(70)", unicode: false, maxLength: 70, nullable: false),
                    create_photo = table.Column<DateTime>(type: "datetime", nullable: true),
                    update_photo = table.Column<DateTime>(type: "datetime", nullable: true),
                    id_Category_Photo = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_photo", x => x.id_photo);
                    table.ForeignKey(
                        name: "FK_187",
                        column: x => x.id_Category_Photo,
                        principalTable: "Category_Photo",
                        principalColumn: "id_Category_Photo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Article_user",
                columns: table => new
                {
                    id_article = table.Column<long>(type: "bigint", nullable: false),
                    id_user = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_article_user", x => new { x.id_article, x.id_user });
                    table.ForeignKey(
                        name: "FK_251",
                        column: x => x.id_article,
                        principalTable: "Article",
                        principalColumn: "id_article",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_255",
                        column: x => x.id_user,
                        principalTable: "User",
                        principalColumn: "id_user",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "user_role",
                columns: table => new
                {
                    id_role = table.Column<long>(type: "bigint", nullable: false),
                    id_user = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_role", x => new { x.id_role, x.id_user });
                    table.ForeignKey(
                        name: "FK_245",
                        column: x => x.id_role,
                        principalTable: "role",
                        principalColumn: "id_role",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_248",
                        column: x => x.id_user,
                        principalTable: "User",
                        principalColumn: "id_user",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Monument",
                columns: table => new
                {
                    id_monument = table.Column<long>(type: "bigint", nullable: false),
                    prise = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    id_photo = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_monument", x => x.id_monument);
                    table.ForeignKey(
                        name: "FK_178",
                        column: x => x.id_photo,
                        principalTable: "Photo",
                        principalColumn: "id_photo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Photo_article",
                columns: table => new
                {
                    id_photo = table.Column<long>(type: "bigint", nullable: false),
                    id_article = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_photo_article", x => new { x.id_photo, x.id_article });
                    table.ForeignKey(
                        name: "FK_198",
                        column: x => x.id_photo,
                        principalTable: "Photo",
                        principalColumn: "id_photo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_202",
                        column: x => x.id_article,
                        principalTable: "Article",
                        principalColumn: "id_article",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Material_monument",
                columns: table => new
                {
                    Material_monument = table.Column<long>(type: "bigint", nullable: false),
                    id_monument = table.Column<long>(type: "bigint", nullable: false),
                    id_material = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_material_monument", x => new { x.Material_monument, x.id_monument, x.id_material });
                    table.ForeignKey(
                        name: "FK_275",
                        column: x => x.id_monument,
                        principalTable: "Monument",
                        principalColumn: "id_monument",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_278",
                        column: x => x.id_material,
                        principalTable: "Material",
                        principalColumn: "id_material",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Monument_Worker",
                columns: table => new
                {
                    id_monument = table.Column<long>(type: "bigint", nullable: false),
                    id_worker = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_monument_worker", x => new { x.id_monument, x.id_worker });
                    table.ForeignKey(
                        name: "FK_171",
                        column: x => x.id_monument,
                        principalTable: "Monument",
                        principalColumn: "id_monument",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_175",
                        column: x => x.id_worker,
                        principalTable: "worker",
                        principalColumn: "id_worker",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "fkIdx_252",
                table: "Article_user",
                column: "id_article");

            migrationBuilder.CreateIndex(
                name: "fkIdx_256",
                table: "Article_user",
                column: "id_user");

            migrationBuilder.CreateIndex(
                name: "fkIdx_288",
                table: "Material",
                column: "id_appointment");

            migrationBuilder.CreateIndex(
                name: "fkIdx_297",
                table: "Material",
                column: "id_category_material");

            migrationBuilder.CreateIndex(
                name: "fkIdx_276",
                table: "Material_monument",
                column: "id_monument");

            migrationBuilder.CreateIndex(
                name: "fkIdx_279",
                table: "Material_monument",
                column: "id_material");

            migrationBuilder.CreateIndex(
                name: "fkIdx_179",
                table: "Monument",
                column: "id_photo");

            migrationBuilder.CreateIndex(
                name: "fkIdx_172",
                table: "Monument_Worker",
                column: "id_monument");

            migrationBuilder.CreateIndex(
                name: "fkIdx_176",
                table: "Monument_Worker",
                column: "id_worker");

            migrationBuilder.CreateIndex(
                name: "fkIdx_188",
                table: "Photo",
                column: "id_Category_Photo");

            migrationBuilder.CreateIndex(
                name: "fkIdx_199",
                table: "Photo_article",
                column: "id_photo");

            migrationBuilder.CreateIndex(
                name: "fkIdx_203",
                table: "Photo_article",
                column: "id_article");

            migrationBuilder.CreateIndex(
                name: "fkIdx_246",
                table: "user_role",
                column: "id_role");

            migrationBuilder.CreateIndex(
                name: "fkIdx_249",
                table: "user_role",
                column: "id_user");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Article_user");

            migrationBuilder.DropTable(
                name: "Material_monument");

            migrationBuilder.DropTable(
                name: "Monument_Worker");

            migrationBuilder.DropTable(
                name: "Photo_article");

            migrationBuilder.DropTable(
                name: "user_role");

            migrationBuilder.DropTable(
                name: "Material");

            migrationBuilder.DropTable(
                name: "Monument");

            migrationBuilder.DropTable(
                name: "worker");

            migrationBuilder.DropTable(
                name: "Article");

            migrationBuilder.DropTable(
                name: "role");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Appointment");

            migrationBuilder.DropTable(
                name: "Category_material");

            migrationBuilder.DropTable(
                name: "Photo");

            migrationBuilder.DropTable(
                name: "Category_Photo");
        }
    }
}
