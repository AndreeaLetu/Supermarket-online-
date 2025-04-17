

using Microsoft.EntityFrameworkCore;

using System.ComponentModel.DataAnnotations;
namespace AspNetCoreEFCoreApp.Models;


public class SupermarketContext : DbContext
{
    public SupermarketContext(DbContextOptions<SupermarketContext> options) :
        base(options)
    { }
    public DbSet<Users> Users { get; set; }
    public DbSet<Products> Products { get; set; }
    public DbSet<Orders> Orders { get; set; }
    public DbSet<Basket> Basket { get; set; }
    public DbSet<BasketDetails> BasketDetails { get; set; }
    public DbSet<Order_Details> Order_Details { get; set; }
    public DbSet<Feedback> Feedback { get; set; }
    public DbSet<Categories> Categories { get; set; }
    public DbSet<PromoPackets> PromoPackets { get; set; }
    public DbSet<Contact> Contact { get; set; }
    public DbSet<PromoPackets_Products> PromoPackets_Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BasketDetails>()
            .HasKey(bd => new { bd.Id_Product, bd.Id_Basket });

        modelBuilder.Entity<BasketDetails>()
            .HasOne(bd => bd.Basket)
            .WithMany(b => b.BasketDetails)
            .HasForeignKey(bd => bd.Id_Basket)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<BasketDetails>()
            .HasOne(bd => bd.Products)
            .WithMany(p => p.BasketDetails)
            .HasForeignKey(bd => bd.Id_Product)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Basket>()
       .HasOne(b => b.Orders)
       .WithOne(o => o.Basket)
       .HasPrincipalKey<Basket>(b => b.Id_Basket)
       .OnDelete(DeleteBehavior.Cascade);


        modelBuilder.Entity<Order_Details>()
         .HasKey(od => new { od.Id_Order, od.Id_Product });

        modelBuilder.Entity<Order_Details>()
            .HasOne(od => od.Orders)
            .WithMany(o => o.Order_Details)
            .HasForeignKey(od => od.Id_Order)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Order_Details>()
            .HasOne(od => od.Products)
            .WithMany(p => p.Order_Details)
            .HasForeignKey(od => od.Id_Product)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Products>()
        .HasMany(p => p.PromoPackets_Products)  // MANY-to-MANY
        .WithOne(pp => pp.Products)
        .HasForeignKey(pp => pp.Id_Product);

        modelBuilder.Entity<PromoPackets_Products>()
        .HasKey(pp => new { pp.Id_Packet, pp.Id_Product });  // Cheia compusă

        modelBuilder.Entity<PromoPackets_Products>()
            .HasOne(pp => pp.PromoPackets)
            .WithMany(p => p.PromoPackets_Products)  // Relație many-to-many
            .HasForeignKey(pp => pp.Id_Packet)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<PromoPackets_Products>()
            .HasOne(pp => pp.Products)
            .WithMany(p => p.PromoPackets_Products)  // Relație many-to-many
            .HasForeignKey(pp => pp.Id_Product)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Feedback>()
           .HasOne(f => f.Users)  // Un feedback are un utilizator
           .WithMany(u => u.Feedbacks)  // Un utilizator are multe feedbackuri
           .HasForeignKey(f => f.CNP)  // CNP-ul este cheia externă
           .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Products>()
      .HasOne(p => p.Categories)
      .WithMany(c => c.Products)
      .HasForeignKey(p => p.Id_Categories)
      .OnDelete(DeleteBehavior.Restrict); // sau .Cascade dacă vrei ștergere în lanț

    }




}