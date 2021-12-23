using Live_e_commerce.Entities;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.BackgroundJobs.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.Identity;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.IdentityServer.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.TenantManagement;
using Volo.Abp.TenantManagement.EntityFrameworkCore;

namespace Live_e_commerce.EntityFrameworkCore
{
    [ReplaceDbContext(typeof(IIdentityDbContext))]
    [ReplaceDbContext(typeof(ITenantManagementDbContext))]
    [ConnectionStringName("Default")]
    public class Live_e_commerceDbContext : 
        AbpDbContext<Live_e_commerceDbContext>,
        IIdentityDbContext,
        ITenantManagementDbContext
    {
        /* Add DbSet properties for your Aggregate Roots / Entities here. */
        
        #region Entities from the modules
        
        /* Notice: We only implemented IIdentityDbContext and ITenantManagementDbContext
         * and replaced them for this DbContext. This allows you to perform JOIN
         * queries for the entities of these modules over the repositories easily. You
         * typically don't need that for other modules. But, if you need, you can
         * implement the DbContext interface of the needed module and use ReplaceDbContext
         * attribute just like IIdentityDbContext and ITenantManagementDbContext.
         *
         * More info: Replacing a DbContext of a module ensures that the related module
         * uses this DbContext on runtime. Otherwise, it will use its own DbContext class.
         */
        
        //Identity
        public DbSet<IdentityUser> Users { get; set; }
        public DbSet<IdentityRole> Roles { get; set; }
        public DbSet<IdentityClaimType> ClaimTypes { get; set; }
        public DbSet<OrganizationUnit> OrganizationUnits { get; set; }
        public DbSet<IdentitySecurityLog> SecurityLogs { get; set; }
        public DbSet<IdentityLinkUser> LinkUsers { get; set; }
        
        // Tenant Management
        public DbSet<Tenant> Tenants { get; set; }
        public DbSet<TenantConnectionString> TenantConnectionStrings { get; set; }

        public  DbSet<Member> Members { get; set; }
        public  DbSet<User> UserInfo { get; set; }
        public  DbSet<UserBase> UserBases { get; set; }
        public  DbSet<UserExtra> UserExtras { get; set; }
        public  DbSet<UserInfoUpdate> UserInfoUpdates { get; set; }
        public  DbSet<UserLocation> UserLocations { get; set; }
        public  DbSet<UserLoginLog> UserLoginLogs { get; set; }
        public  DbSet<UserRegisterLog> UserRegisterLogs { get; set; }
        /// <summary>
        /// 分类
        /// </summary>
        public DbSet<Classification> Classifications { get; set; }
        /// <summary>
        /// 商品
        /// </summary>
        public DbSet<Commodity> Commoditys { get; set; }
        /// <summary>
        /// 订单
        /// </summary>
        public DbSet<Order> Orders { get; set; }
        /// <summary>
        /// 规格
        /// </summary>
        public DbSet<Specification> Specifications { get; set; }
        /// <summary>
        /// 购物车
        /// </summary>
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }

        #endregion
        #region
        public Live_e_commerceDbContext(DbContextOptions<Live_e_commerceDbContext> options)
            : base(options)
        {

        }
        #endregion
        protected override void OnModelCreating(ModelBuilder builder)
        {
            #region
            base.OnModelCreating(builder);

            /* Include modules to your migration db context */

            builder.ConfigurePermissionManagement();
            builder.ConfigureSettingManagement();
            builder.ConfigureBackgroundJobs();
            builder.ConfigureAuditLogging();
            builder.ConfigureIdentity();
            builder.ConfigureIdentityServer();
            builder.ConfigureFeatureManagement();
            builder.ConfigureTenantManagement();

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(Live_e_commerceConsts.DbTablePrefix + "YourEntities", Live_e_commerceConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
            #endregion

            #region entity
            builder.Entity<Member>(b =>
            {
                b.ToTable("Member");
                b.ConfigureByConvention();
            });
            builder.Entity<User>(b =>
            {
                b.ToTable("User");
                b.ConfigureByConvention();
            });
            builder.Entity<UserBase>(b =>
            {
                b.ToTable("UserBase");
                b.ConfigureByConvention();
            });
            builder.Entity<UserExtra>(b =>
            {
                b.ToTable("UserExtra");
                b.ConfigureByConvention();
            });
            builder.Entity<UserInfoUpdate>(b =>
            {
                b.ToTable("UserInfoUpdate");
                b.ConfigureByConvention();
            });
            builder.Entity<UserLocation>(b =>
            {
                b.ToTable("UserLocation");
                b.ConfigureByConvention();
            });
            builder.Entity<UserLoginLog>(b =>
            {
                b.ToTable("UserLoginLog");
                b.ConfigureByConvention();
            });
            builder.Entity<UserRegisterLog>(b =>
            {
                b.ToTable("UserRegisterLog");
                b.ConfigureByConvention();
            });
            builder.Entity<Classification>(b =>
            {
                b.ToTable("Classification");
                b.ConfigureByConvention();
            });
            builder.Entity<Commodity>(b =>
            {
                b.ToTable("Commodity");
                b.ConfigureByConvention();
            });
            builder.Entity<Order>(b =>
            {
                b.ToTable("Order");
                b.ConfigureByConvention();
            });
            builder.Entity<Specification>(b =>
            {
                b.ToTable("Specification");
                b.ConfigureByConvention();
            });
            builder.Entity<ShoppingCart>(b =>
            {
                b.ToTable("ShoppingCart");
                b.ConfigureByConvention();
            });
            #endregion
        }
    }
}
