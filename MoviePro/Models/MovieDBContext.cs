using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MoviePro.Models
{
    public partial class MovieDBContext : DbContext
    {
        public MovieDBContext()
        {
        }

        public MovieDBContext(DbContextOptions<MovieDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TbMGenre> TbMGenre { get; set; }
        public virtual DbSet<TbMMovie> TbMMovie { get; set; }
        public virtual DbSet<TbMUser> TbMUser { get; set; }
        public virtual DbSet<TbTMovieGenre> TbTMovieGenre { get; set; }
        public virtual DbSet<TbTUserMovie> TbTUserMovie { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=Asus;Database=MovieDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TbMGenre>(entity =>
            {
                entity.HasKey(e => e.GenreId)
                    .HasName("PK__TB_M_Gen__0385057E76F456E2");

                entity.ToTable("TB_M_Genre");

                entity.Property(e => e.GenreId).ValueGeneratedNever();

                entity.Property(e => e.GenreName)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbMMovie>(entity =>
            {
                entity.HasKey(e => e.MovieId)
                    .HasName("PK__TB_M_Mov__4BD2941AB3DB2ACE");

                entity.ToTable("TB_M_Movie");

                entity.Property(e => e.MovieId).ValueGeneratedNever();

                entity.Property(e => e.DateRelease).HasColumnType("date");

                entity.Property(e => e.Overview)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbMUser>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__TB_M_Use__1788CC4CFA6DD05F");

                entity.ToTable("TB_M_User");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbTMovieGenre>(entity =>
            {
                entity.HasKey(e => e.MovieGenreId)
                    .HasName("PK__TB_T_Mov__C18CD48053CCB282");

                entity.ToTable("TB_T_MovieGenre");

                entity.Property(e => e.MovieGenreId).ValueGeneratedNever();

                entity.HasOne(d => d.Genre)
                    .WithMany(p => p.TbTMovieGenre)
                    .HasForeignKey(d => d.GenreId)
                    .HasConstraintName("FK__TB_T_Movi__Genre__36B12243");

                entity.HasOne(d => d.Movie)
                    .WithMany(p => p.TbTMovieGenre)
                    .HasForeignKey(d => d.MovieId)
                    .HasConstraintName("FK__TB_T_Movi__Movie__35BCFE0A");
            });

            modelBuilder.Entity<TbTUserMovie>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TB_T_UserMovie");

                entity.HasOne(d => d.Movie)
                    .WithMany(p => p.TbTUserMovie)
                    .HasForeignKey(d => d.MovieId)
                    .HasConstraintName("FK__TB_T_User__Movie__398D8EEE");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TbTUserMovie)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__TB_T_User__Ratin__38996AB5");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
