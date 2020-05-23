using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Aviokompanija.Migrations
{
    public partial class Baza : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Automobil",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kapacitet = table.Column<int>(nullable: false),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Automobil", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Destinacija",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true),
                    Slika = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destinacija", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Putnik",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true),
                    KorisnickoIme = table.Column<string>(nullable: true),
                    Sifra = table.Column<string>(nullable: true),
                    BrojKreditneKartice = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Putnik", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Radnik",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true),
                    KorisnickoIme = table.Column<string>(nullable: true),
                    Sifra = table.Column<string>(nullable: true),
                    Plata = table.Column<double>(nullable: false),
                    DatumZaposlenja = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Radnik", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Let",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrojSlobodnihMjesta = table.Column<int>(nullable: false),
                    VrstaLeta = table.Column<string>(nullable: true),
                    Cijena = table.Column<double>(nullable: false),
                    MjestoPolaskaIDDestinacije = table.Column<int>(nullable: false),
                    VrijemePolijetanja = table.Column<DateTime>(nullable: false),
                    VrijemeSlijetanja = table.Column<DateTime>(nullable: false),
                    AvionId = table.Column<int>(nullable: false),
                    DestinacijaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Let", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Let_Automobil_AvionId",
                        column: x => x.AvionId,
                        principalTable: "Automobil",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Let_Destinacija_DestinacijaId",
                        column: x => x.DestinacijaId,
                        principalTable: "Destinacija",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Recenzija",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImeIPrezime = table.Column<string>(nullable: true),
                    Ocjena = table.Column<int>(nullable: false),
                    Komentar = table.Column<string>(nullable: true),
                    PutnikId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recenzija", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Recenzija_Putnik_PutnikId",
                        column: x => x.PutnikId,
                        principalTable: "Putnik",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Karta",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrojSjedista = table.Column<int>(nullable: false),
                    Klasa = table.Column<string>(nullable: true),
                    Cijena = table.Column<double>(nullable: false),
                    LetId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Karta", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Karta_Let_LetId",
                        column: x => x.LetId,
                        principalTable: "Let",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rezervacija",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatumRezervacije = table.Column<DateTime>(nullable: false),
                    PutnikId = table.Column<int>(nullable: false),
                    KartaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rezervacija", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Rezervacija_Karta_KartaId",
                        column: x => x.KartaId,
                        principalTable: "Karta",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rezervacija_Putnik_PutnikId",
                        column: x => x.PutnikId,
                        principalTable: "Putnik",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Karta_LetId",
                table: "Karta",
                column: "LetId");

            migrationBuilder.CreateIndex(
                name: "IX_Let_AvionId",
                table: "Let",
                column: "AvionId");

            migrationBuilder.CreateIndex(
                name: "IX_Let_DestinacijaId",
                table: "Let",
                column: "DestinacijaId");

            migrationBuilder.CreateIndex(
                name: "IX_Recenzija_PutnikId",
                table: "Recenzija",
                column: "PutnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacija_KartaId",
                table: "Rezervacija",
                column: "KartaId");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacija_PutnikId",
                table: "Rezervacija",
                column: "PutnikId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Radnik");

            migrationBuilder.DropTable(
                name: "Recenzija");

            migrationBuilder.DropTable(
                name: "Rezervacija");

            migrationBuilder.DropTable(
                name: "Karta");

            migrationBuilder.DropTable(
                name: "Putnik");

            migrationBuilder.DropTable(
                name: "Let");

            migrationBuilder.DropTable(
                name: "Automobil");

            migrationBuilder.DropTable(
                name: "Destinacija");
        }
    }
}
