using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Live_e_commerce.Models;

#nullable disable

namespace Live_e_commerce.DbContext
{
    public partial class Live_e_commerceContext : DbContext
    {
        public Live_e_commerceContext()
        {
        }

        public Live_e_commerceContext(DbContextOptions<Live_e_commerceContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AbpAuditLog> AbpAuditLogs { get; set; }
        public virtual DbSet<AbpAuditLogAction> AbpAuditLogActions { get; set; }
        public virtual DbSet<AbpBackgroundJob> AbpBackgroundJobs { get; set; }
        public virtual DbSet<AbpClaimType> AbpClaimTypes { get; set; }
        public virtual DbSet<AbpEntityChange> AbpEntityChanges { get; set; }
        public virtual DbSet<AbpEntityPropertyChange> AbpEntityPropertyChanges { get; set; }
        public virtual DbSet<AbpFeatureValue> AbpFeatureValues { get; set; }
        public virtual DbSet<AbpLinkUser> AbpLinkUsers { get; set; }
        public virtual DbSet<AbpOrganizationUnit> AbpOrganizationUnits { get; set; }
        public virtual DbSet<AbpOrganizationUnitRole> AbpOrganizationUnitRoles { get; set; }
        public virtual DbSet<AbpPermissionGrant> AbpPermissionGrants { get; set; }
        public virtual DbSet<AbpRole> AbpRoles { get; set; }
        public virtual DbSet<AbpRoleClaim> AbpRoleClaims { get; set; }
        public virtual DbSet<AbpSecurityLog> AbpSecurityLogs { get; set; }
        public virtual DbSet<AbpSetting> AbpSettings { get; set; }
        public virtual DbSet<AbpTenant> AbpTenants { get; set; }
        public virtual DbSet<AbpTenantConnectionString> AbpTenantConnectionStrings { get; set; }
        public virtual DbSet<AbpUser> AbpUsers { get; set; }
        public virtual DbSet<AbpUserClaim> AbpUserClaims { get; set; }
        public virtual DbSet<AbpUserLogin> AbpUserLogins { get; set; }
        public virtual DbSet<AbpUserOrganizationUnit> AbpUserOrganizationUnits { get; set; }
        public virtual DbSet<AbpUserRole> AbpUserRoles { get; set; }
        public virtual DbSet<AbpUserToken> AbpUserTokens { get; set; }
        public virtual DbSet<Balance> Balances { get; set; }
        public virtual DbSet<Consumption> Consumptions { get; set; }
        public virtual DbSet<IdentityServerApiResource> IdentityServerApiResources { get; set; }
        public virtual DbSet<IdentityServerApiResourceClaim> IdentityServerApiResourceClaims { get; set; }
        public virtual DbSet<IdentityServerApiResourceProperty> IdentityServerApiResourceProperties { get; set; }
        public virtual DbSet<IdentityServerApiResourceScope> IdentityServerApiResourceScopes { get; set; }
        public virtual DbSet<IdentityServerApiResourceSecret> IdentityServerApiResourceSecrets { get; set; }
        public virtual DbSet<IdentityServerApiScope> IdentityServerApiScopes { get; set; }
        public virtual DbSet<IdentityServerApiScopeClaim> IdentityServerApiScopeClaims { get; set; }
        public virtual DbSet<IdentityServerApiScopeProperty> IdentityServerApiScopeProperties { get; set; }
        public virtual DbSet<IdentityServerClient> IdentityServerClients { get; set; }
        public virtual DbSet<IdentityServerClientClaim> IdentityServerClientClaims { get; set; }
        public virtual DbSet<IdentityServerClientCorsOrigin> IdentityServerClientCorsOrigins { get; set; }
        public virtual DbSet<IdentityServerClientGrantType> IdentityServerClientGrantTypes { get; set; }
        public virtual DbSet<IdentityServerClientIdPrestriction> IdentityServerClientIdPrestrictions { get; set; }
        public virtual DbSet<IdentityServerClientPostLogoutRedirectUri> IdentityServerClientPostLogoutRedirectUris { get; set; }
        public virtual DbSet<IdentityServerClientProperty> IdentityServerClientProperties { get; set; }
        public virtual DbSet<IdentityServerClientRedirectUri> IdentityServerClientRedirectUris { get; set; }
        public virtual DbSet<IdentityServerClientScope> IdentityServerClientScopes { get; set; }
        public virtual DbSet<IdentityServerClientSecret> IdentityServerClientSecrets { get; set; }
        public virtual DbSet<IdentityServerDeviceFlowCode> IdentityServerDeviceFlowCodes { get; set; }
        public virtual DbSet<IdentityServerIdentityResource> IdentityServerIdentityResources { get; set; }
        public virtual DbSet<IdentityServerIdentityResourceClaim> IdentityServerIdentityResourceClaims { get; set; }
        public virtual DbSet<IdentityServerIdentityResourceProperty> IdentityServerIdentityResourceProperties { get; set; }
        public virtual DbSet<IdentityServerPersistedGrant> IdentityServerPersistedGrants { get; set; }
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<TodoItem> TodoItems { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserBase> UserBases { get; set; }
        public virtual DbSet<UserExtra> UserExtras { get; set; }
        public virtual DbSet<UserInfoUpdate> UserInfoUpdates { get; set; }
        public virtual DbSet<UserLocation> UserLocations { get; set; }
        public virtual DbSet<UserLoginLog> UserLoginLogs { get; set; }
        public virtual DbSet<UserRegisterLog> UserRegisterLogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost;Database=Live_e_commerce;User ID=sa;Password=123456;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Chinese_PRC_CI_AS");

            modelBuilder.Entity<AbpAuditLog>(entity =>
            {
                entity.HasIndex(e => new { e.TenantId, e.ExecutionTime }, "IX_AbpAuditLogs_TenantId_ExecutionTime");

                entity.HasIndex(e => new { e.TenantId, e.UserId, e.ExecutionTime }, "IX_AbpAuditLogs_TenantId_UserId_ExecutionTime");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ApplicationName).HasMaxLength(96);

                entity.Property(e => e.BrowserInfo).HasMaxLength(512);

                entity.Property(e => e.ClientId).HasMaxLength(64);

                entity.Property(e => e.ClientIpAddress).HasMaxLength(64);

                entity.Property(e => e.ClientName).HasMaxLength(128);

                entity.Property(e => e.Comments).HasMaxLength(256);

                entity.Property(e => e.ConcurrencyStamp).HasMaxLength(40);

                entity.Property(e => e.CorrelationId).HasMaxLength(64);

                entity.Property(e => e.HttpMethod).HasMaxLength(16);

                entity.Property(e => e.Url).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<AbpAuditLogAction>(entity =>
            {
                entity.HasIndex(e => e.AuditLogId, "IX_AbpAuditLogActions_AuditLogId");

                entity.HasIndex(e => new { e.TenantId, e.ServiceName, e.MethodName, e.ExecutionTime }, "IX_AbpAuditLogActions_TenantId_ServiceName_MethodName_ExecutionTime");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.MethodName).HasMaxLength(128);

                entity.Property(e => e.Parameters).HasMaxLength(2000);

                entity.Property(e => e.ServiceName).HasMaxLength(256);

                entity.HasOne(d => d.AuditLog)
                    .WithMany(p => p.AbpAuditLogActions)
                    .HasForeignKey(d => d.AuditLogId);
            });

            modelBuilder.Entity<AbpBackgroundJob>(entity =>
            {
                entity.HasIndex(e => new { e.IsAbandoned, e.NextTryTime }, "IX_AbpBackgroundJobs_IsAbandoned_NextTryTime");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ConcurrencyStamp).HasMaxLength(40);

                entity.Property(e => e.IsAbandoned)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.JobArgs).IsRequired();

                entity.Property(e => e.JobName)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Priority).HasDefaultValueSql("(CONVERT([tinyint],(15)))");

                entity.Property(e => e.TryCount).HasDefaultValueSql("(CONVERT([smallint],(0)))");
            });

            modelBuilder.Entity<AbpClaimType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ConcurrencyStamp).HasMaxLength(40);

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Regex).HasMaxLength(512);

                entity.Property(e => e.RegexDescription).HasMaxLength(128);
            });

            modelBuilder.Entity<AbpEntityChange>(entity =>
            {
                entity.HasIndex(e => e.AuditLogId, "IX_AbpEntityChanges_AuditLogId");

                entity.HasIndex(e => new { e.TenantId, e.EntityTypeFullName, e.EntityId }, "IX_AbpEntityChanges_TenantId_EntityTypeFullName_EntityId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.EntityId)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.EntityTypeFullName)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.AuditLog)
                    .WithMany(p => p.AbpEntityChanges)
                    .HasForeignKey(d => d.AuditLogId);
            });

            modelBuilder.Entity<AbpEntityPropertyChange>(entity =>
            {
                entity.HasIndex(e => e.EntityChangeId, "IX_AbpEntityPropertyChanges_EntityChangeId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.NewValue).HasMaxLength(512);

                entity.Property(e => e.OriginalValue).HasMaxLength(512);

                entity.Property(e => e.PropertyName)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.PropertyTypeFullName)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.HasOne(d => d.EntityChange)
                    .WithMany(p => p.AbpEntityPropertyChanges)
                    .HasForeignKey(d => d.EntityChangeId);
            });

            modelBuilder.Entity<AbpFeatureValue>(entity =>
            {
                entity.HasIndex(e => new { e.Name, e.ProviderName, e.ProviderKey }, "IX_AbpFeatureValues_Name_ProviderName_ProviderKey");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(64);

                entity.Property(e => e.ProviderName).HasMaxLength(64);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<AbpLinkUser>(entity =>
            {
                entity.HasIndex(e => new { e.SourceUserId, e.SourceTenantId, e.TargetUserId, e.TargetTenantId }, "IX_AbpLinkUsers_SourceUserId_SourceTenantId_TargetUserId_TargetTenantId")
                    .IsUnique()
                    .HasFilter("([SourceTenantId] IS NOT NULL AND [TargetTenantId] IS NOT NULL)");

                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<AbpOrganizationUnit>(entity =>
            {
                entity.HasIndex(e => e.Code, "IX_AbpOrganizationUnits_Code");

                entity.HasIndex(e => e.ParentId, "IX_AbpOrganizationUnits_ParentId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(95);

                entity.Property(e => e.ConcurrencyStamp).HasMaxLength(40);

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId);
            });

            modelBuilder.Entity<AbpOrganizationUnitRole>(entity =>
            {
                entity.HasKey(e => new { e.OrganizationUnitId, e.RoleId });

                entity.HasIndex(e => new { e.RoleId, e.OrganizationUnitId }, "IX_AbpOrganizationUnitRoles_RoleId_OrganizationUnitId");

                entity.HasOne(d => d.OrganizationUnit)
                    .WithMany(p => p.AbpOrganizationUnitRoles)
                    .HasForeignKey(d => d.OrganizationUnitId);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AbpOrganizationUnitRoles)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AbpPermissionGrant>(entity =>
            {
                entity.HasIndex(e => new { e.Name, e.ProviderName, e.ProviderKey }, "IX_AbpPermissionGrants_Name_ProviderName_ProviderKey");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.ProviderKey)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.ProviderName)
                    .IsRequired()
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<AbpRole>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName, "IX_AbpRoles_NormalizedName");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ConcurrencyStamp).HasMaxLength(40);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.NormalizedName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<AbpRoleClaim>(entity =>
            {
                entity.HasIndex(e => e.RoleId, "IX_AbpRoleClaims_RoleId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ClaimType)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.ClaimValue).HasMaxLength(1024);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AbpRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AbpSecurityLog>(entity =>
            {
                entity.HasIndex(e => new { e.TenantId, e.Action }, "IX_AbpSecurityLogs_TenantId_Action");

                entity.HasIndex(e => new { e.TenantId, e.ApplicationName }, "IX_AbpSecurityLogs_TenantId_ApplicationName");

                entity.HasIndex(e => new { e.TenantId, e.Identity }, "IX_AbpSecurityLogs_TenantId_Identity");

                entity.HasIndex(e => new { e.TenantId, e.UserId }, "IX_AbpSecurityLogs_TenantId_UserId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Action).HasMaxLength(96);

                entity.Property(e => e.ApplicationName).HasMaxLength(96);

                entity.Property(e => e.BrowserInfo).HasMaxLength(512);

                entity.Property(e => e.ClientId).HasMaxLength(64);

                entity.Property(e => e.ClientIpAddress).HasMaxLength(64);

                entity.Property(e => e.ConcurrencyStamp).HasMaxLength(40);

                entity.Property(e => e.CorrelationId).HasMaxLength(64);

                entity.Property(e => e.Identity).HasMaxLength(96);

                entity.Property(e => e.TenantName).HasMaxLength(64);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<AbpSetting>(entity =>
            {
                entity.HasIndex(e => new { e.Name, e.ProviderName, e.ProviderKey }, "IX_AbpSettings_Name_ProviderName_ProviderKey");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(64);

                entity.Property(e => e.ProviderName).HasMaxLength(64);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(2048);
            });

            modelBuilder.Entity<AbpTenant>(entity =>
            {
                entity.HasIndex(e => e.Name, "IX_AbpTenants_Name");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ConcurrencyStamp).HasMaxLength(40);

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<AbpTenantConnectionString>(entity =>
            {
                entity.HasKey(e => new { e.TenantId, e.Name });

                entity.Property(e => e.Name).HasMaxLength(64);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(1024);

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.AbpTenantConnectionStrings)
                    .HasForeignKey(d => d.TenantId);
            });

            modelBuilder.Entity<AbpUser>(entity =>
            {
                entity.HasIndex(e => e.Email, "IX_AbpUsers_Email");

                entity.HasIndex(e => e.NormalizedEmail, "IX_AbpUsers_NormalizedEmail");

                entity.HasIndex(e => e.NormalizedUserName, "IX_AbpUsers_NormalizedUserName");

                entity.HasIndex(e => e.UserName, "IX_AbpUsers_UserName");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ConcurrencyStamp).HasMaxLength(40);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.EmailConfirmed)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.IsExternal)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.LockoutEnabled)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.Name).HasMaxLength(64);

                entity.Property(e => e.NormalizedEmail)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.PasswordHash).HasMaxLength(256);

                entity.Property(e => e.PhoneNumber).HasMaxLength(16);

                entity.Property(e => e.PhoneNumberConfirmed)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.SecurityStamp)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Surname).HasMaxLength(64);

                entity.Property(e => e.TwoFactorEnabled)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<AbpUserClaim>(entity =>
            {
                entity.HasIndex(e => e.UserId, "IX_AbpUserClaims_UserId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ClaimType)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.ClaimValue).HasMaxLength(1024);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AbpUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AbpUserLogin>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider });

                entity.HasIndex(e => new { e.LoginProvider, e.ProviderKey }, "IX_AbpUserLogins_LoginProvider_ProviderKey");

                entity.Property(e => e.LoginProvider).HasMaxLength(64);

                entity.Property(e => e.ProviderDisplayName).HasMaxLength(128);

                entity.Property(e => e.ProviderKey)
                    .IsRequired()
                    .HasMaxLength(196);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AbpUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AbpUserOrganizationUnit>(entity =>
            {
                entity.HasKey(e => new { e.OrganizationUnitId, e.UserId });

                entity.HasIndex(e => new { e.UserId, e.OrganizationUnitId }, "IX_AbpUserOrganizationUnits_UserId_OrganizationUnitId");

                entity.HasOne(d => d.OrganizationUnit)
                    .WithMany(p => p.AbpUserOrganizationUnits)
                    .HasForeignKey(d => d.OrganizationUnitId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AbpUserOrganizationUnits)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AbpUserRole>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => new { e.RoleId, e.UserId }, "IX_AbpUserRoles_RoleId_UserId");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AbpUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AbpUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AbpUserToken>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.Property(e => e.LoginProvider).HasMaxLength(64);

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AbpUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<Balance>(entity =>
            {
                entity.ToTable("Balance");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Balance1).HasColumnName("Balance");
            });

            modelBuilder.Entity<Consumption>(entity =>
            {
                entity.ToTable("Consumption");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ProductName)
                    .HasMaxLength(20)
                    .HasColumnName("Product_Name");

                entity.Property(e => e.ProductPrice).HasColumnName("Product_Price");
            });

            modelBuilder.Entity<IdentityServerApiResource>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AllowedAccessTokenSigningAlgorithms).HasMaxLength(100);

                entity.Property(e => e.ConcurrencyStamp).HasMaxLength(40);

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.DisplayName).HasMaxLength(200);

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<IdentityServerApiResourceClaim>(entity =>
            {
                entity.HasKey(e => new { e.ApiResourceId, e.Type });

                entity.Property(e => e.Type).HasMaxLength(200);

                entity.HasOne(d => d.ApiResource)
                    .WithMany(p => p.IdentityServerApiResourceClaims)
                    .HasForeignKey(d => d.ApiResourceId);
            });

            modelBuilder.Entity<IdentityServerApiResourceProperty>(entity =>
            {
                entity.HasKey(e => new { e.ApiResourceId, e.Key, e.Value });

                entity.Property(e => e.Key).HasMaxLength(250);

                entity.Property(e => e.Value).HasMaxLength(2000);

                entity.HasOne(d => d.ApiResource)
                    .WithMany(p => p.IdentityServerApiResourceProperties)
                    .HasForeignKey(d => d.ApiResourceId);
            });

            modelBuilder.Entity<IdentityServerApiResourceScope>(entity =>
            {
                entity.HasKey(e => new { e.ApiResourceId, e.Scope });

                entity.Property(e => e.Scope).HasMaxLength(200);

                entity.HasOne(d => d.ApiResource)
                    .WithMany(p => p.IdentityServerApiResourceScopes)
                    .HasForeignKey(d => d.ApiResourceId);
            });

            modelBuilder.Entity<IdentityServerApiResourceSecret>(entity =>
            {
                entity.HasKey(e => new { e.ApiResourceId, e.Type, e.Value });

                entity.Property(e => e.Type).HasMaxLength(250);

                entity.Property(e => e.Value).HasMaxLength(4000);

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.HasOne(d => d.ApiResource)
                    .WithMany(p => p.IdentityServerApiResourceSecrets)
                    .HasForeignKey(d => d.ApiResourceId);
            });

            modelBuilder.Entity<IdentityServerApiScope>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ConcurrencyStamp).HasMaxLength(40);

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.DisplayName).HasMaxLength(200);

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<IdentityServerApiScopeClaim>(entity =>
            {
                entity.HasKey(e => new { e.ApiScopeId, e.Type });

                entity.Property(e => e.Type).HasMaxLength(200);

                entity.HasOne(d => d.ApiScope)
                    .WithMany(p => p.IdentityServerApiScopeClaims)
                    .HasForeignKey(d => d.ApiScopeId);
            });

            modelBuilder.Entity<IdentityServerApiScopeProperty>(entity =>
            {
                entity.HasKey(e => new { e.ApiScopeId, e.Key, e.Value });

                entity.Property(e => e.Key).HasMaxLength(250);

                entity.Property(e => e.Value).HasMaxLength(2000);

                entity.HasOne(d => d.ApiScope)
                    .WithMany(p => p.IdentityServerApiScopeProperties)
                    .HasForeignKey(d => d.ApiScopeId);
            });

            modelBuilder.Entity<IdentityServerClient>(entity =>
            {
                entity.HasIndex(e => e.ClientId, "IX_IdentityServerClients_ClientId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AllowedIdentityTokenSigningAlgorithms).HasMaxLength(100);

                entity.Property(e => e.BackChannelLogoutUri).HasMaxLength(2000);

                entity.Property(e => e.ClientClaimsPrefix).HasMaxLength(200);

                entity.Property(e => e.ClientId)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ClientName).HasMaxLength(200);

                entity.Property(e => e.ClientUri).HasMaxLength(2000);

                entity.Property(e => e.ConcurrencyStamp).HasMaxLength(40);

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.FrontChannelLogoutUri).HasMaxLength(2000);

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.LogoUri).HasMaxLength(2000);

                entity.Property(e => e.PairWiseSubjectSalt).HasMaxLength(200);

                entity.Property(e => e.ProtocolType)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.UserCodeType).HasMaxLength(100);
            });

            modelBuilder.Entity<IdentityServerClientClaim>(entity =>
            {
                entity.HasKey(e => new { e.ClientId, e.Type, e.Value });

                entity.Property(e => e.Type).HasMaxLength(250);

                entity.Property(e => e.Value).HasMaxLength(250);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.IdentityServerClientClaims)
                    .HasForeignKey(d => d.ClientId);
            });

            modelBuilder.Entity<IdentityServerClientCorsOrigin>(entity =>
            {
                entity.HasKey(e => new { e.ClientId, e.Origin });

                entity.Property(e => e.Origin).HasMaxLength(150);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.IdentityServerClientCorsOrigins)
                    .HasForeignKey(d => d.ClientId);
            });

            modelBuilder.Entity<IdentityServerClientGrantType>(entity =>
            {
                entity.HasKey(e => new { e.ClientId, e.GrantType });

                entity.Property(e => e.GrantType).HasMaxLength(250);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.IdentityServerClientGrantTypes)
                    .HasForeignKey(d => d.ClientId);
            });

            modelBuilder.Entity<IdentityServerClientIdPrestriction>(entity =>
            {
                entity.HasKey(e => new { e.ClientId, e.Provider });

                entity.ToTable("IdentityServerClientIdPRestrictions");

                entity.Property(e => e.Provider).HasMaxLength(200);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.IdentityServerClientIdPrestrictions)
                    .HasForeignKey(d => d.ClientId);
            });

            modelBuilder.Entity<IdentityServerClientPostLogoutRedirectUri>(entity =>
            {
                entity.HasKey(e => new { e.ClientId, e.PostLogoutRedirectUri });

                entity.Property(e => e.PostLogoutRedirectUri).HasMaxLength(2000);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.IdentityServerClientPostLogoutRedirectUris)
                    .HasForeignKey(d => d.ClientId);
            });

            modelBuilder.Entity<IdentityServerClientProperty>(entity =>
            {
                entity.HasKey(e => new { e.ClientId, e.Key, e.Value });

                entity.Property(e => e.Key).HasMaxLength(250);

                entity.Property(e => e.Value).HasMaxLength(2000);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.IdentityServerClientProperties)
                    .HasForeignKey(d => d.ClientId);
            });

            modelBuilder.Entity<IdentityServerClientRedirectUri>(entity =>
            {
                entity.HasKey(e => new { e.ClientId, e.RedirectUri });

                entity.Property(e => e.RedirectUri).HasMaxLength(2000);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.IdentityServerClientRedirectUris)
                    .HasForeignKey(d => d.ClientId);
            });

            modelBuilder.Entity<IdentityServerClientScope>(entity =>
            {
                entity.HasKey(e => new { e.ClientId, e.Scope });

                entity.Property(e => e.Scope).HasMaxLength(200);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.IdentityServerClientScopes)
                    .HasForeignKey(d => d.ClientId);
            });

            modelBuilder.Entity<IdentityServerClientSecret>(entity =>
            {
                entity.HasKey(e => new { e.ClientId, e.Type, e.Value });

                entity.Property(e => e.Type).HasMaxLength(250);

                entity.Property(e => e.Value).HasMaxLength(4000);

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.IdentityServerClientSecrets)
                    .HasForeignKey(d => d.ClientId);
            });

            modelBuilder.Entity<IdentityServerDeviceFlowCode>(entity =>
            {
                entity.HasIndex(e => e.DeviceCode, "IX_IdentityServerDeviceFlowCodes_DeviceCode")
                    .IsUnique();

                entity.HasIndex(e => e.Expiration, "IX_IdentityServerDeviceFlowCodes_Expiration");

                entity.HasIndex(e => e.UserCode, "IX_IdentityServerDeviceFlowCodes_UserCode");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ClientId)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ConcurrencyStamp).HasMaxLength(40);

                entity.Property(e => e.Data).IsRequired();

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.DeviceCode)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.SessionId).HasMaxLength(100);

                entity.Property(e => e.SubjectId).HasMaxLength(200);

                entity.Property(e => e.UserCode)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<IdentityServerIdentityResource>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ConcurrencyStamp).HasMaxLength(40);

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.DisplayName).HasMaxLength(200);

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<IdentityServerIdentityResourceClaim>(entity =>
            {
                entity.HasKey(e => new { e.IdentityResourceId, e.Type });

                entity.Property(e => e.Type).HasMaxLength(200);

                entity.HasOne(d => d.IdentityResource)
                    .WithMany(p => p.IdentityServerIdentityResourceClaims)
                    .HasForeignKey(d => d.IdentityResourceId);
            });

            modelBuilder.Entity<IdentityServerIdentityResourceProperty>(entity =>
            {
                entity.HasKey(e => new { e.IdentityResourceId, e.Key, e.Value });

                entity.Property(e => e.Key).HasMaxLength(250);

                entity.Property(e => e.Value).HasMaxLength(2000);

                entity.HasOne(d => d.IdentityResource)
                    .WithMany(p => p.IdentityServerIdentityResourceProperties)
                    .HasForeignKey(d => d.IdentityResourceId);
            });

            modelBuilder.Entity<IdentityServerPersistedGrant>(entity =>
            {
                entity.HasKey(e => e.Key);

                entity.HasIndex(e => e.Expiration, "IX_IdentityServerPersistedGrants_Expiration");

                entity.HasIndex(e => new { e.SubjectId, e.ClientId, e.Type }, "IX_IdentityServerPersistedGrants_SubjectId_ClientId_Type");

                entity.HasIndex(e => new { e.SubjectId, e.SessionId, e.Type }, "IX_IdentityServerPersistedGrants_SubjectId_SessionId_Type");

                entity.Property(e => e.Key).HasMaxLength(200);

                entity.Property(e => e.ClientId)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ConcurrencyStamp).HasMaxLength(40);

                entity.Property(e => e.Data).IsRequired();

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.SessionId).HasMaxLength(100);

                entity.Property(e => e.SubjectId).HasMaxLength(200);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Member>(entity =>
            {
                entity.ToTable("Member");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.MemberName)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<TodoItem>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.LoginTime).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.PassWord).HasMaxLength(50);
            });

            modelBuilder.Entity<UserBase>(entity =>
            {
                entity.ToTable("User_Base");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Avatar).HasMaxLength(100);

                entity.Property(e => e.Birthday).HasColumnType("date");

                entity.Property(e => e.Hobby)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mail)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NikeName).HasMaxLength(20);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Sign).HasMaxLength(50);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<UserExtra>(entity =>
            {
                entity.ToTable("User_Extra");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Extend1).HasMaxLength(50);

                entity.Property(e => e.Extend2).HasMaxLength(50);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<UserInfoUpdate>(entity =>
            {
                entity.ToTable("User_Info_Update");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AttributeNewVal)
                    .HasMaxLength(50)
                    .HasColumnName("Attribute_New_Val");

                entity.Property(e => e.AttributeOldVal)
                    .HasMaxLength(20)
                    .HasColumnName("Attribute_Old_Val");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Update_Time");
            });

            modelBuilder.Entity<UserLocation>(entity =>
            {
                entity.ToTable("User_Location");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Create_Time");

                entity.Property(e => e.CurrCity)
                    .HasMaxLength(50)
                    .HasColumnName("Curr_City");

                entity.Property(e => e.CurrDistrict)
                    .HasMaxLength(50)
                    .HasColumnName("Curr_District");

                entity.Property(e => e.CurrNation)
                    .HasMaxLength(20)
                    .HasColumnName("Curr_Nation");

                entity.Property(e => e.CurrProvince)
                    .HasMaxLength(20)
                    .HasColumnName("Curr_Province");

                entity.Property(e => e.Location).HasMaxLength(255);
            });

            modelBuilder.Entity<UserLoginLog>(entity =>
            {
                entity.ToTable("User_Login_Log");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Create_Time");
            });

            modelBuilder.Entity<UserRegisterLog>(entity =>
            {
                entity.ToTable("User_Register_Log");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.RegisterMethod)
                    .HasMaxLength(20)
                    .HasColumnName("Register_Method");

                entity.Property(e => e.RegisterTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Register_Time");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
