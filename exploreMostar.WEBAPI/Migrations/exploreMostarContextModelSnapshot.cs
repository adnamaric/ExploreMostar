﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using exploreMostar.WebAPI.Database;

namespace exploreMostar.WebAPI.Migrations
{
    [DbContext(typeof(exploreMostarContext))]
    partial class exploreMostarContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("exploreMostar.WebAPI.Database.Apartmani", b =>
                {
                    b.Property<int>("ApartmanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ApartmanID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("AparatZaKafu");

                    b.Property<bool?>("Bazen");

                    b.Property<int?>("GodinaIzgradnje");

                    b.Property<string>("KategorijaApartmana")
                        .HasMaxLength(1);

                    b.Property<int>("KategorijaId")
                        .HasColumnName("KategorijaID");

                    b.Property<bool?>("Klima");

                    b.Property<double?>("Latitude");

                    b.Property<string>("Lokacija")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<double?>("Longitude");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<double?>("Ocjena");

                    b.Property<bool?>("Parking");

                    b.Property<bool?>("Perilica");

                    b.Property<string>("PutanjaSlike");

                    b.Property<byte[]>("Slika");

                    b.Property<byte[]>("SlikaThumb");

                    b.Property<bool?>("Tv")
                        .HasColumnName("TV");

                    b.Property<double?>("Udaljenost");

                    b.Property<bool?>("Wifi");

                    b.HasKey("ApartmanId");

                    b.HasIndex("KategorijaId");

                    b.ToTable("Apartmani");
                });

            modelBuilder.Entity("exploreMostar.WebAPI.Database.Atrakcije", b =>
                {
                    b.Property<int>("AtrakcijaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("AtrakcijaID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("KategorijaId")
                        .HasColumnName("KategorijaID");

                    b.Property<double?>("Latitude");

                    b.Property<string>("Lokacija")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<double?>("Longitude");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<double?>("Ocjena");

                    b.Property<string>("Opis")
                        .HasMaxLength(250);

                    b.Property<string>("PutanjaSlike");

                    b.Property<byte[]>("Slika");

                    b.Property<byte[]>("SlikaThumn");

                    b.Property<double?>("Udaljenost");

                    b.Property<int?>("VrstaAtrakcijeId")
                        .HasColumnName("VrstaAtrakcijeID");

                    b.HasKey("AtrakcijaId");

                    b.HasIndex("KategorijaId");

                    b.HasIndex("VrstaAtrakcijeId");

                    b.ToTable("Atrakcije");
                });

            modelBuilder.Entity("exploreMostar.WebAPI.Database.DodatneOpcije", b =>
                {
                    b.Property<int>("DodatnaOpcijaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("DodatnaOpcijaID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("Bazen");

                    b.Property<bool?>("Parking");

                    b.Property<bool?>("Tv")
                        .HasColumnName("TV");

                    b.HasKey("DodatnaOpcijaId");

                    b.ToTable("DodatneOpcije");
                });

            modelBuilder.Entity("exploreMostar.WebAPI.Database.Drzave", b =>
                {
                    b.Property<int>("DrzavaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("DrzavaID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Oznaka")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("PutanjaSlike");

                    b.Property<byte[]>("Slika");

                    b.HasKey("DrzavaId");

                    b.ToTable("Drzave");
                });

            modelBuilder.Entity("exploreMostar.WebAPI.Database.Gradovi", b =>
                {
                    b.Property<int>("GradId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("GradID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DrzavaId")
                        .HasColumnName("DrzavaID");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("GradId");

                    b.HasIndex("DrzavaId");

                    b.ToTable("Gradovi");
                });

            modelBuilder.Entity("exploreMostar.WebAPI.Database.Hoteli", b =>
                {
                    b.Property<int>("HotelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("HotelID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("AparatZaKafu");

                    b.Property<bool?>("Bazen");

                    b.Property<int?>("GodinaIzgradnje");

                    b.Property<string>("Kategorija")
                        .HasMaxLength(1);

                    b.Property<int>("KategorijaId")
                        .HasColumnName("KategorijaID");

                    b.Property<bool?>("Klima");

                    b.Property<double?>("Latitude");

                    b.Property<string>("Lokacija")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<double?>("Longitude");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<double?>("Ocjena");

                    b.Property<bool?>("Parking");

                    b.Property<string>("PutanjaSlike");

                    b.Property<byte[]>("Slika");

                    b.Property<byte[]>("SlikaThumn");

                    b.Property<bool?>("Tv")
                        .HasColumnName("TV");

                    b.Property<double?>("Udaljenost");

                    b.Property<bool?>("Wifi");

                    b.HasKey("HotelId");

                    b.HasIndex("KategorijaId");

                    b.ToTable("Hoteli");
                });

            modelBuilder.Entity("exploreMostar.WebAPI.Database.Jela", b =>
                {
                    b.Property<int>("JeloId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("JeloID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("KategorijaJelaId")
                        .HasColumnName("KategorijaJelaID");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<double?>("Ocjena");

                    b.Property<string>("PutanjaSlike");

                    b.Property<string>("Sastojci")
                        .HasMaxLength(100);

                    b.Property<byte[]>("Slika");

                    b.HasKey("JeloId");

                    b.HasIndex("KategorijaJelaId");

                    b.ToTable("Jela");
                });

            modelBuilder.Entity("exploreMostar.WebAPI.Database.Jelovnik", b =>
                {
                    b.Property<int>("JelovnikId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("JelovnikID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BrojJela");

                    b.Property<DateTime?>("Datum")
                        .HasColumnType("datetime");

                    b.Property<int?>("JeloId")
                        .HasColumnName("JeloID");

                    b.Property<string>("Naziv")
                        .HasMaxLength(50);

                    b.Property<string>("Opis")
                        .HasMaxLength(100);

                    b.Property<int?>("RestoranId")
                        .HasColumnName("RestoranID");

                    b.HasKey("JelovnikId");

                    b.HasIndex("JeloId");

                    b.HasIndex("RestoranId");

                    b.ToTable("Jelovnik");
                });

            modelBuilder.Entity("exploreMostar.WebAPI.Database.Kafici", b =>
                {
                    b.Property<int>("KaficId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("KaficID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("KategorijaId")
                        .HasColumnName("KategorijaID");

                    b.Property<double?>("Latitude");

                    b.Property<string>("Lokacija")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<double?>("Longitude");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<double?>("Ocjena");

                    b.Property<string>("PutanjaSlike");

                    b.Property<byte[]>("Slika");

                    b.Property<double?>("Udaljenost");

                    b.HasKey("KaficId");

                    b.HasIndex("KategorijaId");

                    b.ToTable("Kafici");
                });

            modelBuilder.Entity("exploreMostar.WebAPI.Database.KategorijaJela", b =>
                {
                    b.Property<int>("KategorijaJelaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("KategorijaJelaID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasMaxLength(250);

                    b.HasKey("KategorijaJelaId");

                    b.ToTable("KategorijaJela");
                });

            modelBuilder.Entity("exploreMostar.WebAPI.Database.Kategorije", b =>
                {
                    b.Property<int>("KategorijaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("KategorijaID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("Opis")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("Sadrzaj");

                    b.Property<int?>("Ukupno");

                    b.Property<string>("VrstaKategorije");

                    b.HasKey("KategorijaId");

                    b.ToTable("Kategorije");
                });

            modelBuilder.Entity("exploreMostar.WebAPI.Database.Korisnici", b =>
                {
                    b.Property<int>("KorisnikId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("KorisnikID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BrojPrijavljivanja");

                    b.Property<DateTime?>("DatumRodjenja")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int?>("GradId")
                        .HasColumnName("GradID");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("KorisnickoIme")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("LozinkaHash")
                        .HasMaxLength(50);

                    b.Property<string>("LozinkaSalt")
                        .HasMaxLength(50);

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("PutanjaSlike");

                    b.Property<byte[]>("Slika");

                    b.Property<byte[]>("SlikaThumb");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("KorisnikId");

                    b.HasIndex("GradId");

                    b.ToTable("Korisnici");
                });

            modelBuilder.Entity("exploreMostar.WebAPI.Database.KorisniciUloge", b =>
                {
                    b.Property<int>("KorisnickaUlogaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("KorisnickaUlogaID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DatumIzmjene")
                        .HasColumnType("datetime");

                    b.Property<int?>("KorisnikId")
                        .HasColumnName("KorisnikID");

                    b.Property<int?>("UlogaId")
                        .HasColumnName("UlogaID");

                    b.HasKey("KorisnickaUlogaId");

                    b.HasIndex("KorisnikId");

                    b.HasIndex("UlogaId");

                    b.ToTable("KorisniciUloge");
                });

            modelBuilder.Entity("exploreMostar.WebAPI.Database.KorisnikKategorija", b =>
                {
                    b.Property<int>("KorisnikKategorijaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("KorisnikKategorijaID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("KategorijaId")
                        .HasColumnName("KategorijaID");

                    b.Property<int?>("KorisnikId")
                        .HasColumnName("KorisnikID");

                    b.HasKey("KorisnikKategorijaId");

                    b.HasIndex("KategorijaId");

                    b.HasIndex("KorisnikId");

                    b.ToTable("KorisnikKategorija");
                });

            modelBuilder.Entity("exploreMostar.WebAPI.Database.Markeri", b =>
                {
                    b.Property<int>("MarkerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("MarkerID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresa")
                        .IsRequired()
                        .HasMaxLength(80)
                        .IsUnicode(false);

                    b.Property<int?>("GradId")
                        .HasColumnName("GradID");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<double>("Lat")
                        .HasColumnName("lat");

                    b.Property<double>("Lng")
                        .HasColumnName("lng");

                    b.Property<string>("Opis")
                        .HasMaxLength(30);

                    b.HasKey("MarkerId");

                    b.HasIndex("GradId");

                    b.ToTable("Markeri");
                });

            modelBuilder.Entity("exploreMostar.WebAPI.Database.MojiFavoriti", b =>
                {
                    b.Property<int>("FavoritiId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("KorisnikId")
                        .HasColumnName("KorisnikID");

                    b.Property<string>("Naziv");

                    b.Property<int?>("ObjekatId")
                        .HasColumnName("ObjekatID");

                    b.Property<string>("Vrsta");

                    b.HasKey("FavoritiId");

                    b.HasIndex("KorisnikId");

                    b.ToTable("MojiFavoriti");
                });

            modelBuilder.Entity("exploreMostar.WebAPI.Database.Nightclubs", b =>
                {
                    b.Property<int>("NightClubId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("NightClubID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("KategorijaId")
                        .HasColumnName("KategorijaID");

                    b.Property<double?>("Latitude");

                    b.Property<string>("Lokacija")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<double?>("Longitude");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<double?>("Ocjena");

                    b.Property<string>("PutanjaSlike");

                    b.Property<byte[]>("Slika");

                    b.Property<double?>("Udaljenost");

                    b.HasKey("NightClubId");

                    b.HasIndex("KategorijaId");

                    b.ToTable("Nightclubs");
                });

            modelBuilder.Entity("exploreMostar.WebAPI.Database.Objava", b =>
                {
                    b.Property<int>("ObjavaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Autor")
                        .HasMaxLength(40);

                    b.Property<string>("AutorModifikacije")
                        .HasMaxLength(250);

                    b.Property<DateTime?>("Datum")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("DatumModificiranja")
                        .HasColumnType("datetime");

                    b.Property<int?>("KorisnikId")
                        .HasColumnName("KorisnikID");

                    b.Property<string>("Naziv")
                        .HasMaxLength(50);

                    b.Property<string>("PutanjaSlike");

                    b.Property<string>("Sadrzaj")
                        .HasMaxLength(250);

                    b.Property<byte[]>("Slika")
                        .HasMaxLength(1);

                    b.HasKey("ObjavaId");

                    b.HasIndex("KorisnikId");

                    b.ToTable("Objava");
                });

            modelBuilder.Entity("exploreMostar.WebAPI.Database.Poruke", b =>
                {
                    b.Property<int>("PorukaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("PorukaID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("Datum")
                        .HasColumnType("datetime");

                    b.Property<string>("Posiljalac")
                        .HasMaxLength(50);

                    b.Property<int?>("PosiljalacId")
                        .HasColumnName("PosiljalacID");

                    b.Property<string>("Primalac")
                        .HasMaxLength(50);

                    b.Property<int?>("PrimalacId")
                        .HasColumnName("PrimalacID");

                    b.Property<string>("Sadrzaj");

                    b.HasKey("PorukaId");

                    b.HasIndex("PosiljalacId");

                    b.HasIndex("PrimalacId");

                    b.ToTable("Poruke");
                });

            modelBuilder.Entity("exploreMostar.WebAPI.Database.Prevoz", b =>
                {
                    b.Property<int>("PrevozId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("PrevozID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("KategorijaId")
                        .HasColumnName("KategorijaID");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("PutanjaSlike");

                    b.Property<byte[]>("Slika");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Vrsta")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("PrevozId");

                    b.HasIndex("KategorijaId");

                    b.ToTable("Prevoz");
                });

            modelBuilder.Entity("exploreMostar.WebAPI.Database.Recenzije", b =>
                {
                    b.Property<int>("RecenzijaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("RecenzijaID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("Datum")
                        .HasColumnType("datetime");

                    b.Property<string>("ImePrezime");

                    b.Property<int?>("KorisnikId")
                        .HasColumnName("KorisnikID");

                    b.Property<string>("Objekat");

                    b.Property<int?>("Ocjena");

                    b.Property<string>("Sadrzaj");

                    b.Property<string>("Vrsta");

                    b.HasKey("RecenzijaId");

                    b.HasIndex("KorisnikId");

                    b.ToTable("Recenzije");
                });

            modelBuilder.Entity("exploreMostar.WebAPI.Database.Restorani", b =>
                {
                    b.Property<int>("RestoranId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("RestoranID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("GodinaIzgradnje");

                    b.Property<int>("KategorijaId")
                        .HasColumnName("KategorijaID");

                    b.Property<double?>("Latitude");

                    b.Property<string>("Lokacija")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<double?>("Longitude");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<double?>("Ocjena");

                    b.Property<string>("PutanjaSlike");

                    b.Property<byte[]>("Slika");

                    b.Property<double?>("Udaljenost");

                    b.Property<int>("VrstaId")
                        .HasColumnName("VrstaID");

                    b.HasKey("RestoranId");

                    b.HasIndex("KategorijaId");

                    b.HasIndex("VrstaId");

                    b.ToTable("Restorani");
                });

            modelBuilder.Entity("exploreMostar.WebAPI.Database.SearchTrack", b =>
                {
                    b.Property<int>("SearchId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("SearchID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DatumPretrage")
                        .HasColumnType("datetime");

                    b.Property<string>("ImePrezime");

                    b.Property<int?>("KorisnikId")
                        .HasColumnName("KorisnikID");

                    b.Property<string>("Sadrzaj");

                    b.HasKey("SearchId");

                    b.HasIndex("KorisnikId");

                    b.ToTable("SearchTrack");
                });

            modelBuilder.Entity("exploreMostar.WebAPI.Database.Uloge", b =>
                {
                    b.Property<int>("UlogaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasMaxLength(25);

                    b.Property<string>("Opis")
                        .HasMaxLength(100);

                    b.HasKey("UlogaId");

                    b.ToTable("Uloge");
                });

            modelBuilder.Entity("exploreMostar.WebAPI.Database.UserActivity", b =>
                {
                    b.Property<int>("KorisnikId")
                        .HasColumnName("KorisnikID");

                    b.Property<int?>("AdminId")
                        .HasColumnName("AdminID");

                    b.Property<int?>("BrojApartmanaFavoriti");

                    b.Property<int?>("BrojAtrakcijaFavoriti");

                    b.Property<int?>("BrojHotelaFavoriti");

                    b.Property<int?>("BrojKaficaFavoriti");

                    b.Property<int?>("BrojNeuspjesnihPrijavljivanja");

                    b.Property<int?>("BrojNocnihKlubovaFavoriti");

                    b.Property<int?>("BrojPrijavljivanja");

                    b.Property<int?>("BrojRestoranaFavoriti");

                    b.Property<DateTime?>("Datum")
                        .HasColumnType("datetime");

                    b.Property<bool?>("IsApartman")
                        .HasColumnName("isApartman");

                    b.Property<bool?>("IsAtrakcija")
                        .HasColumnName("isAtrakcija");

                    b.Property<bool?>("IsHotel")
                        .HasColumnName("isHotel");

                    b.Property<bool?>("IsKafic")
                        .HasColumnName("isKafic");

                    b.Property<bool?>("IsNightClub")
                        .HasColumnName("isNightClub");

                    b.Property<bool?>("IsRestoran")
                        .HasColumnName("isRestoran");

                    b.Property<string>("ListaOdabranihStavki");

                    b.Property<bool?>("Onemogucen");

                    b.Property<string>("Razlog");

                    b.HasKey("KorisnikId");

                    b.ToTable("UserActivity");
                });

            modelBuilder.Entity("exploreMostar.WebAPI.Database.VrstaAtrakcija", b =>
                {
                    b.Property<int>("VrstaAtrakcijeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("VrstaAtrakcijeID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("VrstaAtrakcijeId");

                    b.ToTable("VrstaAtrakcija");
                });

            modelBuilder.Entity("exploreMostar.WebAPI.Database.VrstaRestorana", b =>
                {
                    b.Property<int>("VrstaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("VrstaID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasMaxLength(50);

                    b.HasKey("VrstaId");

                    b.ToTable("VrstaRestorana");
                });

            modelBuilder.Entity("exploreMostar.WebAPI.Database.Apartmani", b =>
                {
                    b.HasOne("exploreMostar.WebAPI.Database.Kategorije", "Kategorija")
                        .WithMany("Apartmani")
                        .HasForeignKey("KategorijaId")
                        .HasConstraintName("FK__Apartmani__Kateg__160F4887");
                });

            modelBuilder.Entity("exploreMostar.WebAPI.Database.Atrakcije", b =>
                {
                    b.HasOne("exploreMostar.WebAPI.Database.Kategorije", "Kategorija")
                        .WithMany("Atrakcije")
                        .HasForeignKey("KategorijaId")
                        .HasConstraintName("FK__Atrakcije__Kateg__17036CC0");

                    b.HasOne("exploreMostar.WebAPI.Database.VrstaAtrakcija", "VrstaAtrakcije")
                        .WithMany("Atrakcije")
                        .HasForeignKey("VrstaAtrakcijeId")
                        .HasConstraintName("FK__Atrakcije__Vrsta__151B244E");
                });

            modelBuilder.Entity("exploreMostar.WebAPI.Database.Gradovi", b =>
                {
                    b.HasOne("exploreMostar.WebAPI.Database.Drzave", "Drzava")
                        .WithMany("Gradovi")
                        .HasForeignKey("DrzavaId")
                        .HasConstraintName("FK__Gradovi__DrzavaI__6C190EBB");
                });

            modelBuilder.Entity("exploreMostar.WebAPI.Database.Hoteli", b =>
                {
                    b.HasOne("exploreMostar.WebAPI.Database.Kategorije", "KategorijaNavigation")
                        .WithMany("Hoteli")
                        .HasForeignKey("KategorijaId")
                        .HasConstraintName("FK__Hoteli__Kategori__17F790F9");
                });

            modelBuilder.Entity("exploreMostar.WebAPI.Database.Jela", b =>
                {
                    b.HasOne("exploreMostar.WebAPI.Database.KategorijaJela", "KategorijaJela")
                        .WithMany("Jela")
                        .HasForeignKey("KategorijaJelaId")
                        .HasConstraintName("FK__Jela__Kategorija__5224328E");
                });

            modelBuilder.Entity("exploreMostar.WebAPI.Database.Jelovnik", b =>
                {
                    b.HasOne("exploreMostar.WebAPI.Database.Jela", "Jelo")
                        .WithMany("Jelovnik")
                        .HasForeignKey("JeloId")
                        .HasConstraintName("FK__Jelovnik__JeloID__607251E5");

                    b.HasOne("exploreMostar.WebAPI.Database.Restorani", "Restoran")
                        .WithMany("Jelovnik")
                        .HasForeignKey("RestoranId")
                        .HasConstraintName("FK__Jelovnik__Restor__6166761E");
                });

            modelBuilder.Entity("exploreMostar.WebAPI.Database.Kafici", b =>
                {
                    b.HasOne("exploreMostar.WebAPI.Database.Kategorije", "Kategorija")
                        .WithMany("Kafici")
                        .HasForeignKey("KategorijaId")
                        .HasConstraintName("FK__Kafici__Kategori__18EBB532");
                });

            modelBuilder.Entity("exploreMostar.WebAPI.Database.Korisnici", b =>
                {
                    b.HasOne("exploreMostar.WebAPI.Database.Gradovi", "Grad")
                        .WithMany("Korisnici")
                        .HasForeignKey("GradId")
                        .HasConstraintName("FK__Korisnici__GradI__03F0984C");
                });

            modelBuilder.Entity("exploreMostar.WebAPI.Database.KorisniciUloge", b =>
                {
                    b.HasOne("exploreMostar.WebAPI.Database.Korisnici", "Korisnik")
                        .WithMany("KorisniciUloge")
                        .HasForeignKey("KorisnikId")
                        .HasConstraintName("FK__Korisnici__Koris__662B2B3B");

                    b.HasOne("exploreMostar.WebAPI.Database.Uloge", "Uloga")
                        .WithMany("KorisniciUloge")
                        .HasForeignKey("UlogaId")
                        .HasConstraintName("FK__Korisnici__Uloga__671F4F74");
                });

            modelBuilder.Entity("exploreMostar.WebAPI.Database.KorisnikKategorija", b =>
                {
                    b.HasOne("exploreMostar.WebAPI.Database.Kategorije", "Kategorija")
                        .WithMany("KorisnikKategorija")
                        .HasForeignKey("KategorijaId")
                        .HasConstraintName("FK__KorisnikK__Kateg__5441852A");

                    b.HasOne("exploreMostar.WebAPI.Database.Korisnici", "Korisnik")
                        .WithMany("KorisnikKategorija")
                        .HasForeignKey("KorisnikId")
                        .HasConstraintName("FK__KorisnikK__Koris__534D60F1");
                });

            modelBuilder.Entity("exploreMostar.WebAPI.Database.Markeri", b =>
                {
                    b.HasOne("exploreMostar.WebAPI.Database.Gradovi", "Grad")
                        .WithMany("Markeri")
                        .HasForeignKey("GradId")
                        .HasConstraintName("FK__Markeri__GradID__08B54D69");
                });

            modelBuilder.Entity("exploreMostar.WebAPI.Database.MojiFavoriti", b =>
                {
                    b.HasOne("exploreMostar.WebAPI.Database.Korisnici", "Korisnik")
                        .WithMany("MojiFavoriti")
                        .HasForeignKey("KorisnikId")
                        .HasConstraintName("FK__MojiFavor__Koris__2EA5EC27");
                });

            modelBuilder.Entity("exploreMostar.WebAPI.Database.Nightclubs", b =>
                {
                    b.HasOne("exploreMostar.WebAPI.Database.Kategorije", "Kategorija")
                        .WithMany("Nightclubs")
                        .HasForeignKey("KategorijaId")
                        .HasConstraintName("FK__Nightclub__Kateg__19DFD96B");
                });

            modelBuilder.Entity("exploreMostar.WebAPI.Database.Objava", b =>
                {
                    b.HasOne("exploreMostar.WebAPI.Database.Korisnici", "Korisnik")
                        .WithMany("Objava")
                        .HasForeignKey("KorisnikId")
                        .HasConstraintName("FK__Objava__Korisnik__73852659");
                });

            modelBuilder.Entity("exploreMostar.WebAPI.Database.Poruke", b =>
                {
                    b.HasOne("exploreMostar.WebAPI.Database.Korisnici", "PosiljalacNavigation")
                        .WithMany("PorukePosiljalacNavigation")
                        .HasForeignKey("PosiljalacId")
                        .HasConstraintName("FK__Poruke__Posiljal__0880433F");

                    b.HasOne("exploreMostar.WebAPI.Database.Korisnici", "PrimalacNavigation")
                        .WithMany("PorukePrimalacNavigation")
                        .HasForeignKey("PrimalacId")
                        .HasConstraintName("FK__Poruke__Primalac__09746778");
                });

            modelBuilder.Entity("exploreMostar.WebAPI.Database.Prevoz", b =>
                {
                    b.HasOne("exploreMostar.WebAPI.Database.Kategorije", "Kategorija")
                        .WithMany("Prevoz")
                        .HasForeignKey("KategorijaId")
                        .HasConstraintName("FK__Prevoz__Kategori__5EBF139D");
                });

            modelBuilder.Entity("exploreMostar.WebAPI.Database.Recenzije", b =>
                {
                    b.HasOne("exploreMostar.WebAPI.Database.Korisnici", "Korisnik")
                        .WithMany("Recenzije")
                        .HasForeignKey("KorisnikId")
                        .HasConstraintName("FK__Recenzije__Koris__1B9317B3");
                });

            modelBuilder.Entity("exploreMostar.WebAPI.Database.Restorani", b =>
                {
                    b.HasOne("exploreMostar.WebAPI.Database.Kategorije", "Kategorija")
                        .WithMany("Restorani")
                        .HasForeignKey("KategorijaId")
                        .HasConstraintName("FK__Restorani__Kateg__1AD3FDA4");

                    b.HasOne("exploreMostar.WebAPI.Database.VrstaRestorana", "Vrsta")
                        .WithMany("Restorani")
                        .HasForeignKey("VrstaId")
                        .HasConstraintName("FK__Restorani__Vrsta__1DB06A4F");
                });

            modelBuilder.Entity("exploreMostar.WebAPI.Database.SearchTrack", b =>
                {
                    b.HasOne("exploreMostar.WebAPI.Database.Korisnici", "Korisnik")
                        .WithMany("SearchTrack")
                        .HasForeignKey("KorisnikId")
                        .HasConstraintName("FK__SearchTra__Koris__54CB950F");
                });

            modelBuilder.Entity("exploreMostar.WebAPI.Database.UserActivity", b =>
                {
                    b.HasOne("exploreMostar.WebAPI.Database.Korisnici", "Korisnik")
                        .WithOne("UserActivity")
                        .HasForeignKey("exploreMostar.WebAPI.Database.UserActivity", "KorisnikId")
                        .HasConstraintName("FK__UserActiv__Koris__43A1090D");
                });
#pragma warning restore 612, 618
        }
    }
}
