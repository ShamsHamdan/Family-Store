using Microsoft.EntityFrameworkCore.Migrations;

namespace Family_Store.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Family",
                columns: table => new
                {
                    IDF = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Part = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Family", x => x.IDF);
                });

            migrationBuilder.CreateTable(
                name: "clothes",
                columns: table => new
                {
                    IDC = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ctype = table.Column<string>(nullable: false),
                    IDF = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clothes", x => x.IDC);
                    table.ForeignKey(
                        name: "FK_clothes_Family_IDF",
                        column: x => x.IDF,
                        principalTable: "Family",
                        principalColumn: "IDF",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "bag",
                columns: table => new
                {
                    IDB = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDC = table.Column<int>(nullable: false),
                    Bcolor = table.Column<string>(nullable: false),
                    Btype = table.Column<string>(nullable: false),
                    Bmaterail = table.Column<string>(nullable: false),
                    Bprice = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bag", x => x.IDB);
                    table.ForeignKey(
                        name: "FK_bag_clothes_IDC",
                        column: x => x.IDC,
                        principalTable: "clothes",
                        principalColumn: "IDC",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "boot",
                columns: table => new
                {
                    IDBO = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDC = table.Column<int>(nullable: false),
                    BOcolor = table.Column<string>(nullable: false),
                    BObrand = table.Column<string>(nullable: false),
                    BOprice = table.Column<string>(nullable: false),
                    BOsize = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_boot", x => x.IDBO);
                    table.ForeignKey(
                        name: "FK_boot_clothes_IDC",
                        column: x => x.IDC,
                        principalTable: "clothes",
                        principalColumn: "IDC",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "dress",
                columns: table => new
                {
                    IDD = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDC = table.Column<int>(nullable: false),
                    Dcolor = table.Column<string>(nullable: false),
                    Dlength = table.Column<string>(nullable: false),
                    Dfabric = table.Column<string>(nullable: false),
                    Dprice = table.Column<string>(nullable: false),
                    Dsize = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dress", x => x.IDD);
                    table.ForeignKey(
                        name: "FK_dress_clothes_IDC",
                        column: x => x.IDC,
                        principalTable: "clothes",
                        principalColumn: "IDC",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "jaket",
                columns: table => new
                {
                    IDJ = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDC = table.Column<int>(nullable: false),
                    Jcolor = table.Column<string>(nullable: false),
                    Jbrand = table.Column<string>(nullable: false),
                    Jprice = table.Column<string>(nullable: false),
                    Jsize = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jaket", x => x.IDJ);
                    table.ForeignKey(
                        name: "FK_jaket_clothes_IDC",
                        column: x => x.IDC,
                        principalTable: "clothes",
                        principalColumn: "IDC",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "sandal",
                columns: table => new
                {
                    IDSA = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDC = table.Column<int>(nullable: false),
                    SAcolor = table.Column<string>(nullable: false),
                    SAbrand = table.Column<string>(nullable: false),
                    SAprice = table.Column<string>(nullable: false),
                    SAsize = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sandal", x => x.IDSA);
                    table.ForeignKey(
                        name: "FK_sandal_clothes_IDC",
                        column: x => x.IDC,
                        principalTable: "clothes",
                        principalColumn: "IDC",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "scarf",
                columns: table => new
                {
                    IDSC = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDC = table.Column<int>(nullable: false),
                    SCcolor = table.Column<string>(nullable: false),
                    SCfabric = table.Column<string>(nullable: false),
                    SCprice = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_scarf", x => x.IDSC);
                    table.ForeignKey(
                        name: "FK_scarf_clothes_IDC",
                        column: x => x.IDC,
                        principalTable: "clothes",
                        principalColumn: "IDC",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "shoes",
                columns: table => new
                {
                    IDSH = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDC = table.Column<int>(nullable: false),
                    SHcolor = table.Column<string>(nullable: false),
                    SHbrand = table.Column<string>(nullable: false),
                    SHprice = table.Column<string>(nullable: false),
                    SHsize = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_shoes", x => x.IDSH);
                    table.ForeignKey(
                        name: "FK_shoes_clothes_IDC",
                        column: x => x.IDC,
                        principalTable: "clothes",
                        principalColumn: "IDC",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "shorts",
                columns: table => new
                {
                    IDSR = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDC = table.Column<int>(nullable: false),
                    SRcolor = table.Column<string>(nullable: false),
                    SRbrand = table.Column<string>(nullable: false),
                    SRprice = table.Column<string>(nullable: false),
                    SRsize = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_shorts", x => x.IDSR);
                    table.ForeignKey(
                        name: "FK_shorts_clothes_IDC",
                        column: x => x.IDC,
                        principalTable: "clothes",
                        principalColumn: "IDC",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "skirts",
                columns: table => new
                {
                    IDSK = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDC = table.Column<int>(nullable: false),
                    SKcolor = table.Column<string>(nullable: false),
                    SKlength = table.Column<string>(nullable: false),
                    SKfabric = table.Column<string>(nullable: false),
                    SKprice = table.Column<string>(nullable: false),
                    SKsize = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_skirts", x => x.IDSK);
                    table.ForeignKey(
                        name: "FK_skirts_clothes_IDC",
                        column: x => x.IDC,
                        principalTable: "clothes",
                        principalColumn: "IDC",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "t_shirts",
                columns: table => new
                {
                    IDST = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDC = table.Column<int>(nullable: false),
                    STcolor = table.Column<string>(nullable: false),
                    STbrand = table.Column<string>(nullable: false),
                    STprice = table.Column<string>(nullable: false),
                    STsize = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_shirts", x => x.IDST);
                    table.ForeignKey(
                        name: "FK_t_shirts_clothes_IDC",
                        column: x => x.IDC,
                        principalTable: "clothes",
                        principalColumn: "IDC",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "trousers",
                columns: table => new
                {
                    IDT = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDC = table.Column<int>(nullable: false),
                    Tcolor = table.Column<string>(nullable: false),
                    Tfabric = table.Column<string>(nullable: false),
                    Tprice = table.Column<string>(nullable: false),
                    Tsize = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_trousers", x => x.IDT);
                    table.ForeignKey(
                        name: "FK_trousers_clothes_IDC",
                        column: x => x.IDC,
                        principalTable: "clothes",
                        principalColumn: "IDC",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_bag_IDC",
                table: "bag",
                column: "IDC");

            migrationBuilder.CreateIndex(
                name: "IX_boot_IDC",
                table: "boot",
                column: "IDC");

            migrationBuilder.CreateIndex(
                name: "IX_clothes_IDF",
                table: "clothes",
                column: "IDF");

            migrationBuilder.CreateIndex(
                name: "IX_dress_IDC",
                table: "dress",
                column: "IDC");

            migrationBuilder.CreateIndex(
                name: "IX_jaket_IDC",
                table: "jaket",
                column: "IDC");

            migrationBuilder.CreateIndex(
                name: "IX_sandal_IDC",
                table: "sandal",
                column: "IDC");

            migrationBuilder.CreateIndex(
                name: "IX_scarf_IDC",
                table: "scarf",
                column: "IDC");

            migrationBuilder.CreateIndex(
                name: "IX_shoes_IDC",
                table: "shoes",
                column: "IDC");

            migrationBuilder.CreateIndex(
                name: "IX_shorts_IDC",
                table: "shorts",
                column: "IDC");

            migrationBuilder.CreateIndex(
                name: "IX_skirts_IDC",
                table: "skirts",
                column: "IDC");

            migrationBuilder.CreateIndex(
                name: "IX_t_shirts_IDC",
                table: "t_shirts",
                column: "IDC");

            migrationBuilder.CreateIndex(
                name: "IX_trousers_IDC",
                table: "trousers",
                column: "IDC");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bag");

            migrationBuilder.DropTable(
                name: "boot");

            migrationBuilder.DropTable(
                name: "dress");

            migrationBuilder.DropTable(
                name: "jaket");

            migrationBuilder.DropTable(
                name: "sandal");

            migrationBuilder.DropTable(
                name: "scarf");

            migrationBuilder.DropTable(
                name: "shoes");

            migrationBuilder.DropTable(
                name: "shorts");

            migrationBuilder.DropTable(
                name: "skirts");

            migrationBuilder.DropTable(
                name: "t_shirts");

            migrationBuilder.DropTable(
                name: "trousers");

            migrationBuilder.DropTable(
                name: "clothes");

            migrationBuilder.DropTable(
                name: "Family");
        }
    }
}
