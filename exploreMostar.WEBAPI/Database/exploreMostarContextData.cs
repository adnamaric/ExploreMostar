using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exploreMostar.WebAPI.Database
{
    public partial class exploreMostarContext
    {
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Uloge>()
                    .HasData
                    (
                        new Uloge { UlogaId = 1, Naziv = "Administrator",Opis="" },
                        new Uloge { UlogaId = 2, Naziv = "Korisnik",Opis="" }
                    );
            modelBuilder.Entity<Kategorije>()
                   .HasData
                   (
                       new Kategorije { KategorijaId = 1, Naziv = "Food", Opis="",Sadrzaj="Restorani",Ukupno=0,VrstaKategorije= "Default" },
                       new Kategorije { KategorijaId = 2, Naziv = "Atractions", Opis = "", Sadrzaj = "Atrakcije", Ukupno = 0, VrstaKategorije = "Default" },
                       new Kategorije { KategorijaId = 3, Naziv = "Coffee shops", Opis = "", Sadrzaj = "Kafici", Ukupno = 0, VrstaKategorije = "Default" },
                       new Kategorije { KategorijaId = 4, Naziv = "Accommodation", Opis = "", Sadrzaj = "Apartmani, Hoteli", Ukupno = 0, VrstaKategorije = "Default" },
                       new Kategorije { KategorijaId = 5, Naziv = "Transport", Opis = "", Sadrzaj = "Prevoz", Ukupno = 0, VrstaKategorije = "Default" },
                       new Kategorije { KategorijaId = 6, Naziv = "Others", Opis = "Not yet defined", Sadrzaj = "", Ukupno = 0, VrstaKategorije = "Default" }
                   );
            modelBuilder.Entity<KategorijaJela>()
                  .HasData
                  (
                      new KategorijaJela { KategorijaJelaId = 1, Naziv = "Slatka jela" },
                      new KategorijaJela { KategorijaJelaId = 2, Naziv = "Slana jela" },
                      new KategorijaJela { KategorijaJelaId = 3, Naziv = "N/A" }

                  );
            modelBuilder.Entity<VrstaAtrakcija>()
               .HasData
               (
                   new VrstaAtrakcija { VrstaAtrakcijeId = 1, Naziv = "Prirodne" },
                   new VrstaAtrakcija { VrstaAtrakcijeId = 2, Naziv = "Historijske" },
                   new VrstaAtrakcija { VrstaAtrakcijeId = 3, Naziv = "Religijske" },
                   new VrstaAtrakcija { VrstaAtrakcijeId = 4, Naziv = "Adrenalinske" },
                   new VrstaAtrakcija { VrstaAtrakcijeId = 5, Naziv = "N/A" }
               );
            modelBuilder.Entity<VrstaRestorana>()
               .HasData
               (
                   new VrstaRestorana { VrstaId = 1, Naziv = "Restoran" },
                   new VrstaRestorana { VrstaId = 2, Naziv = "Fast Food" },
                   new VrstaRestorana { VrstaId = 3, Naziv = "N/A" }
             
               );
            modelBuilder.Entity<Drzave>()
              .HasData
              (
                  new Drzave { DrzavaId = 1, Naziv = "Bosna i Hercegovina", Oznaka="BiH",PutanjaSlike="" },
                  new Drzave { DrzavaId = 2, Naziv = "Hrvatska", Oznaka = "HR", PutanjaSlike = "" },
                  new Drzave { DrzavaId = 3, Naziv = "Srbija", Oznaka = "SR", PutanjaSlike = "" },
                  new Drzave { DrzavaId = 4, Naziv = "Slovenija", Oznaka = "SL", PutanjaSlike = "" }
                  

              );
            modelBuilder.Entity<Apartmani>()
            .HasData
            (
                new Apartmani { ApartmanId=1,Naziv="Apartment Dalia",Lokacija= "Maršala Tita 33a, Mostar 88000",GodinaIzgradnje=2000,KategorijaId=4,Latitude=43.3537666,Longitude= 17.8125038,Bazen=false,Parking=false,Tv=true,Wifi=true,Klima=true,Perilica=true,AparatZaKafu=true,KategorijaApartmana="D",Ocjena=2.5,PutanjaSlike="" },
                new Apartmani { ApartmanId=2,Naziv= "Apartman Solis", Lokacija= "Braće Trbonja 6, Mostar 88000", GodinaIzgradnje=1999,KategorijaId=4,Latitude= 43.3456693, Longitude= 17.8131764, Bazen=false,Parking=true,Tv=true,Wifi=true,Klima=true,Perilica=true,AparatZaKafu=true,KategorijaApartmana="A",Ocjena=4.3,PutanjaSlike="" },
                new Apartmani { ApartmanId=3, Naziv = "Apartman Aida Mostar", Lokacija = "Braće Šarića 15, 88000 Mostar", GodinaIzgradnje = 2001, KategorijaId = 4, Latitude = 43.3399835, Longitude = 17.8172949, Bazen = true, Parking = false, Tv = true, Wifi = true, Klima = false, Perilica = true, AparatZaKafu = true, KategorijaApartmana = "C", Ocjena = 3.5, PutanjaSlike = "" },
                new Apartmani { ApartmanId=4, Naziv = "Dream Apartments Mostar", Lokacija = "Rizikala 8, Mostar 88000", GodinaIzgradnje = 2002, KategorijaId = 4, Latitude = 43.3421271, Longitude = 17.813691, Bazen = false, Parking = true, Tv = true, Wifi = true, Klima = false, Perilica = true, AparatZaKafu = true, KategorijaApartmana = "B", Ocjena = 4, PutanjaSlike = "" },
                new Apartmani { ApartmanId=5, Naziv = "Apartman Aylin", Lokacija = "Braće Čišića 23, Mostar 88000", GodinaIzgradnje = 2003, KategorijaId = 4, Latitude = 43.3403544, Longitude = 17.8167406, Bazen = false, Parking = true, Tv = true, Wifi = true, Klima = false, Perilica = false, AparatZaKafu = true, KategorijaApartmana = "C", Ocjena = 3.29, PutanjaSlike = "" }

            );
            modelBuilder.Entity<Atrakcije>()
          .HasData
          (
              new Atrakcije { AtrakcijaId = 1, Naziv = "Old Bridge (Stari Most)", Lokacija = "Stari Most, Mostar 88000", VrstaAtrakcijeId=2, KategorijaId = 2, Latitude = 43.337101, Longitude = 17.814850, Opis = "Over the Neretva river in the city of Mostar, Bosnia and Herzegovina, you will find the beautiful stone bridge Stari Most.", Ocjena = 5, PutanjaSlike = "" },
              new Atrakcije { AtrakcijaId = 2, Naziv = "Muslibegovic House", Lokacija = "Osmana Džikića 41, Mostar 88000", VrstaAtrakcijeId=3, KategorijaId = 2, Latitude = 43.3418210027799,Longitude = 17.81652515708834, Opis = "Forming part of a 17th-century heritage complex, this historic, rustic-chic hotel is a 1-minute walk from the Karagöz Bey Mosque and 8 minutes on foot from Stari Most, a restored 16th-century bridge.", Ocjena = 3.4, PutanjaSlike = "" },
              new Atrakcije { AtrakcijaId = 3, Naziv = "ZIPLine Fortica", Lokacija = "Fortica,Mostar 88000", VrstaAtrakcijeId = 4, KategorijaId = 2, Latitude = 43.35029582798046,Longitude = 17.83203907195007, Opis = "Although not an official name, Fortica is a well-established name for a hill above Mostar through which leads the local road to Podveležje, and most probably originates from the Italian word fortezza = fort." ,Ocjena=3, PutanjaSlike=""},
              new Atrakcije { AtrakcijaId = 4, Naziv = "Vrelo Bune", Lokacija = "Blagaj", VrstaAtrakcijeId = 1, KategorijaId = 2, Latitude = 43.25716786061306, Longitude = 17.90466958916682, Opis = "Natural spring flowing from a cavern, forming picturesque falls near waterfront restaurants.", Ocjena = 5, PutanjaSlike = "" },
              new Atrakcije { AtrakcijaId = 5, Naziv = "Koskin-Mehmed Pasha's Mosque", Lokacija = "Mala Tepa 16, Mostar 80807", VrstaAtrakcijeId = 2, KategorijaId = 2, Latitude = 43.339720130675644, Longitude = 17.816927109510132, Opis = "Small mosque dating to the 17th century, with striking views of the river & surrounding town.", Ocjena = 5, PutanjaSlike = "" }
             
          );
            modelBuilder.Entity<Hoteli>()
                .HasData
                (
                    new Hoteli { HotelId = 1, Naziv = "Hotel Mostar", Lokacija = "Kneza Domagoja, Mostar 88000", GodinaIzgradnje = 2000, KategorijaId = 4, Latitude = 43.3455656, Longitude = 17.8057751, Bazen = true, Parking = true, Tv = true, Wifi = true, Klima = true, AparatZaKafu = true, Kategorija = "A", Ocjena = 4.5, PutanjaSlike = "" },
                    new Hoteli { HotelId = 2, Naziv = "Hotel Mepas", Lokacija = "Kneza Višeslava, Mostar 88000", GodinaIzgradnje = 1999, KategorijaId = 4, Latitude = 43.3503297, Longitude = 17.804026, Bazen = false, Parking = true, Tv = true, Wifi = true, Klima = true, AparatZaKafu = true, Kategorija = "B", Ocjena = 3.2, PutanjaSlike = "" },
                    new Hoteli { HotelId = 3, Naziv = "Hotel Eden", Lokacija = "Konak 18, 88000 Mostar", GodinaIzgradnje = 2001, KategorijaId = 4, Latitude = 43.33956973115691, Longitude = 17.82207154707019, Bazen = true, Parking = false, Tv = true, Wifi = true, Klima = false, AparatZaKafu = true, Kategorija = "C", Ocjena = 3.5, PutanjaSlike = "" },
                    new Hoteli { HotelId = 4, Naziv = "Hotel Bristol", Lokacija = "Mostarskog bataljona bb, 88000 Mostar", GodinaIzgradnje = 2002, KategorijaId = 4, Latitude = 43.34469305150322, Longitude = 17.812161670884688, Bazen = false, Parking = true, Tv = true, Wifi = true, Klima = false, AparatZaKafu = true, Kategorija = "B", Ocjena = 4.34, PutanjaSlike = "" },
                    new Hoteli { HotelId = 5, Naziv = "Hotel Emen", Lokacija = "Onešćukova 32, 88000 Mostar", GodinaIzgradnje = 2003, KategorijaId = 4, Latitude = 43.33719935014247, Longitude = 17.813126851831623, Bazen = false, Parking = true, Tv = true, Wifi = true, Klima = false, AparatZaKafu = true, Kategorija = "B", Ocjena = 3.29, PutanjaSlike = "" }

                );
            modelBuilder.Entity<Kafici>()
               .HasData
               (
                   new Kafici{ KaficId = 1, Naziv = "Spago pub", Lokacija = "Zalik 1, Mostar 88000", KategorijaId = 3, Latitude = 43.3586019, Longitude = 17.8145922, Ocjena = 5, PutanjaSlike = "" },
                   new Kafici{ KaficId = 2, Naziv = "Black Pearl", Lokacija = "Kralja Tvrtka 22, Mostar 88000", KategorijaId = 3, Latitude = 43.34598101058836, Longitude = 17.80450003702365, Ocjena = 4.5, PutanjaSlike = "" },
                   new Kafici { KaficId = 3, Naziv = "Cafe Bar IL MOORO", Lokacija = "Braće Fejića 35, Mostar 88000", KategorijaId = 3, Latitude = 43.34314857404068, Longitude = 17.81306363263667, Ocjena = 4.362, PutanjaSlike = "" },
                   new Kafici { KaficId = 4, Naziv = "Café de Alma", Lokacija = "Rade Bitange, Mostar 88000", KategorijaId = 3, Latitude = 43.33756494391407, Longitude = 17.814320673596402, Ocjena = 4.4, PutanjaSlike = "" },
                   new Kafici { KaficId = 5, Naziv = "Caffe Bar Fratello", Lokacija = "Mostar 88000", KategorijaId = 3, Latitude = 43.33554505503043, Longitude = 17.817228391411266, Ocjena = 4.7, PutanjaSlike = "" }

               );
            modelBuilder.Entity<Restorani>()
              .HasData
              (
                  new Restorani { RestoranId = 1, Naziv = "Megamarkt", Lokacija = "Muje Pašica bb, Mostar 88000", KategorijaId = 1, Latitude = 43.3553315, Longitude = 17.8133241, Ocjena = 5, PutanjaSlike = "" ,GodinaIzgradnje=2000,VrstaId=1},
                  new Restorani { RestoranId = 2, Naziv = "Megi", Lokacija = "Kralja Tomislava 29, Mostar 88000", KategorijaId = 1, Latitude = 43.3501688, Longitude = 17.8007839, Ocjena = 4.5, PutanjaSlike = "" ,VrstaId=1,GodinaIzgradnje=1999},
                  new Restorani { RestoranId = 3, Naziv = "TABOO Restaurant", Lokacija = "Vukovarska, Mostar 88000", KategorijaId = 1, Latitude = 43.350002, Longitude = 17.7975807, Ocjena = 4.362, PutanjaSlike = "",VrstaId=2,GodinaIzgradnje=1998 },
                  new Restorani { RestoranId = 4, Naziv = "Urban Grill", Lokacija = "Mala Tepa bb, Mostar 88000", KategorijaId = 1, Latitude = 43.338915, Longitude = 17.8151488, Ocjena = 3.4, PutanjaSlike = "",VrstaId=1,GodinaIzgradnje=2001 },
                  new Restorani { RestoranId = 5, Naziv = "Restoran Radobolja", Lokacija = "Kraljice Katarine 11a, Mostar 88000", KategorijaId = 1, Latitude = 43.3402981, Longitude = 17.8027823, Ocjena = 4.7, PutanjaSlike = "",VrstaId=1,GodinaIzgradnje=2002 }

              );
            modelBuilder.Entity<Prevoz>()
              .HasData
              (
                  new Prevoz { PrevozId = 1, Naziv = "Arny", KategorijaId = 5, PutanjaSlike = "",Vrsta="Taxi", Telefon="1507"},
                  new Prevoz { PrevozId = 2, Naziv = "Herc", KategorijaId = 5, PutanjaSlike = "",Vrsta="Taxi", Telefon="1599"},
                  new Prevoz { PrevozId = 3, Naziv = "Moj Taxi", KategorijaId = 5, PutanjaSlike = "", Vrsta = "Taxi", Telefon = "1503" },
                  new Prevoz { PrevozId = 4, Naziv = "Green Taxi", KategorijaId = 5, PutanjaSlike = "", Vrsta = "Taxi", Telefon = "1500" }

              );
            modelBuilder.Entity<Nightclubs>().HasData(
                new Nightclubs { NightClubId=1,Naziv="Art",Lokacija= "Midhad Hujdur Hujka sportska dvorana",KategorijaId=6, Latitude= 43.3454941, Longitude= 17.8058701, Ocjena=3 },
                new Nightclubs { NightClubId = 2, Naziv = "Drugi način", Lokacija = "Kralja Petra Krešimira IV, Mostar 88000", KategorijaId = 6, Latitude = 43.3418, Longitude = 17.8017, Ocjena = 3 }

                );
            modelBuilder.Entity<Gradovi>()
              .HasData
              (
                  new Gradovi { GradId = 1, Naziv = "Mostar", DrzavaId=1 },
                  new Gradovi { GradId = 2, Naziv = "Sarajevo", DrzavaId=1 },
                  new Gradovi { GradId = 3, Naziv = "Tuzla", DrzavaId = 1 },
                  new Gradovi { GradId = 4, Naziv = "Zenica", DrzavaId = 1 },
                  new Gradovi { GradId = 5, Naziv = "Konjic", DrzavaId = 1 },
                  new Gradovi { GradId = 6, Naziv = "Zagred", DrzavaId = 2},
                  new Gradovi { GradId = 7, Naziv = "Karlovac", DrzavaId = 2 },
                  new Gradovi { GradId = 8, Naziv = "Split", DrzavaId = 2 },
                  new Gradovi { GradId = 9, Naziv = "Dubrovnik", DrzavaId = 2 },
                  new Gradovi { GradId = 10, Naziv = "Osijek", DrzavaId = 2 },
                  new Gradovi { GradId = 11, Naziv = "Beograd", DrzavaId = 3 },
                  new Gradovi { GradId = 12, Naziv = "Novi sad", DrzavaId = 3 },
                  new Gradovi { GradId = 13, Naziv = "Niš", DrzavaId = 3 },
                  new Gradovi { GradId = 14, Naziv = "Kragujevac", DrzavaId = 3 },
                  new Gradovi { GradId = 15, Naziv = "Subotica", DrzavaId = 3 }


              );
            modelBuilder.Entity<Jela>()
             .HasData
             (
                new Jela { JeloId=1,Naziv="Hamburger",PutanjaSlike="",Sastojci="...",KategorijaJelaId=1},
                new Jela { JeloId = 2, Naziv = "Pohovani fileti", PutanjaSlike = "", Sastojci = "...", KategorijaJelaId = 1 },
                new Jela { JeloId = 3, Naziv = "Ćevapi", PutanjaSlike = "", Sastojci = "...", KategorijaJelaId = 1 }


             );
            // modelBuilder.Entity<Jelovnik>()
            //.HasData
            //(
            //     new Jelovnik { JelovnikId=1,}

            //);
            modelBuilder.Entity<Korisnici>().HasData(
                new Korisnici { KorisnikId=1, Ime= "desktop", Prezime= "desktop", Email="desktop@edu.fit.ba",Telefon="036598745",GradId=1, PutanjaSlike="",KorisnickoIme= "testing2", LozinkaSalt= "nfB0WOkoOSuHIlkbdGETHQ==", LozinkaHash= "25BXwlT+alXTy1YgGuVNeFJx7vE=", BrojPrijavljivanja=0 },
                new Korisnici { KorisnikId = 2, Ime = "mobile", Prezime = "mobile", Email = "mobile@edu.fit.ba", Telefon = "036593745", GradId = 2, PutanjaSlike = "", KorisnickoIme = "mobile", LozinkaSalt = "Nr1JgKhL6v1dQtHGc+ytkw==", LozinkaHash = "QMQxyTHTDQPbB99C327FoldOy1g=", BrojPrijavljivanja = 0 }

                );
            modelBuilder.Entity<KorisniciUloge>().HasData(
                new KorisniciUloge { KorisnickaUlogaId=1,KorisnikId=1,UlogaId=1},
                new KorisniciUloge { KorisnickaUlogaId = 2, KorisnikId = 1, UlogaId = 2 },
                new KorisniciUloge { KorisnickaUlogaId = 3, KorisnikId = 2, UlogaId = 2 }

                );
            //modelBuilder.Entity<Objava>().HasData(
            //    new Objava {ObjavaId=1, Naziv="Hello world",Sadrzaj="Testing if this works",PutanjaSlike="", Autor= "desktop desktop", Datum=DateTime.Now },
            //    new Objava { ObjavaId =2, Naziv = "Welcome", Sadrzaj = "Yes, this definitely works", PutanjaSlike = "", Autor = "desktop desktop", Datum = DateTime.Now }


            //    );
            modelBuilder.Entity<Poruke>().HasData(
                new Poruke { PorukaId=1, Sadrzaj="Welcome to explore Mostar!", PosiljalacId=1, PrimalacId=1, Posiljalac= "desktop desktop", Primalac="desktop desktop"},
                new Poruke { PorukaId=2, Sadrzaj="Hello and welcome to our app", PosiljalacId=1, PrimalacId=2, Posiljalac= "desktop desktop", Primalac="mobile mobile"}


                );
            //modelBuilder.Entity<UserActivity>().HasData(
            //    new UserActivity { KorisnikId=1, BrojPrijavljivanja=0, BrojNeuspjesnihPrijavljivanja=0,Onemogucen=false, Datum=DateTime.Now, IsApartman=false, IsAtrakcija=false, IsHotel=false, IsKafic=false, IsNightClub=false, IsRestoran=false}
            //    new UserActivity { KorisnikId=2, BrojPrijavljivanja=0, BrojNeuspjesnihPrijavljivanja=0,Onemogucen=false, Datum=DateTime.Now, IsApartman=false, IsAtrakcija=false, IsHotel=false, IsKafic=false, IsNightClub=false, IsRestoran=false}

            //    );
            //modelBuilder.Entity<Recenzije>().HasData(
            //    new Recenzije {  RecenzijaId=1, KorisnikId=1, Objekat= "Megamarkt",Sadrzaj= "Food was good, staff too. Overall, everything was fine.", Datum=new DateTime(2021,5,24), Vrsta="Restoran" }


            //    );


        }
    }
}
