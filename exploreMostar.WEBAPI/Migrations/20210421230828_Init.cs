using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace exploreMostar.WebAPI.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DodatneOpcije",
                columns: table => new
                {
                    Bazen = table.Column<bool>(nullable: true),
                    TV = table.Column<bool>(nullable: true),
                    Parking = table.Column<bool>(nullable: true),
                    DodatnaOpcijaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DodatneOpcije", x => x.DodatnaOpcijaID);
                });

            migrationBuilder.CreateTable(
                name: "Drzave",
                columns: table => new
                {
                    DrzavaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(maxLength: 50, nullable: false),
                    Oznaka = table.Column<string>(maxLength: 50, nullable: false),
                    PutanjaSlike = table.Column<string>(nullable: true),
                    Slika = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drzave", x => x.DrzavaID);
                });

            migrationBuilder.CreateTable(
                name: "KategorijaJela",
                columns: table => new
                {
                    KategorijaJelaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KategorijaJela", x => x.KategorijaJelaID);
                });

            migrationBuilder.CreateTable(
                name: "Kategorije",
                columns: table => new
                {
                    Naziv = table.Column<string>(maxLength: 30, nullable: false),
                    Opis = table.Column<string>(maxLength: 40, nullable: false),
                    KategorijaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Sadrzaj = table.Column<string>(nullable: true),
                    Ukupno = table.Column<int>(nullable: true),
                    VrstaKategorije = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategorije", x => x.KategorijaID);
                });

            migrationBuilder.CreateTable(
                name: "Uloge",
                columns: table => new
                {
                    UlogaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(maxLength: 25, nullable: true),
                    Opis = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uloge", x => x.UlogaId);
                });

            migrationBuilder.CreateTable(
                name: "VrstaAtrakcija",
                columns: table => new
                {
                    VrstaAtrakcijeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VrstaAtrakcija", x => x.VrstaAtrakcijeID);
                });

            migrationBuilder.CreateTable(
                name: "VrstaRestorana",
                columns: table => new
                {
                    VrstaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VrstaRestorana", x => x.VrstaID);
                });

            migrationBuilder.CreateTable(
                name: "Gradovi",
                columns: table => new
                {
                    GradID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(maxLength: 50, nullable: false),
                    DrzavaID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gradovi", x => x.GradID);
                    table.ForeignKey(
                        name: "FK__Gradovi__DrzavaI__6C190EBB",
                        column: x => x.DrzavaID,
                        principalTable: "Drzave",
                        principalColumn: "DrzavaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Jela",
                columns: table => new
                {
                    Naziv = table.Column<string>(maxLength: 50, nullable: false),
                    JeloID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Slika = table.Column<byte[]>(nullable: true),
                    Sastojci = table.Column<string>(maxLength: 100, nullable: true),
                    Ocjena = table.Column<double>(nullable: true),
                    KategorijaJelaID = table.Column<int>(nullable: true),
                    PutanjaSlike = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jela", x => x.JeloID);
                    table.ForeignKey(
                        name: "FK__Jela__Kategorija__5224328E",
                        column: x => x.KategorijaJelaID,
                        principalTable: "KategorijaJela",
                        principalColumn: "KategorijaJelaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Apartmani",
                columns: table => new
                {
                    Naziv = table.Column<string>(maxLength: 50, nullable: false),
                    Lokacija = table.Column<string>(maxLength: 200, nullable: false),
                    ApartmanID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GodinaIzgradnje = table.Column<int>(nullable: true),
                    KategorijaID = table.Column<int>(nullable: false),
                    Latitude = table.Column<double>(nullable: true),
                    Longitude = table.Column<double>(nullable: true),
                    Bazen = table.Column<bool>(nullable: true),
                    Parking = table.Column<bool>(nullable: true),
                    TV = table.Column<bool>(nullable: true),
                    Wifi = table.Column<bool>(nullable: true),
                    Slika = table.Column<byte[]>(nullable: true),
                    SlikaThumb = table.Column<byte[]>(nullable: true),
                    Klima = table.Column<bool>(nullable: true),
                    Perilica = table.Column<bool>(nullable: true),
                    AparatZaKafu = table.Column<bool>(nullable: true),
                    KategorijaApartmana = table.Column<string>(maxLength: 1, nullable: true),
                    Ocjena = table.Column<double>(nullable: true),
                    PutanjaSlike = table.Column<string>(nullable: true),
                    Udaljenost = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apartmani", x => x.ApartmanID);
                    table.ForeignKey(
                        name: "FK__Apartmani__Kateg__160F4887",
                        column: x => x.KategorijaID,
                        principalTable: "Kategorije",
                        principalColumn: "KategorijaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Hoteli",
                columns: table => new
                {
                    Naziv = table.Column<string>(maxLength: 50, nullable: false),
                    Lokacija = table.Column<string>(maxLength: 200, nullable: false),
                    HotelID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GodinaIzgradnje = table.Column<int>(nullable: true),
                    KategorijaID = table.Column<int>(nullable: false),
                    Latitude = table.Column<double>(nullable: true),
                    Longitude = table.Column<double>(nullable: true),
                    Bazen = table.Column<bool>(nullable: true),
                    Parking = table.Column<bool>(nullable: true),
                    TV = table.Column<bool>(nullable: true),
                    Wifi = table.Column<bool>(nullable: true),
                    Slika = table.Column<byte[]>(nullable: true),
                    SlikaThumn = table.Column<byte[]>(nullable: true),
                    Klima = table.Column<bool>(nullable: true),
                    AparatZaKafu = table.Column<bool>(nullable: true),
                    Kategorija = table.Column<string>(maxLength: 1, nullable: true),
                    Ocjena = table.Column<double>(nullable: true),
                    PutanjaSlike = table.Column<string>(nullable: true),
                    Udaljenost = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hoteli", x => x.HotelID);
                    table.ForeignKey(
                        name: "FK__Hoteli__Kategori__17F790F9",
                        column: x => x.KategorijaID,
                        principalTable: "Kategorije",
                        principalColumn: "KategorijaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Kafici",
                columns: table => new
                {
                    Naziv = table.Column<string>(maxLength: 50, nullable: false),
                    Lokacija = table.Column<string>(maxLength: 50, nullable: false),
                    KaficID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    KategorijaID = table.Column<int>(nullable: false),
                    Latitude = table.Column<double>(nullable: true),
                    Longitude = table.Column<double>(nullable: true),
                    Slika = table.Column<byte[]>(nullable: true),
                    Ocjena = table.Column<double>(nullable: true),
                    PutanjaSlike = table.Column<string>(nullable: true),
                    Udaljenost = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kafici", x => x.KaficID);
                    table.ForeignKey(
                        name: "FK__Kafici__Kategori__18EBB532",
                        column: x => x.KategorijaID,
                        principalTable: "Kategorije",
                        principalColumn: "KategorijaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Nightclubs",
                columns: table => new
                {
                    Naziv = table.Column<string>(maxLength: 50, nullable: false),
                    Lokacija = table.Column<string>(maxLength: 50, nullable: false),
                    NightClubID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    KategorijaID = table.Column<int>(nullable: false),
                    Latitude = table.Column<double>(nullable: true),
                    Longitude = table.Column<double>(nullable: true),
                    Slika = table.Column<byte[]>(nullable: true),
                    Ocjena = table.Column<double>(nullable: true),
                    PutanjaSlike = table.Column<string>(nullable: true),
                    Udaljenost = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nightclubs", x => x.NightClubID);
                    table.ForeignKey(
                        name: "FK__Nightclub__Kateg__19DFD96B",
                        column: x => x.KategorijaID,
                        principalTable: "Kategorije",
                        principalColumn: "KategorijaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Prevoz",
                columns: table => new
                {
                    Naziv = table.Column<string>(maxLength: 50, nullable: false),
                    Vrsta = table.Column<string>(maxLength: 50, nullable: false),
                    Telefon = table.Column<string>(maxLength: 50, nullable: false),
                    PrevozID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    KategorijaID = table.Column<int>(nullable: true),
                    Slika = table.Column<byte[]>(nullable: true),
                    PutanjaSlike = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prevoz", x => x.PrevozID);
                    table.ForeignKey(
                        name: "FK__Prevoz__Kategori__5EBF139D",
                        column: x => x.KategorijaID,
                        principalTable: "Kategorije",
                        principalColumn: "KategorijaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Atrakcije",
                columns: table => new
                {
                    Naziv = table.Column<string>(maxLength: 50, nullable: false),
                    Lokacija = table.Column<string>(maxLength: 50, nullable: false),
                    AtrakcijaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    VrstaAtrakcijeID = table.Column<int>(nullable: true),
                    KategorijaID = table.Column<int>(nullable: false),
                    Latitude = table.Column<double>(nullable: true),
                    Longitude = table.Column<double>(nullable: true),
                    Opis = table.Column<string>(maxLength: 250, nullable: true),
                    Slika = table.Column<byte[]>(nullable: true),
                    SlikaThumn = table.Column<byte[]>(nullable: true),
                    Ocjena = table.Column<double>(nullable: true),
                    PutanjaSlike = table.Column<string>(nullable: true),
                    Udaljenost = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Atrakcije", x => x.AtrakcijaID);
                    table.ForeignKey(
                        name: "FK__Atrakcije__Kateg__17036CC0",
                        column: x => x.KategorijaID,
                        principalTable: "Kategorije",
                        principalColumn: "KategorijaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Atrakcije__Vrsta__151B244E",
                        column: x => x.VrstaAtrakcijeID,
                        principalTable: "VrstaAtrakcija",
                        principalColumn: "VrstaAtrakcijeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Restorani",
                columns: table => new
                {
                    Naziv = table.Column<string>(maxLength: 50, nullable: false),
                    Lokacija = table.Column<string>(maxLength: 200, nullable: false),
                    RestoranID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    KategorijaID = table.Column<int>(nullable: false),
                    VrstaID = table.Column<int>(nullable: false),
                    GodinaIzgradnje = table.Column<int>(nullable: true),
                    Latitude = table.Column<double>(nullable: true),
                    Longitude = table.Column<double>(nullable: true),
                    Slika = table.Column<byte[]>(nullable: true),
                    Ocjena = table.Column<double>(nullable: true),
                    PutanjaSlike = table.Column<string>(nullable: true),
                    Udaljenost = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restorani", x => x.RestoranID);
                    table.ForeignKey(
                        name: "FK__Restorani__Kateg__1AD3FDA4",
                        column: x => x.KategorijaID,
                        principalTable: "Kategorije",
                        principalColumn: "KategorijaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Restorani__Vrsta__1DB06A4F",
                        column: x => x.VrstaID,
                        principalTable: "VrstaRestorana",
                        principalColumn: "VrstaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Korisnici",
                columns: table => new
                {
                    Ime = table.Column<string>(maxLength: 30, nullable: false),
                    Prezime = table.Column<string>(maxLength: 30, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    Telefon = table.Column<string>(maxLength: 50, nullable: false),
                    KorisnikID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GradID = table.Column<int>(nullable: true),
                    KorisnickoIme = table.Column<string>(maxLength: 50, nullable: false),
                    LozinkaHash = table.Column<string>(maxLength: 50, nullable: true),
                    LozinkaSalt = table.Column<string>(maxLength: 50, nullable: true),
                    Slika = table.Column<byte[]>(nullable: true),
                    SlikaThumb = table.Column<byte[]>(nullable: true),
                    PutanjaSlike = table.Column<string>(nullable: true),
                    DatumRodjenja = table.Column<DateTime>(type: "date", nullable: true),
                    BrojPrijavljivanja = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korisnici", x => x.KorisnikID);
                    table.ForeignKey(
                        name: "FK__Korisnici__GradI__03F0984C",
                        column: x => x.GradID,
                        principalTable: "Gradovi",
                        principalColumn: "GradID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Markeri",
                columns: table => new
                {
                    MarkerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ime = table.Column<string>(maxLength: 60, nullable: false),
                    Adresa = table.Column<string>(unicode: false, maxLength: 80, nullable: false),
                    lat = table.Column<double>(nullable: false),
                    lng = table.Column<double>(nullable: false),
                    GradID = table.Column<int>(nullable: true),
                    Opis = table.Column<string>(maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Markeri", x => x.MarkerID);
                    table.ForeignKey(
                        name: "FK__Markeri__GradID__08B54D69",
                        column: x => x.GradID,
                        principalTable: "Gradovi",
                        principalColumn: "GradID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Jelovnik",
                columns: table => new
                {
                    JelovnikID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Opis = table.Column<string>(maxLength: 100, nullable: true),
                    JeloID = table.Column<int>(nullable: true),
                    RestoranID = table.Column<int>(nullable: true),
                    Datum = table.Column<DateTime>(type: "datetime", nullable: true),
                    BrojJela = table.Column<int>(nullable: true),
                    Naziv = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jelovnik", x => x.JelovnikID);
                    table.ForeignKey(
                        name: "FK__Jelovnik__JeloID__607251E5",
                        column: x => x.JeloID,
                        principalTable: "Jela",
                        principalColumn: "JeloID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Jelovnik__Restor__6166761E",
                        column: x => x.RestoranID,
                        principalTable: "Restorani",
                        principalColumn: "RestoranID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "KorisniciUloge",
                columns: table => new
                {
                    KorisnickaUlogaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    KorisnikID = table.Column<int>(nullable: true),
                    UlogaID = table.Column<int>(nullable: true),
                    DatumIzmjene = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KorisniciUloge", x => x.KorisnickaUlogaID);
                    table.ForeignKey(
                        name: "FK__Korisnici__Koris__662B2B3B",
                        column: x => x.KorisnikID,
                        principalTable: "Korisnici",
                        principalColumn: "KorisnikID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Korisnici__Uloga__671F4F74",
                        column: x => x.UlogaID,
                        principalTable: "Uloge",
                        principalColumn: "UlogaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "KorisnikKategorija",
                columns: table => new
                {
                    KorisnikID = table.Column<int>(nullable: true),
                    KategorijaID = table.Column<int>(nullable: true),
                    KorisnikKategorijaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KorisnikKategorija", x => x.KorisnikKategorijaID);
                    table.ForeignKey(
                        name: "FK__KorisnikK__Kateg__5441852A",
                        column: x => x.KategorijaID,
                        principalTable: "Kategorije",
                        principalColumn: "KategorijaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__KorisnikK__Koris__534D60F1",
                        column: x => x.KorisnikID,
                        principalTable: "Korisnici",
                        principalColumn: "KorisnikID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MojiFavoriti",
                columns: table => new
                {
                    FavoritiId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ObjekatID = table.Column<int>(nullable: true),
                    Vrsta = table.Column<string>(nullable: true),
                    KorisnikID = table.Column<int>(nullable: true),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MojiFavoriti", x => x.FavoritiId);
                    table.ForeignKey(
                        name: "FK__MojiFavor__Koris__2EA5EC27",
                        column: x => x.KorisnikID,
                        principalTable: "Korisnici",
                        principalColumn: "KorisnikID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Objava",
                columns: table => new
                {
                    ObjavaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(maxLength: 50, nullable: true),
                    Sadrzaj = table.Column<string>(maxLength: 250, nullable: true),
                    Slika = table.Column<byte[]>(maxLength: 1, nullable: true),
                    PutanjaSlike = table.Column<string>(nullable: true),
                    KorisnikID = table.Column<int>(nullable: true),
                    Autor = table.Column<string>(maxLength: 40, nullable: true),
                    Datum = table.Column<DateTime>(type: "datetime", nullable: true),
                    DatumModificiranja = table.Column<DateTime>(type: "datetime", nullable: true),
                    AutorModifikacije = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Objava", x => x.ObjavaId);
                    table.ForeignKey(
                        name: "FK__Objava__Korisnik__73852659",
                        column: x => x.KorisnikID,
                        principalTable: "Korisnici",
                        principalColumn: "KorisnikID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Poruke",
                columns: table => new
                {
                    PorukaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Sadrzaj = table.Column<string>(nullable: true),
                    Posiljalac = table.Column<string>(maxLength: 50, nullable: true),
                    PosiljalacID = table.Column<int>(nullable: true),
                    Primalac = table.Column<string>(maxLength: 50, nullable: true),
                    PrimalacID = table.Column<int>(nullable: true),
                    Datum = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Poruke", x => x.PorukaID);
                    table.ForeignKey(
                        name: "FK__Poruke__Posiljal__0880433F",
                        column: x => x.PosiljalacID,
                        principalTable: "Korisnici",
                        principalColumn: "KorisnikID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Poruke__Primalac__09746778",
                        column: x => x.PrimalacID,
                        principalTable: "Korisnici",
                        principalColumn: "KorisnikID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Recenzije",
                columns: table => new
                {
                    RecenzijaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ocjena = table.Column<int>(nullable: true),
                    Sadrzaj = table.Column<string>(nullable: true),
                    Objekat = table.Column<string>(nullable: true),
                    KorisnikID = table.Column<int>(nullable: true),
                    ImePrezime = table.Column<string>(nullable: true),
                    Datum = table.Column<DateTime>(type: "datetime", nullable: true),
                    Vrsta = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recenzije", x => x.RecenzijaID);
                    table.ForeignKey(
                        name: "FK__Recenzije__Koris__1B9317B3",
                        column: x => x.KorisnikID,
                        principalTable: "Korisnici",
                        principalColumn: "KorisnikID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SearchTrack",
                columns: table => new
                {
                    SearchID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    KorisnikID = table.Column<int>(nullable: true),
                    Sadrzaj = table.Column<string>(nullable: true),
                    DatumPretrage = table.Column<DateTime>(type: "datetime", nullable: true),
                    ImePrezime = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SearchTrack", x => x.SearchID);
                    table.ForeignKey(
                        name: "FK__SearchTra__Koris__54CB950F",
                        column: x => x.KorisnikID,
                        principalTable: "Korisnici",
                        principalColumn: "KorisnikID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserActivity",
                columns: table => new
                {
                    KorisnikID = table.Column<int>(nullable: false),
                    BrojPrijavljivanja = table.Column<int>(nullable: true),
                    BrojNeuspjesnihPrijavljivanja = table.Column<int>(nullable: true),
                    Onemogucen = table.Column<bool>(nullable: true),
                    Razlog = table.Column<string>(nullable: true),
                    Datum = table.Column<DateTime>(type: "datetime", nullable: true),
                    AdminID = table.Column<int>(nullable: true),
                    ListaOdabranihStavki = table.Column<string>(nullable: true),
                    isApartman = table.Column<bool>(nullable: true),
                    isAtrakcija = table.Column<bool>(nullable: true),
                    isRestoran = table.Column<bool>(nullable: true),
                    isHotel = table.Column<bool>(nullable: true),
                    isKafic = table.Column<bool>(nullable: true),
                    isNightClub = table.Column<bool>(nullable: true),
                    BrojApartmanaFavoriti = table.Column<int>(nullable: true),
                    BrojAtrakcijaFavoriti = table.Column<int>(nullable: true),
                    BrojRestoranaFavoriti = table.Column<int>(nullable: true),
                    BrojHotelaFavoriti = table.Column<int>(nullable: true),
                    BrojKaficaFavoriti = table.Column<int>(nullable: true),
                    BrojNocnihKlubovaFavoriti = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserActivity", x => x.KorisnikID);
                    table.ForeignKey(
                        name: "FK__UserActiv__Koris__43A1090D",
                        column: x => x.KorisnikID,
                        principalTable: "Korisnici",
                        principalColumn: "KorisnikID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Apartmani_KategorijaID",
                table: "Apartmani",
                column: "KategorijaID");

            migrationBuilder.CreateIndex(
                name: "IX_Atrakcije_KategorijaID",
                table: "Atrakcije",
                column: "KategorijaID");

            migrationBuilder.CreateIndex(
                name: "IX_Atrakcije_VrstaAtrakcijeID",
                table: "Atrakcije",
                column: "VrstaAtrakcijeID");

            migrationBuilder.CreateIndex(
                name: "IX_Gradovi_DrzavaID",
                table: "Gradovi",
                column: "DrzavaID");

            migrationBuilder.CreateIndex(
                name: "IX_Hoteli_KategorijaID",
                table: "Hoteli",
                column: "KategorijaID");

            migrationBuilder.CreateIndex(
                name: "IX_Jela_KategorijaJelaID",
                table: "Jela",
                column: "KategorijaJelaID");

            migrationBuilder.CreateIndex(
                name: "IX_Jelovnik_JeloID",
                table: "Jelovnik",
                column: "JeloID");

            migrationBuilder.CreateIndex(
                name: "IX_Jelovnik_RestoranID",
                table: "Jelovnik",
                column: "RestoranID");

            migrationBuilder.CreateIndex(
                name: "IX_Kafici_KategorijaID",
                table: "Kafici",
                column: "KategorijaID");

            migrationBuilder.CreateIndex(
                name: "IX_Korisnici_GradID",
                table: "Korisnici",
                column: "GradID");

            migrationBuilder.CreateIndex(
                name: "IX_KorisniciUloge_KorisnikID",
                table: "KorisniciUloge",
                column: "KorisnikID");

            migrationBuilder.CreateIndex(
                name: "IX_KorisniciUloge_UlogaID",
                table: "KorisniciUloge",
                column: "UlogaID");

            migrationBuilder.CreateIndex(
                name: "IX_KorisnikKategorija_KategorijaID",
                table: "KorisnikKategorija",
                column: "KategorijaID");

            migrationBuilder.CreateIndex(
                name: "IX_KorisnikKategorija_KorisnikID",
                table: "KorisnikKategorija",
                column: "KorisnikID");

            migrationBuilder.CreateIndex(
                name: "IX_Markeri_GradID",
                table: "Markeri",
                column: "GradID");

            migrationBuilder.CreateIndex(
                name: "IX_MojiFavoriti_KorisnikID",
                table: "MojiFavoriti",
                column: "KorisnikID");

            migrationBuilder.CreateIndex(
                name: "IX_Nightclubs_KategorijaID",
                table: "Nightclubs",
                column: "KategorijaID");

            migrationBuilder.CreateIndex(
                name: "IX_Objava_KorisnikID",
                table: "Objava",
                column: "KorisnikID");

            migrationBuilder.CreateIndex(
                name: "IX_Poruke_PosiljalacID",
                table: "Poruke",
                column: "PosiljalacID");

            migrationBuilder.CreateIndex(
                name: "IX_Poruke_PrimalacID",
                table: "Poruke",
                column: "PrimalacID");

            migrationBuilder.CreateIndex(
                name: "IX_Prevoz_KategorijaID",
                table: "Prevoz",
                column: "KategorijaID");

            migrationBuilder.CreateIndex(
                name: "IX_Recenzije_KorisnikID",
                table: "Recenzije",
                column: "KorisnikID");

            migrationBuilder.CreateIndex(
                name: "IX_Restorani_KategorijaID",
                table: "Restorani",
                column: "KategorijaID");

            migrationBuilder.CreateIndex(
                name: "IX_Restorani_VrstaID",
                table: "Restorani",
                column: "VrstaID");

            migrationBuilder.CreateIndex(
                name: "IX_SearchTrack_KorisnikID",
                table: "SearchTrack",
                column: "KorisnikID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Apartmani");

            migrationBuilder.DropTable(
                name: "Atrakcije");

            migrationBuilder.DropTable(
                name: "DodatneOpcije");

            migrationBuilder.DropTable(
                name: "Hoteli");

            migrationBuilder.DropTable(
                name: "Jelovnik");

            migrationBuilder.DropTable(
                name: "Kafici");

            migrationBuilder.DropTable(
                name: "KorisniciUloge");

            migrationBuilder.DropTable(
                name: "KorisnikKategorija");

            migrationBuilder.DropTable(
                name: "Markeri");

            migrationBuilder.DropTable(
                name: "MojiFavoriti");

            migrationBuilder.DropTable(
                name: "Nightclubs");

            migrationBuilder.DropTable(
                name: "Objava");

            migrationBuilder.DropTable(
                name: "Poruke");

            migrationBuilder.DropTable(
                name: "Prevoz");

            migrationBuilder.DropTable(
                name: "Recenzije");

            migrationBuilder.DropTable(
                name: "SearchTrack");

            migrationBuilder.DropTable(
                name: "UserActivity");

            migrationBuilder.DropTable(
                name: "VrstaAtrakcija");

            migrationBuilder.DropTable(
                name: "Jela");

            migrationBuilder.DropTable(
                name: "Restorani");

            migrationBuilder.DropTable(
                name: "Uloge");

            migrationBuilder.DropTable(
                name: "Korisnici");

            migrationBuilder.DropTable(
                name: "KategorijaJela");

            migrationBuilder.DropTable(
                name: "Kategorije");

            migrationBuilder.DropTable(
                name: "VrstaRestorana");

            migrationBuilder.DropTable(
                name: "Gradovi");

            migrationBuilder.DropTable(
                name: "Drzave");
        }
    }
}
