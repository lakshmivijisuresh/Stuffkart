using Microsoft.EntityFrameworkCore;

#nullable disable

namespace StuffKartProject.Models
{
  public partial class StuffKartContext : DbContext
  {
    public StuffKartContext()
    {

    }
    public virtual DbSet<UserDetails> UserDetails { get; set; }

    public StuffKartContext(DbContextOptions<StuffKartContext> options): base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

      modelBuilder.Entity<UserDetails>(entity =>
      {
        entity.HasKey(e => new { e.UserId })
                  .HasName("PK__UserDeta__6F9E65E3D0D59B87");

        entity.Property(e => e.Email)
                  .IsRequired()
                  .HasMaxLength(50)
                  .IsUnicode(false);

        entity.Property(e => e.MobileNumber)
                  .IsRequired()
                  .HasMaxLength(50)
                  .IsUnicode(false);

        entity.Property(e => e.Password)
                  .IsRequired()
                  .HasMaxLength(50)
                  .IsUnicode(false);

        entity.Property(e => e.FirstName)
                  .IsRequired()
                  .HasMaxLength(50)
                  .IsUnicode(false);

        entity.Property(e => e.LastName)
                  .IsRequired()
                  .HasMaxLength(50)
                  .IsUnicode(false);

        entity.Property(e => e.SecurityAnswer)
              .IsRequired()
              .HasMaxLength(50)
              .IsUnicode(false);

        entity.Property(e => e.SecurityQuestion)
              .IsRequired()
              .HasMaxLength(50)
              .IsUnicode(false);

        entity.Property(e => e.isAdmin)
              .IsRequired()
              .HasMaxLength(50)
              .IsUnicode(false);

      });

      modelBuilder.Entity<ResetPassword>(entity =>
      {
        entity.HasKey(e => new { e.MobileNumber })
            .HasName("PK__UserDeta__6F9E65E3D0D59B88");

        entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

        entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

        entity.Property(e => e.ConfirmPassword)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

        entity.Property(e => e.SecurityAnswer)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

        entity.Property(e => e.SecurityQuestion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);


      });

      OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
  }
}
