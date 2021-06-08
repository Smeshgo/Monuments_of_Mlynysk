using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Monuments_of_Mlynysk.Models
{
    public partial class MonumentDBContext : DbContext
    {
        public MonumentDBContext()
        {
        }

        public MonumentDBContext(DbContextOptions<MonumentDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<Article> Articles { get; set; }
        public virtual DbSet<ArticleUser> ArticleUsers { get; set; }
        public virtual DbSet<CategoryMaterial> CategoryMaterials { get; set; }
        public virtual DbSet<CategoryPhoto> CategoryPhotos { get; set; }
        public virtual DbSet<Material> Materials { get; set; }
        public virtual DbSet<MaterialMonument> MaterialMonuments { get; set; }
        public virtual DbSet<Monument> Monuments { get; set; }
        public virtual DbSet<MonumentWorker> MonumentWorkers { get; set; }
        public virtual DbSet<Photo> Photos { get; set; }
        public virtual DbSet<PhotoArticle> PhotoArticles { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
        public virtual DbSet<Worker> Workers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-S9LJBNU\\MONUMENTBD;Initial Catalog=MonumentDB;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Ukrainian_CI_AS");

            modelBuilder.Entity<Appointment>(entity =>
            {
                entity.HasKey(e => e.IdAppointment)
                    .HasName("PK_appointment");

                entity.ToTable("Appointment");

                entity.Property(e => e.IdAppointment)
                    .ValueGeneratedNever()
                    .HasColumnName("id_appointment");

                entity.Property(e => e.CreateAppointment)
                    .HasColumnType("datetime")
                    .HasColumnName("create_appointment");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Update)
                    .HasColumnType("datetime")
                    .HasColumnName("update");
            });

            modelBuilder.Entity<Article>(entity =>
            {
                entity.HasKey(e => e.IdArticle)
                    .HasName("PK_article");

                entity.ToTable("Article");

                entity.Property(e => e.IdArticle)
                    .ValueGeneratedNever()
                    .HasColumnName("id_article");

                entity.Property(e => e.Contents)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("contents");

                entity.Property(e => e.CreateArticle)
                    .HasColumnType("datetime")
                    .HasColumnName("create_article");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("title");

                entity.Property(e => e.UpdateArticle)
                    .HasColumnType("datetime")
                    .HasColumnName("update_article");
            });

            modelBuilder.Entity<ArticleUser>(entity =>
            {
                entity.HasKey(e => new { e.IdArticle, e.IdUser })
                    .HasName("PK_article_user");

                entity.ToTable("Article_user");

                entity.HasIndex(e => e.IdArticle, "fkIdx_252");

                entity.HasIndex(e => e.IdUser, "fkIdx_256");

                entity.Property(e => e.IdArticle).HasColumnName("id_article");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.HasOne(d => d.IdArticleNavigation)
                    .WithMany(p => p.ArticleUsers)
                    .HasForeignKey(d => d.IdArticle)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_251");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.ArticleUsers)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_255");
            });

            modelBuilder.Entity<CategoryMaterial>(entity =>
            {
                entity.HasKey(e => e.IdCategoryMaterial)
                    .HasName("PK_category_material");

                entity.ToTable("Category_material");

                entity.Property(e => e.IdCategoryMaterial)
                    .ValueGeneratedNever()
                    .HasColumnName("id_category_material");

                entity.Property(e => e.CreateCategoryMaterial)
                    .HasColumnType("datetime")
                    .HasColumnName("create_category_material");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<CategoryPhoto>(entity =>
            {
                entity.HasKey(e => e.IdCategoryPhoto)
                    .HasName("PK_category_photo");

                entity.ToTable("Category_Photo");

                entity.Property(e => e.IdCategoryPhoto)
                    .ValueGeneratedNever()
                    .HasColumnName("id_Category_Photo");

                entity.Property(e => e.CreatePhotoPhoto)
                    .HasColumnType("datetime")
                    .HasColumnName("create_photo_photo");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.UpdateCategoryPhoto)
                    .HasColumnType("datetime")
                    .HasColumnName("update_category_photo");
            });

            modelBuilder.Entity<Material>(entity =>
            {
                entity.HasKey(e => e.IdMaterial)
                    .HasName("PK_material");

                entity.ToTable("Material");

                entity.HasIndex(e => e.IdAppointment, "fkIdx_288");

                entity.HasIndex(e => e.IdCategoryMaterial, "fkIdx_297");

                entity.Property(e => e.IdMaterial)
                    .ValueGeneratedNever()
                    .HasColumnName("id_material");

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("color");

                entity.Property(e => e.CreateMaterial)
                    .HasColumnType("datetime")
                    .HasColumnName("create_material");

                entity.Property(e => e.Height)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("height");

                entity.Property(e => e.IdAppointment).HasColumnName("id_appointment");

                entity.Property(e => e.IdCategoryMaterial).HasColumnName("id_category_material");

                entity.Property(e => e.Length)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("length");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Number).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("price");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("datetime")
                    .HasColumnName("update_user");

                entity.Property(e => e.Width)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("width");

                entity.HasOne(d => d.IdAppointmentNavigation)
                    .WithMany(p => p.Materials)
                    .HasForeignKey(d => d.IdAppointment)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_287");

                entity.HasOne(d => d.IdCategoryMaterialNavigation)
                    .WithMany(p => p.Materials)
                    .HasForeignKey(d => d.IdCategoryMaterial)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_296");
            });

            modelBuilder.Entity<MaterialMonument>(entity =>
            {
                entity.HasKey(e => new { e.MaterialMonument1, e.IdMonument, e.IdMaterial })
                    .HasName("PK_material_monument");

                entity.ToTable("Material_monument");

                entity.HasIndex(e => e.IdMonument, "fkIdx_276");

                entity.HasIndex(e => e.IdMaterial, "fkIdx_279");

                entity.Property(e => e.MaterialMonument1).HasColumnName("Material_monument");

                entity.Property(e => e.IdMonument).HasColumnName("id_monument");

                entity.Property(e => e.IdMaterial).HasColumnName("id_material");

                entity.HasOne(d => d.IdMaterialNavigation)
                    .WithMany(p => p.MaterialMonuments)
                    .HasForeignKey(d => d.IdMaterial)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_278");

                entity.HasOne(d => d.IdMonumentNavigation)
                    .WithMany(p => p.MaterialMonuments)
                    .HasForeignKey(d => d.IdMonument)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_275");
            });

            modelBuilder.Entity<Monument>(entity =>
            {
                entity.HasKey(e => e.IdMonument)
                    .HasName("PK_monument");

                entity.ToTable("Monument");

                entity.HasIndex(e => e.IdPhoto, "fkIdx_179");

                entity.Property(e => e.IdMonument)
                    .ValueGeneratedNever()
                    .HasColumnName("id_monument");

                entity.Property(e => e.IdPhoto).HasColumnName("id_photo");

                entity.Property(e => e.Prise)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("prise");

                entity.HasOne(d => d.IdPhotoNavigation)
                    .WithMany(p => p.Monuments)
                    .HasForeignKey(d => d.IdPhoto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_178");
            });

            modelBuilder.Entity<MonumentWorker>(entity =>
            {
                entity.HasKey(e => new { e.IdMonument, e.IdWorker })
                    .HasName("PK_monument_worker");

                entity.ToTable("Monument_Worker");

                entity.HasIndex(e => e.IdMonument, "fkIdx_172");

                entity.HasIndex(e => e.IdWorker, "fkIdx_176");

                entity.Property(e => e.IdMonument).HasColumnName("id_monument");

                entity.Property(e => e.IdWorker).HasColumnName("id_worker");

                entity.HasOne(d => d.IdMonumentNavigation)
                    .WithMany(p => p.MonumentWorkers)
                    .HasForeignKey(d => d.IdMonument)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_171");

                entity.HasOne(d => d.IdWorkerNavigation)
                    .WithMany(p => p.MonumentWorkers)
                    .HasForeignKey(d => d.IdWorker)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_175");
            });

            modelBuilder.Entity<Photo>(entity =>
            {
                entity.HasKey(e => e.IdPhoto)
                    .HasName("PK_photo");

                entity.ToTable("Photo");

                entity.HasIndex(e => e.IdCategoryPhoto, "fkIdx_188");

                entity.Property(e => e.IdPhoto)
                    .ValueGeneratedNever()
                    .HasColumnName("id_photo");

                entity.Property(e => e.CreatePhoto)
                    .HasColumnType("datetime")
                    .HasColumnName("create_photo");

                entity.Property(e => e.IdCategoryPhoto).HasColumnName("id_Category_Photo");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.PathFull)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("path_full");

                entity.Property(e => e.PathMini)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("path_mini");

                entity.Property(e => e.UpdatePhoto)
                    .HasColumnType("datetime")
                    .HasColumnName("update_photo");

                entity.Property(e => e.Uuid)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("uuid");

                entity.HasOne(d => d.IdCategoryPhotoNavigation)
                    .WithMany(p => p.Photos)
                    .HasForeignKey(d => d.IdCategoryPhoto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_187");
            });

            modelBuilder.Entity<PhotoArticle>(entity =>
            {
                entity.HasKey(e => new { e.IdPhoto, e.IdArticle })
                    .HasName("PK_photo_article");

                entity.ToTable("Photo_article");

                entity.HasIndex(e => e.IdPhoto, "fkIdx_199");

                entity.HasIndex(e => e.IdArticle, "fkIdx_203");

                entity.Property(e => e.IdPhoto).HasColumnName("id_photo");

                entity.Property(e => e.IdArticle).HasColumnName("id_article");

                entity.HasOne(d => d.IdArticleNavigation)
                    .WithMany(p => p.PhotoArticles)
                    .HasForeignKey(d => d.IdArticle)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_202");

                entity.HasOne(d => d.IdPhotoNavigation)
                    .WithMany(p => p.PhotoArticles)
                    .HasForeignKey(d => d.IdPhoto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_198");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(e => e.IdRole);

                entity.ToTable("role");

                entity.Property(e => e.IdRole)
                    .ValueGeneratedNever()
                    .HasColumnName("id_role");

                entity.Property(e => e.CreateRole)
                    .HasColumnType("datetime")
                    .HasColumnName("create_role");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.UpdateRole)
                    .HasColumnType("datetime")
                    .HasColumnName("update_role");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.IdUser)
                    .HasName("PK_user");

                entity.ToTable("User");

                entity.Property(e => e.IdUser)
                    .ValueGeneratedNever()
                    .HasColumnName("id_user");

                entity.Property(e => e.Create)
                    .HasColumnType("datetime")
                    .HasColumnName("create");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("datetime")
                    .HasColumnName("create_user");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("firstName");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lastName");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.Update)
                    .HasColumnType("datetime")
                    .HasColumnName("update");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("datetime")
                    .HasColumnName("update_user");

                entity.Property(e => e.Usernama)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usernama");
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.HasKey(e => new { e.IdRole, e.IdUser });

                entity.ToTable("user_role");

                entity.HasIndex(e => e.IdRole, "fkIdx_246");

                entity.HasIndex(e => e.IdUser, "fkIdx_249");

                entity.Property(e => e.IdRole).HasColumnName("id_role");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.HasOne(d => d.IdRoleNavigation)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.IdRole)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_245");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_248");
            });

            modelBuilder.Entity<Worker>(entity =>
            {
                entity.HasKey(e => e.IdWorker);

                entity.ToTable("worker");

                entity.Property(e => e.IdWorker)
                    .ValueGeneratedNever()
                    .HasColumnName("id_worker");

                entity.Property(e => e.CreateWorcer)
                    .HasColumnType("datetime")
                    .HasColumnName("create_worcer");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("firstName");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lastName");

                entity.Property(e => e.NumberOfHours)
                    .HasColumnType("decimal(18, 1)")
                    .HasColumnName("number_of_hours");

                entity.Property(e => e.Rete)
                    .HasColumnType("decimal(18, 1)")
                    .HasColumnName("rete");

                entity.Property(e => e.Salary)
                    .HasColumnType("decimal(18, 1)")
                    .HasColumnName("salary");

                entity.Property(e => e.UpdateWorker)
                    .HasColumnType("datetime")
                    .HasColumnName("update_worker");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
