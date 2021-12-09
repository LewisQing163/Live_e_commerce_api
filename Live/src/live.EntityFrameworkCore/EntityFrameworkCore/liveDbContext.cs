using live.entity;
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
using static AutoMapper.Internal.ExpressionFactory;
using Member = live.entity.Member;

namespace live.EntityFrameworkCore
{
    [ReplaceDbContext(typeof(IIdentityDbContext))]
    [ReplaceDbContext(typeof(ITenantManagementDbContext))]
    [ConnectionStringName("Default")]
    public class liveDbContext : 
        AbpDbContext<liveDbContext>,
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


        #region Identity
        public DbSet<IdentityUser> Users { get; set; }
        public DbSet<IdentityRole> Roles { get; set; }
        public DbSet<IdentityClaimType> ClaimTypes { get; set; }
        public DbSet<OrganizationUnit> OrganizationUnits { get; set; }
        public DbSet<IdentitySecurityLog> SecurityLogs { get; set; }
        public DbSet<IdentityLinkUser> LinkUsers { get; set; }
        #endregion

        #region 自己的dbset
        public DbSet<Member> Members { get; set; }
        public DbSet<User> Userinfos { get; set; }
        public DbSet<UserBase> UserBases { get; set; }
        public DbSet<UserExtra> UserExtras { get; set; }
        public DbSet<UserInfoUpdate> UserInfoUpdates { get; set; }
        public DbSet<UserLocation> UserLocations { get; set; }
        public DbSet<UserLoginLog> UserLoginLogs { get; set; }
        public DbSet<UserRegisterLog> UserRegisterLogs { get; set; }
        #endregion

        // Tenant Management
        public DbSet<Tenant> Tenants { get; set; }
        public DbSet<TenantConnectionString> TenantConnectionStrings { get; set; }
        #endregion

        public liveDbContext(DbContextOptions<liveDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
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
            //    b.ToTable(liveConsts.DbTablePrefix + "YourEntities", liveConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});

            builder.Entity<Member>(b =>
            {
                b.ToTable("Member");
                b.ConfigureByConvention(); //auto configure for the base class props
            });

            builder.Entity<Member>(b =>
            {
                b.ToTable("User");
                b.ConfigureByConvention(); //auto configure for the base class props
            });
            builder.Entity<Member>(b =>
            {
                b.ToTable("UserBase");
                b.ConfigureByConvention(); //auto configure for the base class props
            });
            builder.Entity<Member>(b =>
            {
                b.ToTable("UserExtra");
                b.ConfigureByConvention(); //auto configure for the base class props
            });
            builder.Entity<Member>(b =>
            {
                b.ToTable("UserInfoUpdate");
                b.ConfigureByConvention(); //auto configure for the base class props
            });
            builder.Entity<Member>(b =>
            {
                b.ToTable("UserLocation");
                b.ConfigureByConvention(); //auto configure for the base class props
            });
            builder.Entity<Member>(b =>
            {
                b.ToTable("UserLoginLog");
                b.ConfigureByConvention(); //auto configure for the base class props
            });
            builder.Entity<Member>(b =>
            {
                b.ToTable("UserRegisterLog");
                b.ConfigureByConvention(); //auto configure for the base class props
            });
        }
    }
}
