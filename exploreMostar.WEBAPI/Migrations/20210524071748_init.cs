using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace exploreMostar.WebAPI.Migrations
{
    public partial class init : Migration
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

            migrationBuilder.InsertData(
                table: "Drzave",
                columns: new[] { "DrzavaID", "Naziv", "Oznaka", "PutanjaSlike", "Slika" },
                values: new object[,]
                {
                    { 1, "Bosna i Hercegovina", "BiH", "", null },
                    { 2, "Hrvatska", "HR", "", null },
                    { 3, "Srbija", "SR", "", null },
                    { 4, "Slovenija", "SL", "", null }
                });

            migrationBuilder.InsertData(
                table: "KategorijaJela",
                columns: new[] { "KategorijaJelaID", "Naziv" },
                values: new object[,]
                {
                    { 1, "Slatka jela" },
                    { 2, "Slana jela" },
                    { 3, "N/A" }
                });

            migrationBuilder.InsertData(
                table: "Kategorije",
                columns: new[] { "KategorijaID", "Naziv", "Opis", "Sadrzaj", "Ukupno", "VrstaKategorije" },
                values: new object[,]
                {
                    { 6, "Others", "Not yet defined", "", 0, "Default" },
                    { 4, "Accommodation", "", "Apartmani, Hoteli", 0, "Default" },
                    { 5, "Transport", "", "Prevoz", 0, "Default" },
                    { 2, "Atractions", "", "Atrakcije", 0, "Default" },
                    { 1, "Food", "", "Restorani", 0, "Default" },
                    { 3, "Coffee shops", "", "Kafici", 0, "Default" }
                });

            migrationBuilder.InsertData(
                table: "Uloge",
                columns: new[] { "UlogaId", "Naziv", "Opis" },
                values: new object[,]
                {
                    { 1, "Administrator", "" },
                    { 2, "Korisnik", "" }
                });

            migrationBuilder.InsertData(
                table: "VrstaAtrakcija",
                columns: new[] { "VrstaAtrakcijeID", "Naziv" },
                values: new object[,]
                {
                    { 1, "Prirodne" },
                    { 2, "Historijske" },
                    { 3, "Religijske" },
                    { 4, "Adrenalinske" },
                    { 5, "N/A" }
                });

            migrationBuilder.InsertData(
                table: "VrstaRestorana",
                columns: new[] { "VrstaID", "Naziv" },
                values: new object[,]
                {
                    { 2, "Fast Food" },
                    { 1, "Restoran" },
                    { 3, "N/A" }
                });

            migrationBuilder.InsertData(
                table: "Apartmani",
                columns: new[] { "ApartmanID", "AparatZaKafu", "Bazen", "GodinaIzgradnje", "KategorijaApartmana", "KategorijaID", "Klima", "Latitude", "Lokacija", "Longitude", "Naziv", "Ocjena", "Parking", "Perilica", "PutanjaSlike", "Slika", "SlikaThumb", "TV", "Udaljenost", "Wifi" },
                values: new object[,]
                {
                    { 2, true, false, 1999, "A", 4, true, 43.3456693, "Braće Trbonja 6, Mostar 88000", 17.8131764, "Apartman Solis", 4.3, true, true, "", null, null, true, null, true },
                    { 5, true, false, 2003, "C", 4, false, 43.3403544, "Braće Čišića 23, Mostar 88000", 17.8167406, "Apartman Aylin", 3.29, true, false, "", null, null, true, null, true },
                    { 4, true, false, 2002, "B", 4, false, 43.3421271, "Rizikala 8, Mostar 88000", 17.813691, "Dream Apartments Mostar", 4.0, true, true, "", null, null, true, null, true },
                    { 3, true, true, 2001, "C", 4, false, 43.3399835, "Braće Šarića 15, 88000 Mostar", 17.8172949, "Apartman Aida Mostar", 3.5, false, true, "", null, null, true, null, true },
                    { 1, true, false, 2000, "D", 4, true, 43.3537666, "Maršala Tita 33a, Mostar 88000", 17.8125038, "Apartment Dalia", 2.5, false, true, "", null, null, true, null, true }
                });

            migrationBuilder.InsertData(
                table: "Atrakcije",
                columns: new[] { "AtrakcijaID", "KategorijaID", "Latitude", "Lokacija", "Longitude", "Naziv", "Ocjena", "Opis", "PutanjaSlike", "Slika", "SlikaThumn", "Udaljenost", "VrstaAtrakcijeID" },
                values: new object[,]
                {
                    { 3, 2, 43.35029582798046, "Fortica,Mostar 88000", 17.832039071950071, "ZIPLine Fortica", 3.0, "Although not an official name, Fortica is a well-established name for a hill above Mostar through which leads the local road to Podveležje, and most probably originates from the Italian word fortezza = fort.", "", null, null, null, 4 },
                    { 2, 2, 43.3418210027799, "Osmana Džikića 41, Mostar 88000", 17.816525157088339, "Muslibegovic House", 3.4, "Forming part of a 17th-century heritage complex, this historic, rustic-chic hotel is a 1-minute walk from the Karagöz Bey Mosque and 8 minutes on foot from Stari Most, a restored 16th-century bridge.", "", null, null, null, 3 },
                    { 5, 2, 43.339720130675644, "Mala Tepa 16, Mostar 80807", 17.816927109510132, "Koskin-Mehmed Pasha's Mosque", 5.0, "Small mosque dating to the 17th century, with striking views of the river & surrounding town.", "", null, null, null, 2 },
                    { 1, 2, 43.337101, "Stari Most, Mostar 88000", 17.81485, "Old Bridge (Stari Most)", 5.0, "Over the Neretva river in the city of Mostar, Bosnia and Herzegovina, you will find the beautiful stone bridge Stari Most.", "", null, null, null, 2 },
                    { 4, 2, 43.257167860613059, "Blagaj", 17.904669589166819, "Vrelo Bune", 5.0, "Natural spring flowing from a cavern, forming picturesque falls near waterfront restaurants.", "", null, null, null, 1 }
                });

            migrationBuilder.InsertData(
                table: "Gradovi",
                columns: new[] { "GradID", "DrzavaID", "Naziv" },
                values: new object[,]
                {
                    { 15, 3, "Subotica" },
                    { 14, 3, "Kragujevac" },
                    { 1, 1, "Mostar" },
                    { 12, 3, "Novi sad" },
                    { 11, 3, "Beograd" },
                    { 2, 1, "Sarajevo" },
                    { 3, 1, "Tuzla" },
                    { 4, 1, "Zenica" },
                    { 5, 1, "Konjic" },
                    { 6, 2, "Zagred" },
                    { 13, 3, "Niš" },
                    { 10, 2, "Osijek" },
                    { 9, 2, "Dubrovnik" },
                    { 8, 2, "Split" },
                    { 7, 2, "Karlovac" }
                });

            migrationBuilder.InsertData(
                table: "Hoteli",
                columns: new[] { "HotelID", "AparatZaKafu", "Bazen", "GodinaIzgradnje", "Kategorija", "KategorijaID", "Klima", "Latitude", "Lokacija", "Longitude", "Naziv", "Ocjena", "Parking", "PutanjaSlike", "Slika", "SlikaThumn", "TV", "Udaljenost", "Wifi" },
                values: new object[,]
                {
                    { 5, true, false, 2003, "B", 4, false, 43.33719935014247, "Onešćukova 32, 88000 Mostar", 17.813126851831623, "Hotel Emen", 3.29, true, "", null, null, true, null, true },
                    { 4, true, false, 2002, "B", 4, false, 43.344693051503221, "Mostarskog bataljona bb, 88000 Mostar", 17.812161670884688, "Hotel Bristol", 4.34, true, "", null, null, true, null, true },
                    { 2, true, false, 1999, "B", 4, true, 43.3503297, "Kneza Višeslava, Mostar 88000", 17.804026, "Hotel Mepas", 3.2, true, "", null, null, true, null, true },
                    { 3, true, true, 2001, "C", 4, false, 43.339569731156907, "Konak 18, 88000 Mostar", 17.822071547070191, "Hotel Eden", 3.5, false, "", null, null, true, null, true },
                    { 1, true, true, 2000, "A", 4, true, 43.3455656, "Kneza Domagoja, Mostar 88000", 17.8057751, "Hotel Mostar", 4.5, true, "", null, null, true, null, true }
                });

            migrationBuilder.InsertData(
                table: "Jela",
                columns: new[] { "JeloID", "KategorijaJelaID", "Naziv", "Ocjena", "PutanjaSlike", "Sastojci", "Slika" },
                values: new object[,]
                {
                    { 3, 1, "Ćevapi", null, "", "...", null },
                    { 2, 1, "Pohovani fileti", null, "", "...", null },
                    { 1, 1, "Hamburger", null, "", "...", null }
                });

            migrationBuilder.InsertData(
                table: "Kafici",
                columns: new[] { "KaficID", "KategorijaID", "Latitude", "Lokacija", "Longitude", "Naziv", "Ocjena", "PutanjaSlike", "Slika", "Udaljenost" },
                values: new object[,]
                {
                    { 5, 3, 43.33554505503043, "Mostar 88000", 17.817228391411266, "Caffe Bar Fratello", 4.7, "", null, null },
                    { 4, 3, 43.337564943914067, "Rade Bitange, Mostar 88000", 17.814320673596402, "Café de Alma", 4.4, "", null, null },
                    { 3, 3, 43.343148574040683, "Braće Fejića 35, Mostar 88000", 17.81306363263667, "Cafe Bar IL MOORO", 4.362, "", null, null },
                    { 2, 3, 43.345981010588361, "Kralja Tvrtka 22, Mostar 88000", 17.804500037023651, "Black Pearl", 4.5, "", null, null },
                    { 1, 3, 43.3586019, "Zalik 1, Mostar 88000", 17.8145922, "Spago pub", 5.0, "", null, null }
                });

            migrationBuilder.InsertData(
                table: "Nightclubs",
                columns: new[] { "NightClubID", "KategorijaID", "Latitude", "Lokacija", "Longitude", "Naziv", "Ocjena", "PutanjaSlike", "Slika", "Udaljenost" },
                values: new object[,]
                {
                    { 2, 6, 43.3418, "Kralja Petra Krešimira IV, Mostar 88000", 17.8017, "Drugi način", 3.0, null, null, null },
                    { 1, 6, 43.3454941, "Midhad Hujdur Hujka sportska dvorana", 17.8058701, "Art", 3.0, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Prevoz",
                columns: new[] { "PrevozID", "KategorijaID", "Naziv", "PutanjaSlike", "Slika", "Telefon", "Vrsta" },
                values: new object[,]
                {
                    { 1, 5, "Arny", "", null, "1507", "Taxi" },
                    { 2, 5, "Herc", "", null, "1599", "Taxi" },
                    { 3, 5, "Moj Taxi", "", null, "1503", "Taxi" },
                    { 4, 5, "Green Taxi", "", null, "1500", "Taxi" }
                });

            migrationBuilder.InsertData(
                table: "Restorani",
                columns: new[] { "RestoranID", "GodinaIzgradnje", "KategorijaID", "Latitude", "Lokacija", "Longitude", "Naziv", "Ocjena", "PutanjaSlike", "Slika", "Udaljenost", "VrstaID" },
                values: new object[,]
                {
                    { 4, 2001, 1, 43.338915, "Mala Tepa bb, Mostar 88000", 17.8151488, "Urban Grill", 3.4, "", null, null, 1 },
                    { 5, 2002, 1, 43.3402981, "Kraljice Katarine 11a, Mostar 88000", 17.8027823, "Restoran Radobolja", 4.7, "", null, null, 1 },
                    { 1, 2000, 1, 43.3553315, "Muje Pašica bb, Mostar 88000", 17.8133241, "Megamarkt", 5.0, "", null, null, 1 },
                    { 2, 1999, 1, 43.3501688, "Kralja Tomislava 29, Mostar 88000", 17.8007839, "Megi", 4.5, "", null, null, 1 },
                    { 3, 1998, 1, 43.350002, "Vukovarska, Mostar 88000", 17.7975807, "TABOO Restaurant", 4.362, "", null, null, 2 }
                });

            migrationBuilder.InsertData(
                table: "Korisnici",
                columns: new[] { "KorisnikID", "BrojPrijavljivanja", "DatumRodjenja", "Email", "GradID", "Ime", "KorisnickoIme", "LozinkaHash", "LozinkaSalt", "Prezime", "PutanjaSlike", "Slika", "SlikaThumb", "Telefon" },
                values: new object[] { 1, 0, null, "desktop@edu.fit.ba", 1, "desktop", "testing2", "25BXwlT+alXTy1YgGuVNeFJx7vE=", "nfB0WOkoOSuHIlkbdGETHQ==", "desktop", "", null, null, "036598745" });

            migrationBuilder.InsertData(
                table: "Korisnici",
                columns: new[] { "KorisnikID", "BrojPrijavljivanja", "DatumRodjenja", "Email", "GradID", "Ime", "KorisnickoIme", "LozinkaHash", "LozinkaSalt", "Prezime", "PutanjaSlike", "Slika", "SlikaThumb", "Telefon" },
                values: new object[] { 2, 0, null, "mobile@edu.fit.ba", 2, "mobile", "mobile", "QMQxyTHTDQPbB99C327FoldOy1g=", "Nr1JgKhL6v1dQtHGc+ytkw==", "mobile", "", null, null, "036593745" });

            migrationBuilder.InsertData(
                table: "KorisniciUloge",
                columns: new[] { "KorisnickaUlogaID", "DatumIzmjene", "KorisnikID", "UlogaID" },
                values: new object[,]
                {
                    { 1, null, 1, 1 },
                    { 2, null, 1, 2 },
                    { 3, null, 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "Poruke",
                columns: new[] { "PorukaID", "Datum", "Posiljalac", "PosiljalacID", "Primalac", "PrimalacID", "Sadrzaj" },
                values: new object[,]
                {
                    { 1, null, "desktop desktop", 1, "desktop desktop", 1, "Welcome to explore Mostar!" },
                    { 2, null, "desktop desktop", 1, "mobile mobile", 2, "Hello and welcome to our app" }
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
