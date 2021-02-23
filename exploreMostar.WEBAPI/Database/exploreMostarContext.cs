using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace exploreMostar.WebAPI.Database
{
    public partial class exploreMostarContext : DbContext
    {
        public exploreMostarContext()
        {
        }

        public exploreMostarContext(DbContextOptions<exploreMostarContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Apartmani> Apartmani { get; set; }
        public virtual DbSet<Atrakcije> Atrakcije { get; set; }
        public virtual DbSet<DodatneOpcije> DodatneOpcije { get; set; }
        public virtual DbSet<Drzave> Drzave { get; set; }
        public virtual DbSet<Gradovi> Gradovi { get; set; }
        public virtual DbSet<Hoteli> Hoteli { get; set; }
        public virtual DbSet<Jela> Jela { get; set; }
        public virtual DbSet<Jelovnik> Jelovnik { get; set; }
        public virtual DbSet<Kafici> Kafici { get; set; }
        public virtual DbSet<KategorijaJela> KategorijaJela { get; set; }
        public virtual DbSet<Kategorije> Kategorije { get; set; }
        public virtual DbSet<Korisnici> Korisnici { get; set; }
        public virtual DbSet<KorisnickaUloga> KorisnickaUloga { get; set; }
        public virtual DbSet<KorisnikKategorija> KorisnikKategorija { get; set; }
        public virtual DbSet<Markeri> Markeri { get; set; }
        public virtual DbSet<Nightclubs> Nightclubs { get; set; }
        public virtual DbSet<Objava> Objava { get; set; }
        public virtual DbSet<Prevoz> Prevoz { get; set; }
        public virtual DbSet<Restorani> Restorani { get; set; }
        public virtual DbSet<VrstaAtrakcija> VrstaAtrakcija { get; set; }
        public virtual DbSet<VrstaRestorana> VrstaRestorana { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-HB2VMU2\\ADNASQLSERVER;Database=exploreMostar;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Apartmani>(entity =>
            {
                entity.HasKey(e => e.ApartmanId);

                entity.Property(e => e.ApartmanId).HasColumnName("ApartmanID");

                entity.Property(e => e.KategorijaApartmana).HasMaxLength(1);

                entity.Property(e => e.KategorijaId).HasColumnName("KategorijaID");

                entity.Property(e => e.Lokacija)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Tv).HasColumnName("TV");

                entity.HasOne(d => d.Kategorija)
                    .WithMany(p => p.Apartmani)
                    .HasForeignKey(d => d.KategorijaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Apartmani__Kateg__160F4887");
            });

            modelBuilder.Entity<Atrakcije>(entity =>
            {
                entity.HasKey(e => e.AtrakcijaId);

                entity.Property(e => e.AtrakcijaId).HasColumnName("AtrakcijaID");

                entity.Property(e => e.KategorijaId).HasColumnName("KategorijaID");

                entity.Property(e => e.Lokacija)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Opis).HasMaxLength(250);

                entity.Property(e => e.VrstaAtrakcijeId).HasColumnName("VrstaAtrakcijeID");

                entity.HasOne(d => d.Kategorija)
                    .WithMany(p => p.Atrakcije)
                    .HasForeignKey(d => d.KategorijaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Atrakcije__Kateg__17036CC0");

                entity.HasOne(d => d.VrstaAtrakcije)
                    .WithMany(p => p.Atrakcije)
                    .HasForeignKey(d => d.VrstaAtrakcijeId)
                    .HasConstraintName("FK__Atrakcije__Vrsta__151B244E");
            });

            modelBuilder.Entity<DodatneOpcije>(entity =>
            {
                entity.HasKey(e => e.DodatnaOpcijaId);

                entity.Property(e => e.DodatnaOpcijaId).HasColumnName("DodatnaOpcijaID");

                entity.Property(e => e.Tv).HasColumnName("TV");
            });

            modelBuilder.Entity<Drzave>(entity =>
            {
                entity.HasKey(e => e.DrzavaId);

                entity.Property(e => e.DrzavaId).HasColumnName("DrzavaID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Oznaka)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Gradovi>(entity =>
            {
                entity.HasKey(e => e.GradId);

                entity.Property(e => e.GradId).HasColumnName("GradID");

                entity.Property(e => e.DrzavaId).HasColumnName("DrzavaID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Drzava)
                    .WithMany(p => p.Gradovi)
                    .HasForeignKey(d => d.DrzavaId)
                    .HasConstraintName("FK__Gradovi__DrzavaI__6C190EBB");
            });

            modelBuilder.Entity<Hoteli>(entity =>
            {
                entity.HasKey(e => e.HotelId);

                entity.Property(e => e.HotelId).HasColumnName("HotelID");

                entity.Property(e => e.Kategorija).HasMaxLength(1);

                entity.Property(e => e.KategorijaId).HasColumnName("KategorijaID");

                entity.Property(e => e.Lokacija)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Tv).HasColumnName("TV");

                entity.HasOne(d => d.KategorijaNavigation)
                    .WithMany(p => p.Hoteli)
                    .HasForeignKey(d => d.KategorijaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Hoteli__Kategori__17F790F9");
            });

            modelBuilder.Entity<Jela>(entity =>
            {
                entity.HasKey(e => e.JeloId);

                entity.Property(e => e.JeloId).HasColumnName("JeloID");

                entity.Property(e => e.KategorijaJelaId).HasColumnName("KategorijaJelaID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Sastojci).HasMaxLength(100);

                entity.HasOne(d => d.KategorijaJela)
                    .WithMany(p => p.Jela)
                    .HasForeignKey(d => d.KategorijaJelaId)
                    .HasConstraintName("FK__Jela__Kategorija__5224328E");
            });

            modelBuilder.Entity<Jelovnik>(entity =>
            {
                entity.Property(e => e.JelovnikId).HasColumnName("JelovnikID");

                entity.Property(e => e.Datum).HasColumnType("datetime");

                entity.Property(e => e.JeloId).HasColumnName("JeloID");

                entity.Property(e => e.Opis).HasMaxLength(100);

                entity.Property(e => e.RestoranId).HasColumnName("RestoranID");

                entity.HasOne(d => d.Jelo)
                    .WithMany(p => p.Jelovnik)
                    .HasForeignKey(d => d.JeloId)
                    .HasConstraintName("FK__Jelovnik__JeloID__607251E5");

                entity.HasOne(d => d.Restoran)
                    .WithMany(p => p.Jelovnik)
                    .HasForeignKey(d => d.RestoranId)
                    .HasConstraintName("FK__Jelovnik__Restor__6166761E");
            });

            modelBuilder.Entity<Kafici>(entity =>
            {
                entity.HasKey(e => e.KaficId);

                entity.Property(e => e.KaficId).HasColumnName("KaficID");

                entity.Property(e => e.KategorijaId).HasColumnName("KategorijaID");

                entity.Property(e => e.Lokacija)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Kategorija)
                    .WithMany(p => p.Kafici)
                    .HasForeignKey(d => d.KategorijaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Kafici__Kategori__18EBB532");
            });

            modelBuilder.Entity<KategorijaJela>(entity =>
            {
                entity.Property(e => e.KategorijaJelaId).HasColumnName("KategorijaJelaID");

                entity.Property(e => e.Naziv).HasMaxLength(250);
            });

            modelBuilder.Entity<Kategorije>(entity =>
            {
                entity.HasKey(e => e.KategorijaId);

                entity.Property(e => e.KategorijaId).HasColumnName("KategorijaID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Opis)
                    .IsRequired()
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<Korisnici>(entity =>
            {
                entity.HasKey(e => e.KorisnikId);

                entity.Property(e => e.KorisnikId).HasColumnName("KorisnikID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.GradId).HasColumnName("GradID");

                entity.Property(e => e.Ime)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.KorisnickaUlogaId).HasColumnName("KorisnickaUlogaID");

                entity.Property(e => e.KorisnickoIme)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LozinkaHash).HasMaxLength(50);

                entity.Property(e => e.LozinkaSalt).HasMaxLength(50);

                entity.Property(e => e.Prezime)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Telefon)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Grad)
                    .WithMany(p => p.Korisnici)
                    .HasForeignKey(d => d.GradId)
                    .HasConstraintName("FK__Korisnici__GradI__03F0984C");

                entity.HasOne(d => d.KorisnickaUloga)
                    .WithMany(p => p.Korisnici)
                    .HasForeignKey(d => d.KorisnickaUlogaId)
                    .HasConstraintName("FK__Korisnici__Koris__29221CFB");
            });

            modelBuilder.Entity<KorisnickaUloga>(entity =>
            {
                entity.Property(e => e.KorisnickaUlogaId).HasColumnName("KorisnickaUlogaID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<KorisnikKategorija>(entity =>
            {
                entity.Property(e => e.KorisnikKategorijaId).HasColumnName("KorisnikKategorijaID");

                entity.Property(e => e.KategorijaId).HasColumnName("KategorijaID");

                entity.Property(e => e.KorisnikId).HasColumnName("KorisnikID");

                entity.HasOne(d => d.Kategorija)
                    .WithMany(p => p.KorisnikKategorija)
                    .HasForeignKey(d => d.KategorijaId)
                    .HasConstraintName("FK__KorisnikK__Kateg__5441852A");

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.KorisnikKategorija)
                    .HasForeignKey(d => d.KorisnikId)
                    .HasConstraintName("FK__KorisnikK__Koris__534D60F1");
            });

            modelBuilder.Entity<Markeri>(entity =>
            {
                entity.HasKey(e => e.MarkerId);

                entity.Property(e => e.MarkerId).HasColumnName("MarkerID");

                entity.Property(e => e.Adresa)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.GradId).HasColumnName("GradID");

                entity.Property(e => e.Ime)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Lat).HasColumnName("lat");

                entity.Property(e => e.Lng).HasColumnName("lng");

                entity.Property(e => e.Opis).HasMaxLength(30);

                entity.HasOne(d => d.Grad)
                    .WithMany(p => p.Markeri)
                    .HasForeignKey(d => d.GradId)
                    .HasConstraintName("FK__Markeri__GradID__08B54D69");
            });

            modelBuilder.Entity<Nightclubs>(entity =>
            {
                entity.HasKey(e => e.NightClubId);

                entity.Property(e => e.NightClubId).HasColumnName("NightClubID");

                entity.Property(e => e.KategorijaId).HasColumnName("KategorijaID");

                entity.Property(e => e.Lokacija)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Kategorija)
                    .WithMany(p => p.Nightclubs)
                    .HasForeignKey(d => d.KategorijaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Nightclub__Kateg__19DFD96B");
            });

            modelBuilder.Entity<Objava>(entity =>
            {
                entity.Property(e => e.Naziv).HasMaxLength(50);

                entity.Property(e => e.Sadrzaj).HasMaxLength(250);

                entity.Property(e => e.Slika).HasMaxLength(1);
            });

            modelBuilder.Entity<Prevoz>(entity =>
            {
                entity.Property(e => e.PrevozId).HasColumnName("PrevozID");

                entity.Property(e => e.KategorijaId).HasColumnName("KategorijaID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Telefon)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Vrsta)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Kategorija)
                    .WithMany(p => p.Prevoz)
                    .HasForeignKey(d => d.KategorijaId)
                    .HasConstraintName("FK__Prevoz__Kategori__5EBF139D");
            });

            modelBuilder.Entity<Restorani>(entity =>
            {
                entity.HasKey(e => e.RestoranId);

                entity.Property(e => e.RestoranId).HasColumnName("RestoranID");

                entity.Property(e => e.KategorijaId).HasColumnName("KategorijaID");

                entity.Property(e => e.Lokacija)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.VrstaId).HasColumnName("VrstaID");

                entity.HasOne(d => d.Kategorija)
                    .WithMany(p => p.Restorani)
                    .HasForeignKey(d => d.KategorijaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Restorani__Kateg__1AD3FDA4");

                entity.HasOne(d => d.Vrsta)
                    .WithMany(p => p.Restorani)
                    .HasForeignKey(d => d.VrstaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Restorani__Vrsta__1DB06A4F");
            });

            modelBuilder.Entity<VrstaAtrakcija>(entity =>
            {
                entity.HasKey(e => e.VrstaAtrakcijeId);

                entity.Property(e => e.VrstaAtrakcijeId).HasColumnName("VrstaAtrakcijeID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<VrstaRestorana>(entity =>
            {
                entity.HasKey(e => e.VrstaId);

                entity.Property(e => e.VrstaId).HasColumnName("VrstaID");

                entity.Property(e => e.Naziv).HasMaxLength(50);
            });
        }
    }
}
