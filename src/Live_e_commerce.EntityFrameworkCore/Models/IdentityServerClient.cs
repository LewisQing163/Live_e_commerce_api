using System;
using System.Collections.Generic;

#nullable disable

namespace Live_e_commerce.Models
{
    public partial class IdentityServerClient
    {
        public IdentityServerClient()
        {
            IdentityServerClientClaims = new HashSet<IdentityServerClientClaim>();
            IdentityServerClientCorsOrigins = new HashSet<IdentityServerClientCorsOrigin>();
            IdentityServerClientGrantTypes = new HashSet<IdentityServerClientGrantType>();
            IdentityServerClientIdPrestrictions = new HashSet<IdentityServerClientIdPrestriction>();
            IdentityServerClientPostLogoutRedirectUris = new HashSet<IdentityServerClientPostLogoutRedirectUri>();
            IdentityServerClientProperties = new HashSet<IdentityServerClientProperty>();
            IdentityServerClientRedirectUris = new HashSet<IdentityServerClientRedirectUri>();
            IdentityServerClientScopes = new HashSet<IdentityServerClientScope>();
            IdentityServerClientSecrets = new HashSet<IdentityServerClientSecret>();
        }

        public Guid Id { get; set; }
        public string ClientId { get; set; }
        public string ClientName { get; set; }
        public string Description { get; set; }
        public string ClientUri { get; set; }
        public string LogoUri { get; set; }
        public bool Enabled { get; set; }
        public string ProtocolType { get; set; }
        public bool RequireClientSecret { get; set; }
        public bool RequireConsent { get; set; }
        public bool AllowRememberConsent { get; set; }
        public bool AlwaysIncludeUserClaimsInIdToken { get; set; }
        public bool RequirePkce { get; set; }
        public bool AllowPlainTextPkce { get; set; }
        public bool RequireRequestObject { get; set; }
        public bool AllowAccessTokensViaBrowser { get; set; }
        public string FrontChannelLogoutUri { get; set; }
        public bool FrontChannelLogoutSessionRequired { get; set; }
        public string BackChannelLogoutUri { get; set; }
        public bool BackChannelLogoutSessionRequired { get; set; }
        public bool AllowOfflineAccess { get; set; }
        public int IdentityTokenLifetime { get; set; }
        public string AllowedIdentityTokenSigningAlgorithms { get; set; }
        public int AccessTokenLifetime { get; set; }
        public int AuthorizationCodeLifetime { get; set; }
        public int? ConsentLifetime { get; set; }
        public int AbsoluteRefreshTokenLifetime { get; set; }
        public int SlidingRefreshTokenLifetime { get; set; }
        public int RefreshTokenUsage { get; set; }
        public bool UpdateAccessTokenClaimsOnRefresh { get; set; }
        public int RefreshTokenExpiration { get; set; }
        public int AccessTokenType { get; set; }
        public bool EnableLocalLogin { get; set; }
        public bool IncludeJwtId { get; set; }
        public bool AlwaysSendClientClaims { get; set; }
        public string ClientClaimsPrefix { get; set; }
        public string PairWiseSubjectSalt { get; set; }
        public int? UserSsoLifetime { get; set; }
        public string UserCodeType { get; set; }
        public int DeviceCodeLifetime { get; set; }
        public string ExtraProperties { get; set; }
        public string ConcurrencyStamp { get; set; }
        public DateTime CreationTime { get; set; }
        public Guid? CreatorId { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public Guid? LastModifierId { get; set; }
        public bool? IsDeleted { get; set; }
        public Guid? DeleterId { get; set; }
        public DateTime? DeletionTime { get; set; }

        public virtual ICollection<IdentityServerClientClaim> IdentityServerClientClaims { get; set; }
        public virtual ICollection<IdentityServerClientCorsOrigin> IdentityServerClientCorsOrigins { get; set; }
        public virtual ICollection<IdentityServerClientGrantType> IdentityServerClientGrantTypes { get; set; }
        public virtual ICollection<IdentityServerClientIdPrestriction> IdentityServerClientIdPrestrictions { get; set; }
        public virtual ICollection<IdentityServerClientPostLogoutRedirectUri> IdentityServerClientPostLogoutRedirectUris { get; set; }
        public virtual ICollection<IdentityServerClientProperty> IdentityServerClientProperties { get; set; }
        public virtual ICollection<IdentityServerClientRedirectUri> IdentityServerClientRedirectUris { get; set; }
        public virtual ICollection<IdentityServerClientScope> IdentityServerClientScopes { get; set; }
        public virtual ICollection<IdentityServerClientSecret> IdentityServerClientSecrets { get; set; }
    }
}
