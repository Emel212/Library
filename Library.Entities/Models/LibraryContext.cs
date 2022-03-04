using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Library.Entities.Models
{
    public partial class LibraryContext : DbContext
    {
        public LibraryContext()
        {
        }

        public LibraryContext(DbContextOptions<LibraryContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<BookStatus> BookStatuses { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<Like> Likes { get; set; }
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<Personel> Personels { get; set; }
        public virtual DbSet<Publisher> Publishers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-MR18V5O\\SQLEXPRESS;initial catalog=Library;integrated security=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>(entity =>
            {
                entity.Property(e => e.Author).HasMaxLength(50);

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Description).HasMaxLength(150);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.PublisherId).HasColumnName("PublisherID");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_Books_Category");

                entity.HasOne(d => d.Publisher)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.PublisherId)
                    .HasConstraintName("FK_Books_Publisher");
            });

            modelBuilder.Entity<BookStatus>(entity =>
            {
                entity.ToTable("BookStatus");

                entity.Property(e => e.BookId).HasColumnName("BookID");

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.IsAvailable).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsBorrowed).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsOnHold).HasDefaultValueSql("((0))");

                entity.Property(e => e.LoanPeriod).HasColumnType("datetime");

                entity.Property(e => e.MemberId).HasColumnName("MemberID");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.BookStatuses)
                    .HasForeignKey(d => d.BookId)
                    .HasConstraintName("FK_BookStatus_Books");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.BookStatuses)
                    .HasForeignKey(d => d.MemberId)
                    .HasConstraintName("FK_BookStatus_Members");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Category");

                entity.Property(e => e.Description).HasMaxLength(150);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.Property(e => e.BookId).HasColumnName("BookID");

                entity.Property(e => e.Comment1)
                    .HasMaxLength(150)
                    .HasColumnName("Comment");

                entity.Property(e => e.Datetime).HasColumnType("datetime");

                entity.Property(e => e.IsApproved).HasDefaultValueSql("((0))");

                entity.Property(e => e.MemberId).HasColumnName("MemberID");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.BookId)
                    .HasConstraintName("FK_Comments_Books");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.MemberId)
                    .HasConstraintName("FK_Comments_Members2");
            });

            modelBuilder.Entity<Image>(entity =>
            {
                entity.Property(e => e.BookId).HasColumnName("BookID");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.Images)
                    .HasForeignKey(d => d.BookId)
                    .HasConstraintName("FK_Images_Books");
            });

            modelBuilder.Entity<Like>(entity =>
            {
                entity.Property(e => e.BookId).HasColumnName("BookID");

                entity.Property(e => e.CommentId).HasColumnName("CommentID");

                entity.Property(e => e.MemberId).HasColumnName("MemberID");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.Likes)
                    .HasForeignKey(d => d.BookId)
                    .HasConstraintName("FK_Likes_Books");

                entity.HasOne(d => d.Comment)
                    .WithMany(p => p.Likes)
                    .HasForeignKey(d => d.CommentId)
                    .HasConstraintName("FK_Likes_Comments");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.Likes)
                    .HasForeignKey(d => d.MemberId)
                    .HasConstraintName("FK_Likes_Members");
            });

            modelBuilder.Entity<Member>(entity =>
            {
                entity.Property(e => e.Adress).HasMaxLength(150);

                entity.Property(e => e.LastName).HasMaxLength(25);

                entity.Property(e => e.MemberSince).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(25);

                entity.Property(e => e.Phone).HasMaxLength(15);
            });

            modelBuilder.Entity<Personel>(entity =>
            {
                entity.Property(e => e.Adress).HasMaxLength(50);

                entity.Property(e => e.JobDescription).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Publisher>(entity =>
            {
                entity.ToTable("Publisher");

                entity.Property(e => e.Description).HasMaxLength(150);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
