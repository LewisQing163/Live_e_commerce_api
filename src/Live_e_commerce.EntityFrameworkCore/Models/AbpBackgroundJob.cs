using System;
using System.Collections.Generic;

#nullable disable

namespace Live_e_commerce.Models
{
    public partial class AbpBackgroundJob
    {
        public Guid Id { get; set; }
        public string JobName { get; set; }
        public string JobArgs { get; set; }
        public short TryCount { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime NextTryTime { get; set; }
        public DateTime? LastTryTime { get; set; }
        public bool? IsAbandoned { get; set; }
        public byte Priority { get; set; }
        public string ExtraProperties { get; set; }
        public string ConcurrencyStamp { get; set; }
    }
}
