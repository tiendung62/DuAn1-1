using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Main.Models
{
    public partial class DUANContext : DbContext
    {
        public DUANContext()
        {
        }

        public DUANContext(DbContextOptions<DUANContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Chatlieu> Chatlieus { get; set; } = null!;
        public virtual DbSet<Ctsanpham> Ctsanphams { get; set; } = null!;
        public virtual DbSet<Degiay> Degiays { get; set; } = null!;
        public virtual DbSet<Hoadon> Hoadons { get; set; } = null!;
        public virtual DbSet<Hoadonct> Hoadoncts { get; set; } = null!;
        public virtual DbSet<Khachhang> Khachhangs { get; set; } = null!;
        public virtual DbSet<Khuyenmai> Khuyenmais { get; set; } = null!;
        public virtual DbSet<Kichthuoc> Kichthuocs { get; set; } = null!;
        public virtual DbSet<Loaikhachhang> Loaikhachhangs { get; set; } = null!;
        public virtual DbSet<Mausac> Mausacs { get; set; } = null!;
        public virtual DbSet<NguoiDung> NguoiDungs { get; set; } = null!;
        public virtual DbSet<NhaCungCap> NhaCungCaps { get; set; } = null!;
        public virtual DbSet<Sanpham> Sanphams { get; set; } = null!;
        public virtual DbSet<VaiTro> VaiTros { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=DUAN;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Chatlieu>(entity =>
            {
                entity.HasKey(e => e.Chatlieuu);

                entity.ToTable("CHATLIEU");

                entity.Property(e => e.Chatlieuu)
                    .HasMaxLength(50)
                    .HasColumnName("CHATLIEUU");
            });

            modelBuilder.Entity<Ctsanpham>(entity =>
            {
                entity.HasKey(e => e.Idctsp);

                entity.ToTable("CTSANPHAM");

                entity.Property(e => e.Idctsp)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("IDCTSP");

                entity.Property(e => e.Chatlieuu)
                    .HasMaxLength(50)
                    .HasColumnName("CHATLIEUU");

                entity.Property(e => e.Degiay)
                    .HasMaxLength(50)
                    .HasColumnName("DEGIAY");

                entity.Property(e => e.Doitra)
                    .HasMaxLength(50)
                    .HasColumnName("DOITRA");

                entity.Property(e => e.Giaban)
                    .HasColumnType("money")
                    .HasColumnName("GIABAN");

                entity.Property(e => e.Gianhap).HasColumnName("GIANHAP");

                entity.Property(e => e.Idkm)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("IDKM");

                entity.Property(e => e.Idncc)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("IDNCC");

                entity.Property(e => e.Kichthuoc)
                    .HasMaxLength(50)
                    .HasColumnName("KICHTHUOC");

                entity.Property(e => e.Masp)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MASP");

                entity.Property(e => e.Mau)
                    .HasMaxLength(50)
                    .HasColumnName("MAU");

                entity.Property(e => e.Soluongton).HasColumnName("SOLUONGTON");

                entity.Property(e => e.Tengiay)
                    .HasMaxLength(50)
                    .HasColumnName("TENGIAY");

                entity.HasOne(d => d.ChatlieuuNavigation)
                    .WithMany(p => p.Ctsanphams)
                    .HasForeignKey(d => d.Chatlieuu)
                    .HasConstraintName("FK_CTSANPHAM_CHATLIEU");

                entity.HasOne(d => d.DegiayNavigation)
                    .WithMany(p => p.Ctsanphams)
                    .HasForeignKey(d => d.Degiay)
                    .HasConstraintName("FK_CTSANPHAM_DEGIAY");

                entity.HasOne(d => d.IdkmNavigation)
                    .WithMany(p => p.Ctsanphams)
                    .HasForeignKey(d => d.Idkm)
                    .HasConstraintName("FK_CTSANPHAM_KHUYENMAI");

                entity.HasOne(d => d.IdnccNavigation)
                    .WithMany(p => p.Ctsanphams)
                    .HasForeignKey(d => d.Idncc)
                    .HasConstraintName("FK_CTSANPHAM_NhaCungCap");

                entity.HasOne(d => d.KichthuocNavigation)
                    .WithMany(p => p.Ctsanphams)
                    .HasForeignKey(d => d.Kichthuoc)
                    .HasConstraintName("FK_CTSANPHAM_KICHTHUOC");

                entity.HasOne(d => d.MaspNavigation)
                    .WithMany(p => p.Ctsanphams)
                    .HasForeignKey(d => d.Masp)
                    .HasConstraintName("FK_CTSANPHAM_SANPHAM");

                entity.HasOne(d => d.MauNavigation)
                    .WithMany(p => p.Ctsanphams)
                    .HasForeignKey(d => d.Mau)
                    .HasConstraintName("FK_CTSANPHAM_MAUSAC");
            });

            modelBuilder.Entity<Degiay>(entity =>
            {
                entity.HasKey(e => e.Degiay1);

                entity.ToTable("DEGIAY");

                entity.Property(e => e.Degiay1)
                    .HasMaxLength(50)
                    .HasColumnName("DEGIAY");
            });

            modelBuilder.Entity<Hoadon>(entity =>
            {
                entity.HasKey(e => e.Mahd);

                entity.ToTable("HOADON");

                entity.Property(e => e.Mahd)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MAHD");

                entity.Property(e => e.Idkh)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("IDKH");

                entity.Property(e => e.Ngayban)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYBAN");

                entity.Property(e => e.Soluong).HasColumnName("SOLUONG");

                entity.Property(e => e.Tensp)
                    .HasMaxLength(50)
                    .HasColumnName("TENSP");

                entity.Property(e => e.Tongtien)
                    .HasColumnType("money")
                    .HasColumnName("TONGTIEN");

                entity.Property(e => e.Trangthai)
                    .HasMaxLength(50)
                    .HasColumnName("TRANGTHAI");

                entity.HasOne(d => d.IdkhNavigation)
                    .WithMany(p => p.Hoadons)
                    .HasForeignKey(d => d.Idkh)
                    .HasConstraintName("FK_HOADON_KHACHHANG");
            });

            modelBuilder.Entity<Hoadonct>(entity =>
            {
                entity.HasKey(e => new { e.Mahd, e.Idctsp });

                entity.ToTable("HOADONCT");

                entity.Property(e => e.Mahd)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MAHD");

                entity.Property(e => e.Idctsp)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("IDCTSP");

                entity.Property(e => e.Gia)
                    .HasColumnType("money")
                    .HasColumnName("GIA");

                entity.Property(e => e.Ngayban)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYBAN");

                entity.Property(e => e.Slban).HasColumnName("SLBAN");

                entity.HasOne(d => d.IdctspNavigation)
                    .WithMany(p => p.Hoadoncts)
                    .HasForeignKey(d => d.Idctsp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HOADONCT_CTSANPHAM");

                entity.HasOne(d => d.MahdNavigation)
                    .WithMany(p => p.Hoadoncts)
                    .HasForeignKey(d => d.Mahd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HOADONCT_HOADON");
            });

            modelBuilder.Entity<Khachhang>(entity =>
            {
                entity.HasKey(e => e.Idkh);

                entity.ToTable("KHACHHANG");

                entity.Property(e => e.Idkh)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("IDKH");

                entity.Property(e => e.Diachi)
                    .HasMaxLength(50)
                    .HasColumnName("DIACHI");

                entity.Property(e => e.Diem)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DIEM");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Idloaind)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("IDLOAIND");

                entity.Property(e => e.Sdt).HasColumnName("SDT");

                entity.Property(e => e.Ten)
                    .HasMaxLength(50)
                    .HasColumnName("TEN");

                entity.HasOne(d => d.IdloaindNavigation)
                    .WithMany(p => p.Khachhangs)
                    .HasForeignKey(d => d.Idloaind)
                    .HasConstraintName("FK_KHACHHANG_LOAIKHACHHANG");
            });

            modelBuilder.Entity<Khuyenmai>(entity =>
            {
                entity.HasKey(e => e.Idkm);

                entity.ToTable("KHUYENMAI");

                entity.Property(e => e.Idkm)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("IDKM");

                entity.Property(e => e.Giamgia)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GIAMGIA");

                entity.Property(e => e.Ngaytao)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYTAO");

                entity.Property(e => e.Sukienkm)
                    .HasMaxLength(50)
                    .HasColumnName("SUKIENKM");

                entity.Property(e => e.Trangthai)
                    .HasMaxLength(50)
                    .HasColumnName("TRANGTHAI");
            });

            modelBuilder.Entity<Kichthuoc>(entity =>
            {
                entity.HasKey(e => e.Kichthuoc1);

                entity.ToTable("KICHTHUOC");

                entity.Property(e => e.Kichthuoc1)
                    .HasMaxLength(50)
                    .HasColumnName("KICHTHUOC");
            });

            modelBuilder.Entity<Loaikhachhang>(entity =>
            {
                entity.HasKey(e => e.Idloaind);

                entity.ToTable("LOAIKHACHHANG");

                entity.Property(e => e.Idloaind)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("IDLOAIND");

                entity.Property(e => e.Diem)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DIEM");

                entity.Property(e => e.Mota)
                    .HasMaxLength(50)
                    .HasColumnName("MOTA");

                entity.Property(e => e.Ten)
                    .HasMaxLength(30)
                    .HasColumnName("TEN");
            });

            modelBuilder.Entity<Mausac>(entity =>
            {
                entity.HasKey(e => e.Mau);

                entity.ToTable("MAUSAC");

                entity.Property(e => e.Mau)
                    .HasMaxLength(50)
                    .HasColumnName("MAU");
            });

            modelBuilder.Entity<NguoiDung>(entity =>
            {
                entity.HasKey(e => e.IdnguoiDung);

                entity.ToTable("NguoiDung");

                entity.Property(e => e.IdnguoiDung)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("IDNguoiDung");

                entity.Property(e => e.Diachi)
                    .HasMaxLength(50)
                    .HasColumnName("DIACHI");

                entity.Property(e => e.Dthoai)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("DTHOAI");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.IdvaiTro)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("IDVaiTro");

                entity.Property(e => e.MatKhau)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Ten)
                    .HasMaxLength(10)
                    .HasColumnName("TEN");

                entity.Property(e => e.Trangthai).HasMaxLength(50);

                entity.HasOne(d => d.IdvaiTroNavigation)
                    .WithMany(p => p.NguoiDungs)
                    .HasForeignKey(d => d.IdvaiTro)
                    .HasConstraintName("FK_NguoiDung_VaiTro");
            });

            modelBuilder.Entity<NhaCungCap>(entity =>
            {
                entity.HasKey(e => e.Idncc);

                entity.ToTable("NhaCungCap");

                entity.Property(e => e.Idncc)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("IDNCC");

                entity.Property(e => e.Diachi)
                    .HasMaxLength(100)
                    .HasColumnName("DIACHI");

                entity.Property(e => e.Dieukhoanhoptac)
                    .HasMaxLength(50)
                    .HasColumnName("DIEUKHOANHOPTAC");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Loaidichvu)
                    .HasMaxLength(30)
                    .HasColumnName("LOAIDICHVU");

                entity.Property(e => e.Sdt).HasColumnName("SDT");

                entity.Property(e => e.Tenncc)
                    .HasMaxLength(30)
                    .HasColumnName("TENNCC");
            });

            modelBuilder.Entity<Sanpham>(entity =>
            {
                entity.HasKey(e => e.Masp);

                entity.ToTable("SANPHAM");

                entity.Property(e => e.Masp)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MASP");

                entity.Property(e => e.Diachinhap)
                    .HasMaxLength(100)
                    .HasColumnName("DIACHINHAP");

                entity.Property(e => e.Giaban)
                    .HasColumnType("money")
                    .HasColumnName("GIABAN");

                entity.Property(e => e.Gianhap).HasColumnName("GIANHAP");

                entity.Property(e => e.IdnguoiDung)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("IDNguoiDung");

                entity.Property(e => e.Ngaynhap)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYNHAP");

                entity.Property(e => e.Soluongnhap).HasColumnName("SOLUONGNHAP");

                entity.Property(e => e.Soluongton).HasColumnName("SOLUONGTON");

                entity.Property(e => e.Tensp)
                    .HasMaxLength(30)
                    .HasColumnName("TENSP");

                entity.Property(e => e.Trangthai)
                    .HasMaxLength(50)
                    .HasColumnName("TRANGTHAI");

                entity.HasOne(d => d.IdnguoiDungNavigation)
                    .WithMany(p => p.Sanphams)
                    .HasForeignKey(d => d.IdnguoiDung)
                    .HasConstraintName("FK_SANPHAM_NguoiDung");
            });

            modelBuilder.Entity<VaiTro>(entity =>
            {
                entity.HasKey(e => e.IdvaiTro);

                entity.ToTable("VaiTro");

                entity.Property(e => e.IdvaiTro)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("IDVaiTro");

                entity.Property(e => e.Ten).HasMaxLength(30);

                entity.Property(e => e.Vaitro1)
                    .HasMaxLength(50)
                    .HasColumnName("Vaitro");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
