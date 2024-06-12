using AppData.Entity;
using AppData.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;


namespace AppData.FPhoneDbContexts;

public class FPhoneDbContext : IdentityDbContext<ApplicationUser>
{
    public FPhoneDbContext()
    {
    }

    public FPhoneDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<ContactEntity> Contact { get; set; }
    public DbSet<AccountEntity> Accounts { get; set; }
    public DbSet<AddressEntity> Address { get; set; }

    public DbSet<BillEntity> Bill { get; set; }
    public DbSet<BillDetailsEntity> BillDetails { get; set; }
    public DbSet<BlogEntity> Blogs { get; set; }
    public DbSet<CartEntity> Carts { get; set; }
    public DbSet<CartDetailsEntity> CartDetails { get; set; }
    public DbSet<DiscountEntity> Discount { get; set; }
    public DbSet<ListImageEntity> ListImage { get; set; }
    public DbSet<ProductionCompanyEntity> ProductionCompany { get; set; }
    public DbSet<RankEntity> Ranks { get; set; }
    public DbSet<ReviewEntity> Reviews { get; set; }
    public DbSet<WarrantyEntity> Warranty { get; set; }
    public DbSet<WarrantyCardEntity> WarrantyCards { get; set; }
    public DbSet<SalesEntity> Sales { get; set; }
    public DbSet<SaleDetaildEntity> SalePhoneDetailds { get; set; }
    public DbSet<VirtualItemObjRelationEntity> ItemObjRelationEntities {get;set;}
   public DbSet<ApplicationUser> AspNetUsers { get; set; }
   public DbSet<VirtualItemEntity>   VirtualItems { get; set; }
    //public DbSet<VW_Phone> VW_Phone { get; set; }
    //public DbSet<VTop5_PhoneSell> VW_Top5Phone { get; set; }
    //public DbSet<VW_PhoneDetail> VW_PhoneDetail { get; set; }
    //public DbSet<VW_Phone_Group> VW_Phone_Group { get; set; }
    //public DbSet<VW_List_By_IdPhone> VW_List_By_IdPhone { get; set; }
    //public DbSet<VTop5_PhoneSell> VTop5_PhoneSell { get; set; }
    //public DbSet<vOverView> OverViews { get; set; }
    //public DbSet<BillGanDay> billGanDays { get; set; }
    //public DbSet<PhoneStatitics> PhoneStatitics { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-IHE70EQ6\SQLEXPRESS;Initial Catalog=test_1;Integrated Security=True");
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<CartEntity>().HasOne(c => c.Accounts).WithOne(p => p.Carts).HasForeignKey<CartEntity>();

        builder.Entity<VirtualItemEntity>().HasKey(p => p.Id);
        //builder.Entity<VW_Phone>().ToView("VW_Phone").HasNoKey();
        //builder.Entity<VW_PhoneDetail>().ToView("VW_PhoneDetail").HasNoKey();
        //builder.Entity<VW_Phone_Group>().ToView("VW_Phone_Group").HasNoKey();
        //builder.Entity<VW_List_By_IdPhone>().ToView("VW_List_By_IdPhone").HasNoKey();
        //builder.Entity<VTop5_PhoneSell>().ToView("VTop5_PhoneSell").HasNoKey();
        //builder.Entity<vOverView>().ToView("vOverView").HasNoKey();
        //builder.Entity<BillGanDay>().ToView("BillGanDay").HasNoKey();
        //builder.Entity<PhoneStatitics>().ToView("PhoneStatitics").HasNoKey();
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}